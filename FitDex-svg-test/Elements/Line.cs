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


        #region properties

        Point start => _start;
        Point end => _end;
        string name { get { return _name; } }

        public SvgElement SvgElement {
            get {

                SvgLine l = new SvgLine();
                l.StartX = new SvgUnit( _start.x );
                l.StartY = new SvgUnit( _start.y );
                l.EndX = new SvgUnit( _end.x );
                l.EndY = new SvgUnit( _end.y );
                return l;

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
        /// <param name="pStart"></param>
        /// <param name="pEnd"></param>
        public Line(string pName, Point pStart, Point pEnd) {

            _name = pName;
            _start = pStart;
            _end = pEnd;
        }


    }
}
