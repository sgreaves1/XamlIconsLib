using System.Windows;
using System.Windows.Media;

namespace XamlIconLibrary
{
    /// <summary>
    /// Interaction logic for GameIcon.xaml
    /// </summary>
    public partial class GameIcon 
    {
        /// <summary>
        /// Dependency Property used to back the <see cref="Data"/> Property
        /// </summary>
        public static readonly DependencyProperty DataProperty =
            DependencyProperty.Register("Data",
                typeof(string),
                typeof(GameIcon),
                new PropertyMetadata(""));

        /// <summary>
        /// Dependency Property used to back the <see cref="Icon"/> Property
        /// </summary>
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon",
                typeof(GameIcons),
                typeof(GameIcon),
                new PropertyMetadata(GameIcons._Default, PropertyChangedCallback));

        /// <summary>
        /// Dependency Property used to back the <see cref="IconBorderColor"/> Property
        /// </summary>
        public static readonly DependencyProperty IconBorderColorProperty =
            DependencyProperty.Register("IconBorderColor",
                typeof(Brush),
                typeof(GameIcon),
                new PropertyMetadata(Brushes.Black));

        /// <summary>
        /// Dependency Property used to back the <see cref="IconBorderThickness"/> Property
        /// </summary>
        public static readonly DependencyProperty IconBorderThicknessProperty =
            DependencyProperty.Register("IconBorderThickness",
                typeof(int),
                typeof(GameIcon),
                new PropertyMetadata(0));

        /// <summary>
        /// Dependency Property used to back the <see cref="Author"/> Property
        /// </summary>
        public static readonly DependencyProperty AuthorProperty =
            DependencyProperty.Register("Author",
                typeof(string),
                typeof(GameIcon), 
                new PropertyMetadata(""));

        /// <summary>
        /// Dependency Property used to back the <see cref="Source"/> Property
        /// </summary>
        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source",
                typeof(string),
                typeof(GameIcon),
                new PropertyMetadata("http://game-icons.net/"));

        /// <summary>
        /// Dependency Property used to back the <see cref="ShowCredits"/> Property
        /// </summary>
        public static readonly DependencyProperty ShowCreditsProperty =
            DependencyProperty.Register("ShowCredits",
                typeof(bool),
                typeof(GameIcon),
                new PropertyMetadata(false));

        /// <summary>
        /// Constructor
        /// </summary>
        public GameIcon()
        {
            InitializeComponent();
        }

        /// <summary>
        /// What to do when the icon changes
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="dependencyPropertyChangedEventArgs"></param>
        private static void PropertyChangedCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {
            GameIcon uc = (GameIcon)dependencyObject;

            uc.Data = GameIconsHelper.UpdateData(uc.Icon);
        }

        /// <summary>
        /// Select a predefined icon to use 
        /// </summary>
        public GameIcons Icon
        {
            get { return (GameIcons)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        /// <summary>
        /// Can be used to overwrite with your own icon data
        /// </summary>
        public string Data
        {
            get { return (string)GetValue(DataProperty); }
            set { SetValue(DataProperty, value); }
        }

        /// <summary>
        /// Property used to set the icons border colour
        /// </summary>
        public Brush IconBorderColor
        {
            get { return (Brush)GetValue(IconBorderColorProperty); }
            set { SetValue(IconBorderColorProperty, value); }
        }

        /// <summary>
        /// Property used to set the icons border thickness
        /// </summary>
        public int IconBorderThickness
        {
            get { return (int)GetValue(IconBorderThicknessProperty); }
            set { SetValue(IconBorderThicknessProperty, value); }
        }

        /// <summary>
        /// Property used to set the icons author name
        /// </summary>
        public string Author
        {
            get { return (string)GetValue(AuthorProperty); }
            private set { SetValue(AuthorProperty, value); }
        }

        /// <summary>
        /// Property used to set the location the icon came from
        /// </summary>
        public string Source
        {
            get { return (string)GetValue(SourceProperty); }
            private set { SetValue(SourceProperty, value); }
        }

        /// <summary>
        /// If true shows author and source
        /// </summary>
        public bool ShowCredits
        {
            get { return (bool)GetValue(ShowCreditsProperty); }
            set { SetValue(ShowCreditsProperty, value); }
        }
    }
}
