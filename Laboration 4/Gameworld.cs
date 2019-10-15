﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class GameWorld
    {
        private static char[,] getGameWorld;
        private static char[,] currentGameWorld;
        #region Getters and setters
        public static char[,] GetGameWorld 
        { 
            get => getGameWorld; 
            set => getGameWorld = value;
        }
        public static char[,] CurrentGameWorld 
        {
            get => currentGameWorld;
            set => currentGameWorld = value;
        }
        #endregion
        #region Map
        public static readonly char[,] initialGameWorld = new char[,]
        {   // 0   1   2   3   4   5   6   8   9  10  11  12  13  14  15  16  17  18  19  20  21  22  23  24  25  26  27  28  29  30  31  32  33  34  35  36  37  38  39  40  41  42  43  44  45  46  47  48  49  50  51  52  53  54  55  56  57  58  59  60  61  62  63  64  65  66  67  68  69  70  71  72  73  74  75  76  77  78  79  80  81  82  83  84  85  86  87  88  89  90  91  92  93  94  95  96  97  98
            { 'X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X'},// 0
            { 'X','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','X'},// 1
            { 'X','§',' ',' ',' ',' ',' ','D',' ',' ',' ',' ',' ',' ',' ',' ','M','b','s','M',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','M','b','s','M',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#','X'},// 2
            { 'X','#','#','#','#','#','#','#',' ',' ',' ',' ',' ',' ',' ',' ','#','#','#','#','#','#',' ','#','#','#','#','#','#','#','#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#','#','#','#','#','#','#','#','#',' ','#','#','#','#','#','#','#','#','#',' ','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','X'},// 3
            { 'X','#','s',' ',' ',' ',' ','#',' ',' ',' ',' ','M',' ',' ','b','#',' ',' ',' ','#','#',' ','#',' ',' ',' ',' ',' ',' ','#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#','k','l',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#',' ','#',' ',' ','M',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','M',' ',' ',' ','s',' ',' ',' ',' ',' ','M',' ',' ','#',' ',' ',' ',' ','S','B','#','#','X'},// 4
            { 'X','#',' ',' ',' ',' ',' ','#',' ',' ',' ','M','l','M',' ',' ','#','b','#',' ','#','#',' ','#',' ','#','#','#','#',' ','#',' ','#',' ',' ','M',' ',' ',' ','M',' ','#','#','#','#','#','#','#','#','#',' ','#',' ',' ',' ',' ',' ',' ',' ','#',' ','#',' ','#',' ','#','#','#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','M',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ','j','j',' ','#','D','#','#','X'},// 5
            { 'X','#',' ',' ',' ',' ',' ','#',' ',' ',' ',' ','M',' ',' ',' ','#','k','#',' ','#','#',' ','#',' ','#',' ',' ','#',' ','#',' ','#',' ','M','b','M',' ','M','s','M',' ',' ',' ',' ','s','s','s',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#',' ','#',' ','#',' ','#',' ','#',' ','#',' ',' ',' ',' ',' ',' ','M',' ',' ',' ',' ',' ',' ',' ',' ','M',' ',' ','#',' ','k','k',' ','#','M','#','#','X'},// 6
            { 'X','#',' ','#','#','#','#','#',' ',' ',' ',' ',' ',' ',' ',' ','#','#','#',' ','#','#',' ','#',' ','#',' ',' ','#',' ','#',' ','#',' ',' ','M',' ',' ',' ','M',' ','#','#','#','#','#','#','#','#','#','#','#',' ',' ',' ',' ',' ',' ',' ','#','s','#',' ','#',' ','#',' ','#',' ','#',' ',' ',' ',' ',' ',' ',' ','M',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ','#','M','#','#','X'},// 7
            { 'X','#',' ','#',' ',' ',' ','B',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ','#',' ',' ','#',' ','#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ','#','#',' ','#','#',' ','#','s','#',' ','#',' ','#',' ','#',' ','#','#','#','#','#','#','#','#','#','#','#','#','#','#',' ',' ',' ',' ',' ','#','#','#','#','#','#','M','#','#','X'},// 8
            { 'X','#',' ','#',' ','#','#','#','#','#','#',' ','#','#','#','#','#','#','#','#','#','#','#','#',' ','#',' ',' ','#',' ','#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#','#','#','#','#','#','#','#','#','#','#',' ','#','#',' ','#','#',' ','#','b','#','k','#',' ','#',' ','#',' ','M',' ',' ',' ',' ',' ',' ',' ',' ',' ','M','M',' ','#',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ','S','#','X'},// 9
            { 'X','#',' ','#',' ','#','k',' ',' ','s','#',' ','#',' ',' ',' ',' ','B',' ','B',' ',' ',' ',' ',' ','#',' ',' ','#',' ','#',' ','M',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','b','b','M',' ',' ','#','#','M','#','#',' ','#','b','#',' ','#',' ','#',' ','#',' ','#','#','#','#','M','#','#','#','#','#','#','#',' ','D',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ','#','#','X'},// 10
            { 'X','#','#','#',' ','#',' ',' ',' ',' ','#',' ','#',' ','#','#','#','#','M','#','#','#','#','#',' ','#','#','#','#',' ','#',' ','#','#',' ',' ',' ',' ',' ',' ',' ','#','#','#','#','#','#','#','#','#','#','#',' ','#','#','M','#','#',' ','#',' ','#','#','#',' ','#',' ','#',' ',' ',' ',' ','#',' ','#','s',' ',' ',' ','b','#',' ','#',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ','#','#','X'},// 11
            { 'X','#',' ',' ',' ','#',' ',' ',' ',' ','#','s','#',' ','#','b',' ','#',' ','#',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#','#',' ','#','#',' ','#',' ','M',' ',' ',' ','#',' ','#',' ',' ',' ',' ','#',' ','#',' ',' ',' ',' ',' ','#',' ','#',' ',' ',' ',' ','M','D',' ',' ',' ',' ',' ',' ','#','#','X'},// 12
            { 'X','#','l','#','#','#',' ',' ',' ',' ','#','#','#',' ','#',' ',' ','#','M','#',' ',' ',' ','#',' ','#','#','#','#','#','#','#','#','#','#','#',' ','#','#','#','#','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#','#','#','#',' ','#','#',' ','#',' ','#','#','#','#','#',' ','#',' ',' ',' ',' ','#',' ','#',' ',' ','M',' ',' ','#',' ','#',' ',' ','M',' ',' ','#',' ',' ',' ',' ',' ','j','#','#','X'},// 13
            { 'X','#','#','#','#','#',' ','k',' ',' ','M',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#','#','#',' ',' ',' ',' ',' ',' ','#',' ',' ','#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#',' ','#',' ','#',' ',' ',' ',' ',' ','#',' ',' ',' ',' ','#','M','#',' ',' ',' ','M',' ','#',' ','#',' ',' ',' ',' ',' ','#',' ','#','#','G','#','#','#','#','X'},// 14
            { 'X','#',' ','M',' ','M',' ',' ',' ',' ','#',' ','#','#','#',' ','S',' ',' ',' ',' ','G',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#','#',' ','#',' ','#',' ','#','#','#','#','#','#','#','#','#','#','#','#','#',' ',' ',' ',' ',' ','#',' ','#',' ','#',' ',' ',' ',' ',' ','#',' ',' ','#','#','#','M','#','#','#',' ',' ',' ','#',' ','#',' ',' ','M',' ',' ','#',' ','#',' ',' ',' ',' ',' ','#','X'},// 15
            { 'X','#','M','#','#','#',' ',' ',' ',' ','#',' ','M',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#',' ',' ',' ','j','k',' ',' ',' ','#',' ','#','M','#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#',' ','#',' ','#',' ',' ',' ',' ',' ','#',' ',' ','#',' ',' ',' ',' ',' ','#',' ',' ',' ','#','M','#',' ',' ',' ',' ',' ','#',' ','#',' ',' ',' ',' ',' ','#','X'},// 16
            { 'X','#',' ','#',' ','#',' ',' ',' ',' ','#',' ','M',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#',' ',' ',' ','l','l',' ',' ',' ','#',' ','#','b','#',' ','#','#','#','b',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ','l','l',' ','#',' ','#',' ','#',' ','l','l',' ',' ','#',' ',' ','#',' ',' ',' ',' ',' ','#',' ',' ',' ','#','M','#',' ',' ',' ',' ',' ','#',' ','#',' ',' ',' ',' ',' ','#','X'},// 17
            { 'X','#','M','#',' ','#',' ',' ',' ',' ','#',' ','#','#','#','#','#','#','#','#','#','#','#','#','#',' ',' ',' ',' ',' ',' ',' ',' ','#',' ','#','M','#',' ',' ','M','M','b',' ',' ','l','l',' ',' ',' ',' ','#',' ',' ','k','l',' ','#',' ','#',' ','#',' ','k','k',' ',' ','M',' ',' ','#',' ','l','l',' ',' ','#',' ',' ',' ','#',' ','#',' ',' ',' ',' ','s','#',' ','#',' ',' ','s',' ',' ','#','X'},// 18
            { 'X','#',' ',' ',' ','#',' ',' ',' ',' ','M',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','M',' ',' ',' ',' ',' ',' ',' ',' ','#',' ','#',' ','#',' ','#','#','#','s',' ',' ','l','k',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#',' ','#',' ','#',' ',' ',' ',' ',' ','#',' ',' ','#',' ','k','l',' ',' ','#',' ',' ',' ','#',' ','#','#','#','#','#','#','#',' ','#',' ',' ','b',' ',' ','#','X'},// 19
            { 'X','#',' ','#',' ','#','M',' ',' ',' ','#','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#',' ','#',' ','#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#',' ','#',' ','#',' ',' ',' ',' ',' ','#',' ',' ','#',' ','k','j',' ',' ','#',' ',' ',' ','#',' ',' ','M','M','M','g','M','M','M','#',' ',' ',' ',' ',' ','#','X'},// 20
            { 'X','#','G','#',' ','#','S','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#',' ','#',' ','#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#',' ','#',' ','#',' ',' ',' ',' ',' ','#',' ',' ','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#',' ',' ',' ',' ',' ','#','X'},// 21
            { 'X','#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#',' ','M',' ','#',' ',' ',' ',' ',' ','#',' ',' ','B',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#','X'},// 22
            { 'X','#','E','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','X'},// 23
            { 'X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X'} // 24
        };
        #endregion
    }
}



