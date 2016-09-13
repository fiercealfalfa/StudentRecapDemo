using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecapDemo
{
    class Player
    {
        public string name;
        public Wallet wallet;
        public Inventory inventory;

        public Player(string name)
        {
           this.name = name;
           wallet = new Wallet();
            inventory = new Inventory();
        }
    }
}
