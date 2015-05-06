using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMove
{
    class Display
    {
        uint sizeOfDisplay;
        uint numberOfColors;

        public Display()
        {

        }

        public Display(uint size, uint numberOfColors)
        {
            this.sizeOfDisplay = size;
            this.numberOfColors = numberOfColors;
        }

        public uint Size
        {
            get
            {
                return this.sizeOfDisplay;
            }
        }

        public uint NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
        }

        public override string ToString()
        {
            return this.sizeOfDisplay + " " + this.numberOfColors;
        }
    } 
}
