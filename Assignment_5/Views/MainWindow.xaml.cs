using Assignment_5.ViewModels;
using System.Windows;

namespace Assignment_5.Views
{
    /// <inheritdoc />
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <inheritdoc />
        /// <summary>
        ///     Default constructor with default values.
        /// </summary>
        public MainWindow()
            : this("Anonymous")
        {
        }
        /// <inheritdoc />
        /// <summary>
        ///     Constructor with 1 given value, and one default
        /// </summary>
        /// <param name="name"></param>
        public MainWindow(string name)
        {
            InitializeComponent();
            this.DataContext = new GameViewModel(name);
        }
    }
}
