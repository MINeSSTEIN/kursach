using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Data.Entity;
using System.Threading;

namespace Kursach.Res.Pages.NoUser
{
    /// <summary>
    /// Логика взаимодействия для DishesBrowser.xaml
    /// </summary>
    public partial class DishesBrowser : Page
    {
        DataGrid nota = new DataGrid(); //По приколу создаем "виртуальную" таблицу чтобы пихнуть туда блюда из базы
        List<InterfaceObjects.DishView> lViews = new List<InterfaceObjects.DishView>(); //Делаем коллекцию с кастомным элементом управления

        public DishesBrowser()
        {
            InitializeComponent();

            LoadDishesDataFromDB();

            ThreadLoadedData();

            LoadDishesToViews();

            WriteDishesCount();
        }

        private void WriteDishesCount()
        {
            var l = new Label();
            l.Content = $"Записей загружено: {lViews.Count}";
            wpDishes.Children.Add(l);
        }

        private void ThreadLoadedData()
        {
            Thread thread1 = new Thread(LoadDishesToViews);
            thread1.Start();
            Thread.Sleep(0);
        }

        private void LoadDishesDataFromDB()
        {
            Classes.ObjectsVisibility.EntityVision.e.v_Dishes_With_Types_View.Load();//Загружаем таблицу с блюдами из базы данных
            nota.ItemsSource = Classes.ObjectsVisibility.EntityVision.e.v_Dishes_With_Types_View.Local.ToBindingList(); //Таки пихаем данные из таблицы в таблицу (хвахывхаыва)
        }

        private void LoadDishesToViews()
        {

            for (int i = 0; i < nota.Items.Count - 1; i++) //ну в цикле все +/- понятно, но стоит все равно объяснить
            {
                try
                {
                    lViews.Add(new InterfaceObjects.DishView()); //Добавляем новый элемент в коллекцию
                    decimal t_price = Math.Round(Classes.ObjectsVisibility.EntityVision.e.v_Dishes_With_Types_View.Local[i].Price, 2); //Округляем циферки в цене
                    lViews[i].lName.Content = Classes.ObjectsVisibility.EntityVision.e.v_Dishes_With_Types_View.Local[i].Name.ToString(); //Задаем имя...
                    lViews[i].lPrice.Content = $"{t_price} p."; //...цену...
                    lViews[i].lWeight.Content = $"{Classes.ObjectsVisibility.EntityVision.e.v_Dishes_With_Types_View.Local[i].Weight} г."; //...вес...
                    lViews[i].lType.Content = Classes.ObjectsVisibility.EntityVision.e.v_Dishes_With_Types_View.Local[i].Type;
                    wpDishes.Children.Add(lViews[i]);
                }
                catch { }
            }
        }
    }
}
