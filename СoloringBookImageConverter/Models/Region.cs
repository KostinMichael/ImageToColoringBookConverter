using System.Collections.Generic;
using System.Drawing;

namespace Model {
    class Region {
        public List<Point> EdgesPoints { get; set; } //массив крайних точек
        public List<Point> FontsCoord { get; set; } //массив возможных координат для шрифтов 

        public Region() {
            EdgesPoints = new List<Point>();
            FontsCoord = new List<Point>();
        }
    }
}
