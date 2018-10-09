using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements
{





    /// <summary>
    /// Single variable class
    /// </summary>
    /// <created>
    ///  <author>DIVI Group</author>
    ///  <date>2018.10.03</date>
    /// </created>
    public class Variable
    {

        public enum VarType
        {
            VAR_TYPE_SIMPLE = 1,
            VAR_TYPE_OBJECT = 0
        }

        private string _name = "";
        private VarType _varType = VarType.VAR_TYPE_SIMPLE;
        private string _value = "";

        #region properties

        public string name { get { return _name; } }
        public string value { get { return _value; } set { _value = value; } }
        public VarType type { get { return _varType; } }

        #endregion properties


        /// <summary>
        /// variable construction
        /// </summary>
        /// <created>
        ///  <author>DIVI Group</author>
        ///  <date>2018.10.03</date>
        /// </created>
        /// <param name="name"></param>
        /// <param name="varType"></param>
        /// <param name="value"></param>
        public Variable(string name, VarType varType, string value)
        {
            _name = name;
            _varType = varType;
            _value = value;
        }
    }


}
