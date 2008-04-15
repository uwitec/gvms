using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Soap;

namespace GPSTrackingMonitor.Configures
{
    [Serializable]
    class ConfigureInfosStrcut
    {
        #region fields

        private SystemConfigureStrcut _systemConfigureInfos = new SystemConfigureStrcut();
        private CarSymbolConfigureStrcut _carSymbolConfigureInfos = new CarSymbolConfigureStrcut();
        private CommunicationConfigureStruct _communicationConfigureInfos = new CommunicationConfigureStruct();
        private TrackingReplayConfigureStruct _trackingReplayConfigureInfos = new TrackingReplayConfigureStruct();

        #endregion

        #region properties

        public SystemConfigureStrcut SystemConfigureInfos
        {
            get {return this._systemConfigureInfos;}
            set { this._systemConfigureInfos = value;}
        }

        public CarSymbolConfigureStrcut CarSymbolConfigureInfos
        {
            get { return this._carSymbolConfigureInfos;}
            set { this._carSymbolConfigureInfos = value;}
        }

        public CommunicationConfigureStruct CommunicationConfigureInfos
        {
            get { return this._communicationConfigureInfos;}
            set { this._communicationConfigureInfos = value;}
        }

        public TrackingReplayConfigureStruct TrackingReplayConfigureInfos
        {
            get { return this._trackingReplayConfigureInfos;}
            set { this._trackingReplayConfigureInfos  = value;}
        }

        #endregion

        #region methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="configureFileName"></param>
        /// <returns></returns>
        public static ConfigureInfosStrcut LoadConfigureInfos(string configureFileName)
        {
            ConfigureInfosStrcut oResult = new ConfigureInfosStrcut();
            SoapFormatter oXmlFomatter = new SoapFormatter();

            System.IO.FileStream oFileStream = new System.IO.FileStream(configureFileName, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            oResult = (ConfigureInfosStrcut)oXmlFomatter.Deserialize(oFileStream);

            oFileStream.Close();
            return oResult;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="informations"></param>
        /// <param name="savePath"></param>
        public static void SaveConfigureInfos(ConfigureInfosStrcut informations, string savePath)
        {
            SoapFormatter oXmlFormatter = new SoapFormatter();
            System.IO.MemoryStream oMemStream = new System.IO.MemoryStream();

            oXmlFormatter.Serialize(oMemStream, informations);

            System.IO.FileStream oFileStream = new System.IO.FileStream(savePath, System.IO.FileMode.Create, System.IO.FileAccess.Write, System.IO.FileShare.ReadWrite);

            byte[] oBytes = oMemStream.GetBuffer();
            oFileStream.Write(oBytes, 0, oBytes.Length);

            oFileStream.Close();
        }

        #endregion
    }
}
