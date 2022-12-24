using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFDi40.Objects
{
    internal class ComplementoImpuestoPObj
    {
        private decimal baseP;
        private string impuestoP;
        private string tasCuoP;
        private decimal totImportP;
        private string tipFactP;
        private string forPag;
        private string tipoImp;

        public decimal BaseP { get => baseP; set => baseP = value; }
        public string ImpuestoP { get => impuestoP; set => impuestoP = value; }
        public string TasCuoP { get => tasCuoP; set => tasCuoP = value; }
        public decimal TotImportP { get => totImportP; set => totImportP = value; }
        public string TipFactP { get => tipFactP; set => tipFactP = value; }
        public string ForPag { get => forPag; set => forPag = value; }
        public string TipoImp { get => tipoImp; set => tipoImp = value; }
    }
}
