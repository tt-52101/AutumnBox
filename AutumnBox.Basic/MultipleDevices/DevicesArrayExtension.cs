﻿/*************************************************
** auth： zsh2401@163.com
** date:  2018/9/1 18:24:52 (UTC +8:00)
** desc： ...
*************************************************/
using AutumnBox.Basic.Device;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutumnBox.Basic.MultipleDevices
{
    public static class DevicesArrayExtension
    {
        public static bool DevicesEquals(this IEnumerable<IDevice> _this, IEnumerable<IDevice> other)
        {
            if (_this.Count() != other.Count()) return false;
            foreach (IDevice info in _this)
            {
                if (!other.Contains(info)) return false;
            }
            return true;
        }
    }
}