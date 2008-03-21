

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Reflection;

namespace GPSTrackingMonitor.TrackingReplay
{
    #region trackpoint class

    /// <summary>
    /// 轨迹点信息
    /// </summary>
    public class TrackPoint
    {
        private double _x;
        private double _y;
        private DateTime _timeStamp;
        private int _id;

        /// <summary>
        /// 
        /// </summary>
        public TrackPoint()
        {
        }

        /// <summary>
        /// 新建TrackPoint对象
        /// </summary>
        /// <param name="ID">ID</param>
        /// <param name="X">X</param>
        /// <param name="Y">Y</param>
        /// <param name="TimeStamp">时间戳</param>
        public TrackPoint(int ID, double X, double Y, DateTime TimeStamp)
        {
            this._id = ID;
            this._x = X;
            this._y = Y;
            this._timeStamp = TimeStamp;
        }

        /// <summary>
        /// 坐标的X值
        /// </summary>
        public double X
        {
            get { return this._x; }
            set { this._x = value; }
        }

        /// <summary>
        /// 坐标的Y值
        /// </summary>
        public double Y
        {
            get { return this._y; }
            set { this._y = value; }
        }

        /// <summary>
        /// 轨迹点的时间戳
        /// </summary>
        public DateTime TimeStamp
        {
            get { return this._timeStamp; }
            set { this._timeStamp = value; }
        }

        /// <summary>
        /// 轨迹点的ID号
        /// </summary>
        public int ID
        {
            get { return this._id; }
            set { this._id = value; }
        }
    }

    #endregion

    #region list trackpoints class
    /// <summary>
    /// 轨迹点集合
    /// </summary>
    public class TrackPoints : List<TrackPoint>
    {
    }

    #endregion

    #region tracksegment class

    /// <summary>
    /// 轨迹段信息
    /// </summary>
    public class TrackSegment : Object, ICloneable
    {
        private TrackPoint _startTrackPoint;
        private TrackPoint _endTrackPoint;
        private double _segLength;
        private double _speed;
        private double _courseTime;

        /// <summary>
        /// 分段的开始节点
        /// </summary>
        public TrackPoint StartTrackPoint
        {
            get { return this._startTrackPoint; }
            set { this._startTrackPoint = value; }
        }


        /// <summary>
        /// 分段的结束节点
        /// </summary>
        public TrackPoint EndTrackPoint
        {
            get { return this._endTrackPoint; }
            set { this._endTrackPoint = value; }
        }

        /// <summary>
        /// 分段长度（单位：米）
        /// </summary>
        public double SegmentLenth
        {
            get { return this._segLength; }
            set { this._segLength = value; }
        }

        /// <summary>
        /// 速度（单位：米/毫秒）
        /// </summary>
        public double Speed
        {
            get { return this._speed; }
            set { this._speed = value; }
        }

        /// <summary>
        /// 所用时间（单位:毫秒)
        /// </summary>
        public double CourseTime
        {
            get { return this._courseTime; }
            set { this._courseTime = value; }
        }

        /// <summary>
        /// 深度复制
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            object obj = this.MemberwiseClone();
            TrackSegment oSeg = obj as TrackSegment;
            oSeg.CourseTime = this.CourseTime;
            oSeg.EndTrackPoint = this.EndTrackPoint;
            oSeg.SegmentLenth = this.SegmentLenth;
            oSeg.Speed = this.Speed;
            oSeg.StartTrackPoint = this.StartTrackPoint;

            return obj;
        }
    }

    #endregion

    #region list tracksegments class

    /// <summary>
    /// 轨迹段集合
    /// </summary>
    public class TrackSegments : List<TrackSegment>
    {
    }

    #endregion
}
