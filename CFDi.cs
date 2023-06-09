using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.Runtime.InteropServices;
using CFDi40.Utils;
using CFDi40.Obj;
using System.Xml.Xsl;
using System.Xml.Schema;
using System.Xml.Linq;
using CFDi40.Objects;

namespace CFDi40
{
    public class CFDi
    {
        private Comprobante objComprobante;
        private List<ComprobanteConcepto> _listConceptos = new List<ComprobanteConcepto>();
        private List<ComprobanteCfdiRelacionados> _listCfdiRelacionados = new List<ComprobanteCfdiRelacionados>();
        private ComprobanteCfdiRelacionados _cfdiRelacionados = new ComprobanteCfdiRelacionados();
        private List<ComprobanteCfdiRelacionadosCfdiRelacionado> _listCfdiRelacionado =  new List<ComprobanteCfdiRelacionadosCfdiRelacionado>();
        private List<ComprobanteConceptoImpuestos> _listImpuestosConceptos = new List<ComprobanteConceptoImpuestos>();
        private ComprobanteConceptoImpuestos _impuestosConceptos = new ComprobanteConceptoImpuestos();
        private List<ComprobanteConceptoImpuestosTraslado> _listConceptoImpuestosTra = new List<ComprobanteConceptoImpuestosTraslado>();
        private List<ComprobanteConceptoImpuestosRetencion> _listConceptoImpuestosRet = new List<ComprobanteConceptoImpuestosRetencion>();
        private ComprobanteImpuestos _comprobanteImpuestos = new ComprobanteImpuestos();
        private Pagos objPagos = new Pagos();
        private List<PagosPago> listPagos = new List<PagosPago>();
        private List<PagosPagoDoctoRelacionado> _listPagoDR = new List<PagosPagoDoctoRelacionado>();
        private string currentDir = Directory.GetCurrentDirectory();
        private string pathCer;
        private string pathKey;
        private string clavePrivada;
        private int decimalesMoneda = 2;
        private string fDecMon = "{0:0.00}";
        private List<ComplementoImpuestoDRObj> oImpuestosDRList = new List<ComplementoImpuestoDRObj>();

        /// <summary>Recibe un objeto con los datos del comprobante. Además recibe el UUID de los documentos relacionados, y el tipo de relación.
        /// <param name="comprobanteObj">Objeto con los datos del comprobante</param>
        /// <param name="UUIDRel">UUID de los documentos relacionados, separados por comas</param>
        /// <param name="tipRel">Tipo de relación entre los documentos relacionados</param>
        /// </summary>
        public void DatosComprobante(Comprobante comprobanteObj, string UUIDRel = "", string tipRel = "")
        {
            objComprobante = comprobanteObj;
            if (!string.IsNullOrEmpty(UUIDRel) && !string.IsNullOrEmpty(tipRel))
            {
                _cfdiRelacionados.TipoRelacion = tipRel.Trim();

                string[] uuids = UUIDRel.Split(',');
                foreach (var uuid in uuids)
                {
                    ComprobanteCfdiRelacionadosCfdiRelacionado cfdiRelacionado = new ComprobanteCfdiRelacionadosCfdiRelacionado();
                    cfdiRelacionado.UUID = uuid.Trim();
                    _listCfdiRelacionado.Add(cfdiRelacionado);
                }

                _cfdiRelacionados.CfdiRelacionado = _listCfdiRelacionado.ToArray();
                _listCfdiRelacionados.Add(_cfdiRelacionados);
            }
            objComprobante.CfdiRelacionados = _listCfdiRelacionados.ToArray();

        }

        /// <summary>Asigna los datos del emisor al objeto de comprobante.
        /// <param name="emisor">Objeto con los datos del emisor</param>
        /// </summary>
        public void DatosEmisor(ComprobanteEmisor emisor)
        {
            objComprobante.Emisor = emisor;
        }

        /// <summary>Asigna los datos del receptor al objeto de comprobante.
        /// <param name="receptorObj">Objeto con los datos del receptor</param>
        /// </summary>
        public void DatosReceptor(ComprobanteReceptor receptorObj)
        {
            objComprobante.Receptor = receptorObj;
        }

