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
        String Operção;
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

        void selecionar_numero(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string pressionar = button.Text;

            if (this.txtResultado.Text == "0" || currentSatate < 0)
            {
                this.txtResultado.Text = "";
                if (currentSatate < 0)
                    currentSatate *= -1;

            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
