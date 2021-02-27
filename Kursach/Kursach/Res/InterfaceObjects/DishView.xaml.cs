﻿using System;
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

namespace Kursach.Res.InterfaceObjects
{
    /// <summary>
    /// Логика взаимодействия для DishView.xaml
    /// </summary>
    public partial class DishView : UserControl
    {
        public string pic;
        public string aa;

        public DishView()
        {
            InitializeComponent();
            this.Margin = new Thickness(10);
            pic = @"/Res/Static/Pictures/Dishes/GrekoVostochniy.jpg";
        }
    }
}