using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class LaCalculadora : Form
    {
        public LaCalculadora()
        {
            InitializeComponent();
        }
        
        private static Double Operar(string numero1, string numero2, string operador)
        {
            Calculadora calcu = new Calculadora();
            Numero num1= new Numero(numero1);
            Numero num2= new Numero(numero2);
            return calcu.Operar(num1, num2, operador);
        }
        private void Limpiar()
        {
            this.txtN1.Text = "";
            this.txtN2.Text = "";
            this.lblResultado.Text = "";
            this.cmbOperador.Text = "";
           // this.banderaBinario = true;
        }
        private bool verificarSiEsBinario(string binario)
        {
            int i;
            bool retorno=false;
            for (i = binario.Length - 1; i >= 0; i--)
            { 
                if(binario[i]=='1'||binario[i]=='0')
                { 
                    retorno = true; 
                }
                else
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text=""+LaCalculadora.Operar(this.txtN1.Text, this.txtN2.Text, this.cmbOperador.Text);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnABinario_Click(object sender, EventArgs e)
        {
            int aux;
             if (int.TryParse(this.lblResultado.Text,out aux))
            {
                Numero numero = new Numero(this.lblResultado.Text);
                this.lblResultado.Text=numero.DecimalBinario(this.lblResultado.Text);
                //this.banderaBinario = false;
            }
        }

        private void btnADecimal_Click(object sender, EventArgs e)
        {

            if (this.verificarSiEsBinario(this.lblResultado.Text))
            {
                Numero numero = new Numero(this.lblResultado.Text);
                this.lblResultado.Text = numero.BinarioDecimal(this.lblResultado.Text);
            }
        }
    }
}
