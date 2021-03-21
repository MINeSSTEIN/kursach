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

        private static Button oldButton;

        public ButtonsNoUser()
        {
            InitializeComponent();

            _btnMain = btnMain;
            _btnDishes = btnDishesView;
            _btnLogin = btnLogin;
            _btnReg = btnReg;

            oldButton = btnMain;

            Classes.StaticClasses.ButtonsBehaviour.SetButtonsColorDefault();
            Classes.StaticClasses.ButtonsBehaviour.SetButtonsColorDefault(_btnMain, btnDishesView);
        }

        private void btnDishesView_Click(object sender, RoutedEventArgs e)
        {
            SelectPage(btnDishesView, oldButton, new NoUser.DishesBrowser());
        }

        private void btnMain_Click(object sender, RoutedEventArgs e)
        {
            SelectPage(btnMain, oldButton, new NoUser.Main());
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            SelectPage(btnLogin, oldButton, new NoUser.Login());
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            SelectPage(btnReg, oldButton, new NoUser.Registration());
        }

        /// <summary>
        /// Задает страницу, соответствующую нажатой кнопки, изменяя цвет этой кнопки
        /// </summary>
        /// <param name="active">Активная кнопка</param>
        /// <param name="newActive">Активная страница</param>
        private static void SelectPage(Button active, Button old, Page newActive)
        {
            Classes.ObjectsVisibility.FrameVision.f.Navigate(newActive);
            Classes.StaticClasses.ButtonsBehaviour.SetButtonsColorDefault(active, old);
            oldButton = active;
        }
    }
}
