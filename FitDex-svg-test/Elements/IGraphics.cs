using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Svg;

namespace Elements
{

    /// <summary>
    /// Graphic object iterface
    /// </summary>
    /// <created>
    ///  <author>DIVI Group</author>
    ///  <date>2018.09.26</date>
    /// </created>
    interface IGraphics
    {
        SvgElement SvgElement { get; }
    }
}
