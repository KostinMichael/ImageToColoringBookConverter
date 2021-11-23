using System;

namespace Model
{
    public class Pixel : Object , IComparable
    {
        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }
        public int Size { get; set; }
        public int Region { get; set; }

        public Pixel(byte R, byte G, byte B)
        {
            this.R = R;
            this.G = G;
            this.B = B;
            Size = 0;
            Region = 0;
        }

        public Pixel(byte R, byte G, byte B, int Region)
        {
            this.R = R;
            this.G = G;
            this.B = B;
            Size = 0;
            this.Region = Region;
        }

        public Pixel()
        {
            Size = 0;
            Region = 0;
        }

        public override bool Equals(Object obj)
        {
            if (((Pixel)obj).R == this.R & ((Pixel)obj).G == this.G & ((Pixel)obj).B == this.B)
            {
                return true;
            }
            else return false;
        }

        public int CompareTo(object obj)
        {
            if (((Pixel)obj).R > this.R && ((Pixel)obj).G > this.G && ((Pixel)obj).B > this.B)
            {
                return 0;
            }
            else return 1;
        }
    }
}
