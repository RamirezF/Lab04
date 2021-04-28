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
using Business;
using Entity;
using Semana04.ViewModel;

namespace Semana04.View
{
    /// <summary>
    /// Lógica de interacción para ManCategoria.xaml
    /// </summary>
    public partial class ManCategoria : Window
    {
        ManCategoriaViewModel viewModel;
        public ManCategoria()
        {
            InitializeComponent();
            viewModel = new ManCategoriaViewModel();
            this.DataContext = viewModel;
        }

        private void bntGrabar_Click(object sender, RoutedEventArgs e)
        {
            BCategoria bcategoria = null;
            bcategoria = new BCategoria();
            bcategoria.Insertar(new Categoria { NombreCategoria = txtNombre.Text, Desripcion = txtDescripcion.Text });
            Close();
        }
    }
}
