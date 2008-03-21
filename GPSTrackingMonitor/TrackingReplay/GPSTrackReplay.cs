using System;
using System.Collections.Generic;
using System.Text;

namespace GPSTrackingMonitor.TrackingReplay
{
    public  class GPSTrackReplay
    {
        #region fields

        private TrackPoints _inputData = null;
        private TrackSegments _outputData = null;
        private double _baseIntervalLength = 200;
        private double _baseIntervalTime = 0;
        private double _smoothFactor = 0;
        private double _speedScaleFactor = 0;

        #endregion

        #region public properties

        /// <summary>
        /// 输出数据（计算结果）
        /// </summary>
        public TrackSegments OutputData
        {
            get { return this._outputData; }          
        }

        ///// <summary>
        ///// 插入点之间的基本间距，这个间距越大，平滑度越小，请根据时间情况设定，默认值为200m
        ///// </summary>
        //public double BaseIntervalLength
        //{
        //    set { this._baseIntervalLength = value; }
        //}

        ///// <summary>
        ///// 插入点之间的时间差，这个差距越大，平滑度越小，默认值为所有轨迹段所用时间中最小值（即1秒）
        ///// </summary>
        //public double BaseIntervalTime
        //{
        //    set { this._baseIntervalTime = value; }
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        //public double SmoothFactor
        //{
        //    set { this._smoothFactor = value;}
        //}

        /// <summary>
        /// 
        /// </summary>
        public double SpeedScaleFactor
        {
            set { this._speedScaleFactor = value; }
        }

        #endregion      

        #region public methods

        public GPSTrackReplay(TrackPoints inputPoints)
        {
            this._inputData = inputPoints;
        }

        public GPSTrackReplay()
        {
        }

        /// <summary>
        /// 获取计算结果
        /// </summary>
        /// <param name="inputPoints">输入轨迹点集合</param>
        /// <param name="baseIntervalTime">各差值轨迹点之间的时间间隔</param>
        /// <returns>差值后的轨迹点集合</returns>
        public TrackPoints GetResultByInterpolateTime(TrackPoints inputPoints, double baseIntervalTime)
        {
            TrackPoints oResultPoint = null;

            try
            {
                TrackInterpolate oTrackInter = new TrackInterpolate();
                oTrackInter.BaseIntervalTime = baseIntervalTime;

                oResultPoint = oTrackInter.InterpolateProcess(inputPoints,);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.StackTrace);
            }

            return oResultPoint;
        }

        /// <summary>
        /// 获取计算结果
        /// </summary>
        /// <returns>差值后的轨迹点集合</returns>
        public TrackPoints GetResultByInterpolateTime()
        {
            if (this._inputData == null)
                throw new Exception("please check that you had initilized the property  'InputValue'.");

            TrackPoints oResultPoints = null;

            try
            {
                oResultPoints = this.GetResultByInterpolateTime(this._inputData, this._baseIntervalTime);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.StackTrace);
            }

            return oResultPoints;
        }

        ///// <summary>
        ///// 获取计算结果
        ///// </summary>
        ///// <param name="inputPoints">输入轨迹点集合</param>
        ///// <param name="baseIntervalTime">各差值轨迹点之间的时间间隔</param>
        ///// <returns>差值后的轨迹点集合</returns>
        //public TrackPoints GetResultByInterpolateLength(TrackPoints inputPoints, double baseIntervalLength,double smoothFactor,double speedScaleFactor)
        //{
        //    TrackPoints oResultPoint = null;

        //    try
        //    {
        //        TrackInterpolate oTrackInter = new TrackInterpolate();
        //        //oTrackInter.BaseIntevalLength = baseIntervalLength;
        //        oTrackInter.SmoothFactor = smoothFactor;
        //        //oTrackInter.SpeedScaleFactor = speedScaleFactor;

        //        oResultPoint = oTrackInter.InterpolateProcess(inputPoints);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.StackTrace);
        //    }

        //    return oResultPoint;
        //}

        ///// <summary>
        ///// 获取计算结果
        ///// </summary>
        ///// <returns>差值后的轨迹点集合</returns>
        //public TrackPoints GetResultByInterpolateLength()
        //{
        //    if (this._inputData == null)
        //        throw new Exception("please check that you had initilized the property  'InputValue'.");

        //    TrackPoints oResultPoints = null;

        //    try
        //    {
        //        oResultPoints = this.GetResultByInterpolateLength(this._inputData, this._baseIntervalLength,this._smoothFactor,this._speedScaleFactor);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.StackTrace);
        //    }

        //    return oResultPoints;
        //}
   
        #endregion
    }
}
