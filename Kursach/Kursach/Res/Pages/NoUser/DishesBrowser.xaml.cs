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
            List<InterfaceObjects.DishView> lViews = new List<InterfaceObjects.DishView>(); //Делаем коллекцию с кастомным элементом управления


            for (int i = 0; i < nota.Items.Count - 1; i++) //ну в цикле все +/- понятно, но стоит все равно объяснить
            {
                lViews.Add(new InterfaceObjects.DishView()); //Добавляем новый элемент в коллекцию
                decimal t_price = Math.Round(Classes.ObjectsVisibility.EntityVision.e.Dishes.Find(i + 1).Price, 2); //Округляем циферки в цене
                lViews[i].lName.Content = Classes.ObjectsVisibility.EntityVision.e.Dishes.Find(i + 1).Name.ToString(); //Задаем имя...
                lViews[i].lPrice.Content = $"{t_price.ToString()} p."; //...цену...
                lViews[i].lWeight.Content = $"{Classes.ObjectsVisibility.EntityVision.e.Dishes.Find(i + 1).Weight.ToString()} г."; //...вес


            }
        }
    }
}
