using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace XamlIconLibrary
{
    /// <summary>
    /// Interaction logic for AccountCircle.xaml
    /// </summary>
    public partial class AccountCircle 
    {
        public Brush IconBorderColor
        {
            get { return (Brush)GetValue(IconBorderColorProperty); }
            set { SetValue(IconBorderColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconBorderColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconBorderColorProperty =
            DependencyProperty.Register("IconBorderColor", typeof(Brush), typeof(AccountCircle), new PropertyMetadata(null));



        public int IconBorderThickness
        {
            get { return (int)GetValue(IconBorderThicknessProperty); }
            set { SetValue(IconBorderThicknessProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconBorderThickness.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconBorderThicknessProperty =
            DependencyProperty.Register("IconBorderThickness", typeof(int), typeof(AccountCircle), new PropertyMetadata(0));

        public AccountCircle()
        {
            InitializeComponent();
        }
    }
}
