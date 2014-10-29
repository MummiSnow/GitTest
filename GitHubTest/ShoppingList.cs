using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTest
{
    class ShoppingList
    {
        public string CocaCola { get; private set; }
        public string Milk { get; set; }
        public string Bread { get; set; }

        public string Mert { get; set; }
        public ShoppingList(string cocaCola, string milk, string bread)
        {
            CocaCola = cocaCola;
            Milk = milk;
            Bread = bread;
        }
    }
}