        /// <summary>Asigna los datos del emisor al objeto de comprobante.
        /// <param name="emisor">Objeto con los datos del emisor</param>
        /// </summary>
        public void AgregarDatosCFDIGlobal(ComprobanteInformacionGlobal informacionGlobal)
        {
            objComprobante.InformacionGlobal = informacionGlobal;
        }

        /// <summary>Agrega un concepto al objeto de comprobante. Puede incluir impuestos trasladados y retenidos.
        /// <param name="concepto">Objeto con los datos del concepto</param>
        /// </summary>
        public void AgregaConcepto(ComprobanteConcepto concepto)
        {
            bool hayImpuestoConcepto = false;
            if (_listConceptoImpuestosTra.Any() && !concepto.ObjetoImp.Equals("01"))
            {
                _impuestosConceptos.Traslados = _listConceptoImpuestosTra.ToArray();
                hayImpuestoConcepto = true;
            }

            if (_listConceptoImpuestosRet.Any() && !concepto.ObjetoImp.Equals("01"))
            {
                _impuestosConceptos.Retenciones = _listConceptoImpuestosRet.ToArray();
                hayImpuestoConcepto = true;
            }

            if (hayImpuestoConcepto)
            {
                concepto.Impuestos = _impuestosConceptos;
            }

            _listConceptos.Add(concepto);
        }

        /// <summary>Agrega un concepto al objeto de comprobante con impuestos trasladados específicos.
        /// <param name="concepto">Objeto con los datos del concepto</param>
        /// <param name="cImpuestosTraslado">Lista de objetos con los impuestos trasladados específicos del concepto</param>
        /// </summary>
        public void AgregaConcepto(ComprobanteConcepto concepto, List<ComprobanteConceptoImpuestosTraslado> cImpuestosTraslado)
        {
            ComprobanteConceptoImpuestos impuestosConceptos = new ComprobanteConceptoImpuestos();
            if (cImpuestosTraslado.Any() && !concepto.ObjetoImp.Equals("01"))
            {
                impuestosConceptos.Traslados = cImpuestosTraslado.ToArray();

                concepto.Impuestos = impuestosConceptos;
            }

            _listConceptos.Add(concepto);
        }

        /// <summary>Agrega un concepto al objeto de comprobante con impuestos retenidos específicos.
        /// <param name="concepto">Objeto con los datos del concepto</param>
        /// <param name="cImpuestosRetencion">Lista de objetos con los impuestos retenidos específicos del concepto</param>
        /// </summary>
        public void AgregaConcepto(ComprobanteConcepto concepto, List<ComprobanteConceptoImpuestosRetencion> cImpuestosRetencion)
        {
            ComprobanteConceptoImpuestos impuestosConceptos = new ComprobanteConceptoImpuestos();
            if (cImpuestosRetencion.Any() && !concepto.ObjetoImp.Equals("01"))
            {
                impuestosConceptos.Retenciones = cImpuestosRetencion.ToArray();

                concepto.Impuestos = impuestosConceptos;
            }

            _listConceptos.Add(concepto);
        }

        /// <summary>Agrega un concepto al objeto de comprobante con impuestos trasladados y retenidos específicos.
        /// <param name="concepto">Objeto con los datos del concepto</param>
        /// <param name="cImpuestosTraslado">Impuestos traslados específicos del concepto</param>
        /// <param name="cImpuestosRetencion">Impuestos retenidos específicos del concepto</param>
        /// </summary>
        public void AgregaConcepto(ComprobanteConcepto concepto, List<ComprobanteConceptoImpuestosTraslado> cImpuestosTraslado, List<ComprobanteConceptoImpuestosRetencion> cImpuestosRetencion)
        {
            if (cImpuestosTraslado.Any() && !concepto.ObjetoImp.Equals("01"))
            {
                _impuestosConceptos.Traslados = cImpuestosTraslado.ToArray();
            }

            if (cImpuestosRetencion.Any() && !concepto.ObjetoImp.Equals("01"))
            {
                _impuestosConceptos.Retenciones = cImpuestosRetencion.ToArray();
            }

                concepto.Impuestos = _impuestosConceptos;

            _listConceptos.Add(concepto);
        }

        /// <summary>Asigna los conceptos al objeto de comprobante</summary>
        private void DatosConceptos()
        {
            objComprobante.Conceptos = _listConceptos.ToArray();
        }

