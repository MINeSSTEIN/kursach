using System.Windows;
using System.Windows.Controls;
using Kursach.Res;

namespace Kursach.Res.Pages.Buttons
{
    /// <summary>
    /// Логика взаимодействия для ButtonsNoUser.xaml
    /// </summary>
    public partial class ButtonsNoUser : Page
    {
        public ButtonsNoUser()
        {
            InitializeComponent();
        }

        private void btnDishesView_Click(object sender, RoutedEventArgs e)
        {
            Classes.ObjectsVisibility.FrameVision.f.Navigate(new NoUser.DishesBrowser());
        }

        private void btnMain_Click(object sender, RoutedEventArgs e)
        {
            Classes.ObjectsVisibility.FrameVision.f.Navigate(new NoUser.Main());
        }
    }
}
