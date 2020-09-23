using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Player
    {
        private int _gold;
        private Item[] _inventory;
        

        public Player()
        {
            _inventory = new Item[3];
        }

        public bool Buy(int Item)
        {
            if (Item > 0 && Item < _inventory.Length)
            {
                return true;
            }
            return false;
        }

        public void Buy(Item item, int index)
        {
            _inventory[index] = item;
        }

        public Item[] GetInventory()
        {
            return _inventory;
        }

        public int getGold()
        {
            return _gold;
        }
    }
}
