using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace CFDi40 { 

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    [XmlRoot(Namespace = "http://www.sat.gob.mx/cfd/4", IsNullable = false)]
    public partial class Comprobante
    {

        private ComprobanteInformacionGlobal informacionGlobal;
        private ComprobanteCfdiRelacionados[] cfdiRelacionados;
        private ComprobanteEmisor emisor;
        private ComprobanteReceptor receptor;
        private ComprobanteConcepto[] conceptos;
        private ComprobanteImpuestos impuestos;
        private ComprobanteComplemento complemento;
        private ComprobanteAddenda addenda;
        private string version;
        private string serie;
        private string folio;
        private DateTime fecha;
        private string sello;
        private string formaPago;
        private bool formaPagoFieldSpecified;
        private string noCertificado;
        private string certificado;
        private string condicionesDePago;
        private string subTotal;
        private string descuento;
        private bool descuentoFieldSpecified;
        private string moneda;
        private string tipoCambio;
        private bool tipoCambioFieldSpecified;
        private string total;
        private string tipoDeComprobante;
        private string exportacion;
        private string metodoPago;
        private bool metodoPagoFieldSpecified;
        private string lugarExpedicion;
        private string confirmacion;

        [XmlAttribute("schemaLocation", Namespace = XmlSchema.InstanceNamespace)]
        public string schemaLocation { get; set; }
        //private string schemaLocation = "http://www.sat.gob.mx/cfd/4 http://www.sat.gob.mx/sitio_internet/cfd/4/cfdv40.xsd";
        
        public Comprobante()
        {
            version = "4.0";
        }


        /// <summary>
        /// Nodo condicional para precisar la información relacionada con el comprobante global.
        /// </summary>
        public ComprobanteInformacionGlobal InformacionGlobal
        {
            get
            {
                return this.informacionGlobal;
            }
            set
            {
                this.informacionGlobal = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("CfdiRelacionados")]
        public ComprobanteCfdiRelacionados[] CfdiRelacionados
        {
            get
            {
                return this.cfdiRelacionados;
            }
            set
            {
                this.cfdiRelacionados = value;
            }
        }

        /// <remarks/>
        public ComprobanteEmisor Emisor
        {
            get
            {
                return this.emisor;
            }
            set
            {
                this.emisor = value;
            }
        }

        /// <remarks/>
        public ComprobanteReceptor Receptor
        {
            get
            {
                return this.receptor;
            }
            set
            {
                this.receptor = value;
            }
        }

        /// <remarks/>
        [XmlArrayItemAttribute("Concepto", IsNullable = false)]
        public ComprobanteConcepto[] Conceptos
        {
            get
            {
                return this.conceptos;
            }
            set
            {
                this.conceptos = value;
            }
        }

        /// <remarks/>
        public ComprobanteImpuestos Impuestos
        {
            get
            {
                return this.impuestos;
            }
            set
            {
                this.impuestos = value;
            }
        }

        /// <remarks/>
        public ComprobanteComplemento Complemento
        {
            get
            {
                return this.complemento;
            }
            set
            {
                this.complemento = value;
            }
        }

        /// <remarks/>
        public ComprobanteAddenda Addenda
        {
            get
            {
                return this.addenda;
            }
            set
            {
                this.addenda = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Version
        {
            get
            {
                return this.version;
            }
            set
            {
                this.version = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Serie
        {
            get
            {
                return this.serie;
            }
            set
            {
                this.serie = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Folio
        {
            get
            {
                return this.folio;
            }
            set
            {
                this.folio = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public System.DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
            set
            {
                this.fecha = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Sello
        {
            get
            {
                return this.sello;
            }
            set
            {
                this.sello = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string FormaPago
        {
            get
            {
                return this.formaPago;
            }
            set
            {
                this.formaPago = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool FormaPagoSpecified
        {
            get
            {
                return this.formaPagoFieldSpecified;
            }
            set
            {
                this.formaPagoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string NoCertificado
        {
            get
            {
                return this.noCertificado;
            }
            set
            {
                this.noCertificado = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Certificado
        {
            get
            {
                return this.certificado;
            }
            set
            {
                this.certificado = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string CondicionesDePago
        {
            get
            {
                return this.condicionesDePago;
            }
            set
            {
                this.condicionesDePago = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string SubTotal
        {
            get
            {
                return this.subTotal;
            }
            set
            {
                this.subTotal = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Descuento
        {
            get
            {
                return this.descuento;
            }
            set
            {
                this.descuento = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool DescuentoSpecified
        {
            get
            {
                return this.descuentoFieldSpecified;
            }
            set
            {
                this.descuentoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Moneda
        {
            get
            {
                return this.moneda;
            }
            set
            {
                this.moneda = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string TipoCambio
        {
            get
            {
                return this.tipoCambio;
            }
            set
            {
                this.tipoCambio = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TipoCambioSpecified
        {
            get
            {
                return this.tipoCambioFieldSpecified;
            }
            set
            {
                this.tipoCambioFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Total
        {
            get
            {
                return this.total;
            }
            set
            {
                this.total = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string TipoDeComprobante
        {
            get
            {
                return this.tipoDeComprobante;
            }
            set
            {
                this.tipoDeComprobante = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Exportacion
        {
            get
            {
                return this.exportacion;
            }
            set
            {
                this.exportacion = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string MetodoPago
        {
            get
            {
                return this.metodoPago;
            }
            set
            {
                this.metodoPago = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool MetodoPagoSpecified
        {
            get
            {
                return this.metodoPagoFieldSpecified;
            }
            set
            {
                this.metodoPagoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string LugarExpedicion
        {
            get
            {
                return this.lugarExpedicion;
            }
            set
            {
                this.lugarExpedicion = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Confirmacion
        {
            get
            {
                return this.confirmacion;
            }
            set
            {
                this.confirmacion = value;
            }
        }

    }

    /// <remarks/>

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteInformacionGlobal
    {

        private string periodicidad;

        private string meses;

        private short año;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Periodicidad
        {
            get
            {
                return this.periodicidad;
            }
            set
            {
                this.periodicidad = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Meses
        {
            get
            {
                return this.meses;
            }
            set
            {
                this.meses = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public short Año
        {
            get
            {
                return this.año;
            }
            set
            {
                this.año = value;
            }
        }
    }


    /// <remarks/>

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteCfdiRelacionados
    {

        private ComprobanteCfdiRelacionadosCfdiRelacionado[] cfdiRelacionado;

        private string tipoRelacion;

        /// <remarks/>
        [XmlElementAttribute("CfdiRelacionado")]
        public ComprobanteCfdiRelacionadosCfdiRelacionado[] CfdiRelacionado
        {
            get
            {
                return this.cfdiRelacionado;
            }
            set
            {
                this.cfdiRelacionado = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string TipoRelacion
        {
            get
            {
                return this.tipoRelacion;
            }
            set
            {
                this.tipoRelacion = value;
            }
        }
    }

    /// <remarks/>

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteCfdiRelacionadosCfdiRelacionado
    {

        private string uUID;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string UUID
        {
            get
            {
                return this.uUID;
            }
            set
            {
                this.uUID = value;
            }
        }
    }


    /// <remarks/>

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteEmisor
    {

        private string rfc;

        private string nombre;

        private string regimenFiscal;

        private string facAtrAdquirente;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Rfc
        {
            get
            {
                return this.rfc;
            }
            set
            {
                this.rfc = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string RegimenFiscal
        {
            get
            {
                return this.regimenFiscal;
            }
            set
            {
                this.regimenFiscal = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string FacAtrAdquirente
        {
            get
            {
                return this.facAtrAdquirente;
            }
            set
            {
                this.facAtrAdquirente = value;
            }
        }
    }

    /// <remarks/>

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteReceptor
    {

        private string rfc;

        private string nombre;

        private string domicilioFiscalReceptor;

        private string residenciaFiscal;

        private bool residenciaFiscalFieldSpecified;

        private string numRegIdTrib;

        private string regimenFiscalReceptor;

        private string usoCFDI;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Rfc
        {
            get
            {
                return this.rfc;
            }
            set
            {
                this.rfc = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string DomicilioFiscalReceptor
        {
            get
            {
                return this.domicilioFiscalReceptor;
            }
            set
            {
                this.domicilioFiscalReceptor = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string ResidenciaFiscal
        {
            get
            {
                return this.residenciaFiscal;
            }
            set
            {
                this.residenciaFiscal = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ResidenciaFiscalSpecified
        {
            get
            {
                return this.residenciaFiscalFieldSpecified;
            }
            set
            {
                this.residenciaFiscalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string NumRegIdTrib
        {
            get
            {
                return this.numRegIdTrib;
            }
            set
            {
                this.numRegIdTrib = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string RegimenFiscalReceptor
        {
            get
            {
                return this.regimenFiscalReceptor;
            }
            set
            {
                this.regimenFiscalReceptor = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string UsoCFDI
        {
            get
            {
                return this.usoCFDI;
            }
            set
            {
                this.usoCFDI = value;
            }
        }
    }

    /// <remarks/>

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteConcepto
    {

        private ComprobanteConceptoImpuestos impuestos;

        private ComprobanteConceptoACuentaTerceros aCuentaTerceros;

        private ComprobanteConceptoInformacionAduanera[] informacionAduanera;

        private ComprobanteConceptoCuentaPredial[] cuentaPredial;

        private ComprobanteConceptoComplementoConcepto complementoConcepto;

        private ComprobanteConceptoParte[] parte;

        private string claveProdServ;

        private string noIdentificacion;

        private string cantidad;

        private string claveUnidad;

        private string unidad;

        private string descripcion;

        private string valorUnitario;

        private string importe;

        private string descuento;

        private bool descuentoFieldSpecified;

        private string objetoImp;

        /// <remarks/>
        public ComprobanteConceptoImpuestos Impuestos
        {
            get
            {
                return this.impuestos;
            }
            set
            {
                this.impuestos = value;
            }
        }

        /// <remarks/>
        public ComprobanteConceptoACuentaTerceros ACuentaTerceros
        {
            get
            {
                return this.aCuentaTerceros;
            }
            set
            {
                this.aCuentaTerceros = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("InformacionAduanera")]
        public ComprobanteConceptoInformacionAduanera[] InformacionAduanera
        {
            get
            {
                return this.informacionAduanera;
            }
            set
            {
                this.informacionAduanera = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("CuentaPredial")]
        public ComprobanteConceptoCuentaPredial[] CuentaPredial
        {
            get
            {
                return this.cuentaPredial;
            }
            set
            {
                this.cuentaPredial = value;
            }
        }

        /// <remarks/>
        public ComprobanteConceptoComplementoConcepto ComplementoConcepto
        {
            get
            {
                return this.complementoConcepto;
            }
            set
            {
                this.complementoConcepto = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("Parte")]
        public ComprobanteConceptoParte[] Parte
        {
            get
            {
                return this.parte;
            }
            set
            {
                this.parte = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string ClaveProdServ
        {
            get
            {
                return this.claveProdServ;
            }
            set
            {
                this.claveProdServ = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string NoIdentificacion
        {
            get
            {
                return this.noIdentificacion;
            }
            set
            {
                this.noIdentificacion = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Cantidad
        {
            get
            {
                return this.cantidad;
            }
            set
            {
                this.cantidad = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string ClaveUnidad
        {
            get
            {
                return this.claveUnidad;
            }
            set
            {
                this.claveUnidad = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Unidad
        {
            get
            {
                return this.unidad;
            }
            set
            {
                this.unidad = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                this.descripcion = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string ValorUnitario
        {
            get
            {
                return this.valorUnitario;
            }
            set
            {
                this.valorUnitario = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Importe
        {
            get
            {
                return this.importe;
            }
            set
            {
                this.importe = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Descuento
        {
            get
            {
                return this.descuento;
            }
            set
            {
                this.descuento = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool DescuentoSpecified
        {
            get
            {
                return this.descuentoFieldSpecified;
            }
            set
            {
                this.descuentoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string ObjetoImp
        {
            get
            {
                return this.objetoImp;
            }
            set
            {
                this.objetoImp = value;
            }
        }
    }

    /// <remarks/>

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteConceptoImpuestos
    {

        private ComprobanteConceptoImpuestosTraslado[] traslados;

        private ComprobanteConceptoImpuestosRetencion[] retenciones;

        /// <remarks/>
        [XmlArrayItemAttribute("Traslado", IsNullable = false)]
        public ComprobanteConceptoImpuestosTraslado[] Traslados
        {
            get
            {
                return this.traslados;
            }
            set
            {
                this.traslados = value;
            }
        }

        /// <remarks/>
        [XmlArrayItemAttribute("Retencion", IsNullable = false)]
        public ComprobanteConceptoImpuestosRetencion[] Retenciones
        {
            get
            {
                return this.retenciones;
            }
            set
            {
                this.retenciones = value;
            }
        }
    }

    /// <remarks/>

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteConceptoImpuestosTraslado
    {

        private decimal baseImp;
        private string impuesto;
        private string tipoFactor;
        private string tasaOCuota;
        private bool tasaOCuotaFieldSpecified = true;
        private decimal importe;
        private bool importeFieldSpecified = true;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal Base
        {
            get
            {
                return this.baseImp;
            }
            set
            {
                this.baseImp = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Impuesto
        {
            get
            {
                return this.impuesto;
            }
            set
            {
                this.impuesto = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string TipoFactor
        {
            get
            {
                return this.tipoFactor;
            }
            set
            {
                this.tipoFactor = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string TasaOCuota
        {
            get
            {
                return this.tasaOCuota;
            }
            set
            {
                this.tasaOCuota = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TasaOCuotaSpecified
        {
            get
            {
                return this.tasaOCuotaFieldSpecified;
            }
            set
            {
                this.tasaOCuotaFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal Importe
        {
            get
            {
                return this.importe;
            }
            set
            {
                this.importe = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ImporteSpecified
        {
            get
            {
                return this.importeFieldSpecified;
            }
            set
            {
                this.importeFieldSpecified = value;
            }
        }
    }


    /// <remarks/>

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteConceptoImpuestosRetencion
    {

        private decimal baseImp;

        private string impuesto;

        private string tipoFactor;

        private decimal tasaOCuota;

        private decimal importe;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal Base
        {
            get
            {
                return this.baseImp;
            }
            set
            {
                this.baseImp = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Impuesto
        {
            get
            {
                return this.impuesto;
            }
            set
            {
                this.impuesto = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string TipoFactor
        {
            get
            {
                return this.tipoFactor;
            }
            set
            {
                this.tipoFactor = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal TasaOCuota
        {
            get
            {
                return this.tasaOCuota;
            }
            set
            {
                this.tasaOCuota = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal Importe
        {
            get
            {
                return this.importe;
            }
            set
            {
                this.importe = value;
            }
        }
    }

    /// <remarks/>

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteConceptoACuentaTerceros
    {

        private string rfcACuentaTerceros;

        private string nombreACuentaTerceros;

        private string regimenFiscalACuentaTerceros;

        private string domicilioFiscalACuentaTerceros;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string RfcACuentaTerceros
        {
            get
            {
                return this.rfcACuentaTerceros;
            }
            set
            {
                this.rfcACuentaTerceros = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string NombreACuentaTerceros
        {
            get
            {
                return this.nombreACuentaTerceros;
            }
            set
            {
                this.nombreACuentaTerceros = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string RegimenFiscalACuentaTerceros
        {
            get
            {
                return this.regimenFiscalACuentaTerceros;
            }
            set
            {
                this.regimenFiscalACuentaTerceros = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string DomicilioFiscalACuentaTerceros
        {
            get
            {
                return this.domicilioFiscalACuentaTerceros;
            }
            set
            {
                this.domicilioFiscalACuentaTerceros = value;
            }
        }
    }

    /// <remarks/>

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteConceptoInformacionAduanera
    {

        private string numeroPedimento;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string NumeroPedimento
        {
            get
            {
                return this.numeroPedimento;
            }
            set
            {
                this.numeroPedimento = value;
            }
        }
    }

    /// <remarks/>

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteConceptoCuentaPredial
    {

        private string numero;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }
    }

    /// <remarks/>

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteConceptoComplementoConcepto
    {

        private System.Xml.XmlElement[] any;

        /// <remarks/>
        [XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.any;
            }
            set
            {
                this.any = value;
            }
        }
    }

    /// <remarks/>

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteConceptoParte
    {

        private ComprobanteConceptoParteInformacionAduanera[] informacionAduanera;

        private string claveProdServ;

        private string noIdentificacion;

        private decimal cantidad;

        private string unidad;

        private string descripcion;

        private decimal valorUnitario;

        private bool valorUnitarioFieldSpecified;

        private decimal importe;

        private bool importeFieldSpecified;

        /// <remarks/>
        [XmlElementAttribute("InformacionAduanera")]
        public ComprobanteConceptoParteInformacionAduanera[] InformacionAduanera
        {
            get
            {
                return this.informacionAduanera;
            }
            set
            {
                this.informacionAduanera = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string ClaveProdServ
        {
            get
            {
                return this.claveProdServ;
            }
            set
            {
                this.claveProdServ = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string NoIdentificacion
        {
            get
            {
                return this.noIdentificacion;
            }
            set
            {
                this.noIdentificacion = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal Cantidad
        {
            get
            {
                return this.cantidad;
            }
            set
            {
                this.cantidad = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Unidad
        {
            get
            {
                return this.unidad;
            }
            set
            {
                this.unidad = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                this.descripcion = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal ValorUnitario
        {
            get
            {
                return this.valorUnitario;
            }
            set
            {
                this.valorUnitario = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ValorUnitarioSpecified
        {
            get
            {
                return this.valorUnitarioFieldSpecified;
            }
            set
            {
                this.valorUnitarioFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal Importe
        {
            get
            {
                return this.importe;
            }
            set
            {
                this.importe = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ImporteSpecified
        {
            get
            {
                return this.importeFieldSpecified;
            }
            set
            {
                this.importeFieldSpecified = value;
            }
        }
    }

    /// <remarks/>

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteConceptoParteInformacionAduanera
    {

        private string numeroPedimento;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string NumeroPedimento
        {
            get
            {
                return this.numeroPedimento;
            }
            set
            {
                this.numeroPedimento = value;
            }
        }
    }


    /// <remarks/>

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteImpuestos
    {

        private ComprobanteImpuestosRetencion[] retenciones;

        private ComprobanteImpuestosTraslado[] traslados;

        private string totalImpuestosRetenidos;

        private bool totalImpuestosRetenidosSpecified;

        private string totalImpuestosTrasladados;

        private bool totalImpuestosTrasladadosSpecified;

        /// <remarks/>
        [XmlArrayItemAttribute("Retencion", IsNullable = false)]
        public ComprobanteImpuestosRetencion[] Retenciones
        {
            get
            {
                return this.retenciones;
            }
            set
            {
                this.retenciones = value;
            }
        }

        /// <remarks/>
        [XmlArrayItemAttribute("Traslado", IsNullable = false)]
        public ComprobanteImpuestosTraslado[] Traslados
        {
            get
            {
                return this.traslados;
            }
            set
            {
                this.traslados = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string TotalImpuestosRetenidos
        {
            get
            {
                return this.totalImpuestosRetenidos;
            }
            set
            {
                this.totalImpuestosRetenidos = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TotalImpuestosRetenidosSpecified
        {
            get
            {
                return this.totalImpuestosRetenidosSpecified;
            }
            set
            {
                this.totalImpuestosRetenidosSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string TotalImpuestosTrasladados
        {
            get
            {
                return this.totalImpuestosTrasladados;
            }
            set
            {
                this.totalImpuestosTrasladados = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TotalImpuestosTrasladadosSpecified
        {
            get
            {
                return this.totalImpuestosTrasladadosSpecified;
            }
            set
            {
                this.totalImpuestosTrasladadosSpecified = value;
            }
        }
    }

    /// <remarks/>

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteImpuestosRetencion
    {

        private string impuesto;

        private decimal importe;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Impuesto
        {
            get
            {
                return this.impuesto;
            }
            set
            {
                this.impuesto = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal Importe
        {
            get
            {
                return this.importe;
            }
            set
            {
                this.importe = value;
            }
        }
    }

    /// <remarks/>

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteImpuestosTraslado
    {

        private string baseImp;

        private string impuesto;

        private string tipoFactor;

        private string tasaOCuota;

        private bool tasaOCuotaFieldSpecified = true;

        private string importe;

        private bool importeFieldSpecified = true;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Base
        {
            get
            {
                return this.baseImp;
            }
            set
            {
                this.baseImp = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Impuesto
        {
            get
            {
                return this.impuesto;
            }
            set
            {
                this.impuesto = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string TipoFactor
        {
            get
            {
                return this.tipoFactor;
            }
            set
            {
                this.tipoFactor = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string TasaOCuota
        {
            get
            {
                return this.tasaOCuota;
            }
            set
            {
                this.tasaOCuota = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TasaOCuotaSpecified
        {
            get
            {
                return this.tasaOCuotaFieldSpecified;
            }
            set
            {
                this.tasaOCuotaFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Importe
        {
            get
            {
                return this.importe;
            }
            set
            {
                this.importe = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ImporteSpecified
        {
            get
            {
                return this.importeFieldSpecified;
            }
            set
            {
                this.importeFieldSpecified = value;
            }
        }
    }

    /// <remarks/>

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteComplemento
    {

        private System.Xml.XmlElement[] any;

        /// <remarks/>
        [XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.any;
            }
            set
            {
                this.any = value;
            }
        }
    }

    /// <remarks/>

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteAddenda
    {

        private System.Xml.XmlElement[] any;

        /// <remarks/>
        [XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.any;
            }
            set
            {
                this.any = value;
            }
        }
    }
}