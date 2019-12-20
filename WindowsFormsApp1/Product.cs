using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Product: IEnumerable<Parameters>
    {
        public int Increment { get; set; } = 75;
        public Parameters ProductName { get; set; } = new Parameters {Name="ProductName", StartingAdress="0", Length = "15", ConvertToAsciiString = true };
        public Parameters LabelName { get; set; } = new Parameters {Name="LabelName", StartingAdress = "30", Length = "1", ConvertToAsciiString = true };
        public Parameters FowardCircuit { get; set; } = new Parameters {Name="FowradCircuit", StartingAdress = "31", Length = "1", ConvertToAsciiString = false };
        public Parameters FowardSpeed { get; set; } = new Parameters {Name= "FowardSpeed", StartingAdress = "32", Length = "1", ConvertToAsciiString = false };
        public Parameters BackCircuit { get; set; } = new Parameters {Name="BackCircuit", StartingAdress = "33", Length = "1", ConvertToAsciiString = false };
        public Parameters BackSpeed { get; set; } = new Parameters {Name="BackSpeed", StartingAdress = "34", Length = "1", ConvertToAsciiString = false };
        public Parameters FowardAcceleration { get; set; } = new Parameters {Name="FowardAcceleration", StartingAdress = "35", Length = "1", ConvertToAsciiString = false };
        public Parameters FowardDeceleration { get; set; } = new Parameters {Name="FowardDeceleration", StartingAdress = "36", Length = "1", ConvertToAsciiString = false };
        public Parameters BackAcceleration { get; set; } = new Parameters {Name="BackAcceleration", StartingAdress = "37", Length = "1", ConvertToAsciiString = false };
        public Parameters BackDeceleration { get; set; } = new Parameters {Name="BackDeceleration", StartingAdress = "38", Length = "1", ConvertToAsciiString = false };
        public Parameters TurArasiBekletme { get; set; } = new Parameters {Name="TurArasiBekletme", StartingAdress = "39", Length = "1", ConvertToAsciiString = false };
        public Parameters KabloBirakmaSuresi { get; set; } = new Parameters {Name="KabloBirakmaSuresi", StartingAdress = "40", Length = "1", ConvertToAsciiString = false };
        public Parameters CableDirection { get; set; } = new Parameters {Name="CableDirection", StartingAdress = "41", Length = "1", ConvertToAsciiString = false };
        public Parameters Cable1Color { get; set; } = new Parameters {Name="Cable1Color", StartingAdress = "42", Length = "1", ConvertToAsciiString = false };
        public Parameters Cable2Color { get; set; } = new Parameters {Name="Cable2Color", StartingAdress = "43", Length = "1", ConvertToAsciiString = false };
        public Parameters CableDiameter { get; set; } = new Parameters {Name="CableDiameter", StartingAdress = "44", Length = "1", ConvertToAsciiString = false };
        public Parameters CableSection { get; set; } = new Parameters {Name="CableSection", StartingAdress = "45", Length = "1", ConvertToAsciiString = false };
        public Parameters Quantity { get; set; } = new Parameters {Name="Quantity", StartingAdress = "0", Length = "1", ConvertToAsciiString = false };
        public Parameters BurulmaSonrasiBoy1 { get; set; } = new Parameters {Name="BurulmaSonrasiBoy1", StartingAdress = "71", Length = "1", ConvertToAsciiString = false };
        public Parameters BurulmaSonrasiBoy2 { get; set; } = new Parameters {Name="BurulmaSonrasiBoy2", StartingAdress = "72", Length = "1", ConvertToAsciiString = false };
        public Parameters SagAcikBoy { get; set; } = new Parameters {Name="SagAcikBoy", StartingAdress = "73", Length = "1", ConvertToAsciiString = false };
        public Parameters SolAcikBoy { get; set; } = new Parameters {Name="SolAcikBoy", StartingAdress = "74", Length = "1", ConvertToAsciiString = false };
        public Parameters PitchDimension { get; set; } = new Parameters {Name="PitchDimenson", StartingAdress = "75", Length = "1", ConvertToAsciiString = false };

        public IEnumerator<Parameters> GetEnumerator()
        {
          
            yield return ProductName;
            yield return LabelName;
            yield return FowardCircuit;
            yield return FowardSpeed;
            yield return BackCircuit;
            yield return BackSpeed;
            yield return FowardAcceleration;
            yield return FowardDeceleration;
            yield return BackAcceleration;
            yield return BackDeceleration;
            yield return TurArasiBekletme;
            yield return KabloBirakmaSuresi;
            yield return CableDirection;
            yield return Cable1Color;
            yield return Cable2Color;
            yield return CableDiameter;
            yield return CableSection;
            yield return Quantity;
            yield return BurulmaSonrasiBoy1;
            yield return BurulmaSonrasiBoy2;
            yield return SagAcikBoy;
            yield return SolAcikBoy;
            yield return PitchDimension;

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
