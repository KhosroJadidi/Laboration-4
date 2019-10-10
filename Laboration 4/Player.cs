﻿using System.Collections;
using System.Collections.Generic;

namespace Laboration_4
{
    public class Player : GameAsset
    {
        private int healthPoints;
        private Color swordType;
        
        public int HealthPoints
        {
            get => healthPoints;
            set => healthPoints = value;
        }
        public int DamageOutput { get; internal set; }

        //public Material SwordType
        //{
        //    get => swordType;
        //    set => swordType = SwordType;
        //}
        public Player(uint positionX, uint positionY)
             : this(positionX, positionY, false, true, 'P', Color.RED)
        {
            HealthPoints = 1000;
            Color = Color.BRONZE;
        }
        public Player(uint positionX, uint positionY, bool isPassable, bool isVisible, char mapRepresentation, Color color)
            : base(positionX, positionY, isPassable, isVisible, mapRepresentation, color) { }
    }
}
