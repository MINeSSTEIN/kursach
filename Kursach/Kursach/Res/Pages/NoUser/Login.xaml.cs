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

namespace Kursach.Res.Pages.NoUser
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var usr = Classes.ObjectsVisibility.EntityVision.e.Users.FirstOrDefault(x => x.Telephone == tbLogin.Text && x.Password == pbPassword.Password);

                if(usr == null)
                {
                    MessageBox.Show("Такого пользователя нет");
                }
                else
                {
                    switch (usr.Type)
                    {
                        case (1):
                            Classes.ObjectsVisibility.btnsFrameVision.f.Navigate(new Buttons.Buttons_Guest());
                            Classes.ObjectsVisibility.FrameVision.f.Navigate(new Guest.Main());

                            Classes.ObjectsVisibility.CurrentUserInfo.id = usr.id;
                            Classes.ObjectsVisibility.CurrentUserInfo.type = usr.Type;
                            break;
                        default:
                            MessageBox.Show("Такой роли пользователя не существует");
                            break;
                    }
                }
            }
            catch { }
        }
    }
}
