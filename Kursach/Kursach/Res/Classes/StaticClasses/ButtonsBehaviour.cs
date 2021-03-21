using System.Windows.Controls;
using System.Windows.Media;

namespace Kursach.Res.Classes.StaticClasses
{
    public static class ButtonsBehaviour
    {
        public static void SetButtonsColorDefault(Button activeButton, Button oldButton)
        {
            oldButton.Background = new SolidColorBrush(Color.FromRgb(249, 207, 195));
            activeButton.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        }

        public static void SetButtonsColorDefault()
        {
            Pages.Buttons.ButtonsNoUser._btnMain.Background = new SolidColorBrush(Color.FromRgb(249, 207, 195));
            Pages.Buttons.ButtonsNoUser._btnLogin.Background = new SolidColorBrush(Color.FromRgb(249, 207, 195));
            Pages.Buttons.ButtonsNoUser._btnDishes.Background = new SolidColorBrush(Color.FromRgb(249, 207, 195));
            Pages.Buttons.ButtonsNoUser._btnReg.Background = new SolidColorBrush(Color.FromRgb(249, 207, 195));
        }
    }
}
