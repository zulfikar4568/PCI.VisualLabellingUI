using Camstar.WCF.ObjectStack;
using PCI.VisualCheckingUI.Util;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCI.VisualCheckingUI.Config
{
    public static class AppSettings
    {
        public static string AssemblyName { get; set; }
        #region TIME
        public static TimeSpan UTCOffset
        {
            get
            {
                string sUTCOffset = ConfigurationManager.AppSettings["UTCOffset"];
                string[] aUTCOffset = sUTCOffset.Split(':');
                return new TimeSpan(Int32.Parse(aUTCOffset[0]), Int32.Parse(aUTCOffset[1]), Int32.Parse(aUTCOffset[2]));
            }
        }
        public static ulong TimerPollingInterval
        {
            get
            {
                return Convert.ToUInt64(ConfigurationManager.AppSettings["TimerPollingInterval"]);
            }
        }
        #endregion

        #region CONFIG ACCOUNT ExCore
        private static string ExCoreHost
        {
            get
            {
                return ConfigurationManager.AppSettings["ExCoreHost"];
            }
        }
        private static string ExCorePort
        {
            get
            {
                return ConfigurationManager.AppSettings["ExCorePort"];
            }
        }
        private static string ExCoreUsername
        {
            get
            {
                return ConfigurationManager.AppSettings["ExCoreUsername"];
            }
        }
        private static string ExCorePassword
        {
            get
            {

                Simple3Des oSimple3Des = new Simple3Des(ConfigurationManager.AppSettings["ExCorePasswordKey"]);
                return oSimple3Des.DecryptData(ConfigurationManager.AppSettings["ExCorePassword"]);
            }
        }
        private static UserProfile _ExCoreUserProfile = null;
        public static UserProfile ExCoreUserProfile
        {
            get
            {
                if (_ExCoreUserProfile == null)
                {
                    _ExCoreUserProfile = new UserProfile(ExCoreUsername, ExCorePassword, UTCOffset);
                }
                if (_ExCoreUserProfile.Name != ExCoreUsername || _ExCoreUserProfile.Password.Value != ExCorePassword)
                {
                    _ExCoreUserProfile = new UserProfile(ExCoreUsername, ExCorePassword, UTCOffset);
                }
                return _ExCoreUserProfile;
            }
        }
        #endregion

        #region UNC PATH Folder
        public static string Folder
        {
            get
            {
                return ConfigurationManager.AppSettings["Folder"];
            }
        }
        public static string UNCPath
        {
            get
            {
                return ConfigurationManager.AppSettings["UNCPath"];
            }
        }
        internal static string UNCPathUsername
        {
            get
            {
                return ConfigurationManager.AppSettings["UNCPathUsername"];
            }
        }
        internal static string UNCPathPassword
        {
            get
            {
                if (ConfigurationManager.AppSettings["UNCPathPassword"] != "")
                {
                    Simple3Des oSimple3Des = new Simple3Des(ConfigurationManager.AppSettings["ExCorePasswordKey"]);
                    return oSimple3Des.DecryptData(ConfigurationManager.AppSettings["UNCPathPassword"]);
                }
                else
                {
                    return "";
                }
            }
        }
        #endregion

    }
}