        /// <summary>Genera los impuestos totales a partir de los impuestos en los conceptos</summary>
        private void GeneraImpuestosTotales()
        {
            List<ComprobanteImpuestosTraslado> listTImpuestosTraslados = new List<ComprobanteImpuestosTraslado>();
            List<ComprobanteImpuestosRetencion> listTImpuestosRetenidos = new List<ComprobanteImpuestosRetencion>();
            decimal importeTotalTr;
            decimal importeTotalRet;
            decimal baseTotalTr;
            string tasaOCuotaTr;
            string impuestoTr;
            string tipoFactor;
            string impuestoRet;
            decimal totalImpuestosTrasladados;
            decimal totalImpuestosRetenidos;
            string[] llaves = new string[1000];
            
            /*
             * Optenemos una llave para identificar los distintos impuestos en los concceptos
             */
        ComprobanteConcepto[] conceptos = objComprobante.Conceptos;
            int i = 0;
            foreach (ComprobanteConcepto concepto in conceptos)
            {
                try
                {
                    foreach (ComprobanteConceptoImpuestosTraslado impTraslados in concepto.Impuestos.Traslados ?? Enumerable.Empty<object>())
                    {
                        string llave = "TRA" + impTraslados.Impuesto + impTraslados.TipoFactor + impTraslados.TasaOCuota;
                        llaves[i++] = llave;
                        Console.WriteLine(llave);
                    }
                } catch(NullReferenceException) {}

                try { 

                    foreach (ComprobanteConceptoImpuestosRetencion impRetenidos in concepto.Impuestos.Retenciones ?? Enumerable.Empty<object>())
                    {
                        string llave = "RET" + impRetenidos.Impuesto + impRetenidos.TipoFactor + impRetenidos.TasaOCuota;
                        llaves[i++] = llave;
                        Console.WriteLine(llave);
                    }
                
                }
                catch (NullReferenceException)  {}

            }

            var distinctArray = llaves.Distinct().ToArray();
            totalImpuestosTrasladados = 0;
            totalImpuestosRetenidos = 0;
            foreach (string llaveUnik in distinctArray)
            {
                if (!string.IsNullOrEmpty(llaveUnik)) {
                    
                    importeTotalTr = 0;
                    importeTotalRet = 0;
                    baseTotalTr = 0;
                    tasaOCuotaTr = "";
                    impuestoTr = "";
                    impuestoRet = "";
                    tipoFactor = "";
                    foreach (ComprobanteConcepto concepto in conceptos)
                    {
                        foreach (ComprobanteConceptoImpuestosTraslado impTraslados in concepto.Impuestos.Traslados ?? Enumerable.Empty<object>())
                        {
                            string llave = "TRA" + impTraslados.Impuesto + impTraslados.TipoFactor + impTraslados.TasaOCuota;

                            if (llaveUnik.Equals(llave))
                            {
                                importeTotalTr = importeTotalTr + impTraslados.Importe;
                                tasaOCuotaTr = impTraslados.TasaOCuota;
                                baseTotalTr = baseTotalTr + impTraslados.Base;
                                impuestoTr = impTraslados.Impuesto;
                                tipoFactor = impTraslados.TipoFactor;
                            }
                        }

                        foreach (ComprobanteConceptoImpuestosRetencion impRetenidos in concepto.Impuestos.Retenciones ?? Enumerable.Empty<object>())
                        {
                            string llave = "RET" + impRetenidos.Impuesto + impRetenidos.TipoFactor + impRetenidos.TasaOCuota;

                            if (llaveUnik.Equals(llave))
                            {
                                importeTotalRet = importeTotalRet + impRetenidos.Importe;
                                impuestoRet = impRetenidos.Impuesto;

                            }
                        }
                    }

                    if (llaveUnik.StartsWith("TRA"))
                    {
                        ComprobanteImpuestosTraslado tImpuestosTraslados = new ComprobanteImpuestosTraslado();

                        tImpuestosTraslados.Base = String.Format(fDecMon, Math.Round(baseTotalTr, decimalesMoneda, MidpointRounding.AwayFromZero));
                        tImpuestosTraslados.TasaOCuota = tasaOCuotaTr;
                        tImpuestosTraslados.Importe = String.Format(fDecMon, Math.Round(importeTotalTr, decimalesMoneda, MidpointRounding.AwayFromZero));
                        tImpuestosTraslados.Impuesto = impuestoTr;
                        tImpuestosTraslados.TipoFactor = tipoFactor;

                        listTImpuestosTraslados.Add(tImpuestosTraslados);
                        totalImpuestosTrasladados = totalImpuestosTrasladados + importeTotalTr;
                    }

                    if (llaveUnik.StartsWith("RET"))
                    {
                        ComprobanteImpuestosRetencion tImpuestosRetenidos = new ComprobanteImpuestosRetencion();
                        tImpuestosRetenidos.Importe = Math.Round(importeTotalRet, decimalesMoneda, MidpointRounding.AwayFromZero);
                        tImpuestosRetenidos.Impuesto = impuestoRet;

                        listTImpuestosRetenidos.Add(tImpuestosRetenidos);
                        totalImpuestosRetenidos = totalImpuestosRetenidos + importeTotalRet;
                    }

                }
            }

            if(listTImpuestosTraslados.Count > 0)
            {
                _comprobanteImpuestos.TotalImpuestosTrasladados = String.Format(fDecMon, Math.Round(totalImpuestosTrasladados, decimalesMoneda, MidpointRounding.AwayFromZero));
                _comprobanteImpuestos.TotalImpuestosTrasladadosSpecified = true;
                _comprobanteImpuestos.Traslados = listTImpuestosTraslados.ToArray();
            }
            if(listTImpuestosRetenidos.Count > 0)
            {
                _comprobanteImpuestos.TotalImpuestosRetenidos = String.Format(fDecMon, Math.Round(totalImpuestosRetenidos, decimalesMoneda, MidpointRounding.AwayFromZero));
                _comprobanteImpuestos.TotalImpuestosRetenidosSpecified = true;
                _comprobanteImpuestos.Retenciones = listTImpuestosRetenidos.ToArray();
            }
            
            objComprobante.Impuestos = _comprobanteImpuestos;

        }

