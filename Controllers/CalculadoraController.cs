using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTarea1.Controllers
{
    public class CalculadoraController
    {
        public decimal Suma(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public decimal Resta(decimal num1, decimal num2)
        {
            return num1 - num2;
        }

        public decimal Multiplicacion(decimal num1, decimal num2)
        {
            return num1 * num2;
        }

        public decimal? Division(decimal num1, decimal num2)
        {
            try
            {
                return num1 / num2;
            }
            catch(Exception ex)
            {
                ex.ToString();
                return null;
            }
        }
    }
}
