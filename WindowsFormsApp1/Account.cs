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
        public object[] userName { get; set; } = new object[4] {5000, string.Empty, 13, true};
        public object[] Pin { get; set; } = new object[4] {5013, string.Empty, 14, false};
        public object[] barcodPin { get; set; } = new object[4] { 5027, string.Empty, 1, false};
        public object[] Level { get; set; } = new object[4] { 5028, string.Empty, 1, false};
        public object[] protectInfo { get; set; } = new object[4] { 5029, string.Empty, 1, false};
    }
}
