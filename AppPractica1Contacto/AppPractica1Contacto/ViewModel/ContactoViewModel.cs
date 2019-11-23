using AppPractica1Contacto.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppPractica1Contacto.ViewModel
{
    class ContactoViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public ObservableCollection<Model.Contacto> Contacto { get; set; }


        public ICommand OperationsCommand { get; set; }


        public ContactoViewModel()
        {

            // OperationsCommand = new Command(MuestraContactos);

            ObservableCollection<Contacto> Contacto = VerContactos();
        }



        public ObservableCollection<Contacto> VerContactos()
        {
            return Contacto = new ObservableCollection<Contacto>
            {

                new Contacto{
                  Nombre="Roy",
                  Apellido="Casas",
                  Sexo="M",
                  Telefono="777777777"

                },
                new Contacto{
                  Nombre="Gely",
                  Apellido="Aparicio",
                  Sexo="F",
                  Telefono="555555"
                }

            };
        }

    }
}
