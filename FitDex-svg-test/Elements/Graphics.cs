using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitDex_svg_test;

namespace Elements
{
    public static class Graphics
    {

        public static Dictionary<string, Variable> Variables = new Dictionary<string, Variable>();
        public static Dictionary<string, Point> Points = new Dictionary<string, Point>();
        public static Dictionary<string, Line> Lines = new Dictionary<string, Line>();
        public static Dictionary<string, LineType> LineTypes = new Dictionary<string, LineType>();
        public static Dictionary<string, PointType> PointTypes = new Dictionary<string, PointType>();


        // class names
        const string CLASS_POINT = "Point";
        const string CLASS_LINE = "Straight";


        public enum Direction {

            DIR_RIGHT =1,
            DIR_LEFT = 2,
            DIR_UP = 3,
            DIR_DOWN = 4

        }



        #region Add List Items

        /// <summary>
        /// MEthod to access variables with error checking
        /// </summary>
        /// <created>
        ///  <atuhor>DIVI Group</atuhor>
        ///  <date>2018.10.23</date>
        /// </created>
        /// <param name="pName"></param>
        /// <returns></returns>
        public static Variable GetVariable(string pName)
        {
            if (Interpreter.IsBreakpoint) { return null; }

            string name = pName.Trim();
            if (!Graphics.Variables.ContainsKey( name ))
            {
                Interpreter.AddError(string.Format("Variable [{0}] does not exists", pName));
                return null;
            }
            else
            {
                return Graphics.Variables[name];
            }
        }


        /// <summary>
        /// Creates new variable
        /// </summary>
        /// <created>
        ///  <author>DIVI Group</author>
        ///  <date>2018.10.23</date>
        /// </created>
        /// <param name="pName"></param>
        /// <param name=""></param>
        /// <param name="pValue"></param>
        public static Variable NewVariable(string pName, Variable.VarType pType, string pValue) {

            if (Interpreter.IsBreakpoint) { return null; }

            // rise error if variable allready exists
            if (Graphics.Variables.ContainsKey(pName))
            {
                Interpreter.AddError(string.Format("Variable [{0}] already exists", pName));
                return null;
            }
            else
            {
                Variable v = new Variable(pName, pType, pValue);
                Graphics.Variables.Add( pName, v );
                return v;
            }

        }



        /// <summary>
        /// Set variable value
        /// </summary>
        /// <created>
        ///  <author>DIVI Group</author>
        ///  <date>2018.10.23</date>
        /// </created>
        /// <param name="pName"></param>
        /// <param name="pType"></param>
        /// <param name="pValue"></param>
        public static void SetVariable(string pName, Variable.VarType pType, string pValue) {

            if (! Interpreter.IsBreakpoint) { 

                if (Graphics.Variables.ContainsKey(pName))
                {
                    if (Graphics.Variables[pName].type == pType)
                    {
                        Graphics.Variables[pName].value = pValue;
                    }
                    else
                    {
                        Interpreter.AddError(string.Format("You cannot change data type of variable [{0}]. Actual type is [{1}].", pName, pType ));
                    }
                }
                else
                {
                    Graphics.NewVariable(pName, pType, pValue); 
                }

            }

        }



        /// <summary>
        /// gets point by name
        /// </summary>
        /// <created>
        ///  <author>DIVI Group</author>
        ///  <date>2018.10.23</date>
        /// </created>
        /// <param name="pName"></param>
        /// <returns></returns>
        public static Point GetPoint(string pName) {

            if (Interpreter.IsBreakpoint) { return null; }

            // rise error if variable allready exists
            if (!Graphics.Points.ContainsKey(pName))
            {
                Interpreter.AddError(string.Format("Point with name [{0}] does not exists", pName));
                return null;
            }
            else
            {
                return Graphics.Points[pName];
            }

        }






        /// <summary>
        /// gets line by name
        /// </summary>
        /// <created>
        ///  <author>DIVI Group</author>
        ///  <date>2018.10.31</date>
        /// </created>
        /// <param name="pName"></param>
        /// <returns></returns>
        public static Line GetLine(string pName)
        {

            if (Interpreter.IsBreakpoint) { return null; }

            // rise error if variable does not exists
            if (!Graphics.Lines.ContainsKey(pName))
            {
                Interpreter.AddError(string.Format("Line with name [{0}] does not exists", pName));
                return null;
            }
            else
            {
                return Graphics.Lines[pName];
            }

        }



        #endregion Properties



        #region New objects


