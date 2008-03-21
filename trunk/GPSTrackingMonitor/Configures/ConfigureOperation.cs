using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Soap;

namespace GPSTrackingMonitor.Configures
{
    class ConfigureOperation
    {
        #region public methods

        public ConfigureInfos GetConfigureInfos(string configureFileName)
        {
            ConfigureInfos oResult = new ConfigureInfos();
            SoapFormatter oXmlFomatter = new SoapFormatter();

            System.IO.FileStream oFileStream = new System.IO.FileStream(configureFileName, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            oResult = (ConfigureInfos)oXmlFomatter.Deserialize(oFileStream);

            return oResult;
        }

        public void SaveConfigureInfos(ConfigureInfos informations,string savePath)
        {
            SoapFormatter oXmlFormatter = new SoapFormatter();
            System.IO.MemoryStream oMemStream = new System.IO.MemoryStream();

            oXmlFormatter.Serialize(oMemStream, informations);
            string sContext = Encoding.ASCII.GetString(oMemStream.GetBuffer());
            System.IO.File.WriteAllText(savePath, sContext);
        }

        #endregion
    }
}
