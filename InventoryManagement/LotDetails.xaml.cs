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

namespace InventoryManagement
{
    /// <summary>
    /// Interaction logic for LotDetails.xaml
    /// </summary>
    public partial class LotDetails : Window
    {
        public LotDetails()
        {
            InitializeComponent();
        }

        private void Lot_Details_Close_Btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win1 = new MainWindow();
            win1.Show();
            this.Close();
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //left side
            String ptNum = partNumBox.Text;
            String uom = uomBox.Text;
            String desc = descriptionBox.Text;
            String ptCost = partCost.Text;
            String clientCom = clientComments.Text;
            String ltNum = lotNum.Text;
            String expDate = expirationDate.Text;
            String qtyInStock = quantityInStock.Text;
            String inven = inventory.Text;

            //right side
            int qtyAdded = int.Parse(quantityAdded.Text);
            String dt = dates.Text;
            String init = initials.Text;
            String loc = location.Text;
            String stat = status.Text;
            String rfc = reasonForChange.Text;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            using (var db = new Model1())
            {
               // Part Num Dropdown
                ComboBoxItem item = new ComboBoxItem();
                item = new ComboBoxItem { Content = "" };
                var query1 =
                    db.tblPartNums.Select(x => x.partnum);

                for (int i = 0; i < query1.ToList().Count; i++)
                {
                    partNumBox.Items.Add(query1.ToList()[i]);
                }

                // Part Desc Dropdown
                item = new ComboBoxItem { Content = "" };
                var query2 =
                    db.tblPartNums.Select(x => x.partdesc);

                for (int i = 0; i < query2.ToList().Count; i++)
                {
                    descriptionBox.Items.Add(query2.ToList()[i]);
                }

                // UOM Dropdown
                item = new ComboBoxItem { Content = "" };
                var query3 =
                    db.tblLotNums.Select(x => x.lotuam);

                for (int i = 0; i < query3.ToList().Count; i++)
                {
                    uomBox.Items.Add(query3.ToList()[i]);
                }
            }
        }
    }
}
