using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
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
using Kursach.Res.InterfaceObjects;
using System.Data.Entity;

namespace Kursach.Res.Pages.Guest
{
    /// <summary>
    /// Логика взаимодействия для Orders.xaml
    /// </summary>
    public partial class Orders : Page
    {
        public static WrapPanel wpOrdersVisible;

        DataGrid dgOrders = new DataGrid();
        public Orders()
        {
            InitializeComponent();

            LoadOrdersToTable();

            LoadOrders();
        }

        private void LoadOrdersToTable()
        {
            try
            {
                EntityVision.e.v_orders_view.Load();
                dgOrders.ItemsSource = EntityVision.e.v_orders_view.Local.ToBindingList();
                wpOrdersVisible = wpOrders;
            }
            catch { }
        }

        
        
        private void LoadOrders()
        {
            for (int i = 0; i < dgOrders.Items.Count + 1; i++)
            {
                try
                {
                    OrderView ovTemp = new OrderView();
                    BitmapImage bm = new BitmapImage();
                    bm.BeginInit();
                    bm.UriSource = new Uri(System.IO.Directory.GetCurrentDirectory() + EntityVision.e.v_orders_view.Local[i].PicturePath);
                    bm.EndInit();
                    ovTemp.iImage.Source = bm;
                    ovTemp.lConditionIndicator.Content = "Не оплачен";
                    ovTemp.lName.Content = EntityVision.e.v_orders_view.Local[i].Name;
                    ovTemp.id = EntityVision.e.v_orders_view.Local[i].id;
                    wpOrders.Children.Add(ovTemp);
                }
                catch { }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            wpOrders.Children.Clear();
            LoadOrdersToTable();
            LoadOrders();
        }

        private void btnPayAll_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
