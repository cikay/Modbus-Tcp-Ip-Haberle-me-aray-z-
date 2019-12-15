using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Cable
    {
        public Parameters Name { get; set; } = new Parameters() { StartingAdress = "0", Length = "10", ConvertToAsciiString = true };
        public Parameters Section { get; set; } = new Parameters() { StartingAdress = "10", Length = "1", ConvertToAsciiString = false };
        public Parameters outerDiameter { get; set; } = new Parameters() { StartingAdress = "11", Length = "1", ConvertToAsciiString = false };
        public Parameters Direction { get; set; } = new Parameters() { StartingAdress = "12", Length = "1", ConvertToAsciiString = false };
        public Parameters color { get; set; } = new Parameters() { StartingAdress = "13", Length = "1", ConvertToAsciiString = false };

    }
}
