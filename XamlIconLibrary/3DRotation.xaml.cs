using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace XamlIconLibrary
{
    /// <summary>
    /// Interaction logic for _3D_Rotation.xaml
    /// </summary>
    public partial class _3DRotation
    {
        public Brush IconBorderColor
        {
            get { return (Brush)GetValue(IconBorderColorProperty); }
            set { SetValue(IconBorderColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconBorderColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconBorderColorProperty =
            DependencyProperty.Register("IconBorderColor", typeof(Brush), typeof(_3DRotation), new PropertyMetadata(null));



        public int IconBorderThickness
        {
            get { return (int)GetValue(IconBorderThicknessProperty); }
            set { SetValue(IconBorderThicknessProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconBorderThickness.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconBorderThicknessProperty =
            DependencyProperty.Register("IconBorderThickness", typeof(int), typeof(_3DRotation), new PropertyMetadata(0));
        
        public _3DRotation()
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
            DependencyProperty.Register("Author", typeof(string), typeof(_3DRotation), new PropertyMetadata("Google"));

        public string Source
        {
            get { return (string)GetValue(SourceProperty); }
            private set { SetValue(SourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Author.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source", typeof(string), typeof(_3DRotation), new PropertyMetadata("https://design.google.com/icons/"));



        public bool ShowCredits
        {
            get { return (bool)GetValue(ShowCreditsProperty); }
            set { SetValue(ShowCreditsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ShowCredits.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ShowCreditsProperty =
            DependencyProperty.Register("ShowCredits", typeof(bool), typeof(_3DRotation), new PropertyMetadata(false));


    }
}
