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

namespace XamlIconLibrary
{
    /// <summary>
    /// Interaction logic for Accessibility.xaml
    /// </summary>
    public partial class AccessibilityIcon : UserControl
    {



        public Brush IconBorderColor
        {
            get { return (Brush)GetValue(IconBorderColorProperty); }
            set { SetValue(IconBorderColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconBorderColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconBorderColorProperty =
            DependencyProperty.Register("IconBorderColor", typeof(Brush), typeof(AccessibilityIcon), new PropertyMetadata(null));



        public int IconBorderThickness
        {
            get { return (int)GetValue(IconBorderThicknessProperty); }
            set { SetValue(IconBorderThicknessProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconBorderThickness.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconBorderThicknessProperty =
            DependencyProperty.Register("IconBorderThickness", typeof(int), typeof(AccessibilityIcon), new PropertyMetadata(0));

        public AccessibilityIcon()
        {
            InitializeComponent();
        }

        public string Author
        {
            get { return (string)GetValue(AuthorProperty); }
            private set { SetValue(AuthorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Author.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AuthorProperty =
            DependencyProperty.Register("Author", typeof(string), typeof(AccessibilityIcon), new PropertyMetadata("Google"));

        public string Source
        {
            get { return (string)GetValue(SourceProperty); }
            private set { SetValue(SourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Author.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source", typeof(string), typeof(AccessibilityIcon), new PropertyMetadata("https://design.google.com/icons/"));
    }
}
