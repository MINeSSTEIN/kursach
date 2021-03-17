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
        public static Button _btnMain;
        public static Button _btnLogin;
        public static Button _btnDishes;
        public ButtonsNoUser()
        {
            InitializeComponent();
            _btnMain = btnMain;
            _btnDishes = btnDishesView;
            _btnLogin = btnLogin;
            Classes.StaticClasses.ButtonsBehaviour.SetButtonsColorDefault();
            Classes.StaticClasses.ButtonsBehaviour.SetButtonsColorDefault(_btnMain);
        }

        private void btnDishesView_Click(object sender, RoutedEventArgs e)
        {
            Classes.ObjectsVisibility.FrameVision.f.Navigate(new NoUser.DishesBrowser());
            Classes.StaticClasses.ButtonsBehaviour.SetButtonsColorDefault(_btnDishes);

        }

        private void btnMain_Click(object sender, RoutedEventArgs e)
        {
            Classes.ObjectsVisibility.FrameVision.f.Navigate(new NoUser.Main());
            Classes.StaticClasses.ButtonsBehaviour.SetButtonsColorDefault(_btnMain);

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Classes.StaticClasses.ButtonsBehaviour.SetButtonsColorDefault(_btnLogin);
            Classes.ObjectsVisibility.FrameVision.f.Navigate(new NoUser.Login());
        }
    }
}
