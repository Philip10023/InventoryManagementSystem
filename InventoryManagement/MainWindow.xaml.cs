using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace InventoryManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Lot_Details_Btn_Click(object sender, RoutedEventArgs e)
        {
            LotDetails win2 = new LotDetails();
            win2.Show();
            this.Close();
        }

        private void Part_Num_Details_Btn_Click(object sender, RoutedEventArgs e)
        {
            PartNumberDetails win3 = new PartNumberDetails();
            win3.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            using (var db = new Model1())
            {
                /*var query1 =
                    from partnumt in db.tblPartNums
                    join lotnumt in db.tblLotNums
                    join db.lotqtyt on lotnumt.ID = tblLotqty.lotID
                    //on partnumt.CustomerID equals o.CustomerID into CustomersAndOrders      // place resuts in order
                    //from ord in CustomersAndOrders.DefaultIfEmpty()         // Customers who do not have orders will have null orders
                    select new                                              // Create a new anonymous object that customers and order info.
                    {
                        cust.CustomerID,                                // Using existing field
                        CustomerName = cust.CustomerName.Trim(),        // creating a new field
                        OrderNum = (ord == null) ? -1 : ord.OrderNum,   // if customer does not have an order
                        // ProductName = (ord == null) ? String.Empty : ord.ProductName.Trim()
                        ProductName = (ord == null) ? "Customer without order" : ord.ProductName.Trim()
                    };
                
                Console.WriteLine("All Lots in db");
                foreach (var item in query1)
                {
                    Console.WriteLine($"{item.CustomerID} {item.CustomerName.Trim()} {item.ProductName.Trim()}, {item.ProductName}");
                }
                Console.WriteLine();
                */
                
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*
             * Search specific lot
            */
            String input = mainInput.Text;
            using (var db = new Model1())
            {
                var query2 =
                    from lotnumt in db.tblLotNums
                    from partnumt in db.tblPartNums
                    where lotnumt.lotnum == input || partnumt.partnum == input
                    select lotnumt;


                lotDataGrid.ItemsSource = query2.ToList();
            }
        }
    }
}
