using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class User
    {
        public Parameters Name { get; set; } = new Parameters() {Name="Name", StartingAdress = "0", Length = "13", ConvertToAsciiString = true };
        public Parameters BarcodPin { get; set; } = new Parameters() {Name="BarcodPin", StartingAdress = "13", Length = "14", ConvertToAsciiString = false };
        public Parameters Pin { get; set; } = new Parameters() {Name="Pin", StartingAdress = "27", Length = "1", ConvertToAsciiString = false };
        public Parameters Level { get; set; } = new Parameters() {Name="Level", StartingAdress = "28", Length = "1", ConvertToAsciiString = false };
        public Parameters ProtectInfo { get; set; } = new Parameters() {Name="ProtectInfo", StartingAdress = "29", Length = "1", ConvertToAsciiString = false };

    }
}
