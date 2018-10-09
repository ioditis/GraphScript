using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements
{
    public static class Graphics
    {

        public static Dictionary<string, Variable> Variables = new Dictionary<string, Variable>();
        public static Dictionary<string, Point> Points = new Dictionary<string, Point>();
        public static Dictionary<string, Line> Lines = new Dictionary<string, Line>();


        public enum Direction {

            DIR_RIGHT =1,
            DIR_LEFT = 2,
            DIR_UP = 3,
            DIR_DOWN = 4

        }



        #region New objects


        /// <summary>
        /// Adds new point to Graphics
        /// </summary>
        /// <created>
        ///  <author>DIVI Group</author>
        ///  <date>2018.10.05</date>
        /// </created>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static string AddPoint(string pName, string pParameters) {

            string errors = "";

            Console.WriteLine(  string.Format("Add Point: {0}, [{1}]", pName, pParameters) );

            // TODO: error validation

            // gets point
            string[] xy_param = pParameters.Split(',');

            // builds coordinates
            Variable x;
            Variable y;
            String name = "";
            if (xy_param[0].EndsWith("(d)"))
            {
                name = pName + "__X__";
                x = new Variable(
                        pName + "__X__",
                        Variable.VarType.VAR_TYPE_SIMPLE,
                        xy_param[0].Substring(0, xy_param[0].Length - 3)
                        );
                Graphics.Variables.Add(name, x);
            }
            else {
                x = Graphics.Variables[xy_param[0]];
            };

            if (xy_param[1].EndsWith("(d)"))
            {
                name = pName + "__Y__";
                y = new Variable(
                        pName + "__Y__",
                        Variable.VarType.VAR_TYPE_SIMPLE,
                        xy_param[1].Substring(0, xy_param[1].Length - 3)
                        );
                Graphics.Variables.Add(name, y);
            }
            else
            {
                y = Graphics.Variables[xy_param[1]];
            };

            Elements.Graphics.Points.Add(  
                    pName,
                    new Point( pName, x, y)
                );
            Elements.Graphics.Variables.Add(pName, new Variable(pName, Variable.VarType.VAR_TYPE_OBJECT, "Point"));

            return errors;
        }




        /// <summary>
        /// Adds new line to Graphics
        /// </summary>
        /// <created>
        ///  <author>DIVI Group</author>
        ///  <date>2018.10.05</date>
        /// </created>
        /// <param name="pName">line name</param>
        /// <param name="parameters">line parameters: point names separated by comma</param>
        /// <returns></returns>
        public static string AddLine(string pName, string pParameters)
        {

            string errors = "";

            Console.WriteLine(string.Format("Add Line: {0}, [{1}]", pName, pParameters));

            // TODO: error validation

            // gets point
            string[] xy_param = pParameters.Split(',');

            // builds coordinates
            Elements.Graphics.Lines.Add(
                    pName,
                    new Line(
                        pName,
                        Graphics.Points[xy_param[0]],
                        Graphics.Points[xy_param[1]]
                    )
                );
            Elements.Graphics.Variables.Add(pName, new Variable(pName, Variable.VarType.VAR_TYPE_OBJECT, "Line"));


            return errors;
        }




        public static string Call(string pName, string pSource, string pFunction, string pParams) {

            string error = "";
            Variable sourceVar = Elements.Graphics.Variables[pSource];
            string[] param = pParams.Split(',');

            if (sourceVar.type == Variable.VarType.VAR_TYPE_OBJECT) {

                // rebuild param array
                string[] realParams = new string[param.Length];
                int i = 0;
                foreach (string p in param) {
                    if (p.LastIndexOf("(d)") > 0)
                    {
                        realParams[i] = p.Substring(0, p.Length - 3);
                    }
                    else
                    {
                        realParams[i] = Elements.Graphics.Variables[p].value;
                    }
                    i++;
                }

                // executes function
                switch (sourceVar.value) {
                    case "Point":
                        switch (pFunction.ToUpper()) {
                            case "LEFT":
                                Elements.Graphics.AddPointOnSide(pName, pSource, Direction.DIR_LEFT, realParams[0]);
                                break;
                            case "RIGHT":
                                Elements.Graphics.AddPointOnSide(pName, pSource, Direction.DIR_RIGHT, realParams[0]);
                                break;
                            case "UP":
                                Elements.Graphics.AddPointOnSide(pName, pSource, Direction.DIR_UP, realParams[0]);
                                break;
                            case "DOWN":
                                Elements.Graphics.AddPointOnSide(pName, pSource, Direction.DIR_DOWN, realParams[0]);
                                break;
                        }
                        break;
                }

            }


            return error;
        }



        public static string AddPointOnSide(string pName, string pSource, Graphics.Direction pDir, string pLength) {

            string error = "";

            // TODO: error processing

            // gets current point
            Point source = Graphics.Points[pSource];

            // computes result coordinates
            int x = 0;
            int y = 0;
            int length = Int32.Parse( pLength );

            switch (pDir) {

                case Direction.DIR_DOWN:
                    y = source.y + length;
                    x = source.x;
                    break;

                case Direction.DIR_UP:
                    y = source.y - length;
                    x = source.x;
                    break;

                case Direction.DIR_RIGHT:
                    y = source.y;
                    x = source.x + length;
                    break;

                case Direction.DIR_LEFT:
                    y = source.y;
                    x = source.x - length;
                    break;
            }

            // creates new point
            error = Graphics.AddPoint(pName, string.Format( "{0}(d),{1}(d)", x, y ));


            return error;
        }



        #endregion New objects



        /// <summary>
        /// Sets property to object
        /// </summary>
        /// <created>
        ///  <author>DIVI Group</author>
        ///  <date>2018.10.05</date>
        /// </created>
        /// <param name="pName"></param>
        /// <param name="pAttribute"></param>
        /// <param name="pValue"></param>
        /// <returns></returns>
        public static string SetProperty(string pName, string pAttribute, string pValue)
        {
            string error = "";

            // todo: error validation
            Console.WriteLine(string.Format("Set Value: {0}.{1} [{2}]", pName, pAttribute, pValue));

            // set value
            Variable curVar = Elements.Graphics.Variables[pName];
            if (curVar.type == Variable.VarType.VAR_TYPE_OBJECT) {
                switch (curVar.value) {
                    case "Point":
                        switch (pAttribute.ToUpper()) {
                            case "X":
                                Elements.Graphics.Points[pName].x = Int32.Parse(pValue);
                                break;
                            case "Y":
                                Elements.Graphics.Points[pName].y = Int32.Parse(pValue);
                                break;
                        }
                        break;
                    case "Line":
                        break;
                }
            }

            return error;
        }



        /// <summary>
        /// Get object property value
        /// </summary>
        /// <created>
        ///  <author>DIVI Group</author>
        ///  <date>2018.10.05</date>
        /// </created>
        /// <param name="pName"></param>
        /// <param name="pAttribute"></param>
        /// <returns></returns>
        public static string GetProperty(string pName, string pAttribute)
        {
            string error = "";

            // todo: error validation
            Console.WriteLine(string.Format("Get Value: {0}.{1}", pName, pAttribute));

            // set value
            Variable curVar = Elements.Graphics.Variables[pName];
            if (curVar.type == Variable.VarType.VAR_TYPE_OBJECT)
            {
                switch (curVar.value)
                {
                    case "Point":
                        switch (pAttribute.ToUpper())
                        {
                            case "X":
                                return Elements.Graphics.Points[pName].x.ToString();
                                break;
                            case "Y":
                                return Elements.Graphics.Points[pName].y.ToString();
                                break;
                        }
                        break;
                    case "Line":
                        break;
                }
            }

            return error;
        }


    }


}
