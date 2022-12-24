using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFDi40.Objects
{
    internal class ComplementoImpuestoDRObj
    {
        private decimal baseDR;
        private string impuDR;
        private string tiFadDR;
        private decimal tasCuDR;
        private decimal impoDR;
        private string tipoImpDR;

        public decimal BaseDR { get => baseDR; set => baseDR = value; }
        public string ImpuDR { get => impuDR; set => impuDR = value; }
        public string TiFadDR { get => tiFadDR; set => tiFadDR = value; }
        public decimal TasCuDR { get => tasCuDR; set => tasCuDR = value; }
        public decimal ImpoDR { get => impoDR; set => impoDR = value; }
        public string TipoImpDR { get => tipoImpDR; set => tipoImpDR = value; }
    }
}
