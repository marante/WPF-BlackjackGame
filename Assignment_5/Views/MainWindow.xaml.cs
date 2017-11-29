using System.Windows;
using Assignment_5.ViewModels;

namespace Assignment_5.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        ///     Default constructor with default values.
        /// </summary>
        public MainWindow()
            : this("Unknown", 100)
        {
        }
        /// <summary>
        ///     Constructor with 1 given value, and one default
        /// </summary>
        /// <param name="name"></param>
        public MainWindow(string name)
            : this(name, 100)
        {
        }

        /// <summary>
        ///     Constructor with name and starting money parameters.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="startingMoney"></param>
        public MainWindow(string name, int startingMoney)
        {
            InitializeComponent();

            this.DataContext = new GameViewModel(name, startingMoney);
        }
    }
}
