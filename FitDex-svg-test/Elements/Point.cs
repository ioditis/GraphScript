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


        #region properties

        public int x {
            get { return Int32.Parse(_x.value); }
            set { _x.value = value.ToString(); }
        }
        public int y {
            get { return Int32.Parse(_y.value); }
            set { _y.value = value.ToString(); }
        }
        public string name { get { return _name; } }

        #endregion properties


        #region constructors

        /// <summary>
        /// constructor
        /// </summary>
        /// <created>
        ///  <author>DIVI Group</author>
        ///  <date>2018.09.26</date>
        /// </created>
        /// <param name="pName">name of the point</param>
        /// <param name="pX"></param>
        /// <param name="pY"></param>
        public Point(string pName, Variable pX, Variable pY) {
            _name = pName;
            _x = pX;
            _y = pY;
        }

        #endregion cosntructors

    }
}
