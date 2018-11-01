using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Svg;

namespace Elements
{

    /// <summary>
    /// Point type class
    /// </summary>
    /// <created>
    ///  <author>DIVI Group</author>
    ///  <date>2018.10.25</date>
    /// </created>
    public class PointType
    {
        public System.Drawing.Color color;
        public float radius;
        public float width;
        public float opacity = 1;
        public bool isFill = true;
        public System.Drawing.Color fill;
        public float fillOpacity = 1;

        public PointType(
                System.Drawing.Color pColor, float pRadius, float pWidth, float pOpacity, 
                bool pIsFill, System.Drawing.Color pFill, float pFillOpacity = 1)
        {

            color = pColor;
            radius = pRadius;
            width = pWidth;
            opacity = pOpacity;
            isFill = pIsFill;
            fill = pFill;
            fillOpacity = pFillOpacity;

        }

        public void SetupElement(SvgCircle pEl)
        {

            pEl.Stroke = new SvgColourServer(color);
            pEl.Radius = radius;
            pEl.StrokeWidth = width;
            pEl.StrokeOpacity = opacity;
            if (isFill) {
                pEl.Fill = new SvgColourServer(fill);
                pEl.FillOpacity = fillOpacity;
            }

        }

    }
}
