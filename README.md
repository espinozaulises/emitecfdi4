
# EmiteCfdi 4.0

Librería DLL desarrollada en C# para la generación del XML del CFDI 4.0 que cumple con los estandares de la autoridad fiscal Mexicana.




## Ejemplos de uso

```C#
CFDi40.CFDi cfd = new CFDi40.CFDi();

/*
 * Se le pasan las rutas de los archivos del CSD
 */
cfd.PathCer = pathCer;
cfd.PathKey = pathKey;
cfd.ClavePrivada = clavePrivada;

/*
 * Se instancia el objeto Comprobante y se llenan las propiedades
 */
Comprobante comprobante = new Comprobante();
comprobante.Folio = "123";
comprobante.Fecha = fecha;
comprobante.Total = "2615.00";
comprobante.TipoDeComprobante = "I";
comprobante.Exportacion = "01";
comprobante.LugarExpedicion = "67800";
comprobante.Serie = "A";
comprobante.FormaPago = "01";
comprobante.CondicionesDePago = "3 MESES";
//comprobante.Descuento = "22500.00";
comprobante.TipoCambio = "1";
comprobante.MetodoPago = "PUE";
comprobante.SubTotal = "2313.62";
comprobante.Moneda = "MXN";

cfd.DatosComprobante(comprobante);

/*
 * Datos del receptor y emisor
 */
ComprobanteEmisor cEmisor = new ComprobanteEmisor();
cEmisor.Nombre = "ESCUELA KEMPER URGATE";
cEmisor.Rfc = "EKU9003173C9";
cEmisor.RegimenFiscal = "601";
cfd.DatosEmisor(cEmisor);

ComprobanteReceptor cReceptor = new ComprobanteReceptor();
cReceptor.Nombre = "FELIX MANUEL ANDRADE BALLADO";
cReceptor.Rfc = "AABF800614HI0";
cReceptor.RegimenFiscalReceptor = "612";
cReceptor.DomicilioFiscalReceptor = "86400";
cReceptor.UsoCFDI = "G03";
cfd.DatosReceptor(cReceptor);

ComprobanteConcepto concepto = new ComprobanteConcepto();
concepto.ClaveProdServ = "10121804";
concepto.NoIdentificacion = "BCT001";
concepto.Cantidad = "1";
concepto.ClaveUnidad = "XSA";
concepto.Unidad = "Bulto";
concepto.Descripcion = "ALIMENTO DE PERRO 15 KG";
concepto.ValorUnitario = "508.62";
concepto.Importe = "508.62";
concepto.ObjetoImp = "02";

ComprobanteConceptoImpuestosTraslado cImpTraslados = new ComprobanteConceptoImpuestosTraslado();
List<ComprobanteConceptoImpuestosTraslado> listCImpTraslados = new List<ComprobanteConceptoImpuestosTraslado>();

cImpTraslados.Base = "508.62";
cImpTraslados.Importe = "81.38";
cImpTraslados.Impuesto = "002";
cImpTraslados.TasaOCuota = "0.160000";
cImpTraslados.TipoFactor = "Tasa";

listCImpTraslados.Add(cImpTraslados);
cfd.AgregaConcepto(concepto, listCImpTraslados);

/*
 * Se genera el XML
 */
string sXml;
sXml = cfd.GeneraXML();

```
