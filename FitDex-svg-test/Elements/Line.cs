using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Svg;

namespace Elements
{


    /// <summary>
    /// Line class
    /// </summary>
    /// <created>
    ///  <author>DIVI Group</author>
    ///  <date>2018.09.26</date>
    /// </created>
    public class Line //: IGraphics
    {

        Point _start;
        Point _end;
        string _name;
        bool _visible;
        string _type;

        #region properties

        public Point start => _start;
        public Point end => _end;
        public string name { get { return _name; } }
        public bool visible
        {
            get { return _visible; }
            set { _visible = value; }
        }
        public string type
        {
            get { return _type; }
            set { _type = value; }
        }

        public SvgElement SvgElement {
            get {

                if (_visible)
                {
                    SvgLine l = new SvgLine();
                    l.StartX = new SvgUnit(_start.x);
                    l.StartY = new SvgUnit(_start.y);
                    l.EndX = new SvgUnit(_end.x);
                    l.EndY = new SvgUnit(_end.y);
                    return l;
                }
                else
                {
                    return null;
                }

            }
        }


        /// <summary>
        /// Indicates if lines is vertical
        /// </summary>
        /// <created>
        ///  <author>DIVI Group</author>
        ///  <date>2018.11.01</date>
        /// </created>
        public bool IsVertical
        {
            get { return (_start.x == _end.x); }
        }


        /// <summary>
        /// calculation of the slope for line
        /// </summary>
        /// <created>
        ///  <author>DIVI Group</author>
        ///  <date>2018.10.31</date>
        /// </created>
        public float Slope {
            get {
                float s = 0;
                if (!this.IsVertical) {
                    s = (float)(_start.y - _end.y) / (_start.x - _end.x);
                }
                return s;
            }
        }

        
        /// <summary>
        /// Point where line intercepts y
        /// </summary>
        /// <created>
        ///  <author>DIVI Group</author>
        ///  <date>2018.11.01</date>
        /// </created>
        public float Intercept {
            get {
                return (float)(_start.y - this.Slope * _start.x);
            }
        }

        #endregion properties

        /// <summary>
        /// constructor
        /// </summary>
        /// <created>
        ///  <author>DIVI Group</author>
        ///  <date>2018.09.26</date>
        /// </created>
        /// <param name="pName">line name</param>
        /// <param name="pStart">start point</param>
        /// <param name="pEnd">end point</param>
        /// <param name="pType">line type name</param>
        public Line(string pName, Point pStart, Point pEnd, string pType) {

            _name = pName;
            _start = pStart;
            _end = pEnd;
            _type = pType;
            _visible = true;

        }

        /// <summary>
        /// constructor for invisible line
        /// </summary>
        /// <created>
        ///  <author>DIVI Group</author>
        ///  <date>2018.09.26</date>
        /// </created>
        /// <param name="pName">line name</param>
        /// <param name="pStart">start point</param>
        /// <param name="pEnd">end point</param>
        public Line(string pName, Point pStart, Point pEnd )
        {

            _name = pName;
            _start = pStart;
            _end = pEnd;
            _type = "";
            _visible = false;

        }




        /// <summary>
        /// Finds and returns crosspoint of to lines
        /// </summary>
        /// <param name="pL2"></param>
        /// <param name="pName">name for interception</param>
        /// <returns></returns>
        public Point GetCrossPoint(Line pL2, string pName)
        {

            // paralel lines does not cross
            if (this.Slope == pL2.Slope)
            {
                return null;
            }
            else // lines are crossing
            {
                float x = (pL2.Intercept - this.Intercept) / (this.Slope - pL2.Slope);
                float y = this.Slope * x + this.Intercept;

                Variable vX = Graphics.NewVariable(pName + "_X", Variable.VarType.VAR_TYPE_SIMPLE, ((int)x).ToString());
                Variable vY = Graphics.NewVariable(pName + "_Y", Variable.VarType.VAR_TYPE_SIMPLE, ((int)y).ToString());

                Graphics.NewPoint(pName, String.Format("{0}, {1} ", vX.name, vY.name));

                return Graphics.GetPoint(pName);
            }

        }


    }
}