        /// <summary>Genera el XML a partir de los objetos previamente llenados.</summary>
        public string GeneraXML()
        {
            string sXml = "";
            try
            {
                //XmlSerializer oXml = new XmlSerializer(typeof(Comprobante));
                objComprobante.schemaLocation = "http://www.sat.gob.mx/cfd/4 http://www.sat.gob.mx/sitio_internet/cfd/4/cfdv40.xsd";


                Certificado objCert = new Certificado();
                objCert = SelloDigital.leerCER(pathCer);

                objComprobante.NoCertificado = objCert.NoCertificado;

                if (!string.IsNullOrEmpty(objComprobante.FormaPago))
                {
                    objComprobante.FormaPagoSpecified = true;
                }
                if (!string.IsNullOrEmpty(objComprobante.MetodoPago))
                {
                    objComprobante.MetodoPagoSpecified = true;
                }
                Console.WriteLine(objCert.toString());
                Console.WriteLine(" ");

                DatosConceptos();

                if ("I".Equals(objComprobante.TipoDeComprobante) || "E".Equals(objComprobante.TipoDeComprobante)) { 
                    GeneraImpuestosTotales();
                }

                sXml = CreateXML(objComprobante);

                string cadenaOriginal = "";
                string pathxsl = currentDir + @"\XSLT_V4\cadenaoriginal_4_0.xslt";
                XslCompiledTransform transformador = new XslCompiledTransform(true);
                transformador.Load(pathxsl);
                XmlReader xmlReader = XmlReader.Create(new StringReader(sXml));

                using (StringWriter sw = new StringWriter())
                using (XmlWriter xwo = XmlWriter.Create(sw, transformador.OutputSettings))
                {

                    transformador.Transform(xmlReader, xwo);
                    cadenaOriginal = sw.ToString();
                }


                SelloDigital oSelloDigital = new SelloDigital();
                objComprobante.Certificado = oSelloDigital.Certificado(PathCer);
                objComprobante.Sello = oSelloDigital.Sellar(cadenaOriginal, PathKey, ClavePrivada);

                sXml = CreateXML(objComprobante);
            } catch(Exception ex)   {
                throw new Exception(ex.Message, ex);
            }

            return sXml;
        }

