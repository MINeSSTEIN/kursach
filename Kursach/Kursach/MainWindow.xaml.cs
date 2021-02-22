using System.Windows;
using Kursach.Res.Classes.ObjectsVisibility;
using Kursach.Res;
  

namespace Kursach
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Res.Classes.ObjectsVisibility.FrameVision.f = fMain;
            Res.Classes.ObjectsVisibility.btnsFrameVision.f = fButtons;

            FrameVision.f.Navigate(new Res.Pages.NoUser.Main());
            btnsFrameVision.f.Navigate(new Res.Pages.Buttons.ButtonsNoUser());
        }
    }
}
