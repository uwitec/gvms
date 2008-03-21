using System;
using System.Collections.Generic;
using System.Text;

namespace GPSTrackingMonitor.Utilities
{
    public class CustomFormatProvider:IFormatProvider,ICustomFormatter
    {
        #region IFormatProvider 成员

        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
                return this;
            return null;
        }

        #endregion

        #region ICustomFormatter 成员

        public string Format(string format, object arg, IFormatProvider formatProvider)
        {   
            switch (format)
            {
                case "string":
                case "datetime":
                    return string.Format("\"{0}\"", arg.ToString());
                case null:
                case "":
                default:
                    if (arg is IFormattable)
                        return ((IFormattable)arg).ToString(format, formatProvider);
                    return arg.ToString();
            }
        }

        #endregion
    }
}
