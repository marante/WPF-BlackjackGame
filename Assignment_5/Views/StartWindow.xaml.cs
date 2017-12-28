using Assignment_5.ViewModels;
using System.Windows;

namespace Assignment_5.Views
{
    /// <summary>
    /// Interaction logic for StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
            this.DataContext = new StartViewModel(this);
        }
    }
}
