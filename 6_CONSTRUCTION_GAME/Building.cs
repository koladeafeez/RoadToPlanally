using _6_CONSTRUCTION_GAME.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_CONSTRUCTION_GAME
{
    public class Building
    {
        private List<IRoom> _rooms { get; set; }
        private string Description { get; set; }

        public Building()
        {
            this._rooms = new List<IRoom>();
        }
        public Building AddKitchen()
        {
            this._rooms.Add(new Kitchen());
            return this;
        }
        public Building AddBalcony()
        {
            this._rooms.Add(new Balcony());
            return this;
        }
        public Building AddBedroom(string name)
        {
            this._rooms.Add(new Bedroom(name));
            return this;
        }
        public Building Build()
        {
            this.Description = string.Join(", ", this._rooms.Select(t => t.GetName()));
            return this;
        }
        public string Describe()
        {
            return this.Description;
        }
    }
}
