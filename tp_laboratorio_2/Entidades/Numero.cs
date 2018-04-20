using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private Double numero;
        
        public Numero(string numero)
        {
            this.SetNumero = numero;
        }
        public Numero(double numero):this(numero.ToString())
        {}
        public Numero():this("0")
        {}
        
        

        private double ValidarNumero(string strNumero)
        { 
            double retorno;
            bool todoOk;
            todoOk=double.TryParse(strNumero,out retorno);

            if (todoOk == false)
                retorno = 0;

            return retorno;
        }

        public string SetNumero 
        { 
            set{this.numero=this.ValidarNumero(value);}
        }
        private int restaNoNegativa(int numero1, int numero2)
        {
            int retorno;
            if (numero1 >= numero2)
                retorno = numero1 - numero2;
            else
                retorno = numero2 - numero1;

            return retorno;
            
        }
        public string BinarioDecimal(string binario)
        {
            int i;
            int j;
            int valorJ;
            int potencia=0;
            int acum=0;
            string retorno="";
            for (i = binario.Length-1; i >=0; i--)
            {
                if (binario[i] == '1')
                {
                    valorJ = this.restaNoNegativa(i, binario.Length - 1);
                   
                    
                        potencia = 1;
                        for (j=valorJ ; j > 0; j--)
                        {
                            
                            potencia = potencia * 2;
                        }
                    
                    acum = acum + potencia;
                }
                else if(binario[i]!='0')
                {
                    retorno = "Valor inválido";
                    break;
                }
            }

            if (retorno != "Valor inválido")
                retorno = "" + acum;

            return retorno;
        }

        public string DecimalBinario(double numeroDoble)
        {
            int i;
            string retorno="";
            char letra;
            string binarioAlRevez = "";
            bool flag =true;
            int numero = (int)numeroDoble;
            while (flag)
            {
                if (numero % 2 == 1 || numero % 2 == 0)
                {
                    binarioAlRevez = binarioAlRevez + (numero%2);
                    numero = numero / 2;
                    if (numero / 2 == 1 || numero / 2 == 0)
                    {
                        binarioAlRevez = binarioAlRevez + (numero % 2);
                        binarioAlRevez =binarioAlRevez + numero / 2;
                        flag = false;
                    }
                }
                else
                {
                    binarioAlRevez = "odilávni-rolaV";
                    flag = false;
                }
                
            }
             
            for (i = binarioAlRevez.Length-1; i >=0; i--)
            {
                letra = binarioAlRevez[i];
                retorno=retorno+letra;
            }

            return retorno;
            

        }
        public string DecimalBinario(string numero)
        {
            bool todoOk;
            Double parametro;
            string retorno;
            if ((todoOk = Double.TryParse(numero, out parametro)) == true)
                retorno = this.DecimalBinario(parametro);
            else
                retorno = "Valor inválido";
            return retorno;
        }

        public static double operator +(Numero n1,Numero n2)
        {
            return (n1.numero + n2.numero);
        }
        public static double operator -(Numero n1, Numero n2)
        {
            return (n1.numero - n2.numero);
        }
        public static double operator *(Numero n1, Numero n2)
        {
            return (n1.numero * n2.numero);
        }
        public static double operator /(Numero n1, Numero n2)
        {
            double resultado;
            if (n2.numero != 0)
            {
                resultado = n1.numero / n2.numero;
            }
            else
            {
                resultado = 0;
            }
            return resultado;
        }
    }
}
