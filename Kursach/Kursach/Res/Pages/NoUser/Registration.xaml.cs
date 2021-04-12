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

namespace Kursach.Res.Pages.NoUser
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        private Dictionary<string, int[]> Dates = new Dictionary<string, int[]>();
        private Dictionary<string, int[]> DatesLoap = new Dictionary<string, int[]>();

        private List<string> Months = new List<string>
        {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"
        };

        public Registration()
        {
            InitializeComponent();
            FillMonths();
            FillMonthsLoap();
            FillcbY();
            FillcbM();
            FillcbD();
        }

        private void FillMonths()
        {
            Dates.Add("Январь", new int[] {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31});

            Dates.Add("Февраль", new int[] {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28});

            Dates.Add("Март", new int[] {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31});

            Dates.Add("Апрель", new int[] {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29, 30});

            Dates.Add("Май", new int[] {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31});

            Dates.Add("Июнь", new int[] {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29, 30});

            Dates.Add("Июль", new int[] {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31});

            Dates.Add("Август", new int[] {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31});

            Dates.Add("Сентябрь", new int[] {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29, 30});

            Dates.Add("Октябрь", new int[] {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31});

            Dates.Add("Ноябрь", new int[] {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29, 30});

            Dates.Add("Декабрь", new int[] {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31});
        }

        private void FillMonthsLoap()
        {
            DatesLoap.Add("Январь", new int[] {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31});

            DatesLoap.Add("Февраль", new int[] {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29});

            DatesLoap.Add("Март", new int[] {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31});

            DatesLoap.Add("Апрель", new int[] {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29, 30});

            DatesLoap.Add("Май", new int[] {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31});

            DatesLoap.Add("Июнь", new int[] {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29, 30});

            DatesLoap.Add("Июль", new int[] {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31});

            DatesLoap.Add("Август", new int[] {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31});

            DatesLoap.Add("Сентябрь", new int[] {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29, 30});

            DatesLoap.Add("Октябрь", new int[] {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31});

            DatesLoap.Add("Ноябрь", new int[] {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29, 30});

            DatesLoap.Add("Декабрь", new int[] {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31});
        }

        private void FillcbY()
        {
            for (int i = DateTime.Now.Year - 18; i > 1900; i--)
            {
                cbYear.Items.Add(i);
            }
            cbYear.SelectedIndex = 0;
        }

        private void FillcbM()
        {
            for (int i = 0; i < Months.Count; i++)
            {
                cbMonth.Items.Add(Months[i]);
            }
            cbMonth.SelectedIndex = 0;
        }

        private void FillcbD()
        {
            if ((int)cbYear.SelectedItem % 4 == 0)
            {
                cbDate.ItemsSource = DatesLoap[cbMonth.SelectedItem.ToString()];
            }
            else
            {
                cbDate.ItemsSource = Dates[cbMonth.SelectedItem.ToString()];
            }
            cbDate.SelectedIndex = 0;
        }

        private void cbMonth_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbMonth.SelectedItem != null)
            {
                FillcbD();
            }
        }

        private void cbYear_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbMonth.SelectedItem != null)
            {
                FillcbD();
            }
        }

        private void btnRegistration_Click(object sender, RoutedEventArgs e)
        {
            Registrate();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            FrameVision.f.Navigate(new Login());
        }

        private void Registrate()
        {
            if(pbPassword.Password != pbPasswordConfirm.Password)
            {
                MessageBox.Show("Пароли не совпадают.");
            }
            else if(EntityVision.e.Users.Count(x => x.Telephone == mtbTelephone.Text) > 0)
            {
                MessageBox.Show("Такой телефон уже зарегестрирован.");
            }
            if (mtbEmail.Text != mtbEmailConfirm.Text)
            {
                MessageBox.Show("Почты не совпадают.");
            }
            else
            {
                try
                {
                    Users usr = new Users()
                    {
                        Type = 1,
                        Telephone = mtbTelephone.Text,
                        BirthDate = PickBirthDate(),
                        RegDate = DateTime.Now,
                        Email = mtbEmail.Text,
                        Name = mtbName.Text,
                        Sorename = mtbSurename.Text,
                        Thirdname = mtbThirdname.Text,
                        Mailing = IsSubscribed.IsEnabled,
                        Password = pbPassword.Password
                    };
                    EntityVision.e.Users.Add(usr);
                    EntityVision.e.SaveChanges();
                    MessageBox.Show("Пользователь создан");
                    FrameVision.f.Navigate(new Login());
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.ToString());
                }
            }
        }

        private DateTime PickBirthDate()
        {
            DateTime date = new DateTime(Convert.ToInt32(cbYear.SelectedItem), cbMonth.SelectedIndex + 1, Convert.ToInt32(cbDate.SelectedItem));
            return date;
        }
    }
}
