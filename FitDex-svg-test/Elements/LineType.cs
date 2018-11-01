using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Svg;

namespace Elements
{
    public class LineType
    {

        public System.Drawing.Color color;
        public float width;
        public float opacity;
        public SvgUnitCollection dashArray;

        public LineType(System.Drawing.Color pColor, float pWidth, float pOpacity, SvgUnitCollection pDashArray) {

            color = pColor;
            width = pWidth;
            opacity = pOpacity;
            dashArray = pDashArray;

        }


        public void SetupElement(SvgElement pEl) {

            pEl.Stroke = new SvgColourServer( color );
            pEl.StrokeWidth = width;
            pEl.StrokeOpacity = opacity;
            pEl.StrokeDashArray = dashArray;
            pEl.StrokeLineCap = SvgStrokeLineCap.Round;

        }


    }
}
