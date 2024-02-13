using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace EntregaFinalOficial
{
    public partial class MainWindow : Window 
    {

        Window NuevaVentana;
        List<Eleccion> eleccion = new List<Eleccion>();

        public MainWindow()
        {
            InitializeComponent();
            NuevaVentana = new Window1();

        }

        private void botonAñadirInicial (object sender, EventArgs e)
        {
            NuevaVentana.Show();
        }

        public void añadirEleccion(Eleccion eleccionAux)
        {
            //Con este método podemos transmitir la información de la segunda 
            //ventana a la primera, introduciendo las elecciones en la colección.
            eleccion.Add(eleccionAux);
            Label etiquetaNombreEleccion = new Label();
            etiquetaNombreEleccion.Content = eleccionAux.nombreEleccion;
            EleccionStackPanel.Children.Add(etiquetaNombreEleccion);
            

        }

        

        //public String getEleccion ()
        //{
        //    return 

        //}

        //Aqui vamos a poner los constructores para poder averiguar los datos introducidos 
    }

   
}