        /// <summary>
        /// Crea el XML del comprobante.
        /// <param name="oComprobante">El objeto comprobante con los datos del CFDI.</param>
        /// <returns>Un string con el XML del comprobante.</returns>
        /// </summary>
        private string CreateXML(Comprobante oComprobante)
        {
            XmlSerializerNamespaces xmlNameSpace = new XmlSerializerNamespaces();
            xmlNameSpace.Add("cfdi", "http://www.sat.gob.mx/cfd/4");
            xmlNameSpace.Add("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital");
            xmlNameSpace.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
            if(!Pagos.Equals(objPagos.Pago,null))
            {
                xmlNameSpace.Add("pago20", "http://www.sat.gob.mx/Pagos20");
                oComprobante.schemaLocation = "http://www.sat.gob.mx/cfd/4 http://www.sat.gob.mx/sitio_internet/cfd/4/cfdv40.xsd http://www.sat.gob.mx/Pagos20 http://www.sat.gob.mx/sitio_internet/cfd/Pagos/Pagos20.xsd";
                AgregaNodoComplementoPago();
            }

            XmlSerializer oXmlSerializar = new XmlSerializer(typeof(Comprobante));

            string sXml = "";

            using (var sww = new Utils.StringWriterWithEncoding(Encoding.UTF8))
            {

                using (XmlWriter writter = XmlWriter.Create(sww))
                {

                    oXmlSerializar.Serialize(writter, oComprobante, xmlNameSpace);
                    sXml = sww.ToString();
                }

            }

            return sXml;
        }

        /// <summary>
        /// Genera la cadena original del comprobante.
        /// <param name="sXml">El string del XML del comprobante.</param>
        /// <returns>La cadena original del comprobante.</returns>
        /// </summary>
        public string GeneraCadenaOriginal(string sXml)
        {
            string cadenaOriginal = "";
            string pathxsl = currentDir + @"\XSLT_V4\cadenaoriginal_4_0.xslt";
            XslCompiledTransform transformador = new XslCompiledTransform(true);
            transformador.Load(pathxsl);
            XmlReader xmlReader = XmlReader.Create(new StringReader(sXml));

            using (StringWriter sw = new StringWriter())
            using (XmlWriter xwo = XmlWriter.Create(sw, transformador.OutputSettings))
            {

                transformador.Transform(xmlReader, xwo);
                cadenaOriginal = sw.ToString();
            }

            return cadenaOriginal;
        }
        #region "GENERACIÓN DE COMPLEMENTOS DE PAGOS"
        /// <summary>
        /// Agrega un pago al comprobante.
        /// <param name="pagosPago">Los detalles del pago.</param>
        /// <param name="pagoTotales">Los totales del pago.</param>
        /// </summary>
        public void AgregaPago(PagosPago pagosPago, PagosTotales pagoTotales)
        {
            listPagos.Add(pagosPago);
            objPagos.Pago = listPagos.ToArray();
            objPagos.Totales = pagoTotales;
        }

