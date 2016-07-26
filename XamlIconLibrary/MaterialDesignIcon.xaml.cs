using System.Windows;
using System.Windows.Media;
namespace XamlIconLibrary
{
    /// <summary>
    /// Interaction logic for MaterialDesginIcon.xaml
    /// </summary>
    public partial class MaterialDesignIcon
    {
        /// <summary>
        /// Dependency Property used to back the <see cref="Data"/> Property
        /// </summary>
        public static readonly DependencyProperty DataProperty =
            DependencyProperty.Register("Data",
                typeof(string),
                typeof(MaterialDesignIcon),
                new PropertyMetadata(""));

        /// <summary>
        /// Dependency Property used to back the <see cref="Icon"/> Property
        /// </summary>
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", 
                typeof(MaterialDesignIcons), 
                typeof(MaterialDesignIcon), 
                new PropertyMetadata(MaterialDesignIcons._Default, PropertyChangedCallback));
        
        /// <summary>
        /// What to do when the icon changes
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="dependencyPropertyChangedEventArgs"></param>
        private static void PropertyChangedCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {
            MaterialDesignIcon uc = (MaterialDesignIcon)dependencyObject;

            uc.Data = MaterialDesignIconsHelper.UpdateData(uc.Icon);
        }

        /// <summary>
        /// Dependency Property used to back the <see cref="IconBorderColor"/> Property
        /// </summary>
        public static readonly DependencyProperty IconBorderColorProperty =
            DependencyProperty.Register("IconBorderColor", 
                typeof(Brush), 
                typeof(MaterialDesignIcon), 
                new PropertyMetadata(Brushes.Black));

        /// <summary>
        /// Dependency Property used to back the <see cref="IconBorderThickness"/> Property
        /// </summary>
        public static readonly DependencyProperty IconBorderThicknessProperty =
            DependencyProperty.Register("IconBorderThickness",
                typeof(int), 
                typeof(MaterialDesignIcon), 
                new PropertyMetadata(0));

        /// <summary>
        /// Constructor
        /// </summary>
        public MaterialDesignIcon()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Select a predefined icon to use 
        /// </summary>
        public MaterialDesignIcons Icon
        {
            get { return (MaterialDesignIcons)GetValue(IconProperty); }
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
    }
}
