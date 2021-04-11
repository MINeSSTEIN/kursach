using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kursach.Res.InterfaceObjects
{
    /// <summary>
    /// Логика взаимодействия для DishView.xaml
    /// </summary>
    public partial class DishView : UserControl
    {
        public int id;
        public DishView()
        {
            InitializeComponent();
            this.Margin = new Thickness(10);
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            if (Classes.ObjectsVisibility.CurrentUserInfo.type == 1)
            {
                var order = new Orders();
                order.dish_id = id;
                order.user_id = Classes.ObjectsVisibility.CurrentUserInfo.id;
                order.Time = DateTime.Now;
                order.IsOrdered = false;
                order.IsCooking = false;
                order.IsCooked = false;
                order.IsDelivered = false;

                Classes.ObjectsVisibility.EntityVision.e.Orders.Add(order);
                Classes.ObjectsVisibility.EntityVision.e.SaveChanges();

                Notificate("Заказ добавлен");
            }
            else
            {
                MessageBox.Show("Только авторизованные пользователи могут заказывать блюда.", "Ошибка");
            }
        }

        private void Notificate(string Message)
        {
            //Timer t = new Timer(2000);
            lNoty.Content = Message;
/*            t.Enabled = true;
            while (t.Interval != 2)
            {
            }
            lNoty.Content = "";
            t.Enabled = false;*/
        }
    }
}