        /// <summary>
        /// Agrega los impuestos del documento relacionado al pago.
        /// <param name="oPagoDR">El objeto del documento relacionado del pago.</param>
        /// <param name="sXml">El string del XML del comprobante.</param>
        /// </summary>
        public void AgregaImpuestosDRPago(ref PagosPagoDoctoRelacionado oPagoDR, string sXml, decimal impPagado)
        {
            oPagoDR.ImpuestosDR = ObtieneImpuestosDR(sXml, impPagado);
        }
        /// <summary>
        /// Obtiene los impuestos del documento relacionado.
        /// <param name="sXml">El string del XML del comprobante.</param>
        /// <returns>Una lista con los impuestos del documento relacionado.</returns>
        /// </summary>
        private PagosPagoDoctoRelacionadoImpuestosDR ObtieneImpuestosDR(string sXml, decimal impPagado)
        {
            List<PagosPagoDoctoRelacionadoImpuestosDRTrasladoDR> listTrasladosDR = new List<PagosPagoDoctoRelacionadoImpuestosDRTrasladoDR>();
            List<PagosPagoDoctoRelacionadoImpuestosDRRetencionDR> listRetencionesDR = new List<PagosPagoDoctoRelacionadoImpuestosDRRetencionDR>();
            PagosPagoDoctoRelacionadoImpuestosDR listImpuestosDR = new PagosPagoDoctoRelacionadoImpuestosDR();
            XmlDocument xDoc = new XmlDocument();
            XmlNamespaceManager nsMgr;
            string nsUri;
            
            xDoc.LoadXml(sXml);

            nsUri = xDoc.DocumentElement.NamespaceURI;
            nsMgr = new XmlNamespaceManager(xDoc.NameTable);

            nsMgr.AddNamespace("ns", nsUri);
            XmlNodeList traNodeList = xDoc.SelectNodes("ns:Comprobante/ns:Impuestos/ns:Traslados/ns:Traslado", nsMgr);
            XmlNode comprobanteNode = xDoc.SelectSingleNode("ns:Comprobante", nsMgr);
            decimal totalCFDI = decimal.Parse(comprobanteNode.Attributes["Total"].InnerText);
            decimal proporcion = 1;

            if (impPagado < totalCFDI)
            {
                 proporcion = impPagado / totalCFDI;
            }

            foreach (XmlNode xNode in traNodeList)
            {
                PagosPagoDoctoRelacionadoImpuestosDRTrasladoDR trasladoDR = new PagosPagoDoctoRelacionadoImpuestosDRTrasladoDR();
                ComplementoImpuestoDRObj oImpuestoDR = new ComplementoImpuestoDRObj();

                decimal baseDr = Decimal.Zero;
                decimal taOCu = decimal.Parse(xNode.Attributes["TasaOCuota"].InnerText);
                decimal impoDr = decimal.Parse(xNode.Attributes["Importe"].InnerText);
                decimal impoDrProp = Math.Round(impoDr * proporcion, 2, MidpointRounding.AwayFromZero);
                if (Decimal.Compare(taOCu, Decimal.Zero) > 0 )   {
                    baseDr = Math.Round(impoDrProp / taOCu, 2, MidpointRounding.AwayFromZero);
                }   else    {
                    baseDr = obtieneBaseCFDITasa0(xDoc, nsMgr);
                    baseDr = Math.Round(baseDr * proporcion, 2, MidpointRounding.AwayFromZero);
                }
                
                trasladoDR.ImpuestoDR = xNode.Attributes["Impuesto"].InnerText;
                trasladoDR.TipoFactorDR = xNode.Attributes["TipoFactor"].InnerText;
                trasladoDR.TasaOCuotaDR = taOCu;
                trasladoDR.TasaOCuotaDRSpecified = true;
                trasladoDR.ImporteDR = impoDrProp;
                trasladoDR.BaseDR = Math.Round(baseDr, 2, MidpointRounding.AwayFromZero);

                listTrasladosDR.Add(trasladoDR);

                oImpuestoDR.ImpuDR = trasladoDR.ImpuestoDR;
                oImpuestoDR.TiFadDR = trasladoDR.TipoFactorDR;
                oImpuestoDR.TasCuDR = trasladoDR.TasaOCuotaDR;
                oImpuestoDR.ImpoDR = trasladoDR.ImporteDR;
                oImpuestoDR.BaseDR = trasladoDR.BaseDR;
                oImpuestoDR.TipoImpDR = "TRA";

                oImpuestosDRList.Add(oImpuestoDR);
            }

            listImpuestosDR.TrasladosDR = listTrasladosDR.ToArray();

            return listImpuestosDR;
        }

        private void AgregaNodoComplementoPago()
        {
            XmlDocument docPago = new XmlDocument();
            XmlSerializerNamespaces xmlNameSpacePago = new XmlSerializerNamespaces();

            objComprobante.Complemento = new ComprobanteComplemento();

            xmlNameSpacePago.Add("pago20", "http://www.sat.gob.mx/Pagos20");
            using (XmlWriter writer = docPago.CreateNavigator().AppendChild())
            {
                new XmlSerializer(objPagos.GetType()).Serialize(writer, objPagos, xmlNameSpacePago);
            }
            objComprobante.Complemento.Any = new XmlElement[1];
            objComprobante.Complemento.Any[0] = docPago.DocumentElement;
        }

