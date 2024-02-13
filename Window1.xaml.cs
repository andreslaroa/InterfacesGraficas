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
using System.Windows.Shapes;

namespace EntregaFinalOficial
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        MainWindow ventanaPrincipal = new MainWindow();
        private List<PartidoEscaño> partidos = new List<PartidoEscaño>();
        public Window1()
        {
            InitializeComponent();
            
        }

        private void ButtonAñadirEleccion(object sender, EventArgs e)
        {

            //foreach (Eleccion eleccion in elecciones)
            //{
            //    foreach (PartidoEscaño partido in eleccion.partido)
            //    {

            //    }
            //}

            //Vamos a realizar comprobaciones varias antes de transmitir la información
            /*Con este if vamos a comprobar que ninguna caja de texto esté vacia
             * y que además haya algún partido con sus escaños introducido*/
            if (!string.IsNullOrEmpty(NombreEleccion.Text) |
                !string.IsNullOrEmpty(Fecha.Text) |
                !string.IsNullOrEmpty(NumeroEscaños.Text) |
                !string.IsNullOrEmpty(MayoriaAbsoluta.Text) |
                partidos.Any()) 
            {



                Eleccion eleccionEnviar;
                eleccionEnviar = new Eleccion(NombreEleccion.Text, (String)Fecha.Text, NumeroEscaños.Text, MayoriaAbsoluta.Text, partidos);
                ventanaPrincipal.añadirEleccion(eleccionEnviar);
            }

            
            


        }

        private void ButtonAñadirPartidoEscaños(object sender, EventArgs eventArgs)
        {
            PartidoEscaño partidoNuevo;
            partidoNuevo = new PartidoEscaño(PartidoPolitico.Text, Escaños.Text);
            partidos.Add(partidoNuevo);
        }
    }
}
