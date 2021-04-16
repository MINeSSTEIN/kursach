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
using Kursach.Res.Classes.ObjectsVisibility;
using System.Data.Entity;

namespace Kursach.Res.InterfaceObjects
{
    /// <summary>
    /// Логика взаимодействия для OrderView.xaml
    /// </summary>
    public partial class OrderView : UserControl
    {
        public int id;
        public OrderView()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Task t = Task.Factory.StartNew(() =>
            {
                EntityVision.e.Orders.Remove(EntityVision.e.Orders.Find(id));
                EntityVision.e.SaveChanges();

                Pages.Guest.Orders.wpOrdersVisible.Children.Remove(this);
            });

        }

        private void btnPay_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
