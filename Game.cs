using System;
using System.Collections.Generic;
using System.Text;
namespace HelloWorld

    
{
    struct Item
    {
        public int cost;
        public string name;
    }
    class Game
    {
        private bool _gameOver = false;
        private Player _player;
        private Shop _shop;
        private Item _arrow;
        private Item _shield;
        private Item _gem;
        private Item[] _shopInventory;

        public void InitializeItems()
        {


            _arrow.name = "Arrow";
            _shield.name = "Shield";
            _gem.name = "Healing Gem";

            _arrow.cost = 20;
            _shield.cost = 20;
            _gem.cost = 20;
        }



        public void GetInput(out char input, string option1, string option2, string option3, string query)
        {
            Console.WriteLine(query);

            Console.WriteLine("[1] " + option1);
            Console.WriteLine("[2] " + option2);
            Console.WriteLine("[3] " + option3);
            Console.Write("> ");

            input = ' ';
            //loop until valid input is received
            while (input != '1' && input != '2' && input != '3' && input != '4')
            {
                input = Console.ReadKey().KeyChar;
                if (input != '1' && input != '2' && input != '3' && input != '4')
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
        
        public void OpenShopMenu(Player player)
        {
            Console.WriteLine(_arrow.name);
            Console.WriteLine(_shield.name);
            Console.WriteLine(_gem.name);

            char input;
            GetInput(out input, "Arrow", "Shield", "Health Gem", "OI! Pick whacta want, ehh!!");
            if (input == '1')
            {
                player.Buy(_arrow,0);
                Console.WriteLine("Now Select where to put the Item");
                Console.WriteLine("[1] ");
                Console.WriteLine("[2] ");
                Console.WriteLine("[3] ");
            }
            if (input == '2')
            {
                player.Buy(_shield, 0);
                Console.WriteLine("Now Select where to put the Item");
                Console.WriteLine("[1] ");
                Console.WriteLine("[2] ");
                Console.WriteLine("[3] ");
            }
                
            if (input == '3')
            {
                player.Buy(_gem,0);
                Console.WriteLine("Now Select where to put the Item");
                Console.WriteLine("[1] ");
                Console.WriteLine("[2] ");
                Console.WriteLine("[3] ");
            }

            _gameOver = true;
        }

        public Player CreateCharacter()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Player player = new Player();
            OpenShopMenu(player);
            return player;
        }

        //Run the game
        public void Run()
        {
            Start();

            while (_gameOver == false)
            {
                Update();
            }

            End();
        }

        //Performed once when the game begins
        public void Start()
        {
            
            InitializeItems();
        }

        //Repeated until the game ends
        public void Update()
        {
            CreateCharacter();
        }

        //Performed once when the game ends
        public void End()
        {
            
        }
    }
}
