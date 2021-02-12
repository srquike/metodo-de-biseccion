using System;
using System.Collections.Generic;
using System.Text;

namespace MetodoDeBiseccion
{
    class Iteracion
    {
        public int I { get; set; }
        public double A { get; set; }
        public double B { get; set; }
        public double Xr { get; set; }
        public double Fa { get; set; }
        public double Fxr { get; set; }
        public double Fafxr { get; set; }
        public double Error { get; set; }
        public bool IsSolucion { get; set; }
    }
}
