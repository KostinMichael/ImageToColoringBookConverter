using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageQuantizer
{
    class Region
    {
        public List<Point> EdgesPoints { get; set; } //массив крайних точек
        public List<Point> FontsCoord { get; set; } //массив возможных координат для шрифтов 

        public Region()
        {
            EdgesPoints = new List<Point>();
            FontsCoord = new List<Point>();
        }
    }
}
