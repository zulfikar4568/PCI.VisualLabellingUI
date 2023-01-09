using PCI.VisualCheckingUI.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCI.VisualCheckingUI.Config
{
    public class FolderNetworkConnection
    {

        public static void Connect()
        {
            if (AppSettings.Folder != "" && AppSettings.UNCPathUsername != "" && AppSettings.UNCPathPassword != "")
            {
                NetUtil.Connect(AppSettings.UNCPath, AppSettings.UNCPathUsername, AppSettings.UNCPathPassword);
                if (!Directory.Exists(AppSettings.Folder)) Directory.CreateDirectory(AppSettings.Folder);
            }
        }
        public static void Disconnect()
        {
            if (AppSettings.Folder != "")
            {
                NetUtil.Disconnect(AppSettings.UNCPath);
            }
        }
    }
}
