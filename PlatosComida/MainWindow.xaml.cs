
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;


namespace PlatosComida
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Plato> listaPlatos;
        ObservableCollection<Plato> listaPlatosComida;
        List<string> listaComboBox;
        string rutaImagenes = "C:\\Users\\alex_\\source\\repos\\PlatosComida\\PlatosComida\\images\\";
        public MainWindow()
        {
            InitializeComponent();

            listaPlatos = Plato.GetSamples(rutaImagenes);
            listaComboBox = new List<string> { "China", "Americana", "Mexicana" };

            listaPlatosComida = new ObservableCollection<Plato>(listaPlatos);

            PlatosComidaListBox.DataContext = listaPlatosComida;
            tipoComidaComboBox.DataContext = listaComboBox;

        }

        private void PlatosComidaListBox_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DatosPlatoStackPanel.DataContext = PlatosComidaListBox.SelectedItem;
        }
    }
}
