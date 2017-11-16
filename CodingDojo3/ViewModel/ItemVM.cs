using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo3.ViewModel
{
    public class ItemVM
    {
        public ItemVM(int id, string description, double name, string room, int posX, int posY, string valueType, string itemType, string mode, bool value)
        {
            Id = id;
            Description = description;
            Name = name;
            Room = room;
            PosX = posX;
            PosY = posY;
            ValueType = valueType;
            ItemType = itemType;
            Mode = mode;
            Value = value;
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public double Name { get; set; }
        
        public string Room { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public string ValueType { get; set; }
        public string ItemType { get; set; }
        public string Mode { get; set; }
        public bool Value { get; set; }
        


    }
}
