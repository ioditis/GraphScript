using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitDex_svg_test
{
    public static class Interpreter
    {

        #region line counter 

        // current line encounter
        private static int curLine = 0;
        public static int LineCurrent { get { return curLine; } }
        public static void LineNext() {
            ++curLine;
            //Console.WriteLine( string.Format("Move to new line: {0}", curLine) );
        }
        public static void LineReset() { curLine = 0; }

        #endregion line counter 


        #region error processing

        // errors
        private static List<string> errors = new List<string>();
        public static List<string> Errors { get { return errors; } }
        public static void AddError(string pError) {
            string errorFull = string.Format("Error in line {0}: {1}", Interpreter.LineCurrent, pError);
            errors.Add(errorFull);
            throw new Exception(errorFull);
        }

        #endregion error processing


        #region breakpoint

        // processing breakpoint
        private static int breakpointLine = -1;
        public static int BreakpointLine {
            get { return breakpointLine; }
            set { breakpointLine = value;  }
        }
        public static bool IsBreakpoint {
            get {
                return (breakpointLine == -1 ? false : curLine+1 >= breakpointLine);
            }
        }

        #endregion breakpoint


    }
}
