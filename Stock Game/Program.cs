﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Stock_Game.core;
using Stock_Game.ui;

namespace Stock_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            StockGame game = new StockGame();
            game.Start();
        }
    }
}
