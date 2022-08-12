using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_CONSTRUCTION_GAME.Rooms
{
    public class Bedroom : IRoom
    {
        private string _name { get; set; }
        public Bedroom(string name)
        {
            this._name = $"{name} room";
        }
        public string GetName()
        {
            return this._name;
        }
    }
}