        /// <summary>
        /// Creates new object
        /// </summary>
        /// <created>
        ///  <author>DIVI Group</author>
        ///  <created>2018.10.23</created>
        /// </created>
        /// <param name="pClass">class name</param>
        /// <param name="pName">objects name</param>
        /// <param name="pParameters">list of construction parameters</param>
        public static void NewObject(string pClass, string pName, string pParameters) {

            if (!Interpreter.IsBreakpoint)
            {

                // error validation
                if (Graphics.Variables.ContainsKey(pName))
                {
                    Interpreter.AddError(string.Format("Object with name [{0}] already exists.", pName));
                }
                else
                {

                    switch (pClass)
                    {
                        case CLASS_POINT:
                            {
                                Graphics.NewPoint(pName, pParameters);
                                break;
                            }
                        case CLASS_LINE:
                            {
                                Graphics.NewLine(pName, pParameters);
                                break;
                            }
                        default:
                            {
                                Interpreter.AddError(string.Format("Object of type [{0}] cannot be created.", pClass));
                                break;
                            }
                    }

                }

            }

        }


        /// <summary>
        /// Adds new point to Graphics
        /// </summary>
        /// <created>
        ///  <author>DIVI Group</author>
        ///  <date>2018.10.05</date>
        /// </created>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static void NewPoint(string pName, string pParameters) {

            Console.WriteLine(  string.Format("Add Point: {0}, [{1}]", pName, pParameters) );

            // gets point
            string[] xy_param = pParameters.Split(',');

            // check if point exists
            if (Graphics.Variables.ContainsKey(pName)) {
                Interpreter.AddError(string.Format("Variable [{0}] alreadey exists", pName  ) );
            }

            // validates number of parameters
            if (xy_param.Length < 2 || xy_param.Length > 3 )
            {
                Interpreter.AddError(string.Format("Point definition should have two or three parameters!"));
            }

            // validates color type (3rd parameter)
            if (xy_param.Length == 3)
            {
                if (!Graphics.PointTypes.ContainsKey(xy_param[2]))
                {
                    Interpreter.AddError(string.Format("Point type [{0}] is not defined!", xy_param[2]));
                }
            }


            // builds coordinates
            Variable x;
            Variable y;
            String name = "";
            if (xy_param[0].EndsWith("(d)"))
            {
                name = pName + "__X__";
                x = Graphics.NewVariable(
                        pName + "__X__",
                        Variable.VarType.VAR_TYPE_SIMPLE,
                        xy_param[0].Substring(0, xy_param[0].Length - 3)
                        );
            }
            else {
                x = Graphics.GetVariable( xy_param[0] );
            };

            if (xy_param[1].EndsWith("(d)"))
            {
                name = pName + "__Y__";
                y = Graphics.NewVariable(
                        pName + "__Y__",
                        Variable.VarType.VAR_TYPE_SIMPLE,
                        xy_param[1].Substring(0, xy_param[1].Length - 3)
                        );
            }
            else
            {
                y = Graphics.GetVariable( xy_param[1] );
            };


            Graphics.NewVariable(pName, Variable.VarType.VAR_TYPE_OBJECT, CLASS_POINT);
            if (xy_param.Length == 2)   // invisible point
            {
                Graphics.Points.Add(
                        pName,
                        new Point(pName, x, y)
                    );
            }
            else // visible point with type
            {
                Graphics.Points.Add(
                        pName,
                        new Point(pName, x, y, xy_param[2])
                    );
            }

        }




        /// <summary>
        /// Adds new line to Graphics
        /// </summary>
        /// <created>
        ///  <author>DIVI Group</author>
        ///  <date>2018.10.05</date>
        /// </created>
        /// <param name="pName">line name</param>
        /// <param name="pParameters">line parameters: point names separated by comma</param>
        /// <returns></returns>
        private static void NewLine(string pName, string pParameters )
        {

            Console.WriteLine(string.Format("Add Line: {0}, [{1}]", pName, pParameters));

            // gets point
            string[] xy_param = pParameters.Split(',');

            // validates number of parameters
            if (xy_param.Length < 2 || xy_param.Length > 3)
            {
                Interpreter.AddError(string.Format("Straight line definition should have two or three parameters!"));
            }

            // validates color type (3rd parameter)
            if (xy_param.Length == 3)
            {
                if (!Graphics.LineTypes.ContainsKey(xy_param[2]))
                {
                    Interpreter.AddError(string.Format("Line type [{0}] is not defined!", xy_param[2]));
                }
            }


            // builds coordinates
            // TODO: error validation for Add Lines and get Point
            Graphics.NewVariable(pName, Variable.VarType.VAR_TYPE_OBJECT, CLASS_LINE);
            if (xy_param.Length == 2)
            {
                Elements.Graphics.Lines.Add(
                    pName,
                    new Line(
                        pName,
                        Graphics.GetPoint(xy_param[0]),
                        Graphics.GetPoint(xy_param[1])
                    )
                );
            }
            else {
                Elements.Graphics.Lines.Add(
                    pName,
                    new Line(
                        pName,
                        Graphics.GetPoint(xy_param[0]),
                        Graphics.GetPoint(xy_param[1]),
                        xy_param[2]
                    )
                );
            }

        }




