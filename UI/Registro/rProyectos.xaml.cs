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
    public partial class rProyectos : Window
    {
        private Proyectos proyectos = new Proyectos();
        public rProyectos()
        {
            InitializeComponent();
            this.DataContext = proyectos;

            TipodeTareaComboBox.ItemsSource = TipoTareaBLL.GetTipoTarea();
            TipodeTareaComboBox.SelectedValuePath = "TareaId";
            TipodeTareaComboBox.DisplayMemberPath = "TipodeTarea";
        }


        private bool Validar()
        {
            bool Validado = true;
            if (ProyectoIdTextBox.Text.Length == 0)
            {
                Validado = false;
                MessageBox.Show("Fallida", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return Validado;
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
            var FilaDetalle = new ProyectoDetalle
            {
                TareaId = Convert.ToInt32(TipodeTareaComboBox.SelectedValue.ToString()),
                Requirimiento = (RequerimientoTextBox.Text.ToString()),
                Tiempo = Convert.ToDouble(TiempoTextBox.Text.ToString())
            };

           // this.proyectos.ProyectoDetalle.Add(FilaDetalle);
      
            Cargar();

            TipodeTareaComboBox.SelectedIndex = -1;
            RequerimientoTextBox.Clear();
            TiempoTextBox.Clear();
            

        }

        private void RemoverFilaButton_Click(object sender, RoutedEventArgs e)
        {
            if (DetallesDataGrid.SelectedIndex < 0)
                return;

            proyectos.ProyectoDetalle.RemoveAt(DetallesDataGrid.SelectedIndex);

            Cargar();

        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;

            if (ProyectosBLL.Guardar(proyectos))
            {
                Limpiar();
                MessageBox.Show("Se a Guardado.", "Exito.", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("ERROR Algo salio mal.", "Error.", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if (ProyectosBLL.Eliminar(int.Parse(ProyectoIdTextBox.Text)))
                {
                  Limpiar();
                  MessageBox.Show("Registro Eliminado", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            else
                MessageBox.Show("No se pudo eliminar el registro", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
          
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            this.proyectos = new Proyectos();
            this.DataContext = proyectos;
        }

    }
}
