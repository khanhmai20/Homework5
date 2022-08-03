using System;
namespace OOP
{
    public class Color
    {
        private byte red;
        private byte green;
        private byte blue;
        private byte opaque;

        public Color(byte r, byte g, byte b, byte op)
        {
            red = r;
            green = g;
            blue = b;
            opaque = op; 
        }

        public byte getRed() { return red; }
        public void setRed(byte r) { red = r; }
        public byte getGreen() { return green; }
        public void setGreen(byte g) { green = g; }
        public byte getBlue() { return blue; }
        public void setBlue(byte b) { blue = b; }
        public byte getOp() { return opaque; }
        public void setOp(byte op) { opaque = op; } 

        public Double greyscale()
        {
            return  (getRed() + getGreen() + getBlue())/3.0; 
        }
    }
}

