using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Editor
{
    public class Game
    {
        private string name;
        private string description;

        public string Name
        {
            get { return name; }
        }

        public string Description
        {
            get { return description; }
        }

        public Game(string _name, string _description)
        {
            name = _name;
            description = _description;
        }

        public Game()
        {
            name = "";
            description = "";
        }
    }
}
