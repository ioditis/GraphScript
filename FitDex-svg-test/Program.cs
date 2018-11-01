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

            // sets breakpoint
            Interpreter.BreakpointLine = breakpoint;

            // adds line colors and typs
            LoadConfiguration( "justTest" );


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


        /// <summary>
        /// Loads configuration
        /// </summary>
        /// <param name="pFileName"></param>
        private static void LoadConfiguration(string pFileName) {

            Elements.Graphics.LineTypes.Add("sTechnical", new Elements.LineType(Color.Red, 2F, 0.5F, new SvgUnitCollection()));
            Elements.Graphics.LineTypes.Add("sSeamWide", new Elements.LineType(Color.Black, 1F, 1F, new SvgUnitCollection() { 10, 5,2,2,2,5 }));
            Elements.Graphics.LineTypes.Add("sSimple", new Elements.LineType(Color.Black, 0.5F, 0.5F, new SvgUnitCollection()));
            Elements.Graphics.Variables.Add("sTecnical", new Variable("sTechnical", Variable.VarType.VAR_TYPE_OBJECT, "LineType"));
            Elements.Graphics.Variables.Add("sSeamWide", new Variable("sSeamWide", Variable.VarType.VAR_TYPE_OBJECT, "LineType"));
            Elements.Graphics.Variables.Add("sSimple", new Variable("sSimple", Variable.VarType.VAR_TYPE_OBJECT, "LineType"));

            Elements.Graphics.PointTypes.Add("pSimple", new Elements.PointType( Color.Green, 1.5F, 0.75F, 1, false, Color.Green, 0.5F ));
            Elements.Graphics.PointTypes.Add("pComplex", new Elements.PointType( Color.Green, 2, 0.5F, 1, true, Color.Orange, 0.5F));
            Elements.Graphics.Variables.Add("pSimple", new Variable("pSimple", Variable.VarType.VAR_TYPE_OBJECT, "PointType"));
            Elements.Graphics.Variables.Add("pComplex", new Variable("pSimple", Variable.VarType.VAR_TYPE_OBJECT, "PointType"));

        }


        // Save created svg
        private static void SaveSvg(string fileName) {
            var oSvgDocument = new SvgDocument();

            // draw all lines
            foreach (KeyValuePair< string, Line > l in Elements.Graphics.Lines) {

                SvgElement el = l.Value.SvgElement;
                if (el != null) {
                    if (Elements.Graphics.LineTypes.ContainsKey(l.Value.type))
                    {
                        Elements.Graphics.LineTypes[l.Value.type].SetupElement(el);
                    }
                    else
                    {
                        el.Stroke = new SvgColourServer(Color.Black);
                        el.StrokeWidth = 0.5F;
                        el.StrokeOpacity = 1F;
                    }

                    oSvgDocument.Children.Add(el);
                }
            }

            // draw all point
            foreach (KeyValuePair<string, Elements.Point> p in Elements.Graphics.Points)
            {
                SvgCircle ep = p.Value.SvgElement;
                if (ep != null)
                {
                    if (Elements.Graphics.PointTypes.ContainsKey(p.Value.type))
                    {
                        Elements.Graphics.PointTypes[p.Value.type].SetupElement(ep);
                    }
                    else
                    {
                        ep.Stroke = new SvgColourServer(Color.Black);
                        ep.StrokeWidth = 0.5F;
                        ep.StrokeOpacity = 1F;
                        ep.Fill = new SvgColourServer(Color.Black);
                    }

                    oSvgDocument.Children.Add(ep);
                }

            }

            oSvgDocument.Write(fileName);

        }
    }
}
