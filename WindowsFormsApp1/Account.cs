using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Account: IEnumerable<Parameters>
    {
        public int Increment { get; set; } = 30;
        public Parameters UserName { get; set; } = new Parameters() { Name = "UserName", StartingAdress = "0", Length = "13", ConvertToAsciiString = true };
        public Parameters Pin { get; set; } = new Parameters() { Name = "Pin", StartingAdress = "13", Length = "14", ConvertToAsciiString = false };
        public Parameters BarcodPin { get; set; } = new Parameters() { Name = "BarcodPin", StartingAdress = "27", Length = "1", ConvertToAsciiString = false };
        public Parameters Level { get; set; } = new Parameters() { Name = "Level", StartingAdress = "28", Length = "1", ConvertToAsciiString = false };
        public Parameters ProtectInfo { get; set; } = new Parameters() { Name = "ProtectInfo", StartingAdress = "29", Length = "1", ConvertToAsciiString = false };
        
        public IEnumerator<Parameters> GetEnumerator()
        {

            yield return UserName;
            yield return Pin;
            yield return BarcodPin;
            yield return Level;
            yield return ProtectInfo;

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
