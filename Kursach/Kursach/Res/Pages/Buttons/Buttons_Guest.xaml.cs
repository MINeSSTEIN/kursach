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

namespace Kursach.Res.Pages.Buttons
{
    /// <summary>
    /// Логика взаимодействия для Buttons_Guest.xaml
    /// </summary>
    public partial class Buttons_Guest : Page
    {
        public static Button _btnMain;
        public static Button _btnOld;
        public Buttons_Guest()
        {
            InitializeComponent();
            _btnMain = btnMain;
            _btnOld = btnMain;

            Classes.StaticClasses.ButtonsBehaviour.SetButtonsColorDefault(_btnMain, _btnOld);
        }

        private void btnMain_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
