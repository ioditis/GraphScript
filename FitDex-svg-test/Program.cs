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

            string input = (new System.IO.StreamReader(fileScript)).ReadToEnd();
            /*
            string input = "Ax = 100 ; Ay=100;" + Environment.NewLine + "  "
                    + Environment.NewLine + " pA = new Point( Ax, Ay);"
                    + Environment.NewLine + " pB = new Point( 100, 200);"
                    + Environment.NewLine + " pC = new Point( 200, 200);"
                    + Environment.NewLine + " L_AB = new Line( pA, pB);"
                    + Environment.NewLine + " L_BC = new Line( pB, pC);"
                    + Environment.NewLine + " L_CA = new Line( pC, pA);"
                    + Environment.NewLine + " Ax = 50;"
                    + Environment.NewLine + ""
                    + Environment.NewLine + " simple    =12345;";
               */
            // string input = "v1 = new FgT() ;\n\r;  v2 = new kuku();";

            Console.WriteLine(": ");

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
