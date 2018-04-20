using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        public double Operar(Numero numero1, Numero numero2, String operador)
        {
            double retorno=0;
            operador=ValidarOperador(operador);
            switch (operador)
            {
                case "+":
                    retorno = numero1 + numero2;
                    break;
                case "-":
                    retorno = numero1 - numero2;
                    break;
                case "*":
                    retorno = numero1 * numero2;
                    break;
                case "/":
                    retorno = numero1 / numero2;
                    break;
            }

            return retorno;
        }

        private static String ValidarOperador(String operador)
        {
            String retorno;
            if (operador == "/" || operador == "-" || operador == "*")
            {
                retorno = operador;
            }
            else
            {
                retorno = "+";
            }
            return retorno;
        }

    }
}
