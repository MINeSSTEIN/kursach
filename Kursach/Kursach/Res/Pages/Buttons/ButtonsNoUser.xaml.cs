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
        /// <summary>
        /// Статические поля для взаимодействия с кнопками извне
        /// </summary>
        public static Button _btnMain;
        public static Button _btnLogin;
        public static Button _btnDishes;
        public static Button _btnReg;

        public ButtonsNoUser()
        {
            InitializeComponent();

            _btnMain = btnMain;
            _btnDishes = btnDishesView;
            _btnLogin = btnLogin;
            _btnReg = btnReg;

            Classes.StaticClasses.ButtonsBehaviour.SetButtonsColorDefault();
            Classes.StaticClasses.ButtonsBehaviour.SetButtonsColorDefault(_btnMain);
        }

        private void btnDishesView_Click(object sender, RoutedEventArgs e)
        {
            SelectPage(btnDishesView, new NoUser.DishesBrowser());
        }

        private void btnMain_Click(object sender, RoutedEventArgs e)
        {
            SelectPage(btnMain, new NoUser.Main());
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            SelectPage(btnLogin, new NoUser.Login());
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            SelectPage(btnReg, new NoUser.Registration());
        }

        /// <summary>
        /// Задает страницу, соответствующую нажатой кнопки, изменяя цвет этой кнопки
        /// </summary>
        /// <param name="active">Активная кнопка</param>
        /// <param name="newActive">Активная страница</param>
        private static void SelectPage(Button active, Page newActive)
        {
            Classes.ObjectsVisibility.FrameVision.f.Navigate(newActive);
            Classes.StaticClasses.ButtonsBehaviour.SetButtonsColorDefault(active);
        }
    }
}
