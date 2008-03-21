using System;
using System.Collections.Generic;
using System.Text;

namespace GPSTrackingMonitor.BaseHandler
{
    class MyComparison<T> : IComparer<TrackingReplay.TrackPoint>
    {   
        #region new code

        private ComparisonType _comparisonType;

        public IComparer<TrackingReplay.TrackPoint> GetComparison(ComparisonType comparisonType)
        {
            this._comparisonType = comparisonType;

            return new MyComparison<T>() as IComparer<TrackingReplay.TrackPoint>;
        }

       #region IComparer<TrackPoint> 成员

        public int Compare(GPSTrackingMonitor.TrackingReplay.TrackPoint x, GPSTrackingMonitor.TrackingReplay.TrackPoint y)
        {
            TimeSpan timSpan = x.TimeStamp.Subtract(y.TimeStamp);

            int iResult = 0;

            if (timSpan.TotalMilliseconds > 0)
                iResult = 1;
            else if (timSpan.TotalMilliseconds == 0)
                iResult = 0;
            else if (timSpan.TotalMilliseconds < 0)
                iResult = -1;

            if (this._comparisonType == ComparisonType.ASC)
                return iResult;
            else
                return iResult * -1;
        }

        #endregion

        #endregion

        #region old Code
        /*
        private ComparisonType _comparisonType;
        private Type _objectType;

        public IComparer<T> GetComparison(Type objectType,ComparisonType comparisonType)
        {
            this._comparisonType = comparisonType;
            this._objectType = objectType;

            return (new MyComparison<T>()) as IComparer<T>;
        }


        #region IComparer<object> 成员

        public int Compare(object x, object y)
        {
            if (x.GetType() != y.GetType())
                throw new InvalidOperationException("要比较的两个参数的类型不相同，不能进行比较。");

            double dComputeResult = double.NaN;
            int iResult = 0;

            if (this._objectType == typeof(int)) dComputeResult = (int)x - (int)y;
            else if (this._objectType == typeof(double)) dComputeResult = (double)x - (double)y;
            else if (this._objectType == typeof(float)) dComputeResult = (float)x - (float)y;
            else if (this._objectType == typeof(string)) dComputeResult = string.Compare(x.ToString(), y.ToString(), StringComparison.OrdinalIgnoreCase);
            else if (this._objectType == typeof(DateTime))
            {
                TimeSpan tSpan = ((DateTime)x).Subtract(((DateTime)y));
                dComputeResult = tSpan.TotalMilliseconds;
            }

            if (dComputeResult == double.NaN) throw new Exception("您要比较的类型不支持.");
            else if (dComputeResult > 0) iResult = 1;
            else if (dComputeResult < 0) iResult = -1;
            else if (dComputeResult == 0) iResult = 0;

            if (this._comparisonType == ComparisonType.ASC)
                return iResult;
            else
                return iResult * -1;
        }

        #endregion
         * */
        #endregion
    }

    public enum ComparisonType
    {
        ASC,
        DSC
    }
}
