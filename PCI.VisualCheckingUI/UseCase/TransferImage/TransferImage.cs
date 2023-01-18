using Camstar.WCF.ObjectStack;
using PCI.VisualCheckingUI.Config;
using PCI.VisualCheckingUI.UseCase.Model;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCI.VisualCheckingUI.UseCase
{
    public class TransferImage
    {
        private readonly Repository.Opcenter.ContainerTransaction _containerTxn;
        public TransferImage(Repository.Opcenter.ContainerTransaction containerTxn)
        {
            _containerTxn = containerTxn;
        }
        public ContainerStatusModel ContainerStatusData(string Container)
        {
            ViewContainerStatus containerStatus = _containerTxn.GetCurrentContainer(Container);
            if (containerStatus == null) return null;
            return new ContainerStatusModel
            {
                Product = containerStatus.Product is null ? "Not defined" : containerStatus.Product.ToString(),
                ProductDescription = containerStatus.ProductDescription is null ? "Not defined" : containerStatus.ProductDescription.ToString(),
                Operation = containerStatus.Operation is null ? "Not defined" : containerStatus.Operation.ToString(),
                Qty = containerStatus.Qty is null ? "Not defined" : containerStatus.Qty.ToString(),
                Unit = containerStatus.UOM is null ? "Not defined" : containerStatus.UOM.ToString()
            };
        }

        public bool MainLogic(PictureBox PictureBoxObj, string ContainerName, string DocumentName, string DocumentRevision, string DocumentDescription)
        {
            string nameCapture = DocumentName + ".png";
            if (Directory.Exists(AppSettings.Folder))
            {
                PictureBoxObj.Image.Save($"{AppSettings.Folder}\\{ nameCapture}", ImageFormat.Png);
            }
            else
            {
                Directory.CreateDirectory(AppSettings.Folder);
                PictureBoxObj.Image.Save($"{AppSettings.Folder}\\{nameCapture}", ImageFormat.Png);
            }

            return _containerTxn.AttachDocumentInContainer(ContainerName, AttachmentTypeEnum.NewDocumentReuse, DocumentName, DocumentRevision, $"{AppSettings.Folder}\\{nameCapture}", DocumentDescription);
        }
    }
}
