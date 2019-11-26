using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
    {
    public partial class MainPage : ContentPage
        {
        public MainPage()
            {
            InitializeComponent();
            }

        async void Button_Clicked(object sender, EventArgs e)
            {
            await DisplayAlert("Alerta", "Datos obtenidos", "OK");
            nombre.Text = String.Empty;
            primerApellido.Text = String.Empty;
            segundoApellido.Text = String.Empty;
            fechaNacimiento.Date = DateTime.Today;
            correoElectronico.Text = String.Empty;
            telefonoContacto.Keyboard = Keyboard.Telephone;
            contrasena.Text = String.Empty;
            contrasenaReescritura.Text = String.Empty;

            }
        }
    }
