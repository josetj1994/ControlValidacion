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

namespace ControlValidacion.componentes
{
    /// <summary>
    /// Lógica de interacción para ValidacionPersonalizada.xaml
    /// </summary>
    public partial class ValidacionPersonalizada : UserControl
    {
        public String tipo { get; set; }
        public ValidacionPersonalizada()
        {
            InitializeComponent();
        }

        private void introducePass_LostFocus(object sender, RoutedEventArgs e)
        {
            String content = introducePass.Text;
            switch (tipo)
            {
                case("DNI"):
                    if (content.Length == 9)
                    {
                     control.Content = "DNI Correcto";
                    }
                    else
                    {
                     control.Content = "No es un DNI";
                    }
                    break;
                case ("Telefono"):
                    if(content.Length ==9)
                    {
                     control.Content = "Telefono Correcto";
                    }
                    else
                    {
                        control.Content = "No es un numero telefono";
                    }
                    break;
                case ("CodigoPostal"):
                    if (content.Length == 5)
                    {
                        control.Content = "Codigo postal Correcto";
                    }
                    else
                    {
                        control.Content = "No es un Codigo Postal";
                    }
                    break;
                 default:
                        control.Content = "Introduce un valor correcto";
                    break;
            }
                    

                    
            }
        }
    }
