using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Assignment_5.Commands;
using Assignment_5.Views;

namespace Assignment_5.ViewModels
{
    public class StartViewModel : BaseViewModel
    {

        private readonly StartWindow _startWindow;
        public ICommand StartCommand { get; set; }

        public string Name { get; set; }
        public int Money { get; set; }

        public StartViewModel(StartWindow window)
        {
            _startWindow = window;
            StartCommand = new StartCommand(this);
        }

        public void StartGame()
        {
            MainWindow game = new MainWindow(Name, Money);
            game.Show();
            _startWindow.Close();
        }
    }
}
