using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCI.VisualLabellingUI.Config
{
    internal static class MessageDefinition
    {
        public static string NoDeviceFound = ConfigurationManager.AppSettings["NoDeviceFound"] is null || ConfigurationManager.AppSettings["NoDeviceFound"] == "" ?  "Camera devices not found!" : ConfigurationManager.AppSettings["NoDeviceFound"];
        public static string Waiting = ConfigurationManager.AppSettings["Waiting"] is null || ConfigurationManager.AppSettings["Waiting"] == "" ? "Please wait..." : ConfigurationManager.AppSettings["Waiting"];
        public static string SendImageSuccess = ConfigurationManager.AppSettings["SendImageSuccess"] is null || ConfigurationManager.AppSettings["SendImageSuccess"] == "" ? "Image Captured Successfully!" : ConfigurationManager.AppSettings["SendImageSuccess"];
        public static string SendImageFailed = ConfigurationManager.AppSettings["SendImageFailed"] is null || ConfigurationManager.AppSettings["SendImageFailed"] == "" ? "Image Captured Fail!" : ConfigurationManager.AppSettings["SendImageFailed"];
        public static string CameraNotConnected = ConfigurationManager.AppSettings["CameraNotConnected"] is null || ConfigurationManager.AppSettings["CameraNotConnected"] == "" ? "Please Connect your device camera!" : ConfigurationManager.AppSettings["CameraNotConnected"];
        public static string MessageBeforeScan = ConfigurationManager.AppSettings["MessageBeforeScan"] is null || ConfigurationManager.AppSettings["MessageBeforeScan"] == "" ? "Please scan the Serial Number of Product!" : ConfigurationManager.AppSettings["MessageBeforeScan"];
        public static string MessageAfterScan = ConfigurationManager.AppSettings["MessageAfterScan"] is null || ConfigurationManager.AppSettings["MessageAfterScan"] == "" ? "Put the camera in correct position then please click capture button to catch the image!" : ConfigurationManager.AppSettings["MessageAfterScan"];
        public static string ProductNotFound = ConfigurationManager.AppSettings["ProductNotFound"] is null || ConfigurationManager.AppSettings["ProductNotFound"] == "" ? "Container / Product Serial Number doesn't exists!" : ConfigurationManager.AppSettings["ProductNotFound"];
        public static string ObjectNotDefined = ConfigurationManager.AppSettings["ObjectNotDefined"] is null || ConfigurationManager.AppSettings["ObjectNotDefined"] == "" ? "Not defined" : ConfigurationManager.AppSettings["ObjectNotDefined"];
        public static string OperationEnforcement = ConfigurationManager.AppSettings["OperationEnforcement"] is null || ConfigurationManager.AppSettings["OperationEnforcement"] == "" ? "Identifier / Product Unit incorrect position!" : ConfigurationManager.AppSettings["OperationEnforcement"];
    }
}
