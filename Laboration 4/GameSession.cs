﻿using System.Collections.Generic;

namespace Laboration_4
{
    public class GameSession
    {
        public int MaxMapRows { get; set; }
        public int MaxMapColumns { get; set; }
        public int Score { get; set; } = 1000;
        public char[,] CurrentGameWorld { get; set; }
        public List<GameAsset> CurrentGameAssets { get; set; }
        public bool GameOver { get; set; }
        public State NewGameState{ get; set; }
        public StateMachine StateMachine { get; set; }
        public GameSession() { }

        public Player GetPlayer()
        {
            foreach(var element in CurrentGameAssets)
            {
                if (element is Player)
                {
                    return element as Player;
                }
            }
            return null;
        }

    }
}