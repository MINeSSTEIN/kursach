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
using System.Data.Entity;

namespace Kursach.Res.Pages.NoUser
{
    /// <summary>
    /// Логика взаимодействия для DishesBrowser.xaml
    /// </summary>
    public partial class DishesBrowser : Page
    {
        public DishesBrowser()
        {
            InitializeComponent();

            DataGrid nota = new DataGrid(); //По приколу создаем "виртуальную" таблицу чтобы пихнуть туда блюда из базы

            Classes.ObjectsVisibility.EntityVision.e.Dishes.Load();//Загружаем таблицу с блюдами из базы данных
            nota.ItemsSource = Classes.ObjectsVisibility.EntityVision.e.Dishes.Local.ToBindingList(); //Таки пихаем данные из таблицы в таблицу (хвахывхаыва)
            List<InterfaceObjects._Attempt_DishView> lViews = new List<InterfaceObjects._Attempt_DishView>();


            for (int i = 0; i < nota.Items.Count - 1; i++)
            {
                lViews.Add(new InterfaceObjects._Attempt_DishView());
                lViews[i].lName.Content = Classes.ObjectsVisibility.EntityVision.e.Dishes.Find(i + 1).Name.ToString();
                wpDishes.Children.Add(lViews[i]);
            }
        }
    }
}
