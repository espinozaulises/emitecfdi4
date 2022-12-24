﻿using System;
using System.Xml.Serialization;

namespace CFDi40
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos20")]
    [XmlRootAttribute(Namespace = "http://www.sat.gob.mx/Pagos20", IsNullable = false)]
    public partial class Pagos
    {

        private PagosTotales totalesField;
        private PagosPago[] pagoField;
        private string versionField;

        public Pagos()
        {
            this.versionField = "2.0";
        }

        /// <remarks/>
        public PagosTotales Totales
        {
            get
            {
                return this.totalesField;
            }
            set
            {
                this.totalesField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("Pago")]
        public PagosPago[] Pago
        {
            get
            {
                return this.pagoField;
            }
            set
            {
                this.pagoField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos20")]
    public partial class PagosTotales
    {

        private decimal totalRetencionesIVAField;
        private bool totalRetencionesIVAFieldSpecified;
        private decimal totalRetencionesISRField;
        private bool totalRetencionesISRFieldSpecified;
        private decimal totalRetencionesIEPSField;
        private bool totalRetencionesIEPSFieldSpecified;
        private decimal totalTrasladosBaseIVA16Field;
        private bool totalTrasladosBaseIVA16FieldSpecified;
        private decimal totalTrasladosImpuestoIVA16Field;
        private bool totalTrasladosImpuestoIVA16FieldSpecified;
        private decimal totalTrasladosBaseIVA8Field;
        private bool totalTrasladosBaseIVA8FieldSpecified;
        private decimal totalTrasladosImpuestoIVA8Field;
        private bool totalTrasladosImpuestoIVA8FieldSpecified;
        private decimal totalTrasladosBaseIVA0Field;
        private bool totalTrasladosBaseIVA0FieldSpecified;
        private decimal totalTrasladosImpuestoIVA0Field;
        private bool totalTrasladosImpuestoIVA0FieldSpecified;
        private decimal totalTrasladosBaseIVAExentoField;
        private bool totalTrasladosBaseIVAExentoFieldSpecified;
        private decimal montoTotalPagosField;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal TotalRetencionesIVA
        {
            get
            {
                return this.totalRetencionesIVAField;
            }
            set
            {
                this.totalRetencionesIVAField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TotalRetencionesIVASpecified
        {
            get
            {
                return this.totalRetencionesIVAFieldSpecified;
            }
            set
            {
                this.totalRetencionesIVAFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal TotalRetencionesISR
        {
            get
            {
                return this.totalRetencionesISRField;
            }
            set
            {
                this.totalRetencionesISRField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TotalRetencionesISRSpecified
        {
            get
            {
                return this.totalRetencionesISRFieldSpecified;
            }
            set
            {
                this.totalRetencionesISRFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal TotalRetencionesIEPS
        {
            get
            {
                return this.totalRetencionesIEPSField;
            }
            set
            {
                this.totalRetencionesIEPSField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TotalRetencionesIEPSSpecified
        {
            get
            {
                return this.totalRetencionesIEPSFieldSpecified;
            }
            set
            {
                this.totalRetencionesIEPSFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal TotalTrasladosBaseIVA16
        {
            get
            {
                return this.totalTrasladosBaseIVA16Field;
            }
            set
            {
                this.totalTrasladosBaseIVA16Field = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TotalTrasladosBaseIVA16Specified
        {
            get
            {
                return this.totalTrasladosBaseIVA16FieldSpecified;
            }
            set
            {
                this.totalTrasladosBaseIVA16FieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal TotalTrasladosImpuestoIVA16
        {
            get
            {
                return this.totalTrasladosImpuestoIVA16Field;
            }
            set
            {
                this.totalTrasladosImpuestoIVA16Field = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TotalTrasladosImpuestoIVA16Specified
        {
            get
            {
                return this.totalTrasladosImpuestoIVA16FieldSpecified;
            }
            set
            {
                this.totalTrasladosImpuestoIVA16FieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal TotalTrasladosBaseIVA8
        {
            get
            {
                return this.totalTrasladosBaseIVA8Field;
            }
            set
            {
                this.totalTrasladosBaseIVA8Field = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TotalTrasladosBaseIVA8Specified
        {
            get
            {
                return this.totalTrasladosBaseIVA8FieldSpecified;
            }
            set
            {
                this.totalTrasladosBaseIVA8FieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal TotalTrasladosImpuestoIVA8
        {
            get
            {
                return this.totalTrasladosImpuestoIVA8Field;
            }
            set
            {
                this.totalTrasladosImpuestoIVA8Field = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TotalTrasladosImpuestoIVA8Specified
        {
            get
            {
                return this.totalTrasladosImpuestoIVA8FieldSpecified;
            }
            set
            {
                this.totalTrasladosImpuestoIVA8FieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal TotalTrasladosBaseIVA0
        {
            get
            {
                return this.totalTrasladosBaseIVA0Field;
            }
            set
            {
                this.totalTrasladosBaseIVA0Field = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TotalTrasladosBaseIVA0Specified
        {
            get
            {
                return this.totalTrasladosBaseIVA0FieldSpecified;
            }
            set
            {
                this.totalTrasladosBaseIVA0FieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal TotalTrasladosImpuestoIVA0
        {
            get
            {
                return this.totalTrasladosImpuestoIVA0Field;
            }
            set
            {
                this.totalTrasladosImpuestoIVA0Field = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TotalTrasladosImpuestoIVA0Specified
        {
            get
            {
                return this.totalTrasladosImpuestoIVA0FieldSpecified;
            }
            set
            {
                this.totalTrasladosImpuestoIVA0FieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal TotalTrasladosBaseIVAExento
        {
            get
            {
                return this.totalTrasladosBaseIVAExentoField;
            }
            set
            {
                this.totalTrasladosBaseIVAExentoField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TotalTrasladosBaseIVAExentoSpecified
        {
            get
            {
                return this.totalTrasladosBaseIVAExentoFieldSpecified;
            }
            set
            {
                this.totalTrasladosBaseIVAExentoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal MontoTotalPagos
        {
            get
            {
                return this.montoTotalPagosField;
            }
            set
            {
                this.montoTotalPagosField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos20")]
    public partial class PagosPago
    {

        private PagosPagoDoctoRelacionado[] doctoRelacionadoField;
        private PagosPagoImpuestosP impuestosPField;
        private String fechaPago;
        private string formaDePagoPField;
        private string monedaPField;
        private string tipoCambioPField;
        private bool tipoCambioPFieldSpecified;
        private string montoField;
        private string numOperacionField;
        private string rfcEmisorCtaOrdField;
        private string nomBancoOrdExtField;
        private string ctaOrdenanteField;
        private string rfcEmisorCtaBenField;
        private string ctaBeneficiarioField;
        private string tipoCadPagoField;
        private bool tipoCadPagoFieldSpecified;
        private byte[] certPagoField;
        private string cadPagoField;
        private byte[] selloPagoField;

        /// <remarks/>
        [XmlElementAttribute("DoctoRelacionado")]
        public PagosPagoDoctoRelacionado[] DoctoRelacionado
        {
            get
            {
                return this.doctoRelacionadoField;
            }
            set
            {
                this.doctoRelacionadoField = value;
            }
        }

        /// <remarks/>
        public PagosPagoImpuestosP ImpuestosP
        {
            get
            {
                return this.impuestosPField;
            }
            set
            {
                this.impuestosPField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string FechaPago
        {
            get
            {
                return this.fechaPago;
            }
            set
            {
                this.fechaPago = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string FormaDePagoP
        {
            get
            {
                return this.formaDePagoPField;
            }
            set
            {
                this.formaDePagoPField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string MonedaP
        {
            get
            {
                return this.monedaPField;
            }
            set
            {
                this.monedaPField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string TipoCambioP
        {
            get
            {
                return this.tipoCambioPField;
            }
            set
            {
                this.tipoCambioPField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TipoCambioPSpecified
        {
            get
            {
                return this.tipoCambioPFieldSpecified;
            }
            set
            {
                this.tipoCambioPFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Monto
        {
            get
            {
                return this.montoField;
            }
            set
            {
                this.montoField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string NumOperacion
        {
            get
            {
                return this.numOperacionField;
            }
            set
            {
                this.numOperacionField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string RfcEmisorCtaOrd
        {
            get
            {
                return this.rfcEmisorCtaOrdField;
            }
            set
            {
                this.rfcEmisorCtaOrdField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string NomBancoOrdExt
        {
            get
            {
                return this.nomBancoOrdExtField;
            }
            set
            {
                this.nomBancoOrdExtField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string CtaOrdenante
        {
            get
            {
                return this.ctaOrdenanteField;
            }
            set
            {
                this.ctaOrdenanteField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string RfcEmisorCtaBen
        {
            get
            {
                return this.rfcEmisorCtaBenField;
            }
            set
            {
                this.rfcEmisorCtaBenField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string CtaBeneficiario
        {
            get
            {
                return this.ctaBeneficiarioField;
            }
            set
            {
                this.ctaBeneficiarioField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string TipoCadPago
        {
            get
            {
                return this.tipoCadPagoField;
            }
            set
            {
                this.tipoCadPagoField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TipoCadPagoSpecified
        {
            get
            {
                return this.tipoCadPagoFieldSpecified;
            }
            set
            {
                this.tipoCadPagoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "base64Binary")]
        public byte[] CertPago
        {
            get
            {
                return this.certPagoField;
            }
            set
            {
                this.certPagoField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string CadPago
        {
            get
            {
                return this.cadPagoField;
            }
            set
            {
                this.cadPagoField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "base64Binary")]
        public byte[] SelloPago
        {
            get
            {
                return this.selloPagoField;
            }
            set
            {
                this.selloPagoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos20")]
    public partial class PagosPagoDoctoRelacionado
    {

        private PagosPagoDoctoRelacionadoImpuestosDR impuestosDRField;
        private string idDocumentoField;
        private string serieField;
        private string folioField;
        private string monedaDRField;
        private decimal equivalenciaDRField;
        private bool equivalenciaDRFieldSpecified;
        private string numParcialidadField;
        private decimal impSaldoAntField;
        private decimal impPagadoField;
        private decimal impSaldoInsolutoField;
        private string objetoImpDRField;

        /// <remarks/>
        public PagosPagoDoctoRelacionadoImpuestosDR ImpuestosDR
        {
            get
            {
                return this.impuestosDRField;
            }
            set
            {
                this.impuestosDRField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string IdDocumento
        {
            get
            {
                return this.idDocumentoField;
            }
            set
            {
                this.idDocumentoField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Serie
        {
            get
            {
                return this.serieField;
            }
            set
            {
                this.serieField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Folio
        {
            get
            {
                return this.folioField;
            }
            set
            {
                this.folioField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string MonedaDR
        {
            get
            {
                return this.monedaDRField;
            }
            set
            {
                this.monedaDRField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal EquivalenciaDR
        {
            get
            {
                return this.equivalenciaDRField;
            }
            set
            {
                this.equivalenciaDRField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool EquivalenciaDRSpecified
        {
            get
            {
                return this.equivalenciaDRFieldSpecified;
            }
            set
            {
                this.equivalenciaDRFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "integer")]
        public string NumParcialidad
        {
            get
            {
                return this.numParcialidadField;
            }
            set
            {
                this.numParcialidadField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal ImpSaldoAnt
        {
            get
            {
                return this.impSaldoAntField;
            }
            set
            {
                this.impSaldoAntField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal ImpPagado
        {
            get
            {
                return this.impPagadoField;
            }
            set
            {
                this.impPagadoField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal ImpSaldoInsoluto
        {
            get
            {
                return this.impSaldoInsolutoField;
            }
            set
            {
                this.impSaldoInsolutoField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string ObjetoImpDR
        {
            get
            {
                return this.objetoImpDRField;
            }
            set
            {
                this.objetoImpDRField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos20")]
    public partial class PagosPagoDoctoRelacionadoImpuestosDR
    {

        private PagosPagoDoctoRelacionadoImpuestosDRRetencionDR[] retencionesDRField;

        private PagosPagoDoctoRelacionadoImpuestosDRTrasladoDR[] trasladosDRField;

        /// <remarks/>
        [XmlArrayItemAttribute("RetencionDR", IsNullable = false)]
        public PagosPagoDoctoRelacionadoImpuestosDRRetencionDR[] RetencionesDR
        {
            get
            {
                return this.retencionesDRField;
            }
            set
            {
                this.retencionesDRField = value;
            }
        }

        /// <remarks/>
        [XmlArrayItemAttribute("TrasladoDR", IsNullable = false)]
        public PagosPagoDoctoRelacionadoImpuestosDRTrasladoDR[] TrasladosDR
        {
            get
            {
                return this.trasladosDRField;
            }
            set
            {
                this.trasladosDRField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos20")]
    public partial class PagosPagoDoctoRelacionadoImpuestosDRRetencionDR
    {

        private decimal baseDRField;
        private string impuestoDRField;
        private string tipoFactorDRField;
        private decimal tasaOCuotaDRField;
        private decimal importeDRField;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal BaseDR
        {
            get
            {
                return this.baseDRField;
            }
            set
            {
                this.baseDRField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string ImpuestoDR
        {
            get
            {
                return this.impuestoDRField;
            }
            set
            {
                this.impuestoDRField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string TipoFactorDR
        {
            get
            {
                return this.tipoFactorDRField;
            }
            set
            {
                this.tipoFactorDRField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal TasaOCuotaDR
        {
            get
            {
                return this.tasaOCuotaDRField;
            }
            set
            {
                this.tasaOCuotaDRField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal ImporteDR
        {
            get
            {
                return this.importeDRField;
            }
            set
            {
                this.importeDRField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos20")]
    public partial class PagosPagoDoctoRelacionadoImpuestosDRTrasladoDR
    {

        private decimal baseDRField;
        private string impuestoDRField;
        private string tipoFactorDRField;
        private decimal tasaOCuotaDRField;
        private bool tasaOCuotaDRFieldSpecified;
        private decimal importeDRField;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal BaseDR
        {
            get
            {
                return this.baseDRField;
            }
            set
            {
                this.baseDRField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string ImpuestoDR
        {
            get
            {
                return this.impuestoDRField;
            }
            set
            {
                this.impuestoDRField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string TipoFactorDR
        {
            get
            {
                return this.tipoFactorDRField;
            }
            set
            {
                this.tipoFactorDRField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal TasaOCuotaDR
        {
            get
            {
                return this.tasaOCuotaDRField;
            }
            set
            {
                this.tasaOCuotaDRField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TasaOCuotaDRSpecified
        {
            get
            {
                return this.tasaOCuotaDRFieldSpecified;
            }
            set
            {
                this.tasaOCuotaDRFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal ImporteDR
        {
            get
            {
                return this.importeDRField;
            }
            set
            {
                this.importeDRField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos20")]
    public partial class PagosPagoImpuestosP
    {

        private PagosPagoImpuestosPRetencionP[] retencionesPField;
        private PagosPagoImpuestosPTrasladoP[] trasladosPField;

        /// <remarks/>
        [XmlArrayItemAttribute("RetencionP", IsNullable = false)]
        public PagosPagoImpuestosPRetencionP[] RetencionesP
        {
            get
            {
                return this.retencionesPField;
            }
            set
            {
                this.retencionesPField = value;
            }
        }

        /// <remarks/>
        [XmlArrayItemAttribute("TrasladoP", IsNullable = false)]
        public PagosPagoImpuestosPTrasladoP[] TrasladosP
        {
            get
            {
                return this.trasladosPField;
            }
            set
            {
                this.trasladosPField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos20")]
    public partial class PagosPagoImpuestosPRetencionP
    {

        private string impuestoPField;

        private decimal importePField;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string ImpuestoP
        {
            get
            {
                return this.impuestoPField;
            }
            set
            {
                this.impuestoPField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal ImporteP
        {
            get
            {
                return this.importePField;
            }
            set
            {
                this.importePField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos20")]
    public partial class PagosPagoImpuestosPTrasladoP
    {

        private decimal basePField;
        private string impuestoPField;
        private string tipoFactorPField;
        private decimal tasaOCuotaPField;
        private bool tasaOCuotaPFieldSpecified;
        private decimal importePField;
        private bool importePFieldSpecified;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal BaseP
        {
            get
            {
                return this.basePField;
            }
            set
            {
                this.basePField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string ImpuestoP
        {
            get
            {
                return this.impuestoPField;
            }
            set
            {
                this.impuestoPField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string TipoFactorP
        {
            get
            {
                return this.tipoFactorPField;
            }
            set
            {
                this.tipoFactorPField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal TasaOCuotaP
        {
            get
            {
                return this.tasaOCuotaPField;
            }
            set
            {
                this.tasaOCuotaPField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TasaOCuotaPSpecified
        {
            get
            {
                return this.tasaOCuotaPFieldSpecified;
            }
            set
            {
                this.tasaOCuotaPFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal ImporteP
        {
            get
            {
                return this.importePField;
            }
            set
            {
                this.importePField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ImportePSpecified
        {
            get
            {
                return this.importePFieldSpecified;
            }
            set
            {
                this.importePFieldSpecified = value;
            }
        }
    }
}
