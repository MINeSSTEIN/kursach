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
            InterfaceObjects._Attempt_DishView vi = new InterfaceObjects._Attempt_DishView();
            vi.lName.Content = "Здесь будет имя";
            Res.Classes.ObjectsVisibility.EntityVision.e.Dishes.Load();
            DataGrid nota = new DataGrid();
            Classes.ObjectsVisibility.EntityVision.e.Dishes.Local.ToBindingList();
            nota.ItemsSource = Classes.ObjectsVisibility.EntityVision.e.Dishes.Local.ToBindingList();
            vi.lName.Content = nota.Name.FirstOrDefault();
            a.Navigate(vi);

        }
    }
}
