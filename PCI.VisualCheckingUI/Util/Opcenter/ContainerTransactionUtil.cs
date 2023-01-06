using Camstar.WCF.ObjectStack;
using Camstar.WCF.Services;
using PCI.VisualCheckingUI.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PCI.VisualCheckingUI.Util.Opcenter
{
    public class ContainerTransactionUtil
    {
        private readonly HelperUtil _helperUtil;
        public ContainerTransactionUtil(HelperUtil helperUtil)
        {
            _helperUtil = helperUtil;
        }
        public bool ExecuteMoveIn(string ContainerName, string ResourceName, string DataCollectionName = "", string DataCollectionRev = "", DataPointDetails[] DataPoints = null, string CarrierName = "", string Comments = "", bool IgnoreException = true)
        {
            string TxnId = Guid.NewGuid().ToString();
            MoveInService oService = null;
            try
            {
                string sMessage = "";
                MoveIn oServiceObject = null;
                ResultStatus oResulstStatus = null;
                oService = new MoveInService(AppSettings.ExCoreUserProfile);
                EventLogUtil.LogEvent(Logging.LoggingContainer(ContainerName, TxnId, "Setting input data for MoveIn ..."), System.Diagnostics.EventLogEntryType.Information, 2);
                oServiceObject = new MoveIn() { Container = new ContainerRef(ContainerName) };
                if (ResourceName != "") oServiceObject.Resource = new NamedObjectRef(ResourceName);
                if (DataPoints != null)
                {
                    if (DataCollectionName != "")
                    {
                        oServiceObject.DataCollectionDef = new RevisionedObjectRef() { Name = DataCollectionName, Revision = DataCollectionRev, RevisionOfRecord = (DataCollectionRev == "") };
                        oServiceObject.ParametricData = _helperUtil.SetDataPointSummary(oServiceObject.DataCollectionDef, DataPoints);
                    }
                    else
                    {
                        DataPointSummary oDataPointSummaryRef = _helperUtil.GetDataPointSummaryRef(oService, oServiceObject, new MoveIn_Request(), new MoveIn_Info(), ref DataCollectionName, ref DataCollectionRev);
                        oServiceObject.ParametricData = _helperUtil.SetDataPointSummary(oDataPointSummaryRef, DataPoints);
                    }
                }
                if (CarrierName != "") //Attach = true
                {
                    oServiceObject.Carrier = new NamedObjectRef(CarrierName);
                }
                if (Comments != "") oServiceObject.Comments = Comments;

                // Execute Transaction
                EventLogUtil.LogEvent(Logging.LoggingContainer(ContainerName, TxnId, "Execution a Move In"), System.Diagnostics.EventLogEntryType.Information, 2);
                oResulstStatus = oService.ExecuteTransaction(oServiceObject);

                // Process Result
                bool statusMoveIn = _helperUtil.ProcessResult(oResulstStatus, ref sMessage, false);
                EventLogUtil.LogEvent(Logging.LoggingContainer(ContainerName, TxnId, sMessage), System.Diagnostics.EventLogEntryType.Information, 2);
                return statusMoveIn;
            }
            catch (Exception ex)
            {
                ex.Source = AppSettings.AssemblyName == ex.Source ? MethodBase.GetCurrentMethod().Name : MethodBase.GetCurrentMethod().Name + "." + ex.Source;
                string exceptionMsg = Logging.LoggingContainer(ContainerName, TxnId, ex.Message);
                EventLogUtil.LogErrorEvent(ex.Source, exceptionMsg);
                if (!IgnoreException) throw ex;
                return false;
            }
            finally
            {
                if (!(oService is null)) oService.Close();
            }
        }
        public bool ExecuteMoveStd(string ContainerName, string ToResourceName = "", string Resource = "", string DataCollectionName = "", string DataCollectionRev = "", DataPointDetails[] DataPoints = null, string CarrierName = "", string Comments = "", bool IgnoreException = true)
        {
            string TxnId = Guid.NewGuid().ToString();
            MoveStdService oService = null;
            try
            {
                string sMessage = "";
                MoveStd oServiceObject = null;
                ResultStatus oResultStatus = null;
                oService = new MoveStdService(AppSettings.ExCoreUserProfile);
                EventLogUtil.LogEvent(Logging.LoggingContainer(ContainerName, TxnId, "Setting input data for MoveStd ..."), System.Diagnostics.EventLogEntryType.Information, 2);
                oServiceObject = new MoveStd() { Container = new ContainerRef(ContainerName) };
                if (Resource != "")
                {
                    oServiceObject.Resource = new NamedObjectRef() { Name = Resource };
                }
                if (ToResourceName != "")
                {
                    oServiceObject.ToResource = new NamedObjectRef() { Name = ToResourceName };
                }
                if (DataPoints != null)
                {
                    if (DataCollectionName != "")
                    {
                        oServiceObject.DataCollectionDef = new RevisionedObjectRef() { Name = DataCollectionName, Revision = DataCollectionRev, RevisionOfRecord = (DataCollectionRev == "") };
                        oServiceObject.ParametricData = _helperUtil.SetDataPointSummary(oServiceObject.DataCollectionDef, DataPoints);
                    }
                    else
                    {
                        DataPointSummary oDataPointSummaryRef = _helperUtil.GetDataPointSummaryRef(oService, oServiceObject, new MoveStd_Request(), new MoveStd_Info(), ref DataCollectionName, ref DataCollectionRev);
                        oServiceObject.ParametricData = _helperUtil.SetDataPointSummary(oDataPointSummaryRef, DataPoints);
                    }
                }

                if (CarrierName != "") //Attach = true
                {
                    oServiceObject.Carrier = new NamedObjectRef(CarrierName);
                }
                if (Comments != "") oServiceObject.Comments = Comments;
                EventLogUtil.LogEvent(Logging.LoggingContainer(ContainerName, TxnId, "Execution MoveStd ...."), System.Diagnostics.EventLogEntryType.Information, 2);
                oResultStatus = oService.ExecuteTransaction(oServiceObject);
                bool statusMoveStd = _helperUtil.ProcessResult(oResultStatus, ref sMessage, false);
                EventLogUtil.LogEvent(Logging.LoggingContainer(ContainerName, TxnId, sMessage), System.Diagnostics.EventLogEntryType.Information, 2);
                return statusMoveStd;
            }
            catch (Exception ex)
            {
                ex.Source = AppSettings.AssemblyName == ex.Source ? MethodBase.GetCurrentMethod().Name : MethodBase.GetCurrentMethod().Name + "." + ex.Source;
                EventLogUtil.LogErrorEvent(Logging.LoggingContainer(ContainerName, TxnId, ex.Source), ex);
                if (!IgnoreException) throw ex;
                return false;
            }
            finally
            {
                if (!(oService is null)) oService.Close();
            }
        }
        public bool ContainerExists(string ContainerName, bool IgnoreException = true)
        {
            string TxnId = Guid.NewGuid().ToString();
            ViewContainerStatusService oService = null;
            try
            {
                oService = new ViewContainerStatusService(AppSettings.ExCoreUserProfile);

                //Set input Data
                ViewContainerStatus oServiceObject = new ViewContainerStatus();
                oServiceObject.Container = new ContainerRef(ContainerName);
                ViewContainerStatus_Request oServiceRequest = new ViewContainerStatus_Request();
                oServiceRequest.Info = new ViewContainerStatus_Info();
                oServiceRequest.Info.ContainerName = new Info(true);

                //Request the Data
                ViewContainerStatus_Result oServiceResult = null;
                ResultStatus oResultStatus = oService.ExecuteTransaction(oServiceObject, oServiceRequest, out oServiceResult);

                //Return the Result
                string sMessage = "";
                bool isExists = _helperUtil.ProcessResult(oResultStatus, ref sMessage, true);
                EventLogUtil.LogEvent(Logging.LoggingContainer(ContainerName, TxnId, sMessage), System.Diagnostics.EventLogEntryType.Information, 3);
                return isExists;
            }
            catch (Exception ex)
            {
                ex.Source = AppSettings.AssemblyName == ex.Source ? MethodBase.GetCurrentMethod().Name : MethodBase.GetCurrentMethod().Name + "." + ex.Source;
                string exceptionMsg = Logging.LoggingContainer(ContainerName, TxnId, ex.Message);
                EventLogUtil.LogErrorEvent(ex.Source, exceptionMsg);
                if (!IgnoreException) throw ex;
                return false;
            }
            finally
            {
                if (!(oService is null)) oService.Close();
            }
        }

        public bool SaveDocument(string Name, string Revision, string Identifier, bool UploadFile, string IsRevOfRcd = "", string Description = "", string Notes = "", bool IgnoreException = true)
        {
            DocumentMaintService oService = null;
            try
            {
                DocumentMaint oServiceObject = null;
                oService = new DocumentMaintService(AppSettings.ExCoreUserProfile);
                EventLogUtil.LogEvent($"Check Document {Name} : {Revision}...", System.Diagnostics.EventLogEntryType.Information, 3);
                bool bBaseExists = _helperUtil.ObjectExists(oService, new DocumentMaint(), Name, "");
                bool bObjectExists = _helperUtil.ObjectExists(oService, new DocumentMaint(), Name, Revision);
                EventLogUtil.LogEvent($"Prepare Document {Name} : {Revision}...", System.Diagnostics.EventLogEntryType.Information, 3);
                if (bObjectExists)
                {
                    oServiceObject.ObjectToChange = new RevisionedObjectRef(Name, Revision);
                    oService.BeginTransaction();
                    oService.Load(oServiceObject);
                }
                else if (bBaseExists)
                {
                    oService.BeginTransaction();
                    oServiceObject.BaseToChange = new RevisionedObjectRef();
                    oServiceObject.BaseToChange.Name = Name;
                    oService.NewRev(oServiceObject);
                }

                oServiceObject = new DocumentMaint();
                oServiceObject.ObjectChanges = new DocumentChanges();
                oServiceObject.ObjectChanges.Name = new Primitive<string> { Value = Name };
                oServiceObject.ObjectChanges.Revision = new Primitive<string> { Value = Revision };
                if (UploadFile)
                {
                    //if (!System.IO.File.Exists(Identifier)) throw new Exception($"{Identifier} does not exist");
                    oServiceObject.ObjectChanges.FileLocation = new Primitive<string> { Value = System.IO.Path.GetDirectoryName(Identifier) };
                    oServiceObject.ObjectChanges.FileName = new Primitive<string> { Value = System.IO.Path.GetFileName(Identifier) };
                    oServiceObject.ObjectChanges.Identifier = new Primitive<string> { Value = System.IO.Path.GetFileName(Identifier) };
                    oServiceObject.ObjectChanges.UploadFile = new Primitive<bool> { Value = true };
                }
                else
                {
                    oServiceObject.ObjectChanges.BrowseMode = BrowseModeEnum.Url;
                    oServiceObject.ObjectChanges.Identifier = new Primitive<string> { Value = Identifier };
                }
                if (IsRevOfRcd != "") oServiceObject.ObjectChanges.IsRevOfRcd = new Primitive<bool> { Value = Convert.ToBoolean(IsRevOfRcd) };
                if (Description != "") oServiceObject.ObjectChanges.Description = new Primitive<string> { Value = Description };
                if (Notes != "") oServiceObject.ObjectChanges.Notes = new Primitive<string> { Value = Notes };

                //Save the Data
                if (bObjectExists)
                {
                    EventLogUtil.LogEvent($"Updating Document {Name} : {Revision}...", System.Diagnostics.EventLogEntryType.Information, 3);
                    oService.ExecuteTransaction(oServiceObject);
                }
                else if (bBaseExists)
                {
                    EventLogUtil.LogEvent($"Creating Document {Name} : {Revision}...", System.Diagnostics.EventLogEntryType.Information, 3);
                    oService.ExecuteTransaction(oServiceObject);
                }
                else
                {
                    EventLogUtil.LogEvent($"Creating Document {Name} : {Revision}...", System.Diagnostics.EventLogEntryType.Information, 3);
                    oService.BeginTransaction();
                    oService.New(oServiceObject);
                    oService.ExecuteTransaction();
                }
                string sMessage = "";
                bool statusDocument = _helperUtil.ProcessResult(oService.CommitTransaction(), ref sMessage, false);
                EventLogUtil.LogEvent(sMessage, System.Diagnostics.EventLogEntryType.Information, 2);
                return statusDocument;
            }
            catch (Exception ex)
            {
                ex.Source = AppSettings.AssemblyName == ex.Source ? MethodBase.GetCurrentMethod().Name : MethodBase.GetCurrentMethod().Name + "." + ex.Source;
                EventLogUtil.LogErrorEvent(ex.Source, ex);
                if (!IgnoreException) throw ex;
                return false;
            }
            finally
            {
                if (oService != null) oService.Close();
            }
        }
        public bool AttachDocumentInContainer(string ContainerName, Enumeration<AttachmentTypeEnum, int> AttachmentType, string DocumentName, string DocumentRevision = "", string Identifier = "", string DocumentDescription = "", string Comments = "", bool IgnoreException = true)
        {
            string TxnId = Guid.NewGuid().ToString();
            AttachDocumentService oService = null;
            try
            {
                string sMessage = "";
                AttachDocument oServiceObject = null;
                ResultStatus oResultStatus = null;
                oService = new AttachDocumentService(AppSettings.ExCoreUserProfile);
                EventLogUtil.LogEvent(Logging.LoggingContainer(ContainerName, TxnId, "Setting input data for AttachDocument ..."), System.Diagnostics.EventLogEntryType.Information, 2);

                // Setting InputObject
                oServiceObject = new AttachDocument() { ContainerInstance = new ContainerRef(ContainerName) };
                oServiceObject.DocumentName = new Primitive<string> { Value = DocumentName };
                if (DocumentDescription != "") oServiceObject.DocumentDescription = new Primitive<string> { Value = DocumentDescription };

                // Common Object
                oServiceObject.InstanceName = new Primitive<string> { Value = ContainerName };
                oServiceObject.AttachmentType = AttachmentType;
                oServiceObject.IsContainer = true; // Set Document for Container

                //Validation
                if (Identifier == "" && (AttachmentType == AttachmentTypeEnum.NewDocumentReuse || AttachmentType == AttachmentTypeEnum.NewDocumentNOReuse))
                {
                    throw new Exception(Logging.LoggingContainer(ContainerName, TxnId, "Identifier cannot null if you set attachment to NewDocumentReuse or NewDocumentNoReuse"));
                }
                if (DocumentRevision == "" && AttachmentType == AttachmentTypeEnum.NewDocumentReuse)
                {
                    throw new Exception(Logging.LoggingContainer(ContainerName, TxnId, "DocumentRevision must be set or cannot empty if attachment type NewDocumentReuse"));
                }


                // Setting Object Again
                if (AttachmentType == AttachmentTypeEnum.NewDocumentReuse)
                {
                    oServiceObject.DocumentRevision = new Primitive<string> { Value = DocumentRevision };
                }
                else if (AttachmentType == AttachmentTypeEnum.ExistingDocument)
                {
                    oServiceObject.AttachedDocument = new RevisionedObjectRef(DocumentName, DocumentRevision);
                }

                // For NewDocumentReuse or NewDocumentNoReuse
                if (AttachmentType == AttachmentTypeEnum.NewDocumentReuse || AttachmentType == AttachmentTypeEnum.NewDocumentNOReuse)
                {
                    oServiceObject.Identifier = new Primitive<string> { Value = System.IO.Path.GetFileName(Identifier) };
                    oServiceObject.FilePath = new Primitive<string> { Value = System.IO.Path.GetDirectoryName(Identifier) };
                    oServiceObject.AttachedFileName = new Primitive<string> { Value = System.IO.Path.GetFileName(Identifier) };
                    oServiceObject.AttachedFileExtension = new Primitive<string> { Value = System.IO.Path.GetExtension(Identifier) };
                }

                if (Comments != "") oServiceObject.Comments = new Primitive<string> { Value = Comments };

                // Execute Transaction
                EventLogUtil.LogEvent(Logging.LoggingContainer(ContainerName, TxnId, "Execution a AttachDocument"), System.Diagnostics.EventLogEntryType.Information, 2);
                oResultStatus = oService.ExecuteTransaction(oServiceObject);

                // Process Result
                bool statusMoveIn = _helperUtil.ProcessResult(oResultStatus, ref sMessage, false);
                EventLogUtil.LogEvent(Logging.LoggingContainer(ContainerName, TxnId, sMessage), System.Diagnostics.EventLogEntryType.Information, 2);
                return statusMoveIn;
            }
            catch (Exception ex)
            {
                ex.Source = AppSettings.AssemblyName == ex.Source ? MethodBase.GetCurrentMethod().Name : MethodBase.GetCurrentMethod().Name + "." + ex.Source;
                string exceptionMsg = Logging.LoggingContainer(ContainerName, TxnId, ex.Message);
                EventLogUtil.LogErrorEvent(ex.Source, exceptionMsg);
                if (!IgnoreException) throw ex;
                return false;
            }
            finally
            {
                if (!(oService is null)) oService.Close();
            }
        }

    }
}
