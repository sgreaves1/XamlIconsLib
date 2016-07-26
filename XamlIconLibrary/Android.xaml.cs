using System.Windows;
using System.Windows.Media;

namespace XamlIconLibrary
{
    /// <summary>
    /// Interaction logic for Android.xaml
    /// </summary>
    public partial class Android
    {
        /// <summary>
        /// Dependency Property that backs the <see cref="IconBorderColor"/> property
        /// </summary>
        public static readonly DependencyProperty IconBorderColorProperty =
            DependencyProperty.Register("IconBorderColor", 
                typeof(Brush), 
                typeof(Android), 
                new PropertyMetadata(null));

        /// <summary>
        /// Dependency Property that backs the <see cref="Source"/> property
        /// </summary>
        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source", 
                typeof(string), 
                typeof(Android), 
                new PropertyMetadata("https://design.google.com/icons/"));

        /// <summary>
        /// Dependency Property that backs the <see cref="ShowCredits"/> property
        /// </summary>
        public static readonly DependencyProperty ShowCreditsProperty =
            DependencyProperty.Register("ShowCredits",
                typeof(bool),
                typeof(Android),
                new PropertyMetadata(false));

        /// <summary>
        /// Dependency Property that backs the <see cref="IconBorderThickness"/> property
        /// </summary>
        public static readonly DependencyProperty IconBorderThicknessProperty =
            DependencyProperty.Register("IconBorderThickness",
                typeof(int),
                typeof(Android),
                new PropertyMetadata(0));

        /// <summary>
        /// Dependency Property that backs the <see cref="Author"/> property
        /// </summary>
        public static readonly DependencyProperty AuthorProperty =
            DependencyProperty.Register("Author", 
                typeof(string), 
                typeof(Android), 
                new PropertyMetadata("Google"));

        public Android()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The colour of the icons border
        /// </summary>
        public Brush IconBorderColor
        {
            get { return (Brush)GetValue(IconBorderColorProperty); }
            set { SetValue(IconBorderColorProperty, value); }
        }

        /// <summary>
        /// The thickness of the border
        /// </summary>
        public int IconBorderThickness
        {
            get { return (int)GetValue(IconBorderThicknessProperty); }
            set { SetValue(IconBorderThicknessProperty, value); }
        }

        /// <summary>
        /// The name of the author of this icon
        /// </summary>
        public string Author
        {
            get { return (string)GetValue(AuthorProperty); }
            private set { SetValue(AuthorProperty, value); }
        }
        
        /// <summary>
        /// The location this icon has come from
        /// </summary>
        public string Source
        {
            get { return (string)GetValue(SourceProperty); }
            private set { SetValue(SourceProperty, value); }
        }

        /// <summary>
        /// Represents if the author and source are to be displayed
        /// </summary>
        public bool ShowCredits
        {
            get { return (bool)GetValue(ShowCreditsProperty); }
            set { SetValue(ShowCreditsProperty, value); }
        }

        
    }
}
