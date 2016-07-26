using System.Windows;
using System.Windows.Media;

namespace XamlIconLibrary
{
    /// <summary>
    /// Interaction logic for BiohazardIcon.xaml
    /// </summary>
    public partial class Biohazard
    {


        public Brush IconBorderColor
        {
            get { return (Brush)GetValue(IconBorderColorProperty); }
            set { SetValue(IconBorderColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconBorderColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconBorderColorProperty =
            DependencyProperty.Register("IconBorderColor", typeof(Brush), typeof(Biohazard), new PropertyMetadata(null));



        public int IconBorderThickness
        {
            get { return (int)GetValue(IconBorderThicknessProperty); }
            set { SetValue(IconBorderThicknessProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconBorderThickness.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconBorderThicknessProperty =
            DependencyProperty.Register("IconBorderThickness", typeof(int), typeof(Biohazard), new PropertyMetadata(0));



        public Biohazard()
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
            DependencyProperty.Register("Author", typeof(string), typeof(Biohazard), new PropertyMetadata("Yasmina Lembachar"));

        public string Source
        {
            get { return (string)GetValue(SourceProperty); }
            private set { SetValue(SourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Author.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source", typeof(string), typeof(Biohazard), new PropertyMetadata("https://materialdesignicons.com"));
    }
}
