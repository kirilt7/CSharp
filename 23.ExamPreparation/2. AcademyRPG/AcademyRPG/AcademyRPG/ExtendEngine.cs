﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    class ExtendEngine:Engine
    {
        public override void ExecuteCreateObjectCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "knight":
                    {
                        string name = commandWords[2];
                        Point position = Point.Parse(commandWords[3]);
                        int owner = int.Parse(commandWords[4]);
                        this.AddObject(new Knight(name, position, owner));
                        break;
                    }
                case "house":
                    {
                        Point position = Point.Parse(commandWords[2]);
                        int owner = int.Parse(commandWords[3]);
                        this.AddObject(new House(position, owner));
                        break;
                    }
                default:
                    {
                        base.ExecuteCreateObjectCommand(commandWords);
                        break;
                    }
            }
        }
    }
}
