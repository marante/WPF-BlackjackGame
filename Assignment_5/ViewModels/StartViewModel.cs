using Assignment_5.Commands;
using Assignment_5.Views;
using System.Windows.Input;

namespace Assignment_5.ViewModels
{
    public class StartViewModel : BaseViewModel
    {

        private readonly StartWindow _startWindow;

        public string Name { get; set; }

        public StartViewModel(StartWindow window)
        {
            _startWindow = window;
        }

        /// <summary>
        /// Implementation of Flexcommand. Checks if the Name property is null, in that case return false else true.
        /// </summary>
        public ICommand StartCommand => new FlexCommand(
            param =>
            {
                var game = new MainWindow(Name);
                game.Show();
                _startWindow.Close();
            },
            param =>
            {
                return !string.IsNullOrEmpty(Name);
            });
    }
}
