using System;
using System.Collections.Generic;
using System.Text;

namespace FactorialN
{
    class Factorial
    { 

        //variable y propiedad
        int num;
        public void Num_set(int valor)
        {
            num = valor;
        }
        //variable y propiedad
        int fac;
        public int fac_regresar()
        {
            return fac;
        }
        //metodo para calcular el factorial
        public void calcular()
        {
            int i;
            fac = num;

            for (i= 1; i < num;i++)
            {
                fac = fac * i;
            }
        }
    }
}
