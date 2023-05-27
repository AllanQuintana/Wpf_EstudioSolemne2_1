﻿using System;
using System.Collections.Generic;
using System.IO;
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

namespace Wpf_EstudioSolemne2_1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            this.txtNombre.Clear();
            this.txtTelefono.Clear();   
        }

        private void btnGrabar_Click(object sender, RoutedEventArgs e)
        {
            string strNombre = this.txtNombre.Text.Trim();
            string strTelefono = this.txtTelefono.Text.Trim();

            string contacto = strNombre.ToUpper() + "," + strTelefono;
            StreamWriter writer = new StreamWriter("MiAgenda.txt", true);
            writer.WriteLine(contacto);
            writer.Close();

            MessageBox.Show("Contacto agregado");
        }
    }
}
