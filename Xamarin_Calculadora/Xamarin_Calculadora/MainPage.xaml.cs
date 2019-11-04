using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin_Calculadora
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        int currentSatate = 1;
        String Operação;
        double primeiro_numero, segundo_numero;

        public MainPage()
        {
            InitializeComponent();
            btnLimpar_Clicked(new object(), new EventArgs());
        }

        private void btnLimpar_Clicked(object sender, EventArgs e)
        {
            primeiro_numero = 0;
            segundo_numero = 0;
            currentSatate = 1;
            this.txtResultado.Text = "0";
        }

       private void selecionar_numero(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string pressionar = button.Text;

            if (this.txtResultado.Text == "0" || currentSatate < 0)
            {
                this.txtResultado.Text = "";
                if (currentSatate < 0)
                    currentSatate *= -1;

            }
            this.txtResultado.Text += pressionar;

            double numero;

            if (double.TryParse(this.txtResultado.Text, out numero))
            {
                // O número que aparece na tela resultado, já vem formatado com ponto e virgula.
                this.txtResultado.Text = numero.ToString("N0");
                if (currentSatate == 1)
                {
                    primeiro_numero = numero;
                }
                else
                {
                    segundo_numero = numero;
                }
            }
        }

        //Após selecionar a operação ele armazena o valor no segundo número.
        private void selecionar_operacao(object sendre, EventArgs e)
        {
            currentSatate = -2;
            Button button = (Button)sendre;
            string pressionar = button.Text;
            Operação = pressionar;
        }

        private void Calcular(object sendre, EventArgs e)
        {
            if(currentSatate == 2)
            {
                double resultado = 0;
                
                if(Operação == "+")
                {
                    resultado = primeiro_numero + segundo_numero;
                }
                if (Operação == "-")
                {
                    resultado = primeiro_numero - segundo_numero;
                }
                if (Operação == "*")
                {
                    resultado = primeiro_numero * segundo_numero;
                }
                if (Operação == "/")
                {
                    resultado = primeiro_numero / segundo_numero;
                }

                
                this.txtResultado.Text = resultado.ToString("N0");
                primeiro_numero = resultado;
                currentSatate = -1;
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