        /// <summary>
        /// Obtiene la Base del total de impuestos trasladados ya sea que esta no exista (cuando el CFDI es 3.3) o bien para que el calculo sea exacto y cumplir con las validaciones
        /// <param name="xDoc">El xmlDocument del CFDI Relacionado.</param>
        /// <returns>El valor de la base correspondiente a los impuestos Totales del CFDI Relacionado.</returns>
        /// </summary>
        private decimal obtieneBaseCFDITasa0(XmlDocument xDoc, XmlNamespaceManager nsMgr)
        {
            string tasaOCuota;
            decimal baseDR = Decimal.Zero;
            decimal baseTotal = Decimal.Zero;
            XmlNodeList conceptoList = xDoc.SelectNodes("ns:Comprobante/ns:Conceptos/ns:Concepto", nsMgr);

            foreach (XmlNode conceptoNode in conceptoList)
            {
                XmlNodeList impuestoList = conceptoNode.SelectNodes("ns:Impuestos/ns:Traslados/ns:Traslado", nsMgr);
                foreach (XmlNode impuesto in impuestoList)
                {
                    tasaOCuota = impuesto.Attributes["TasaOCuota"].InnerText;
                    if (tasaOCuota.StartsWith("0.00"))
                    {
                        //Console.WriteLine("TasaOCuota:: " + tasaOCuota);
                        string baseAux = impuesto.Attributes["Base"].InnerText;
                        if(Decimal.TryParse(baseAux, out baseDR))
                        {
                            baseTotal = Decimal.Add(baseTotal, baseDR);
                        }
                        else
                        {
                            throw new Exception("No es posible convertir " + baseAux + " a decimal.");
                        }
                    }
                }
            }
            //Console.WriteLine("baseTotal = {0}", baseTotal);
            return baseTotal;
        }

        public PagosPagoImpuestosP GeneraImpuestosP()
        {
            List<PagosPagoImpuestosPTrasladoP> impuestosPTrasladosList = new List<PagosPagoImpuestosPTrasladoP>();
            ComplementoImpuestoPObj oImpuestosP = new ComplementoImpuestoPObj();
            PagosPagoImpuestosP pagosPagoImpuestosP = new PagosPagoImpuestosP();
            string[] llaves = new string[1000];
            int i = 0;
            foreach (ComplementoImpuestoDRObj impuestosDR in oImpuestosDRList)
            {
                if ("TRA".Equals(impuestosDR.TipoImpDR))
                {
                    string llave = "TRA" + impuestosDR.ImpuDR + impuestosDR.TiFadDR + impuestosDR.TasCuDR;
                    llaves[i++] = llave;
                }
            }

            var distinctArray = llaves.Distinct().ToArray();
            foreach (string llaveUnik in distinctArray)
            {
                PagosPagoImpuestosPTrasladoP impuestoPTraslado = new PagosPagoImpuestosPTrasladoP();
                decimal baseP = Decimal.Zero;
                string impuestoP = "002";
                string tipoFactorP = "Tasa";
                decimal tasaOcuotaP = Decimal.Zero;
                decimal importeP = Decimal.Zero;
                if (!string.IsNullOrEmpty(llaveUnik))
                {
                    foreach (ComplementoImpuestoDRObj impuestosDR in oImpuestosDRList)
                    {
                        if ("TRA".Equals(impuestosDR.TipoImpDR))
                        {
                            string llave = "TRA" + impuestosDR.ImpuDR + impuestosDR.TiFadDR + impuestosDR.TasCuDR;
                            if (llaveUnik.Equals(llave))
                            {
                                impuestoP = impuestosDR.ImpuDR;
                                tipoFactorP = impuestosDR.TiFadDR;
                                tasaOcuotaP = impuestosDR.TasCuDR;
                                baseP = Decimal.Add(baseP, impuestosDR.BaseDR);
                                importeP = Decimal.Add(importeP, impuestosDR.ImpoDR);
                            }
                        }
                    }
                    impuestoPTraslado.ImpuestoP = impuestoP;
                    impuestoPTraslado.TipoFactorP = tipoFactorP;
                    impuestoPTraslado.BaseP = baseP;
                    impuestoPTraslado.ImporteP = importeP;
                    impuestoPTraslado.ImportePSpecified = true;
                    impuestoPTraslado.TasaOCuotaP = tasaOcuotaP;
                    impuestoPTraslado.TasaOCuotaPSpecified = true;


                    impuestosPTrasladosList.Add(impuestoPTraslado);
                }
            }

            pagosPagoImpuestosP.TrasladosP = impuestosPTrasladosList.ToArray();

            return pagosPagoImpuestosP;
        }

