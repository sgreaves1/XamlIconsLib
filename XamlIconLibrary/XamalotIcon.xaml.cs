using System.Windows;
using System.Windows.Controls;

namespace XamlIconLibrary
{
    /// <summary>
    /// Interaction logic for XamalotIcon.xaml
    /// </summary>
    public partial class XamalotIcon
    {
        /// <summary>
        /// Dependency Property used to back the <see cref="Icon"/> Property
        /// </summary>
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon",
                typeof(XamalotIcons),
                typeof(XamalotIcon),
                new PropertyMetadata(XamalotIcons._Default, PropertyChangedCallback));

        /// <summary>
        /// Dependency Property used to back the <see cref="Author"/> Property
        /// </summary>
        public static readonly DependencyProperty AuthorProperty =
            DependencyProperty.Register("Author",
                typeof(string),
                typeof(XamalotIcon),
                new PropertyMetadata("Unknown"));

        /// <summary>
        /// Dependency Property used to back the <see cref="Source"/> Property
        /// </summary>
        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source",
                typeof(string),
                typeof(XamalotIcon),
                new PropertyMetadata("http://www.xamalot.com/"));

        /// <summary>
        /// Dependency Property used to back the <see cref="ShowCredits"/> Property
        /// </summary>
        public static readonly DependencyProperty ShowCreditsProperty =
            DependencyProperty.Register("ShowCredits",
                typeof(bool),
                typeof(XamalotIcon),
                new PropertyMetadata(false));

        /// <summary>
        /// Dependency Property used to back the <see cref="AkirossAudioButtonSet4Visible"/> Property
        /// </summary>
        public static readonly DependencyProperty AkirossAudioButtonSet4VisibleProperty =
            DependencyProperty.Register("AkirossAudioButtonSet4Visible", 
                typeof(bool), 
                typeof(XamalotIcon), 
                new PropertyMetadata(false));

        /// <summary>
        /// Dependency Property used to back the <see cref="TangoXOfficeCalenderVisible"/> Property
        /// </summary>
        public static readonly DependencyProperty TangoXOfficeCalenderVisibleProperty =
            DependencyProperty.Register("TangoXOfficeCalenderVisible",
                typeof(bool),
                typeof(XamalotIcon),
                new PropertyMetadata(false));

        /// <summary>
        /// Constructor
        /// </summary>
        public XamalotIcon()
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
            XamalotIcon uc = (XamalotIcon)dependencyObject;

            XamalotIconInformation info = XamalotIconsHelper.UpdateData(uc.Icon);

            uc.AkirossAudioButtonSet4Visible = info.AkirossAudioButtonSet4Visible;
            uc.TangoXOfficeCalenderVisible = info.TangoXOfficeCalenderVisible;

            uc.Author = info._author;
        }

        /// <summary>
        /// Select a predefined icon to use 
        /// </summary>
        public XamalotIcons Icon
        {
            get { return (XamalotIcons)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
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
        /// Property used to set where the icon came from
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

        /// <summary>
        /// Show the AkirossAudioButtonSet4 icon or not
        /// </summary>
        public bool AkirossAudioButtonSet4Visible
        {
            get { return (bool)GetValue(AkirossAudioButtonSet4VisibleProperty); }
            set { SetValue(AkirossAudioButtonSet4VisibleProperty, value); }
        }

        /// <summary>
        /// Show the TangoXOfficeCalender icon or not
        /// </summary>
        public bool TangoXOfficeCalenderVisible
        {
            get { return (bool)GetValue(TangoXOfficeCalenderVisibleProperty); }
            set { SetValue(TangoXOfficeCalenderVisibleProperty, value); }
        }
    }
}
