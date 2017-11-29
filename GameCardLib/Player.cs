namespace GameCardLib
{
    public class Player
    {
        private bool _isFinished = false;

        public int ID { get; set; }
        public Hand Hand { get; set; }
        public bool IsFinished { get; set; }
        public bool IsThick { get; set; }
        public string Name { get; set; }
        public int? Money { get; set; }

        public Player(string name, int money)
        {
            Name = name;
            Money = money;
        }

    }
}
