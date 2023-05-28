using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pie_Pie_Snake_Game
{
    class Setting
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static string Directions;

        public Setting()
        {
            Width = 16; Height = 16;
            Directions = "left";
        
        }

    }
}
