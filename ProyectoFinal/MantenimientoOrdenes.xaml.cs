using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ProyectoFinal.Clases;
using System.Data.Linq;
using System.ComponentModel;
using ProyectoFinal.NorthwindDataSetTableAdapters;
using System.Data.SqlClient;
using System.Data;

namespace ProyectoFinal
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MantenimientoOrdenes : Window
    {
        private DataContext db;

        public MantenimientoOrdenes()
        {
            InitializeComponent();
            string conexion = @"Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            db = new DataContext(conexion);
             
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            NorthwindDataSet northwindDataSet = ((NorthwindDataSet)(this.FindResource("northwindDataSet")));
            // Cargar datos en la tabla Order_Details. Puede modificar este código según sea necesario.
            Order_DetailsTableAdapter northwindDataSetOrder_DetailsTableAdapter = new Order_DetailsTableAdapter();
            northwindDataSetOrder_DetailsTableAdapter.Fill(northwindDataSet.Order_Details);
            CollectionViewSource order_DetailsViewSource = ((CollectionViewSource)(this.FindResource("order_DetailsViewSource")));
            order_DetailsViewSource.View.MoveCurrentToFirst();
      
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            Order_Details detalles = new Order_Details();
            detalles.OrderID = Int16.Parse(OrderID.Text);
            detalles.ProductID = ProductID.Text;
            detalles.Quantity = Int16.Parse(Quantity.Text);
            detalles.UnitPrice = Int16.Parse(UnitPrice.Text);
            detalles.Discount =  Decimal.Parse(Discount.Text);

                db.GetTable<Order_Details>().InsertOnSubmit(detalles);
                db.SubmitChanges();
                MessageBox.Show("El Registro Ha sido Agregado", "Mensaje");

        }

        private void order_DetailsDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(((DataRowView)order_DetailsDataGrid.SelectedItem).Row["OrderID"].ToString());

        }
    }
}
