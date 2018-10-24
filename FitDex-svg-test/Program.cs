using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Svg;
using System.Drawing;
using Elements;

namespace FitDex_svg_test
{
    class Program
    {
        static void Main(string[] args)
        {


            string fileScript = args[0];
            string fileSvg = args[1];
            int breakpoint = -1;            // break point line set to none

            if (args.Length > 2)
            {
                if (args[2].Substring(0, 11).ToUpper() == "BREAKPOINT=") {
                    breakpoint = int.Parse( args[2].Substring(11));
                }
            }

            string input = (new System.IO.StreamReader(fileScript)).ReadToEnd();

            Interpreter.BreakpointLine = breakpoint;

            var matcher = new FitDex(); //new Calc();
            var result = matcher.GetMatch(input, matcher.Script);

            if (result.Success)
            {
                Console.WriteLine("Result: " + result.Result);
                SaveSvg(fileSvg);
            }
            else
            {
                Console.WriteLine("Error: " + result.Error);
                Console.WriteLine( string.Format( "Error line: {0}", Interpreter.LineCurrent+1));
            }
            Console.Write("Press enter to quit");
            Console.ReadLine();

            

        }



        // Save created svg
        private static void SaveSvg(string fileName) {
            var oSvgDocument = new SvgDocument();

            foreach (KeyValuePair< string, Line > l in Elements.Graphics.Lines) {
                SvgElement el = l.Value.SvgElement;
                el.Stroke = new SvgColourServer(Color.Black);
                el.StrokeWidth = 1.0F;
                oSvgDocument.Children.Add(el);
            }

            oSvgDocument.Write(fileName);

        }
    }
}
