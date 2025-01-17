﻿using EasyModbus;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Modbus
{
    class Tools
    {
        public static ModbusClient modbusClient = new ModbusClient() { IPAddress = "192.168.2.86", Port = 502 };

        public Tools()
        {

        }
        public IEnumerable<Control> GetAllChildControl(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAllChildControl(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

    }
}
