using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFDi40.Obj
{
    public class Certificado
    {
        private string subject;
        private string emisor;
        private DateTime validoDesde;
        private DateTime validoHasta;
        private string noSerie;
        private string noCertificado;
        private string tamanioKey;
        private bool vigente;
        public Certificado() { }

        public string toString()
        {
            StringBuilder sb = new StringBuilder("Detalle del certificado: ");

            sb.Append("Persona = ").Append(this.subject).Append("; ");
            sb.Append("Emisor = ").Append(this.emisor).Append("; ");
            sb.Append("Válido desde = ").Append(validoDesde.ToString()).Append("; ");
            sb.Append("Válido hasta = ").Append(validoHasta.ToString()).Append("; ");
            sb.Append("Tamaño de la clave = ").Append(tamanioKey).Append("; ");
            sb.Append("Número de serie = ").Append(noSerie).Append("; ");
            sb.Append("Número de certificado = ").Append(noCertificado);

            return sb.ToString();
        }

        public string Subject { get => subject; set => subject = value; }
        public string Emisor { get => emisor; set => emisor = value; }
        public DateTime ValidoDesde { get => validoDesde; set => validoDesde = value; }
        public DateTime ValidoHasta { get => validoHasta; set => validoHasta = value; }
        public string NoSerie { get => noSerie; set => noSerie = value; }
        public string NoCertificado { get => noCertificado; set => noCertificado = value; }
        public bool Vigente { get => vigente; set => vigente = value; }
        public string TamanioKey { get => tamanioKey; set => tamanioKey = value; }
    }
}
