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

namespace Calculadora_Sin_XAML
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            
            Grid grid = (Grid)this.Content;

            int contador = 1;

            for (int i = 1; i <= 3; i++)
            {
                
                for (int j = 0; j < 3; j++)
                {
                    Button boton = new Button();
                    TextBlock tb = new TextBlock();
                    Viewbox vb = new Viewbox(); 

                    tb.Text = contador.ToString();
                    vb.Child = tb;
                    boton.Content = vb;

                    boton.Tag = contador;
                    boton.Margin = new Thickness(5);
                    boton.Click += Button_Click;
                    boton.BorderThickness = new Thickness(1);
                    boton.BorderBrush = Brushes.Black;

                    grid.Children.Add(boton);
                    Grid.SetRow(boton, i);
                    Grid.SetColumn(boton, j);
                    contador++;
                }
            }
                       
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextoPrincipal.Text += ((Button)sender).Tag;
        }

    }
}
