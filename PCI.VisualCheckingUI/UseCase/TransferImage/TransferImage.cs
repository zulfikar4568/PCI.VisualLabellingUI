using Camstar.WCF.ObjectStack;
using PCI.VisualCheckingUI.UseCase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCI.VisualCheckingUI.UseCase
{
    public class TransferImage
    {
        private Repository.Opcenter.ContainerTransaction _containerTxn;
        public TransferImage(Repository.Opcenter.ContainerTransaction containerTxn)
        {
            _containerTxn = containerTxn;
        }
        public ContainerStatusModel ContainerStatusData(string Container)
        {
            CurrentContainerStatus containerStatus = _containerTxn.GetContainerStatusDetails(Container);
            return new ContainerStatusModel
            {
                Product = containerStatus.Product.Name,
                Operation = containerStatus.Operation.Name,
                ProductionOrder = containerStatus.MfgOrder.Name,
                Qty = containerStatus.Qty.ToString(),
                Unit = containerStatus.UOM.ToString()
            };
        }
    }
}
