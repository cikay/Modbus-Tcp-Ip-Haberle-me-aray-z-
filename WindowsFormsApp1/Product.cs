using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Product
    {
        public object[] ProductName { get; set; } = new object[2] { 0, string.Empty };
        public object[] Label { get; set; } = new object[2] { 15, string.Empty };
        public object[] FowardCircuit { get; set; } = new object[2] { 30, string.Empty };
        public object[] FowardSpeed { get; set; } = new object[2] { 31, string.Empty };
        public object[] BackCircuit { get; set; } = new object[2] { 32, string.Empty };
        public object[] BackSpeed { get; set; } = new object[2] { 33, string.Empty };
        public object[] FowardAcceleration { get; set; } = new object[2] { 34, string.Empty };
        public object[] FowardDeceleration { get; set; } = new object[2] { 35, string.Empty };
        public object[] BackAcceleration { get; set; } = new object[2] { 36, string.Empty };
        public object[] BackDeceleration { get; set; } = new object[2] { 37, string.Empty };
        public object[] TurArasiBekletme { get; set; } = new object[2] { 38, string.Empty };
        public object[] CabloBırakmaSuresi { get; set; } = new object[2] { 39, string.Empty };
        public object[] CableDirection { get; set; } = new object[2] { 40, string.Empty };
        public object[] Cable1Color { get; set; } = new object[2] { 41, string.Empty };
        public object[] Cable2Color { get; set; } = new object[2] { 42, string.Empty };
        public object[] CableDiameter { get; set; } = new object[2] { 43, string.Empty };
        public object[] CableSection { get; set; } = new object[2] { 44, string.Empty };
        public object[] Quantity { get; set; } = new object[2] { 45, string.Empty };
        public object[] BurulmasSonrasiBoy1 { get; set; } = new object[2] { 71, string.Empty };
        public object[] BurulmasSonrasiBoy2 { get; set; } = new object[2] { 72, string.Empty };
        public object[] SagAcikBoy { get; set; } = new object[2] { 73, string.Empty };
        public object[] SolAcikBoy { get; set; } = new object[2] { 74, string.Empty };
        public object[] PitchDimension { get; set; } = new object[2] { 75, string.Empty };
    
    }
}
