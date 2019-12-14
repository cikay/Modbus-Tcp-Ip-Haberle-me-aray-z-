using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Account
    {
        public object[] userName { get; set; } = new object[2] {5000, string.Empty};
        public object[] Pin { get; set; } = new object[2] {5013, string.Empty};
        public object[] barcodPin { get; set; } = new object[2] { 5027, string.Empty };
        public object[] Level { get; set; } = new object[2] { 5028, string.Empty };
        public object[] protectInfo { get; set; } = new object[2] { 5029, string.Empty };
    }
}
