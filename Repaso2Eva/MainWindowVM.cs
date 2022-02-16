using Microsoft.Toolkit.Mvvm.ComponentModel;
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


        public void ListadoComponentes()
        {
            lista = Componente.GetSamples();
        }
    }
}
