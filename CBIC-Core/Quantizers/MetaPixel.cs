namespace CBIC.Quantizers {
    /// <summary>
    /// byte[3] RGB  {256,256,256}
    /// </summary>
    public class MetaPixel {
        public ColorHolder[] RGBbuf { get; set; }
        public byte[] RGB { get; set; }
        public int HeightPos { get; set; }
        public int WidthPos { get; set; }
        public MetaPixel(byte R, byte G, byte B, int heightPos, int widthPos) {
            RGB = new[] { R, G, B };
            HeightPos = heightPos;
            WidthPos = widthPos;
            RGBbuf = new ColorHolder[3];
        }
        public override string ToString() {
            return RGB[0] + "," + RGB[1] + "," + RGB[2] + "}  {" + RGBbuf[0] + "," + RGBbuf[1] + "," + RGBbuf[2];
        }
    }
}
