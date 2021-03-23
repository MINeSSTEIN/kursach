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
            LogMeIn();
        }

        /// <summary>
        /// Метод входа пользователя
        /// </summary>
        private void LogMeIn()
        {
            try
            {
                var usr = Classes.ObjectsVisibility.EntityVision.e.Users.FirstOrDefault(x => x.Telephone == tbLogin.Text && x.Password == pbPassword.Password); // Создает временный объект пользователя с введенными логином и паролем

                if (usr == null)
                {
                    MessageBox.Show("Такого пользователя нет"); // Если данные введены некорректно или не введены вовсе, выводит сообщение о том, что пользователя не существует
                }
                else
                {
                    switch (usr.Type) // Если такой пользователь есть, то он проверяет его роль
                    {
                        case (1): // Если это роль пользователя, то загружаются соответствующие страницы
                            Classes.ObjectsVisibility.btnsFrameVision.f.Navigate(new Buttons.Buttons_Guest());
                            Classes.ObjectsVisibility.FrameVision.f.Navigate(new Guest.Main());


                            // Следующие команды записывают данные о пользователе в соответствующие поля в статическом классе для дальнейшего использования
                            Classes.ObjectsVisibility.CurrentUserInfo.id = usr.id; 
                            Classes.ObjectsVisibility.CurrentUserInfo.type = usr.Type;
                            break;

                        default: // Если роли пользователя не найдено, то выводится сообщение о том, что ее не существует
                            MessageBox.Show("Такой роли пользователя не существует");
                            break;
                    }
                }
            }
            catch { }
        }
    }
}
