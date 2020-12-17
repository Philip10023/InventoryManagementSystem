using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Interaction logic for PartNumberDetails.xaml
    /// </summary>
    public partial class PartNumberDetails : Window
    {
        public PartNumberDetails()
        {
            InitializeComponent();
        }

        private void Part_Num_Details_Close_Btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win1 = new MainWindow();
            win1.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String partNum = partNumber.Text;
            String desc = description.Text;
            String nt = notes.Text;

            //var id = Guid.NewGuid();

            /*using (var db = new Model1())
            {
                db.tblPartNums.Add(new tblPartNum(id, partNum, desc, nt));
                db.SaveChanges();
            }
            */
        }
    }
}
