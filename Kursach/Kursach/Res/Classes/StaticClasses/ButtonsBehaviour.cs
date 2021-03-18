using System.Windows.Controls;
using System.Windows.Media;

namespace Kursach.Res.Classes.StaticClasses
{
    public static class ButtonsBehaviour
    {
        public static void SetButtonsColorDefault(Button activeButton)
        {
            switch (ObjectsVisibility.CurrentUserInfo.type)
            {
                case (1):
                    break;
                default:
                    Pages.Buttons.ButtonsNoUser._btnMain.Background = new SolidColorBrush(Color.FromRgb(255, 0, 255));
                    Pages.Buttons.ButtonsNoUser._btnLogin.Background = new SolidColorBrush(Color.FromRgb(255, 0, 255));
                    Pages.Buttons.ButtonsNoUser._btnDishes.Background = new SolidColorBrush(Color.FromRgb(255, 0, 255));
                    Pages.Buttons.ButtonsNoUser._btnReg.Background = new SolidColorBrush(Color.FromRgb(255, 0, 255));
                    activeButton.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                    break;
            }

        }

        public static void SetButtonsColorDefault()
        {
            Pages.Buttons.ButtonsNoUser._btnMain.Background = new SolidColorBrush(Color.FromRgb(255, 0, 255));
            Pages.Buttons.ButtonsNoUser._btnLogin.Background = new SolidColorBrush(Color.FromRgb(255, 0, 255));
            Pages.Buttons.ButtonsNoUser._btnDishes.Background = new SolidColorBrush(Color.FromRgb(255, 0, 255));
            Pages.Buttons.ButtonsNoUser._btnReg.Background = new SolidColorBrush(Color.FromRgb(255, 0, 255));
        }
    }
}
