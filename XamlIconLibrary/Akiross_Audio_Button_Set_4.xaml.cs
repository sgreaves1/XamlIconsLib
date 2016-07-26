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
    /// Interaction logic for Akiross_Audio_Button_Set_4.xaml
    /// </summary>
    public partial class Akiross_Audio_Button_Set_4 : UserControl
    {
        public Akiross_Audio_Button_Set_4()
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
            DependencyProperty.Register("Author", typeof(string), typeof(Akiross_Audio_Button_Set_4), new PropertyMetadata("Xamalot"));

        public string Source
        {
            get { return (string)GetValue(SourceProperty); }
            private set { SetValue(SourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Author.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source", typeof(string), typeof(Akiross_Audio_Button_Set_4), new PropertyMetadata("http://www.xamalot.com/"));

        public bool ShowCredits
        {
            get { return (bool)GetValue(ShowCreditsProperty); }
            set { SetValue(ShowCreditsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ShowCredits.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ShowCreditsProperty =
            DependencyProperty.Register("ShowCredits", typeof(bool), typeof(Akiross_Audio_Button_Set_4), new PropertyMetadata(false));
    }
}
