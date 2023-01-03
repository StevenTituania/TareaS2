using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaS2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {


            string usuario = "estudiante2022";
            string clave = "uisrael2022";

            if (txtUsuario.Text == usuario && txtClave.Text == clave)
            {

                Navigation.PushAsync(new MainPage(usuario));

            }
            else
            {

                DisplayAlert("Alerta", "Usuario o Contraseña Incorrectos", "cerrar");
            }

        }
    }
}