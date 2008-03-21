using System;
using System.Collections.Generic;
using System.Text;

namespace GPSTrackingMonitor.TrackingReplay
{   
    /// <summary>
    /// 
    /// </summary>
    public class TrackInterpolate
    {
        #region private methods
      
        /// <summary>
        /// 计算两点之间的距离
        /// </summary>  
        /// <param name="startPoint">开始点</param>
        /// <param name="endPoint">终止点</param>
        /// <returns></returns>
        private double ComputeDirectDistance(TrackPoint startPoint, TrackPoint endPoint)
        {
            double x1 = 0;
            double y1 = 0;
            double x2 = 0;
            double y2 = 0;

            x1 = startPoint.X;
            y1 = startPoint.Y;
            x2 = endPoint.X;
            y2 = endPoint.Y;

            return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
        }

        /// <summary>
        /// 计算两轨迹点之间所花的时间
        /// </summary>
        /// <param name="startPoint">开始点</param>
        /// <param name="endPoint">终止点</param>
        /// <returns></returns>
        private double ComputeTotalTime(TrackPoint startPoint, TrackPoint endPoint)
        {
            TimeSpan oTime = endPoint.TimeStamp.Subtract(startPoint.TimeStamp);

            return  Math.Abs(oTime.TotalMilliseconds);
        }
     
        /// <summary>
        /// 根据轨迹点集合来生成相对应的轨迹段集合
        /// </summary>
        /// <param name="allPoints">轨迹点集合</param>
        /// <param name="segmentsInfos">轨迹段集合</param>
        private void GetSegmentInfos(TrackPoints allPoints,  ref TrackSegments segmentsInfos)
        {
            int iPointsCount = allPoints.Count;

            double dCurDistance = 0;

            if (iPointsCount < 2)
                throw new Exception("the count of points can not be less than 2");

            for (int i = 0; i < iPointsCount - 1; i++)
            {
                TrackPoint oPrePoint = new TrackPoint();
                TrackPoint oNextPoint = new TrackPoint();
                TrackSegment oSegInfos = new TrackSegment();
                TimeSpan oTimeSpan = new TimeSpan();

                oPrePoint = allPoints[i];
                oNextPoint = allPoints[i + 1];

                dCurDistance = this.ComputeDirectDistance(oPrePoint, oNextPoint);
                oTimeSpan = oNextPoint.TimeStamp.Subtract(oPrePoint.TimeStamp);

                oSegInfos.StartTrackPoint = oPrePoint;
                oSegInfos.EndTrackPoint = oNextPoint;
                oSegInfos.SegmentLenth = dCurDistance;
                oSegInfos.CourseTime = oTimeSpan.TotalMilliseconds;

                if (oSegInfos.CourseTime == 0)
                {
                    oSegInfos.Speed = 0;
                }
                else
                {
                    oSegInfos.Speed = oSegInfos.SegmentLenth / oSegInfos.CourseTime;
                }

                segmentsInfos.Add(oSegInfos);
            }
        }

        /////// <summary>
        /////// 对轨迹点集合进行插值处理的核心代码
        /////// </summary>
        /////// <param name="allPoints">轨迹点集合</param>
        /////// <param name="smoothFactor">平滑系数</param>
        /////// <param name="speedScaleFactor">速度比例系数</param>
        /////// <returns>轨迹段集合</returns>
        ////private TrackSegments InterpolateProcessCore(TrackPoints allPoints,InterpolateType interpolateType, double smoothFactor, double speedScaleFactor)
        ////{
        ////    TrackPoints oPointsResult = new TrackPoints();
        ////    TrackSegments oSegmentsInfos = new TrackSegments();
        ////    TrackSegments oSegmentsResult = new TrackSegments();

        ////    int iPointCount = 0;
           
        ////    iPointCount = allPoints.Count;

        ////    if (interpolateType == InterpolateType.LengthInterpolate)
        ////    {
        ////        double dSegLength = 0;

        ////        for (int i = 0; i < iPointCount - 1; i++)
        ////        {
        ////            dSegLength = ComputeDirectDistance(allPoints[i], allPoints[i + 1]);
        ////            this.DividSegmentByLength(ref oPointsResult, dSegLength, smoothFactor, speedScaleFactor, allPoints[i], allPoints[i + 1]);
        ////        }
        ////    }
        ////    else if (interpolateType == InterpolateType.TimeInterpolate)
        ////    {
        ////        double dUsedTime = 0;
        ////        for (int i = 0; i < iPointCount - 1; i++)
        ////        {
        ////            dUsedTime = ComputeTotalTime(allPoints[i], allPoints[i + 1]) / speedScaleFactor;
        ////            this.DividSegmentByTime(ref oPointsResult, dUsedTime, this._baseIntervalTime, allPoints[i], allPoints[i + 1]);
        ////        }
        ////    }

