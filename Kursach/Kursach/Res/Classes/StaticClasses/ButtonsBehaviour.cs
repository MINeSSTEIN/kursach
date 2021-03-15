using System.Windows.Controls;
using System.Windows.Media;

namespace Kursach.Res.Classes.StaticClasses
{
    public static class ButtonsBehaviour
    {
        public static void SetButtonsColorDefault(Button activeButton)
        {
            switch(ObjectsVisibility.CurrentUserInfo.type)
            {
                case("guest"):


                    break;
            }
            Pages.Buttons.ButtonsNoUser._btnMain.Background = new SolidColorBrush(Color.FromRgb(255, 0, 255));
            Pages.Buttons.ButtonsNoUser._btnLogin.Background = new SolidColorBrush(Color.FromRgb(255, 0, 255));
            Pages.Buttons.ButtonsNoUser._btnDishes.Background = new SolidColorBrush(Color.FromRgb(255, 0, 255));
            try
            {
                activeButton.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            }
            catch { }
        }

        public static void SetButtonsColorDefault()
        {
            Pages.Buttons.ButtonsNoUser._btnMain.Background = new SolidColorBrush(Color.FromRgb(255, 0, 255));
            Pages.Buttons.ButtonsNoUser._btnLogin.Background = new SolidColorBrush(Color.FromRgb(255, 0, 255));
            Pages.Buttons.ButtonsNoUser._btnDishes.Background = new SolidColorBrush(Color.FromRgb(255, 0, 255));
        }
    }
}