        /// <summary>
        /// Genera los totales de los impuestos de los pagos, para el complemento de pagos, de acuerdo a la especificación del SAT.
        /// </summary>
        /// <param name="oImpuestosP"> </param>
        /// <returns></returns>
        public PagosTotales GeneraTotalesPago(PagosPagoImpuestosP oImpuestosP)
        {
            PagosTotales oTotalesPago = new PagosTotales();
            decimal retencionesIEPS = Decimal.Zero;
            decimal retencionesIVA = Decimal.Zero;
            decimal retencionesISR = Decimal.Zero;
            decimal totalTrasladosImpuestoIVA16 = Decimal.Zero;
            decimal totalTrasladosBaseIVA16 = Decimal.Zero;
            decimal totalTrasladosImpuestoIVA8 = Decimal.Zero;
            decimal totalTrasladosBaseIVA8 = Decimal.Zero;
            decimal totalTrasladosImpuestoIVA0 = Decimal.Zero;
            decimal totalTrasladosBaseIVA0 = Decimal.Zero;

            foreach(PagosPagoImpuestosPTrasladoP trasladoP in oImpuestosP.TrasladosP)
            {
                if(trasladoP.ImpuestoP.Equals("002"))
                {
                    decimal iva16 = Decimal.Round(new Decimal(0.16), 6);
                    decimal iva8 = Decimal.Round(new Decimal(0.08), 6);
                    decimal iva0 = Decimal.Round(Decimal.Zero, 6);
                    decimal tasCuoP = trasladoP.TasaOCuotaP;

                    if(Decimal.Compare(iva16, tasCuoP) == 0)
                    {
                        totalTrasladosImpuestoIVA16 = Decimal.Add(totalTrasladosImpuestoIVA16, trasladoP.ImporteP);
                        totalTrasladosBaseIVA16 = Decimal.Add(totalTrasladosBaseIVA16, trasladoP.BaseP);
                    }
                    if (Decimal.Compare(iva8, tasCuoP) == 0)
                    {
                        totalTrasladosImpuestoIVA8 = Decimal.Add(totalTrasladosImpuestoIVA8, trasladoP.ImporteP);
                        totalTrasladosBaseIVA8 = Decimal.Add(totalTrasladosBaseIVA8, trasladoP.BaseP);
                    }
                    if (Decimal.Compare(iva0, tasCuoP) == 0)
                    {
                        totalTrasladosImpuestoIVA0 = Decimal.Add(totalTrasladosImpuestoIVA0, trasladoP.ImporteP);
                        totalTrasladosBaseIVA0 = Decimal.Add(totalTrasladosBaseIVA0, trasladoP.BaseP);
                    }
                }
            }

            if (Decimal.Compare(totalTrasladosImpuestoIVA16, Decimal.Zero) > 0)
            {
                oTotalesPago.TotalTrasladosImpuestoIVA16 = totalTrasladosImpuestoIVA16;
                oTotalesPago.TotalTrasladosImpuestoIVA16Specified = true;
                oTotalesPago.TotalTrasladosBaseIVA16 = totalTrasladosBaseIVA16;
                oTotalesPago.TotalTrasladosBaseIVA16Specified = true;
            }

            if (Decimal.Compare(totalTrasladosImpuestoIVA8, Decimal.Zero) > 0)
            {
                oTotalesPago.TotalTrasladosImpuestoIVA8 = totalTrasladosImpuestoIVA8;
                oTotalesPago.TotalTrasladosImpuestoIVA8Specified = true;
                oTotalesPago.TotalTrasladosBaseIVA8 = totalTrasladosBaseIVA8;
                oTotalesPago.TotalTrasladosBaseIVA8Specified = true;
            }

            if (Decimal.Compare(totalTrasladosBaseIVA0, Decimal.Zero) > 0)
            {
                oTotalesPago.TotalTrasladosImpuestoIVA0 = totalTrasladosImpuestoIVA0;
                oTotalesPago.TotalTrasladosImpuestoIVA0Specified = true;
                oTotalesPago.TotalTrasladosBaseIVA0 = totalTrasladosBaseIVA0;
                oTotalesPago.TotalTrasladosBaseIVA0Specified = true;
            }

            return oTotalesPago;
        }



#endregion
        public string PathCer { get => pathCer; set => pathCer = value; }
        public string PathKey { get => pathKey; set => pathKey = value; }
        public string ClavePrivada { get => clavePrivada; set => clavePrivada = value; }
        public int DecimalesMoneda { get => decimalesMoneda; set => decimalesMoneda = value; }
    }


}
