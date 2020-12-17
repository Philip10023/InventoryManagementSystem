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
                var query1 =
                  from lotNum in db.tblLotNums
                  join qty in db.tblLotqties on lotNum.ID equals qty.lotID
                  join part in db.tblPartNums on lotNum.ID equals part.ID into joinedTables
                  from dt in joinedTables.DefaultIfEmpty()
                  select new
                  {
                      lotNum.lotnum,
                      lotNum.tblPartNum.partdesc,
                      lotNum.lotComments,
                      qty.QTY_Added_Removed,
                      lotNum.lotuam,
                      qty.StatusOfitem,
                      qty.a_location,
                      lotNum.lotnote
                  };

                lotDataGrid.ItemsSource = query1.ToList();
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
                    where lotnumt.lotnum == input || lotnumt.tblPartNum.partnum == input
                    select lotnumt;


                lotDataGrid.ItemsSource = query2.ToList();
            }
        }
    }
}