        public static void Call(string pName, string pSource, string pFunction, string pParams) {


            if (Interpreter.IsBreakpoint) { return; }

            // todo: correct and ERRORS
            Console.WriteLine(string.Format("Function call: {0} = {1}.{2} ( {3} )", pName, pSource, pFunction, pParams ));

            Variable sourceVar = Graphics.GetVariable( pSource );
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
                        if (Graphics.Variables.ContainsKey(p))
                        {
                            if (Graphics.Variables[p].type == Variable.VarType.VAR_TYPE_SIMPLE)
                            {
                                realParams[i] = Graphics.GetVariable(p).value;
                            }
                            else {
                                realParams[i] = p;
                            }
                        }
                        else
                        {
                            // TODO Error
                        }
                    }
                    i++;
                }

                // executes function
                switch (sourceVar.value) {
                    case CLASS_POINT:
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
                    case CLASS_LINE:
                        switch (pFunction.ToUpper())
                        {
                            case "GETCROSSPOINT":
                                Elements.Graphics.LineGetCrossPoint(pName, pSource, realParams);
                                break;
                        }
                        break;
                }

            }
        }



        public static void AddPointOnSide(string pName, string pSource, Graphics.Direction pDir, string pLength) {

            if (Interpreter.IsBreakpoint) { return; }

            // gets current point
            Point source = Graphics.GetPoint( pSource );

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
            Graphics.NewPoint(pName, string.Format( "{0}(d),{1}(d)", x, y ));
        }


        /// <summary>
        /// Calculates crosspoint of two straight lines
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pSource"></param>
        /// <param name="pParams"></param>
        public static void LineGetCrossPoint(string pName, string pSource, string[] pParams)
        {

            // TODO: validates parametes

            // gets current point
            Line line1 = Graphics.GetLine(pSource);

            // gets other line
            Line line2 = Graphics.GetLine(pParams[0]);

            // computes result coordinates
            line1.GetCrossPoint(line2, pName );

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

            if (Interpreter.IsBreakpoint) { return ""; }


            string error = "";

            // todo: error validation
            Console.WriteLine(string.Format("Set Value: {0}.{1} [{2}]", pName, pAttribute, pValue));

            // set value
            Variable curVar = Graphics.GetVariable( pName );
            if (curVar.type == Variable.VarType.VAR_TYPE_OBJECT) {
                switch (curVar.value) {
                    case CLASS_POINT:
                        {
                            switch (pAttribute.ToUpper())
                            {
                                case "X":
                                    Graphics.GetPoint( pName ).x = Int32.Parse(pValue);
                                    break;
                                case "Y":
                                    Graphics.GetPoint( pName ).y = Int32.Parse(pValue);
                                    break;
                                case "TYPE":
                                    Graphics.GetPoint( pName ).type = pValue;
                                    break;
                                case "VISIBLE":
                                    Graphics.GetPoint(pName).visible = ( pValue.ToUpper() == "FALSE" ? false : true ) ;
                                    break;
                                default:
                                    Interpreter.AddError(string.Format("Object [{0}] of calss [{1}] has no attribute [{2}]", pName, CLASS_POINT, pAttribute));
                                    break;
                            }
                            break;
                        }
                    case CLASS_LINE:
                        {
                            switch (pAttribute.ToUpper())
                            {
                                case "TYPE":
                                    Graphics.GetLine(pName).type = pValue;
                                    break;
                                case "VISIBLE":
                                    Graphics.GetLine(pName).visible = (pValue.ToUpper() == "FALSE" ? false : true);
                                    break;
                                default:
                                    Interpreter.AddError(string.Format("Object [{0}] of calss [{1}] has no attribute [{2}]", pName, CLASS_LINE, pAttribute));
                                    break;
                            }
                            break;
                        }
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

            if (Interpreter.IsBreakpoint) { return ""; }


            string error = "";

            // 
            Console.WriteLine(string.Format("Get Value: {0}.{1}", pName, pAttribute));

            // set value
            Variable curVar = Graphics.GetVariable( pName );
            if (curVar.type == Variable.VarType.VAR_TYPE_OBJECT)
            {
                switch (curVar.value)
                {
                    case CLASS_POINT:
                        {
                            switch (pAttribute.ToUpper())
                            {
                                case "X":
                                    return Graphics.GetPoint( pName ).x.ToString();
                                    break;
                                case "Y":
                                    return Graphics.GetPoint( pName ).y.ToString();
                                    break;
                                default:
                                    Interpreter.AddError(string.Format("Object [{0}] of calss [{1}] has no attribute [{2}]", pName, CLASS_POINT, pAttribute));
                                    break;
                            }
                            break;
                        }
                    case CLASS_LINE:
                        {
                            Interpreter.AddError(string.Format("Object [{0}] of calss [{1}] has no attribute [{2}]", pName, CLASS_POINT, pAttribute));
                            break;
                        }
                }
            }

            return error;
        }


    }


}
