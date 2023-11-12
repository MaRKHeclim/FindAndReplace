﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndReplace.Core.DataStructures
{
    internal class CLSInstanceSettings
    {
        public bool vbnDebug;
        public bool vbnRunAsGUIApp;
        public bool vbnRunAsCLIApp;
        public bool vbnRunAsPortListener;

        public CLSInstanceSettings(bool p_vbnDebug = false, bool p_vbnRunAsGUIApp = true, bool p_vbnRunAsCLIApp = false, bool p_vbnRunAsPortListener = false)
        {
            this.vbnDebug = p_vbnDebug;
            this.vbnRunAsGUIApp = p_vbnRunAsGUIApp;
            this.vbnRunAsCLIApp = p_vbnRunAsCLIApp;
            this.vbnRunAsPortListener = p_vbnRunAsPortListener;
        }
    }
}
