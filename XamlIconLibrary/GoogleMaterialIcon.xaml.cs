﻿using System.Windows;
using System.Windows.Media;
namespace XamlIconLibrary
{
    /// <summary>
    /// Interaction logic for GoogleMaterialIcon.xaml
    /// </summary>
    public partial class GoogleMaterialIcon
    {
        /// <summary>
        /// Dependency Property used to back the <see cref="Data"/> Property
        /// </summary>
        public static readonly DependencyProperty DataProperty =
            DependencyProperty.Register("Data",
                typeof(string),
                typeof(GoogleMaterialIcon),
                new PropertyMetadata(""));

        /// <summary>
        /// Dependency Property used to back the <see cref="Icon"/> Property
        /// </summary>
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", 
                typeof(GoogleMaterialIcons), 
                typeof(GoogleMaterialIcon), 
                new PropertyMetadata(GoogleMaterialIcons._Default, PropertyChangedCallback));
        
        /// <summary>
        /// What to do when the icon changes
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="dependencyPropertyChangedEventArgs"></param>
        private static void PropertyChangedCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {
            GoogleMaterialIcon uc = (GoogleMaterialIcon)dependencyObject;

            uc.Data = GoogleMaterialIconsHelper.UpdateData(uc.Icon);
        }

        /// <summary>
        /// Dependency Property used to back the <see cref="IconBorderColor"/> Property
        /// </summary>
        public static readonly DependencyProperty IconBorderColorProperty =
            DependencyProperty.Register("IconBorderColor", 
                typeof(Brush), 
                typeof(GoogleMaterialIcon), 
                new PropertyMetadata(Brushes.Black));

        /// <summary>
        /// Dependency Property used to back the <see cref="IconBorderThickness"/> Property
        /// </summary>
        public static readonly DependencyProperty IconBorderThicknessProperty =
            DependencyProperty.Register("IconBorderThickness",
                typeof(int), 
                typeof(GoogleMaterialIcon), 
                new PropertyMetadata(0));

        /// <summary>
        /// Constructor
        /// </summary>
        public GoogleMaterialIcon()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Select a predefined icon to use 
        /// </summary>
        public GoogleMaterialIcons Icon
        {
            get { return (GoogleMaterialIcons)GetValue(IconProperty); }
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
