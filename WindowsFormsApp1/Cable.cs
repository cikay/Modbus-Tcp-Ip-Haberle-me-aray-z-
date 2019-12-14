using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Cable
    {
        public object[] Name { get; set; } = new object[2] { 0, string.Empty };
        public object[] Section { get; set; } = new object[2] { 10, string.Empty };
        public object[] outerDiameter { get; set; } = new object[2] { 11, string.Empty };
        public object[] Direction { get; set; } = new object[2] { 12, string.Empty };
        public object[] color { get; set; } = new object[2] { 13, string.Empty };

    }
}
