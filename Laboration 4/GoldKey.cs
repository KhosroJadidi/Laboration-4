﻿namespace Laboration_4
{
    class GoldKey : Loot, IInteractable
    {
        public GoldKey(int positionX, int positionY)
        : this(positionX, positionY, false, false, 'F', Color.GOLD) { }//Game World symbol: 'g'

        public GoldKey(int positionX, int positionY, bool isPassable, bool isVisible, char mapRepresentation, Color color)
        : base(positionX, positionY, isPassable, isVisible, mapRepresentation, color) { }

        public string Interact(Player player) 
        {
            player.inventory.keys.Add(this);
            this.IsPassable = true;
            string message = $"A {this.AssetColor} key added to your inventory.";
            return message;
        }
    }
}
