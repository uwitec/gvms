using System;
using System.Collections.Generic;
using System.Text;

namespace CommnicationMessage
{
    public class ObjectSerialize
    {
        #region public methods

        public static  byte[] SerializeObjectToBytes(object objectNeedSerialized,SeralizeFormatType formatType)
        {
            System.Runtime.Serialization.IFormatter oFormatter = null;

            if (formatType == SeralizeFormatType.BinaryFormat)
                oFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            else if (formatType == SeralizeFormatType.XmlFortmat)
                oFormatter = new System.Runtime.Serialization.Formatters.Soap.SoapFormatter();

            System.IO.MemoryStream oStream = new System.IO.MemoryStream();

            oFormatter.Serialize(oStream, objectNeedSerialized);

            byte[] oBuffer = new byte[oStream.Length];
            oStream.Position = 0;
            oStream.Read(oBuffer, 0, oBuffer.Length);

            return oBuffer;
        }

        public static object DeserializeBytesToObject(byte[] bytesNeedDeserialized,int count,SeralizeFormatType formatType)
        {
            System.Runtime.Serialization.IFormatter oFormatter = null;

            if (formatType == SeralizeFormatType.BinaryFormat)
                oFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            else if (formatType == SeralizeFormatType.XmlFortmat)
                oFormatter = new System.Runtime.Serialization.Formatters.Soap.SoapFormatter();

            System.IO.MemoryStream oStream = new System.IO.MemoryStream(bytesNeedDeserialized,0,count);
            object oResult = oFormatter.Deserialize(oStream);

            return oResult;
        }

        #endregion

        #region inner enum

        public enum SeralizeFormatType
        {
            /// <summary>
            /// 
            /// </summary>
            BinaryFormat = 1,

            /// <summary>
            /// 
            /// </summary>
            XmlFortmat = 2
        }

        #endregion
    }
}
