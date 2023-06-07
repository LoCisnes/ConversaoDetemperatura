using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversaoDetemperaturaJoao
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double valor = Convert.ToDouble(txtValor.Text);

            if (rbCelsius1.Checked == true)
            {
                if (rbKelvin2.Checked == true)
                {
                    txtResultado.Text = (valor + 273) + "K";
                }

                else
                    if (gbSaida.Checked == true)
                    {
                        txtResultado.Text = (valor * 1.8 + 32) + "°F";
                    }
                    else
                    {
                        txtResultado.Text = valor + "°C";
                    }
            }

            else
                if (rbKelvin1.Checked == true)
                {
                    if (rbCelsius2.Checked == true)
                    {
                        txtResultado.Text = (valor - 273) + "°C";
                    }
               else
                        if(gbSaida.Checked == true)
                        {
                            txtResultado.Text = (valor * 1.8 - 459.67) + "°F";
                        }
                    else
                        {
                            txtResultado.Text = valor + "K";
                        }
                }
                    else
                    if (rbFahrenheit1.Checked == true)// Verifica se o Fahreinheit está selecionada no Groupbox Entrada
                    {
                        //Verifica opção está selecionada no Groupbox Saida
                        //e atribui o resultado ao txtResultado
                        if (rbCelsius2.Checked == true)
                        {
                            txtResultado.Text = ((valor - 32) / 1.8) + "°C";
                        }
                        else
                            if (rbKelvin2.Checked == true)
                            {
                                txtResultado.Text = ((valor + 459.67) / 1.8) + "°K";
                            }
                            else
                            {
                                txtResultado.Text = valor + "°F";
                            }
                    }
                    else // Caso todas as opções retornem falso...
                    {
                        txtResultado.Text = valor.ToString(); //... o resultado é apenas atribuidos ao txtResultado
                    }
                                   

               
                          
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            txtResultado.Clear();

            foreach (Control Componente in gbEntrada.Controls) 
            {
                (Componente as RadioButton).Checked = false;
            }
            foreach (Control Componente in gbEntrada.Controls)
            {
                (Componente as RadioButton).Checked = false;
            }




        }
    }
}
