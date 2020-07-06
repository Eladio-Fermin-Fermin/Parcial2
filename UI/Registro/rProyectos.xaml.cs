using Parcial2.Entidades;
using Parcial2.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Parcial2.UI.Registro
{
    /// <summary>
    /// Interaction logic for rR.xaml
    /// </summary>
    public partial class rR : Window
    {
        private Proyectos proyectos = new Proyectos();
        public rR()
        {
            InitializeComponent();
            this.DataContext = proyectos;
        }

        private void Cargar()
        {
            this.DataContext = null;
            this.DataContext = proyectos;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var encontrado = ProyectosBLL.Buscar(proyectos.ProyectoId);

            if (encontrado != null)
            {
                this.proyectos = encontrado;
                Cargar();
            }

            else
            {
                MessageBox.Show("El Proyecto no existe ", "No fue encontrado", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AgregarFilaButton_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidarAgregar())
                return;

            
        }
    }

        private void RemoverFilaButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
