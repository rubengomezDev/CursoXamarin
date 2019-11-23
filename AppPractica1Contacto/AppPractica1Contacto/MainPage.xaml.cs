using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppPractica1Contacto
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //BindingContext = new ViewModel.ContactoViewModel();
         }

        private async void btnAddContacto_Clicked(object sender, EventArgs e)
        {
            await App.Instance.SavePerson(new Model.Contacto
            { Nombre = txtNombre.Text,
            Apellido = txtApellido.Text,
            Telefono = txtTelefono.Text
            });

            txtNombre.Text = txtApellido.Text = txtTelefono.Text = string.Empty;
            listView.ItemsSource = await App.Instance.GetPeopleAsync();
        }
    }
}
