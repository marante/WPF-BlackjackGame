using GameCardLib;
namespace Assignment_5.ViewModels
{
    /// <inheritdoc />
    /// <summary>
    ///     Viewmodel for the actual game.
    /// </summary>
    public class GameViewModel : BaseViewModel
    {
        public Card Card { get; set; }
        public CardSuite CardSuite { get; set; }
        public Deck Deck { get; set; }
        public Hand Hand { get; set; }
        public Player Player { get; set; }

        public GameViewModel(string name)
        {
            Player = new Player(name);
        }
    }
}
