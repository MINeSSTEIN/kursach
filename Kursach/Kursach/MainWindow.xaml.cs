using System.Windows;

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
        }
    }
}
