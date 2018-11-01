using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Svg;

namespace Elements
{

    /// <summary>
    /// Single point
    /// </summary>
    /// <created>
    ///  <author>DIVI Group</author>
    ///  <date>2018.09.26</date>
    /// </created>
    public class Point
    {

        private Variable _x;
        private Variable _y;
        private string _name;
        private bool _visible;
        private string _type;





        #region properties


        /// <summary>
        /// builds SvgElement for point
        /// </summary>
        /// <created>
        ///  <author>DIVI Group</author>
        ///  <created>2018.10.25</created>
        /// </created>
        public SvgCircle SvgElement
        {
            get
            {

                if (_visible)
                {
                    SvgCircle c = new SvgCircle();
                    c.CenterX = new SvgUnit( Int32.Parse( _x.value ) );
                    c.CenterY = new SvgUnit( Int32.Parse( _y.value ) );
                    return c;
                }
                else
                {
                    return null;
                }

            }
        }

        public int x {
            get { return Int32.Parse(_x.value); }
            set { _x.value = value.ToString(); }
        }
        public int y {
            get { return Int32.Parse(_y.value); }
            set { _y.value = value.ToString(); }
        }
        public string name { get { return _name; } }
        public bool visible {
            get { return _visible; }
            set { _visible = value; }
        }
        public string type {
            get { return _type; }
            set { _type = value; }
        }

        #endregion properties


        #region constructors

        /// <summary>
        /// constructor for visible point
        /// </summary>
        /// <created>
        ///  <author>DIVI Group</author>
        ///  <date>2018.10.25</date>
        /// </created>
        /// <param name="pName">name of the point</param>
        /// <param name="pX"></param>
        /// <param name="pY"></param>
        /// <param name="pType">type of point</param>
        public Point(string pName, Variable pX, Variable pY, string pType) {
            _name = pName;
            _x = pX;
            _y = pY;
            _type = pType;
            _visible = true;
        }


        /// <summary>
        /// constructor for invisible point
        /// </summary>
        /// <created>
        ///  <author>DIVI Group</author>
        ///  <date>2018.09.26</date>
        /// </created>
        /// <param name="pName">name of the point</param>
        /// <param name="pX"></param>
        /// <param name="pY"></param>
        public Point(string pName, Variable pX, Variable pY)
        {
            _name = pName;
            _x = pX;
            _y = pY;
            _type = "";
            _visible = false;
        }

        #endregion cosntructors

    }
}
