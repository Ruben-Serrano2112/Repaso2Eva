using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso2Eva
{
    class MainWindowVM : ObservableObject
    {
        private ObservableCollection<Componente> lista;

        public ObservableCollection<Componente> Lista
        {
            get { return lista; }
            set { SetProperty(ref lista, value); }
        }
        private Componente componenteSeleccionado;

        public Componente ComponenteSeleccionado
        {
            get { return componenteSeleccionado;}

            set { SetProperty(ref componenteSeleccionado, value); }
        }



        public RelayCommand Consultar { get; }


        public MainWindowVM()
        {

            Consultar = new RelayCommand();
            lista = Componente.GetSamples();
        }
    }
}
