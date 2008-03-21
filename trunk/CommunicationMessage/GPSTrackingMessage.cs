using System;
using System.Collections.Generic;
using System.Text;

namespace CommnicationMessage
{
    [Serializable]
    public class GPSTrackingMessage
    {
        #region fields

        //GeoID,CarNumber,X,Y,Phone,Direction,CurrentTime
        private string _geoId = "";
        private string _carNumber = "";
        private string _phone = "";
        private double _x = 0;
        private double _y = 0;
        private double _direction = 0;
        private DateTime _timeStamp = DateTime.Now;
        private bool _commnicationStoped = false;

        #endregion

        #region constructors

        public GPSTrackingMessage(string geoId,string carNumber,string phone,double x,double y,double direction,DateTime timeStamp,bool commnicationStoped)
        {
            this._geoId = geoId;
            this._carNumber = carNumber;
            this._phone = phone;
            this._x = x;
            this._y = y;
            this._direction = direction;
            this._timeStamp = timeStamp;
            this._commnicationStoped = commnicationStoped;
        }

        public GPSTrackingMessage()
        {
        }

        #endregion

        #region properties

        public string GeoId
        {
            get{return this._geoId;}
            set{this._geoId = value;}
        }

        public string CarNumber
        {
            get { return this._carNumber; }
            set { this._carNumber = value; }
        }

        public string Phone
        {
            get { return this._phone; }
            set { this._phone = value; }
        }

        public double X
        {
            get { return this._x; }
            set { this._x = value; }
        }

        public double Y
        {
            get { return this._y; }
            set { this._y = value; }
        }

        public double Direction
        {
            get { return this._direction; }
            set { this._direction = value; }
        }

        public DateTime TimeStamp
        {
            get { return this._timeStamp; }
            set { this._timeStamp = value; }
        }

        public bool CommnicationStoped
        {
            get { return this._commnicationStoped; }
            set { this._commnicationStoped = value; }
        }

        #endregion
    }
}