        ////    this.GetSegmentInfos(oPointsResult,ref  oSegmentsResult);          
        ////    return oSegmentsResult;
        ////}

       

        ///// <summary>
        ///// 对指点两个点之间的轨迹段进行分割(以长度为分割单元)
        ///// </summary>
        ///// <param name="trackPointsResult">分割后的轨迹点集合</param>
        ///// <param name="distanceBetweenTwoPoints">两点间的距离</param>
        ///// <param name="smoothFactor">平滑系数</param>
        ///// <param name="speedScaleFactor">速度比例系数</param>
        ///// <param name="StartTrackPoint">起始点</param>
        ///// <param name="EndTrackPoint">终止点</param>
        //private void DividSegmentByLength(ref TrackPoints trackPointsResult, double distanceBetweenTwoPoints, double smoothFactor, double speedScaleFactor, TrackPoint StartTrackPoint, TrackPoint EndTrackPoint)
        //{           
        //    TrackPoint oStartPoint = new TrackPoint();
        //    TrackPoint oEndPoint = new TrackPoint();
        //    TrackSegment oSeg = new TrackSegment();
            
        //    oStartPoint.ID = StartTrackPoint.ID;
        //    oStartPoint.TimeStamp = StartTrackPoint.TimeStamp;
        //    oStartPoint.X = StartTrackPoint.X;
        //    oStartPoint.Y = StartTrackPoint.Y;

        //    oEndPoint.ID = EndTrackPoint.ID;
        //    oEndPoint.TimeStamp = EndTrackPoint.TimeStamp;
        //    oEndPoint.X = EndTrackPoint.X;
        //    oEndPoint.Y = EndTrackPoint.Y;

        //    //计算插入点的个数
        //    decimal decPointCount = smoothFactor == 0 ? 0 : Convert.ToDecimal(distanceBetweenTwoPoints / smoothFactor);
        //    int iInsertPointCount = Convert.ToInt32(Math.Round(decPointCount)) - 1;
        //    iInsertPointCount = iInsertPointCount < 0 ? 0 : iInsertPointCount;
            
        //    /*
        //     * 如果Ps > Pe
        //     * Px = Abs((Ps - Pe) / n ) * x + Ps
        //     * 
        //     * 如果Ps < Pe
        //     * Px = Abs((Ps - Pe) / n ) * (n - 1 - x) + Pe
        //     * 
        //     * 其中，n为分割段的个数（等于插入点个数加1），Ps起始端点，Pe终止端点
        //     * x为插入点的序号（靠近Ps的序号为1，靠近Pe的序号为n -1）,Px为某一插入点
        //     * 
        //     * */

        //    double dSegLenthX = Math.Abs(((oStartPoint.X - oEndPoint.X) / (iInsertPointCount + 1)));
        //    double dSegLenthY = Math.Abs(((oStartPoint.Y - oEndPoint.Y) / (iInsertPointCount + 1)));
        //    TimeSpan oTimeInterval = new TimeSpan();

        //    //计算每个分割轨迹段所用的间隔时间
        //    speedScaleFactor = speedScaleFactor == 0 ? 1 : speedScaleFactor;       
        //    oTimeInterval = oEndPoint.TimeStamp.Subtract(oStartPoint.TimeStamp);
        //    int iInterval = Convert.ToInt32((oTimeInterval.TotalMilliseconds / (iInsertPointCount + 1)) * speedScaleFactor);
             
        //    if (trackPointsResult.Count == 0)
        //    {
        //        oStartPoint.ID = trackPointsResult.Count + 1;
        //        trackPointsResult.Add(oStartPoint);
        //    }            

        //    //将分割后的轨迹点添加到集合中去
        //    for (int i = 0; i < iInsertPointCount; i++)
        //    {
        //        TrackPoint oTempPoint = new TrackPoint();
             
        //        oTempPoint.ID = trackPointsResult.Count + 1;
        //        oTempPoint.TimeStamp = trackPointsResult[trackPointsResult.Count -1].TimeStamp.AddMilliseconds(iInterval);

        //        if (oStartPoint.X >= oEndPoint.X)
        //        {
        //            oTempPoint.X = dSegLenthX * (iInsertPointCount - i) + oEndPoint.X;
        //        }
        //        else
        //        {
        //            oTempPoint.X = dSegLenthX * (i + 1) + oStartPoint.X;
        //        }

        //        if (oStartPoint.Y >= oEndPoint.Y)
        //        {
        //            oTempPoint.Y = dSegLenthY * (iInsertPointCount - i) + oEndPoint.Y;
        //        }
        //        else
        //        {
        //            oTempPoint.Y = dSegLenthY * (i + 1) + oStartPoint.Y;
        //        }

