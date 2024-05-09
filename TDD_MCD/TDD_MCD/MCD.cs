using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_MCD
{
    public class MCD
    {
        public static double Calcular_MCD_Dos(double nro1, double nro2)
        {
            while (nro2 != 0)
            {
                double temp = nro2;
                nro2 = nro1 % nro2;
                nro1 = temp;
            }
            return nro1;
        }

        public static double Calcular_MCD_Cuatro(double nro1, double nro2, double nro3, double nro4)
        {
            double MCD_nro1_nro2 = Calcular_MCD_Dos(nro1, nro2);
            double MCD_nro3_nro4 = Calcular_MCD_Dos(nro3, nro4);
            return Calcular_MCD_Dos(MCD_nro1_nro2, MCD_nro3_nro4);
        }
    }
}
