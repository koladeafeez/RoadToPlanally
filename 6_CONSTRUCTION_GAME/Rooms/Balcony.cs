using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_CONSTRUCTION_GAME.Rooms
{
    public class Balcony : IRoom
    {
        private string _name { get; set; }
        public Balcony()
        {
            this._name = "balcony";
        }
        public string GetName()
        {
            return this._name;
        }
    }
}