        //        trackPointsResult.Add(oTempPoint);
        //    }

        //    oEndPoint.ID = trackPointsResult.Count + 1;
        //    oEndPoint.TimeStamp = trackPointsResult[trackPointsResult.Count - 1].TimeStamp.AddMilliseconds(iInterval);
        //    trackPointsResult.Add(oEndPoint);
        //}

        /// <summary>
        /// 对指点两个点之间的轨迹段进行分割(以时间为分割单元)
        /// </summary>
        /// <param name="trackPointsResult">分割后的轨迹点集合</param>
        /// <param name="totalTimeUsedBetweenTwoPoints">两点间的时间差</param>
        /// <param name="smoothFactor">平滑系数</param>
        /// <param name="speedScaleFactor">速度比例系数</param>
        /// <param name="StartTrackPoint">起始点</param>
        /// <param name="EndTrackPoint">终止点</param>
        private void DividSegmentByTime(ref TrackPoints trackPointsResult, double totalTimeUsedBetweenTwoPoints,double smoothFactor,double intervalTime, TrackPoint StartTrackPoint, TrackPoint EndTrackPoint)
        {
            TrackPoint oStartPoint = new TrackPoint();
            TrackPoint oEndPoint = new TrackPoint();
            TrackSegment oSeg = new TrackSegment();

            oStartPoint.ID = StartTrackPoint.ID;
            oStartPoint.TimeStamp = StartTrackPoint.TimeStamp;
            oStartPoint.X = StartTrackPoint.X;
            oStartPoint.Y = StartTrackPoint.Y;

            oEndPoint.ID = EndTrackPoint.ID;
            oEndPoint.TimeStamp = EndTrackPoint.TimeStamp;
            oEndPoint.X = EndTrackPoint.X;
            oEndPoint.Y = EndTrackPoint.Y;

            //计算插入点的个数
            decimal decPointCount = intervalTime == 0 ? 1 : Convert.ToDecimal((totalTimeUsedBetweenTwoPoints) / intervalTime);

            int iInsertPointCount = Convert.ToInt32(Math.Round(decPointCount)) - 1;
            iInsertPointCount = iInsertPointCount < 0 ? 0 : iInsertPointCount;
            /**************************************************************************************
             * 如果Ps > Pe
             * Px = Abs((Ps - Pe) / n ) * x + Ps
             * 
             * 如果Ps < Pe
             * Px = Abs((Ps - Pe) / n ) * (n - 1 - x) + Pe
             * 
             * 其中，n为分割段的个数（等于插入点个数加1），Ps起始端点，Pe终止端点
             * x为插入点的序号（靠近Ps的序号为1，靠近Pe的序号为n -1）,Px为某一插入点
             * 
             ***************************************************************************************/

            double dSegLenthX = Math.Abs(((oStartPoint.X - oEndPoint.X) / (iInsertPointCount + 1)));
            double dSegLenthY = Math.Abs(((oStartPoint.Y - oEndPoint.Y) / (iInsertPointCount + 1)));            

            if (trackPointsResult.Count == 0)
            {
                oStartPoint.ID = trackPointsResult.Count + 1;
                trackPointsResult.Add(oStartPoint);
            }

            //将分割后的轨迹点添加到集合中去
            for (int i = 0; i < iInsertPointCount; i++)
            {
                TrackPoint oTempPoint = new TrackPoint();

                oTempPoint.ID = trackPointsResult.Count + 1;
                oTempPoint.TimeStamp = trackPointsResult[trackPointsResult.Count - 1].TimeStamp.AddMilliseconds(intervalTime);

                if (oStartPoint.X >= oEndPoint.X)
                {
                    oTempPoint.X = dSegLenthX * (iInsertPointCount - i) + oEndPoint.X;
                }
                else
                {
                    oTempPoint.X = dSegLenthX * (i + 1) + oStartPoint.X;
                }

                if (oStartPoint.Y >= oEndPoint.Y)
                {
                    oTempPoint.Y = dSegLenthY * (iInsertPointCount - i) + oEndPoint.Y;
                }
                else
                {
                    oTempPoint.Y = dSegLenthY * (i + 1) + oStartPoint.Y;
                }

                trackPointsResult.Add(oTempPoint);
            }

            oEndPoint.ID = trackPointsResult.Count + 1;
            trackPointsResult.Add(oEndPoint);
        }

