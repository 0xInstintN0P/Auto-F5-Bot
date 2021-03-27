using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;

namespace S4LeagueAutoF5
{
    class AutoIt
    {
        AutoItX3 a = new AutoItX3();


        public void Escape()
        {
            a.Run("xeroclient.exe" + "" + a.SW_MINIMIZE);
            a.WinWait("Xero Client");
            a.ControlSend("Xero Client", "", "", "{ESC}");
        }

        public void F5()
        {
            a.Run("xeroclient.exe" + "" + a.SW_MINIMIZE);
            a.WinWait("Xero Client");
            a.ControlSend("Xero Client", "", "", "{F5}");
        }

        public void AutoClick()
        {
            a.Run("xeroclient.exe" + "" + a.SW_MINIMIZE);
            a.WinWait("Xero Client");
            a.ControlClick("Xero Client", "", "", "LEFT", 1, 695, 376);
        }


    }
}
