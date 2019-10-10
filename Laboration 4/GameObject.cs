﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    abstract class GameObject : GameAsset, IInteractable
    {
        protected GameObject(uint positionX, uint positionY, bool isPassable, bool isVisible, char mapRepresentation) 
            : base(positionX, positionY, isPassable, isVisible, mapRepresentation) { }

        public virtual void Interact(Player player) { }
    }
}
