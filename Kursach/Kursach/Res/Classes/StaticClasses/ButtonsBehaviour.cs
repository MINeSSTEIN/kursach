using System.Windows.Controls;
using System.Windows.Media;
using Kursach.Res.Pages.Buttons;

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
            switch (Classes.ObjectsVisibility.CurrentUserInfo.type)
            {
                case 1:
                    Buttons_Guest._btnMain.Background = new SolidColorBrush(Color.FromRgb(249, 207, 195));
                    Buttons_Guest._btnMain.Background = new SolidColorBrush(Color.FromRgb(249, 207, 195));

                    break;

                default:
                    ButtonsNoUser._btnMain.Background = new SolidColorBrush(Color.FromRgb(249, 207, 195));
                    ButtonsNoUser._btnLogin.Background = new SolidColorBrush(Color.FromRgb(249, 207, 195));
                    ButtonsNoUser._btnDishes.Background = new SolidColorBrush(Color.FromRgb(249, 207, 195));
                    ButtonsNoUser._btnReg.Background = new SolidColorBrush(Color.FromRgb(249, 207, 195));
                    break;
            }
        }
    }
}
