using System;
using System.Collections;
using System.Collections.Generic;


namespace WindowsFormsApp1
{
    public class Cable: IEnumerable<Parameters>
    {
        public Parameters Name { get; set; } = new Parameters() { StartingAdress = "0", Length = "10", ConvertToAsciiString = true };
        public Parameters Section { get; set; } = new Parameters() { StartingAdress = "10", Length = "1", ConvertToAsciiString = false };
        public Parameters OuterDiameter { get; set; } = new Parameters() { StartingAdress = "11", Length = "1", ConvertToAsciiString = false };
        public Parameters Direction { get; set; } = new Parameters() { StartingAdress = "12", Length = "1", ConvertToAsciiString = false };
        public Parameters Color { get; set; } = new Parameters() { StartingAdress = "13", Length = "1", ConvertToAsciiString = false };
        public IEnumerator<Parameters> GetEnumerator()
        {

            yield return Name;
            yield return Section;
            yield return OuterDiameter;
            yield return Direction;
            yield return Color;

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