        /// <summary>
        /// 查找所有轨迹段中最短的轨迹段
        /// </summary>
        /// <param name="AllPoints">所有的轨迹点</param>
        /// <returns>最短的轨迹段</returns>
        private TrackSegment FindLestTimeInSegments(TrackPoints AllPoints)
        {
            if (AllPoints == null ||  AllPoints.Count < 2)
                return null;

            int iPointsCount = 0;
            double dTotalTime = 0;
            TrackSegment oSegResult = new TrackSegment();
            TrackPoint oPrePoint = new TrackPoint();
            TrackPoint oNextPoint = new TrackPoint();

            iPointsCount = AllPoints.Count;

            oSegResult.CourseTime = this.ComputeTotalTime(AllPoints[0], AllPoints[1]);
            oSegResult.StartTrackPoint = AllPoints[0];
            oSegResult.EndTrackPoint = AllPoints[1];

            for (int i = 1; i < iPointsCount - 1; i++)
            {
                dTotalTime = this.ComputeTotalTime(AllPoints[i], AllPoints[i + 1]);

                if (dTotalTime > 0 && oSegResult.CourseTime > dTotalTime)
                {
                    oSegResult.CourseTime = dTotalTime;
                    oSegResult.StartTrackPoint = AllPoints[i];
                    oSegResult.EndTrackPoint = AllPoints[i + 1];
                }
            }

            oSegResult.SegmentLenth = ComputeDirectDistance(oSegResult.StartTrackPoint, oSegResult.EndTrackPoint);
            oSegResult.Speed = oSegResult.SegmentLenth / oSegResult.CourseTime;

            return oSegResult;
        }

        /// <summary>
        /// 查找所有轨迹段中最短的轨迹段
        /// </summary>
        /// <param name="AllPoints">所有的轨迹点</param>
        /// <returns>最短的轨迹段</returns>
        private TrackSegment FindShortestSegment(TrackPoints AllPoints)
        {
            int iPointsCount = 0;
            double dCurDistance = 0;
            TrackSegment oSegResult = new TrackSegment();
            TrackPoint oPrePoint = new TrackPoint();
            TrackPoint oNextPoint = new TrackPoint();

            iPointsCount = AllPoints.Count;

            oSegResult.SegmentLenth = this.ComputeDirectDistance(AllPoints[0], AllPoints[1]);
            oSegResult.StartTrackPoint = AllPoints[0];
            oSegResult.EndTrackPoint = AllPoints[1];

            for (int i = 0; i < iPointsCount - 1; i++)
            {
                dCurDistance = this.ComputeDirectDistance(AllPoints[i], AllPoints[i + 1]);

                if (oSegResult.SegmentLenth > dCurDistance)
                {
                    oSegResult.SegmentLenth = dCurDistance;
                    oSegResult.StartTrackPoint = AllPoints[i];
                    oSegResult.EndTrackPoint = AllPoints[i + 1];
                }
            }

            TimeSpan oTime = oSegResult.EndTrackPoint.TimeStamp.Subtract(oSegResult.StartTrackPoint.TimeStamp);
            oSegResult.CourseTime = oTime.TotalMilliseconds;
            oSegResult.Speed = oSegResult.SegmentLenth / oSegResult.CourseTime;

            return oSegResult;
        }
        #endregion       

        #region public methods

        /// <summary>
        /// 对轨迹点集合进行插值处理的核心代码
        /// </summary>
        /// <param name="allPoints">轨迹点集合</param>
        /// <param name="smoothFactor">平滑系数</param>
        /// <param name="speedScaleFactor">速度比例系数</param>
        /// <returns>轨迹点集合</returns>
        public TrackPoints InterpolateProcess(TrackPoints allPoints,int smoothFactor)
        {
            if (smoothFactor == 0)
                return allPoints;

            TrackPoints oPointsResult = new TrackPoints();
            TrackSegments oSegmentsInfos = new TrackSegments();
            TrackSegments oSegmentsResult = new TrackSegments();

            int iPointCount = 0;

            iPointCount = allPoints.Count;
            double dUsedTime = 0;
            double dInterval = this.GetIntervalTime(allPoints, smoothFactor);

            for (int i = 0; i < iPointCount - 1; i++)
            {
                dUsedTime = ComputeTotalTime(allPoints[i], allPoints[i + 1]);
                this.DividSegmentByTime(ref oPointsResult, dUsedTime, smoothFactor, dInterval, allPoints[i], allPoints[i + 1]);
            }

            return oPointsResult;
        }

        /// <summary>
        /// 根据平滑系数和速度比例参数来计算时间间隔
        /// </summary>
        /// <param name="allPoints"></param>
        /// <param name="smoothFactor"></param>
        /// <param name="speedScaleFactor"></param>
        /// <returns></returns>
        public double GetIntervalTime(TrackPoints allPoints, double smoothFactor)
        {
            if (allPoints == null ||allPoints.Count == 0)
                return 0;

            double dBaseInterval = this.FindLestTimeInSegments(allPoints).CourseTime;
            double iInterval = 0;

            smoothFactor = smoothFactor == 0 ? 1 : smoothFactor;
            iInterval = dBaseInterval / smoothFactor;

            return iInterval;
        }

        #endregion
    }
}
