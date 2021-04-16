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

namespace Kursach.Res.Pages.Buttons
{
    /// <summary>
    /// Логика взаимодействия для Buttons_Guest.xaml
    /// </summary>
    public partial class Buttons_Guest : Page
    {
        public static Label lNoty;
        public static Button _btnMain;
        public static Button _btnOrders;
        public static Button _btnDishes;
        public static Button _btnOld;
        public Buttons_Guest()
        {
            InitializeComponent();
            _btnMain = btnMain;
            _btnDishes = btnDishes;
            _btnOrders = btnOrders;
            _btnOld = btnMain;
            lNoty = lNotifier;

            Classes.StaticClasses.ButtonsBehaviour.SetButtonsColorDefault(_btnMain, _btnOld);
        }

        private void btnMain_Click(object sender, RoutedEventArgs e)
        {
            Classes.ObjectsVisibility.FrameVision.f.Navigate(new Guest.Main());

        }

        private void btnDishes_Click(object sender, RoutedEventArgs e)
        {
            Classes.ObjectsVisibility.FrameVision.f.Navigate(new NoUser.DishesBrowser());
        }

        private void btnOrders_Click(object sender, RoutedEventArgs e)
        {
            Classes.ObjectsVisibility.FrameVision.f.Navigate(Guest.OrdersPageHolder.p);
        }
    }
}
