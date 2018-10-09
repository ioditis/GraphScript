//
// IronMeta FitDex Parser; Generated 2018-10-08 20:57:13Z UTC
//

using System;
using System.Collections.Generic;
using System.Linq;

using IronMeta.Matcher;
using Elements;

#pragma warning disable 0219
#pragma warning disable 1591

namespace FitDex_svg_test
{

    using _FitDex_Inputs = IEnumerable<char>;
    using _FitDex_Results = IEnumerable<string>;
    using _FitDex_Item = IronMeta.Matcher.MatchItem<char, string>;
    using _FitDex_Args = IEnumerable<IronMeta.Matcher.MatchItem<char, string>>;
    using _FitDex_Memo = IronMeta.Matcher.MatchState<char, string>;
    using _FitDex_Rule = System.Action<IronMeta.Matcher.MatchState<char, string>, int, IEnumerable<IronMeta.Matcher.MatchItem<char, string>>>;
    using _FitDex_Base = IronMeta.Matcher.Matcher<char, string>;

    public partial class FitDex : Matcher<char, string>
    {
        public FitDex()
            : base()
        {
            _setTerminals();
        }

        public FitDex(bool handle_left_recursion)
            : base(handle_left_recursion)
        {
            _setTerminals();
        }

        void _setTerminals()
        {
            this.Terminals = new HashSet<string>()
            {
                "Attribute",
                "ClassAttributeValue",
                "ClassName",
                "Comma",
                "Digit",
                "Digits",
                "EOL",
                "Eq",
                "Function",
                "Letter",
                "NewClass",
                "NL",
                "ObjectName",
                "ParameterEnd",
                "ParameterStart",
                "Script",
                "Space",
                "Statement",
                "Variable",
                "VariableValue",
            };
        }


        public void Script(_FitDex_Memo _memo, int _index, _FitDex_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // AND 0
            int _start_i0 = _index;

            // STAR 1
            int _start_i1 = _index;
            var _res1 = Enumerable.Empty<string>();
        label1:

            // CALLORVAR NL
            _FitDex_Item _r2;

            _r2 = _MemoCall(_memo, "NL", _index, NL, null);

            if (_r2 != null) _index = _r2.NextIndex;

            // STAR 1
            var _r1 = _memo.Results.Pop();
            if (_r1 != null)
            {
                _res1 = _res1.Concat(_r1.Results);
                goto label1;
            }
            else
            {
                _memo.Results.Push(new _FitDex_Item(_start_i1, _index, _memo.InputEnumerable, _res1.Where(_NON_NULL), true));
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label0; }

            // STAR 3
            int _start_i3 = _index;
            var _res3 = Enumerable.Empty<string>();
        label3:

            // AND 4
            int _start_i4 = _index;

            // AND 5
            int _start_i5 = _index;

            // AND 6
            int _start_i6 = _index;

            // STAR 7
            int _start_i7 = _index;
            var _res7 = Enumerable.Empty<string>();
        label7:

            // CALLORVAR Space
            _FitDex_Item _r8;

            _r8 = _MemoCall(_memo, "Space", _index, Space, null);

            if (_r8 != null) _index = _r8.NextIndex;

            // STAR 7
            var _r7 = _memo.Results.Pop();
            if (_r7 != null)
            {
                _res7 = _res7.Concat(_r7.Results);
                goto label7;
            }
            else
            {
                _memo.Results.Push(new _FitDex_Item(_start_i7, _index, _memo.InputEnumerable, _res7.Where(_NON_NULL), true));
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label6; }

            // CALLORVAR Statement
            _FitDex_Item _r9;

            _r9 = _MemoCall(_memo, "Statement", _index, Statement, null);

            if (_r9 != null) _index = _r9.NextIndex;

        label6: // AND
            var _r6_2 = _memo.Results.Pop();
            var _r6_1 = _memo.Results.Pop();

            if (_r6_1 != null && _r6_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i6, _index, _memo.InputEnumerable, _r6_1.Results.Concat(_r6_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i6;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label5; }

            // STAR 10
            int _start_i10 = _index;
            var _res10 = Enumerable.Empty<string>();
        label10:

            // CALLORVAR Space
            _FitDex_Item _r11;

            _r11 = _MemoCall(_memo, "Space", _index, Space, null);

            if (_r11 != null) _index = _r11.NextIndex;

            // STAR 10
            var _r10 = _memo.Results.Pop();
            if (_r10 != null)
            {
                _res10 = _res10.Concat(_r10.Results);
                goto label10;
            }
            else
            {
                _memo.Results.Push(new _FitDex_Item(_start_i10, _index, _memo.InputEnumerable, _res10.Where(_NON_NULL), true));
            }

        label5: // AND
            var _r5_2 = _memo.Results.Pop();
            var _r5_1 = _memo.Results.Pop();

            if (_r5_1 != null && _r5_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i5, _index, _memo.InputEnumerable, _r5_1.Results.Concat(_r5_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i5;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label4; }

            // CALLORVAR EOL
            _FitDex_Item _r12;

            _r12 = _MemoCall(_memo, "EOL", _index, EOL, null);

            if (_r12 != null) _index = _r12.NextIndex;

        label4: // AND
            var _r4_2 = _memo.Results.Pop();
            var _r4_1 = _memo.Results.Pop();

            if (_r4_1 != null && _r4_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i4, _index, _memo.InputEnumerable, _r4_1.Results.Concat(_r4_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i4;
            }

            // STAR 3
            var _r3 = _memo.Results.Pop();
            if (_r3 != null)
            {
                _res3 = _res3.Concat(_r3.Results);
                goto label3;
            }
            else
            {
                _memo.Results.Push(new _FitDex_Item(_start_i3, _index, _memo.InputEnumerable, _res3.Where(_NON_NULL), true));
            }

        label0: // AND
            var _r0_2 = _memo.Results.Pop();
            var _r0_1 = _memo.Results.Pop();

            if (_r0_1 != null && _r0_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i0, _index, _memo.InputEnumerable, _r0_1.Results.Concat(_r0_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i0;
            }

        }


        public void EOL(_FitDex_Memo _memo, int _index, _FitDex_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // AND 0
            int _start_i0 = _index;

            // LITERAL ';'
            _ParseLiteralChar(_memo, ref _index, ';');

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label0; }

            // STAR 2
            int _start_i2 = _index;
            var _res2 = Enumerable.Empty<string>();
        label2:

            // OR 3
            int _start_i3 = _index;

            // CALLORVAR Space
            _FitDex_Item _r4;

            _r4 = _MemoCall(_memo, "Space", _index, Space, null);

            if (_r4 != null) _index = _r4.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i3; } else goto label3;

            // CALLORVAR NL
            _FitDex_Item _r5;

            _r5 = _MemoCall(_memo, "NL", _index, NL, null);

            if (_r5 != null) _index = _r5.NextIndex;

        label3: // OR
            int _dummy_i3 = _index; // no-op for label

            // STAR 2
            var _r2 = _memo.Results.Pop();
            if (_r2 != null)
            {
                _res2 = _res2.Concat(_r2.Results);
                goto label2;
            }
            else
            {
                _memo.Results.Push(new _FitDex_Item(_start_i2, _index, _memo.InputEnumerable, _res2.Where(_NON_NULL), true));
            }

        label0: // AND
            var _r0_2 = _memo.Results.Pop();
            var _r0_1 = _memo.Results.Pop();

            if (_r0_1 != null && _r0_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i0, _index, _memo.InputEnumerable, _r0_1.Results.Concat(_r0_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i0;
            }

        }


        public void NL(_FitDex_Memo _memo, int _index, _FitDex_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // OR 0
            int _start_i0 = _index;

            // LITERAL '\r'
            _ParseLiteralChar(_memo, ref _index, '\r');

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i0; } else goto label0;

            // LITERAL '\n'
            _ParseLiteralChar(_memo, ref _index, '\n');

        label0: // OR
            int _dummy_i0 = _index; // no-op for label

        }


        public void Statement(_FitDex_Memo _memo, int _index, _FitDex_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // CALLORVAR VarDefinition
            _FitDex_Item _r0;

            _r0 = _MemoCall(_memo, "VarDefinition", _index, VarDefinition, null);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void VarDefinition(_FitDex_Memo _memo, int _index, _FitDex_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // OR 0
            int _start_i0 = _index;

            // OR 1
            int _start_i1 = _index;

            // CALLORVAR ClassVariable
            _FitDex_Item _r2;

            _r2 = _MemoCall(_memo, "ClassVariable", _index, ClassVariable, null);

            if (_r2 != null) _index = _r2.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i1; } else goto label1;

            // CALLORVAR SimpleVariable
            _FitDex_Item _r3;

            _r3 = _MemoCall(_memo, "SimpleVariable", _index, SimpleVariable, null);

            if (_r3 != null) _index = _r3.NextIndex;

        label1: // OR
            int _dummy_i1 = _index; // no-op for label

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i0; } else goto label0;

            // CALLORVAR ObjectAttribute
            _FitDex_Item _r4;

            _r4 = _MemoCall(_memo, "ObjectAttribute", _index, ObjectAttribute, null);

            if (_r4 != null) _index = _r4.NextIndex;

        label0: // OR
            int _dummy_i0 = _index; // no-op for label

        }


        public void SimpleVariable(_FitDex_Memo _memo, int _index, _FitDex_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            _FitDex_Item v = null;
            _FitDex_Item d = null;

            // AND 1
            int _start_i1 = _index;

            // AND 2
            int _start_i2 = _index;

            // AND 3
            int _start_i3 = _index;

            // AND 4
            int _start_i4 = _index;

            // CALLORVAR Variable
            _FitDex_Item _r6;

            _r6 = _MemoCall(_memo, "Variable", _index, Variable, null);

            if (_r6 != null) _index = _r6.NextIndex;

            // BIND v
            v = _memo.Results.Peek();

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label4; }

            // STAR 7
            int _start_i7 = _index;
            var _res7 = Enumerable.Empty<string>();
        label7:

            // CALLORVAR Space
            _FitDex_Item _r8;

            _r8 = _MemoCall(_memo, "Space", _index, Space, null);

            if (_r8 != null) _index = _r8.NextIndex;

            // STAR 7
            var _r7 = _memo.Results.Pop();
            if (_r7 != null)
            {
                _res7 = _res7.Concat(_r7.Results);
                goto label7;
            }
            else
            {
                _memo.Results.Push(new _FitDex_Item(_start_i7, _index, _memo.InputEnumerable, _res7.Where(_NON_NULL), true));
            }

        label4: // AND
            var _r4_2 = _memo.Results.Pop();
            var _r4_1 = _memo.Results.Pop();

            if (_r4_1 != null && _r4_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i4, _index, _memo.InputEnumerable, _r4_1.Results.Concat(_r4_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i4;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label3; }

            // CALLORVAR Eq
            _FitDex_Item _r9;

            _r9 = _MemoCall(_memo, "Eq", _index, Eq, null);

            if (_r9 != null) _index = _r9.NextIndex;

        label3: // AND
            var _r3_2 = _memo.Results.Pop();
            var _r3_1 = _memo.Results.Pop();

            if (_r3_1 != null && _r3_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i3, _index, _memo.InputEnumerable, _r3_1.Results.Concat(_r3_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i3;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label2; }

            // STAR 10
            int _start_i10 = _index;
            var _res10 = Enumerable.Empty<string>();
        label10:

            // CALLORVAR Space
            _FitDex_Item _r11;

            _r11 = _MemoCall(_memo, "Space", _index, Space, null);

            if (_r11 != null) _index = _r11.NextIndex;

            // STAR 10
            var _r10 = _memo.Results.Pop();
            if (_r10 != null)
            {
                _res10 = _res10.Concat(_r10.Results);
                goto label10;
            }
            else
            {
                _memo.Results.Push(new _FitDex_Item(_start_i10, _index, _memo.InputEnumerable, _res10.Where(_NON_NULL), true));
            }

        label2: // AND
            var _r2_2 = _memo.Results.Pop();
            var _r2_1 = _memo.Results.Pop();

            if (_r2_1 != null && _r2_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i2, _index, _memo.InputEnumerable, _r2_1.Results.Concat(_r2_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i2;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label1; }

            // PLUS 13
            int _start_i13 = _index;
            var _res13 = Enumerable.Empty<string>();
        label13:

            // CALLORVAR ExpressionNumeric
            _FitDex_Item _r14;

            _r14 = _MemoCall(_memo, "ExpressionNumeric", _index, ExpressionNumeric, null);

            if (_r14 != null) _index = _r14.NextIndex;

            // PLUS 13
            var _r13 = _memo.Results.Pop();
            if (_r13 != null)
            {
                _res13 = _res13.Concat(_r13.Results);
                goto label13;
            }
            else
            {
                if (_index > _start_i13)
                    _memo.Results.Push(new _FitDex_Item(_start_i13, _index, _memo.InputEnumerable, _res13.Where(_NON_NULL), true));
                else
                    _memo.Results.Push(null);
            }

            // BIND d
            d = _memo.Results.Peek();

        label1: // AND
            var _r1_2 = _memo.Results.Pop();
            var _r1_1 = _memo.Results.Pop();

            if (_r1_1 != null && _r1_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i1, _index, _memo.InputEnumerable, _r1_1.Results.Concat(_r1_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i1;
            }

            // ACT
            var _r0 = _memo.Results.Peek();
            if (_r0 != null)
            {
                _memo.Results.Pop();
                _memo.Results.Push( new _FitDex_Item(_r0.StartIndex, _r0.NextIndex, _memo.InputEnumerable, _Thunk(_IM_Result => { string vName = string.Concat( v.Inputs );
            string value = string.Concat( d.Results );

            if (Elements.Graphics.Variables.ContainsKey( vName )) {
                Elements.Graphics.Variables[vName].value = value;
            } 
            else
            {
                Elements.Graphics.Variables.Add( 
                    vName, 
                    new Elements.Variable( vName, Elements.Variable.VarType.VAR_TYPE_SIMPLE, value )
                    );
            }

            return "OK"; }, _r0), true) );
            }

        }


        public void ClassVariable(_FitDex_Memo _memo, int _index, _FitDex_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            _FitDex_Item v = null;
            _FitDex_Item c = null;
            _FitDex_Item p = null;
            _FitDex_Item f = null;

            // OR 0
            int _start_i0 = _index;

            // AND 2
            int _start_i2 = _index;

            // AND 3
            int _start_i3 = _index;

            // AND 4
            int _start_i4 = _index;

            // AND 5
            int _start_i5 = _index;

            // AND 6
            int _start_i6 = _index;

            // AND 7
            int _start_i7 = _index;

            // AND 8
            int _start_i8 = _index;

            // CALLORVAR Variable
            _FitDex_Item _r10;

            _r10 = _MemoCall(_memo, "Variable", _index, Variable, null);

            if (_r10 != null) _index = _r10.NextIndex;

            // BIND v
            v = _memo.Results.Peek();

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label8; }

            // CALLORVAR NewClass
            _FitDex_Item _r11;

            _r11 = _MemoCall(_memo, "NewClass", _index, NewClass, null);

            if (_r11 != null) _index = _r11.NextIndex;

        label8: // AND
            var _r8_2 = _memo.Results.Pop();
            var _r8_1 = _memo.Results.Pop();

            if (_r8_1 != null && _r8_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i8, _index, _memo.InputEnumerable, _r8_1.Results.Concat(_r8_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i8;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label7; }

            // CALLORVAR ClassName
            _FitDex_Item _r13;

            _r13 = _MemoCall(_memo, "ClassName", _index, ClassName, null);

            if (_r13 != null) _index = _r13.NextIndex;

            // BIND c
            c = _memo.Results.Peek();

        label7: // AND
            var _r7_2 = _memo.Results.Pop();
            var _r7_1 = _memo.Results.Pop();

            if (_r7_1 != null && _r7_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i7, _index, _memo.InputEnumerable, _r7_1.Results.Concat(_r7_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i7;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label6; }

            // CALLORVAR ParameterStart
            _FitDex_Item _r14;

            _r14 = _MemoCall(_memo, "ParameterStart", _index, ParameterStart, null);

            if (_r14 != null) _index = _r14.NextIndex;

        label6: // AND
            var _r6_2 = _memo.Results.Pop();
            var _r6_1 = _memo.Results.Pop();

            if (_r6_1 != null && _r6_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i6, _index, _memo.InputEnumerable, _r6_1.Results.Concat(_r6_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i6;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label5; }

            // STAR 15
            int _start_i15 = _index;
            var _res15 = Enumerable.Empty<string>();
        label15:

            // CALLORVAR Space
            _FitDex_Item _r16;

            _r16 = _MemoCall(_memo, "Space", _index, Space, null);

            if (_r16 != null) _index = _r16.NextIndex;

            // STAR 15
            var _r15 = _memo.Results.Pop();
            if (_r15 != null)
            {
                _res15 = _res15.Concat(_r15.Results);
                goto label15;
            }
            else
            {
                _memo.Results.Push(new _FitDex_Item(_start_i15, _index, _memo.InputEnumerable, _res15.Where(_NON_NULL), true));
            }

        label5: // AND
            var _r5_2 = _memo.Results.Pop();
            var _r5_1 = _memo.Results.Pop();

            if (_r5_1 != null && _r5_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i5, _index, _memo.InputEnumerable, _r5_1.Results.Concat(_r5_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i5;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label4; }

            // CALLORVAR Parameters
            _FitDex_Item _r19;

            _r19 = _MemoCall(_memo, "Parameters", _index, Parameters, null);

            if (_r19 != null) _index = _r19.NextIndex;

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

            // BIND p
            p = _memo.Results.Peek();

        label4: // AND
            var _r4_2 = _memo.Results.Pop();
            var _r4_1 = _memo.Results.Pop();

            if (_r4_1 != null && _r4_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i4, _index, _memo.InputEnumerable, _r4_1.Results.Concat(_r4_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i4;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label3; }

            // STAR 20
            int _start_i20 = _index;
            var _res20 = Enumerable.Empty<string>();
        label20:

            // CALLORVAR Space
            _FitDex_Item _r21;

            _r21 = _MemoCall(_memo, "Space", _index, Space, null);

            if (_r21 != null) _index = _r21.NextIndex;

            // STAR 20
            var _r20 = _memo.Results.Pop();
            if (_r20 != null)
            {
                _res20 = _res20.Concat(_r20.Results);
                goto label20;
            }
            else
            {
                _memo.Results.Push(new _FitDex_Item(_start_i20, _index, _memo.InputEnumerable, _res20.Where(_NON_NULL), true));
            }

        label3: // AND
            var _r3_2 = _memo.Results.Pop();
            var _r3_1 = _memo.Results.Pop();

            if (_r3_1 != null && _r3_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i3, _index, _memo.InputEnumerable, _r3_1.Results.Concat(_r3_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i3;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label2; }

            // CALLORVAR ParameterEnd
            _FitDex_Item _r22;

            _r22 = _MemoCall(_memo, "ParameterEnd", _index, ParameterEnd, null);

            if (_r22 != null) _index = _r22.NextIndex;

        label2: // AND
            var _r2_2 = _memo.Results.Pop();
            var _r2_1 = _memo.Results.Pop();

            if (_r2_1 != null && _r2_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i2, _index, _memo.InputEnumerable, _r2_1.Results.Concat(_r2_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i2;
            }

            // ACT
            var _r1 = _memo.Results.Peek();
            if (_r1 != null)
            {
                _memo.Results.Pop();
                _memo.Results.Push( new _FitDex_Item(_r1.StartIndex, _r1.NextIndex, _memo.InputEnumerable, _Thunk(_IM_Result => { string cName = string.Concat( c.Inputs );
            string vName = string.Concat( v.Inputs );

            switch (cName)
            {
                case "Point":
                    Elements.Graphics.AddPoint( vName, string.Concat(p.Results) );
                    break;
                case "Line":
                    Elements.Graphics.AddLine( vName, string.Concat(p.Results) );
                    break;
            }
            return "OK"; }, _r1), true) );
            }

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i0; } else goto label0;

            // AND 24
            int _start_i24 = _index;

            // AND 25
            int _start_i25 = _index;

            // AND 26
            int _start_i26 = _index;

            // AND 27
            int _start_i27 = _index;

            // AND 28
            int _start_i28 = _index;

            // AND 29
            int _start_i29 = _index;

            // AND 30
            int _start_i30 = _index;

            // AND 31
            int _start_i31 = _index;

            // AND 32
            int _start_i32 = _index;

            // CALLORVAR Variable
            _FitDex_Item _r34;

            _r34 = _MemoCall(_memo, "Variable", _index, Variable, null);

            if (_r34 != null) _index = _r34.NextIndex;

            // BIND v
            v = _memo.Results.Peek();

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label32; }

            // CALLORVAR Eq
            _FitDex_Item _r35;

            _r35 = _MemoCall(_memo, "Eq", _index, Eq, null);

            if (_r35 != null) _index = _r35.NextIndex;

        label32: // AND
            var _r32_2 = _memo.Results.Pop();
            var _r32_1 = _memo.Results.Pop();

            if (_r32_1 != null && _r32_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i32, _index, _memo.InputEnumerable, _r32_1.Results.Concat(_r32_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i32;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label31; }

            // CALLORVAR ClassName
            _FitDex_Item _r37;

            _r37 = _MemoCall(_memo, "ClassName", _index, ClassName, null);

            if (_r37 != null) _index = _r37.NextIndex;

            // BIND c
            c = _memo.Results.Peek();

        label31: // AND
            var _r31_2 = _memo.Results.Pop();
            var _r31_1 = _memo.Results.Pop();

            if (_r31_1 != null && _r31_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i31, _index, _memo.InputEnumerable, _r31_1.Results.Concat(_r31_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i31;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label30; }

            // LITERAL '.'
            _ParseLiteralChar(_memo, ref _index, '.');

        label30: // AND
            var _r30_2 = _memo.Results.Pop();
            var _r30_1 = _memo.Results.Pop();

            if (_r30_1 != null && _r30_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i30, _index, _memo.InputEnumerable, _r30_1.Results.Concat(_r30_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i30;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label29; }

            // CALLORVAR Function
            _FitDex_Item _r40;

            _r40 = _MemoCall(_memo, "Function", _index, Function, null);

            if (_r40 != null) _index = _r40.NextIndex;

            // BIND f
            f = _memo.Results.Peek();

        label29: // AND
            var _r29_2 = _memo.Results.Pop();
            var _r29_1 = _memo.Results.Pop();

            if (_r29_1 != null && _r29_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i29, _index, _memo.InputEnumerable, _r29_1.Results.Concat(_r29_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i29;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label28; }

            // CALLORVAR ParameterStart
            _FitDex_Item _r41;

            _r41 = _MemoCall(_memo, "ParameterStart", _index, ParameterStart, null);

            if (_r41 != null) _index = _r41.NextIndex;

        label28: // AND
            var _r28_2 = _memo.Results.Pop();
            var _r28_1 = _memo.Results.Pop();

            if (_r28_1 != null && _r28_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i28, _index, _memo.InputEnumerable, _r28_1.Results.Concat(_r28_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i28;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label27; }

            // STAR 42
            int _start_i42 = _index;
            var _res42 = Enumerable.Empty<string>();
        label42:

            // CALLORVAR Space
            _FitDex_Item _r43;

            _r43 = _MemoCall(_memo, "Space", _index, Space, null);

            if (_r43 != null) _index = _r43.NextIndex;

            // STAR 42
            var _r42 = _memo.Results.Pop();
            if (_r42 != null)
            {
                _res42 = _res42.Concat(_r42.Results);
                goto label42;
            }
            else
            {
                _memo.Results.Push(new _FitDex_Item(_start_i42, _index, _memo.InputEnumerable, _res42.Where(_NON_NULL), true));
            }

        label27: // AND
            var _r27_2 = _memo.Results.Pop();
            var _r27_1 = _memo.Results.Pop();

            if (_r27_1 != null && _r27_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i27, _index, _memo.InputEnumerable, _r27_1.Results.Concat(_r27_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i27;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label26; }

            // CALLORVAR Parameters
            _FitDex_Item _r46;

            _r46 = _MemoCall(_memo, "Parameters", _index, Parameters, null);

            if (_r46 != null) _index = _r46.NextIndex;

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

            // BIND p
            p = _memo.Results.Peek();

        label26: // AND
            var _r26_2 = _memo.Results.Pop();
            var _r26_1 = _memo.Results.Pop();

            if (_r26_1 != null && _r26_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i26, _index, _memo.InputEnumerable, _r26_1.Results.Concat(_r26_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i26;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label25; }

            // STAR 47
            int _start_i47 = _index;
            var _res47 = Enumerable.Empty<string>();
        label47:

            // CALLORVAR Space
            _FitDex_Item _r48;

            _r48 = _MemoCall(_memo, "Space", _index, Space, null);

            if (_r48 != null) _index = _r48.NextIndex;

            // STAR 47
            var _r47 = _memo.Results.Pop();
            if (_r47 != null)
            {
                _res47 = _res47.Concat(_r47.Results);
                goto label47;
            }
            else
            {
                _memo.Results.Push(new _FitDex_Item(_start_i47, _index, _memo.InputEnumerable, _res47.Where(_NON_NULL), true));
            }

        label25: // AND
            var _r25_2 = _memo.Results.Pop();
            var _r25_1 = _memo.Results.Pop();

            if (_r25_1 != null && _r25_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i25, _index, _memo.InputEnumerable, _r25_1.Results.Concat(_r25_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i25;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label24; }

            // CALLORVAR ParameterEnd
            _FitDex_Item _r49;

            _r49 = _MemoCall(_memo, "ParameterEnd", _index, ParameterEnd, null);

            if (_r49 != null) _index = _r49.NextIndex;

        label24: // AND
            var _r24_2 = _memo.Results.Pop();
            var _r24_1 = _memo.Results.Pop();

            if (_r24_1 != null && _r24_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i24, _index, _memo.InputEnumerable, _r24_1.Results.Concat(_r24_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i24;
            }

            // ACT
            var _r23 = _memo.Results.Peek();
            if (_r23 != null)
            {
                _memo.Results.Pop();
                _memo.Results.Push( new _FitDex_Item(_r23.StartIndex, _r23.NextIndex, _memo.InputEnumerable, _Thunk(_IM_Result => { string vName = string.Concat( v.Inputs );
            string cName = string.Concat( c.Inputs );
            string fName = string.Concat( f.Inputs );

            Console.WriteLine( string.Format("Function call: {0} = {1}.{2}", vName, cName, fName) );

            Elements.Graphics.Call( vName, cName, fName, string.Concat(p.Results ) );

            return "OK"; }, _r23), true) );
            }

        label0: // OR
            int _dummy_i0 = _index; // no-op for label

        }


        public void ObjectAttribute(_FitDex_Memo _memo, int _index, _FitDex_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            _FitDex_Item v = null;
            _FitDex_Item a = null;
            _FitDex_Item d = null;

            // AND 1
            int _start_i1 = _index;

            // AND 2
            int _start_i2 = _index;

            // AND 3
            int _start_i3 = _index;

            // AND 4
            int _start_i4 = _index;

            // CALLORVAR Variable
            _FitDex_Item _r6;

            _r6 = _MemoCall(_memo, "Variable", _index, Variable, null);

            if (_r6 != null) _index = _r6.NextIndex;

            // BIND v
            v = _memo.Results.Peek();

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label4; }

            // LITERAL '.'
            _ParseLiteralChar(_memo, ref _index, '.');

        label4: // AND
            var _r4_2 = _memo.Results.Pop();
            var _r4_1 = _memo.Results.Pop();

            if (_r4_1 != null && _r4_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i4, _index, _memo.InputEnumerable, _r4_1.Results.Concat(_r4_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i4;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label3; }

            // CALLORVAR Attribute
            _FitDex_Item _r9;

            _r9 = _MemoCall(_memo, "Attribute", _index, Attribute, null);

            if (_r9 != null) _index = _r9.NextIndex;

            // BIND a
            a = _memo.Results.Peek();

        label3: // AND
            var _r3_2 = _memo.Results.Pop();
            var _r3_1 = _memo.Results.Pop();

            if (_r3_1 != null && _r3_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i3, _index, _memo.InputEnumerable, _r3_1.Results.Concat(_r3_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i3;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label2; }

            // CALLORVAR Eq
            _FitDex_Item _r10;

            _r10 = _MemoCall(_memo, "Eq", _index, Eq, null);

            if (_r10 != null) _index = _r10.NextIndex;

        label2: // AND
            var _r2_2 = _memo.Results.Pop();
            var _r2_1 = _memo.Results.Pop();

            if (_r2_1 != null && _r2_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i2, _index, _memo.InputEnumerable, _r2_1.Results.Concat(_r2_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i2;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label1; }

            // CALLORVAR ExpressionNumeric
            _FitDex_Item _r12;

            _r12 = _MemoCall(_memo, "ExpressionNumeric", _index, ExpressionNumeric, null);

            if (_r12 != null) _index = _r12.NextIndex;

            // BIND d
            d = _memo.Results.Peek();

        label1: // AND
            var _r1_2 = _memo.Results.Pop();
            var _r1_1 = _memo.Results.Pop();

            if (_r1_1 != null && _r1_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i1, _index, _memo.InputEnumerable, _r1_1.Results.Concat(_r1_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i1;
            }

            // ACT
            var _r0 = _memo.Results.Peek();
            if (_r0 != null)
            {
                _memo.Results.Pop();
                _memo.Results.Push( new _FitDex_Item(_r0.StartIndex, _r0.NextIndex, _memo.InputEnumerable, _Thunk(_IM_Result => { Elements.Graphics.SetProperty(
                string.Concat( v.Inputs ),
                string.Concat( a.Inputs ),
                string.Concat( d.Results )
            );

            return "OK"; }, _r0), true) );
            }

        }


        public void Variable(_FitDex_Memo _memo, int _index, _FitDex_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // CALLORVAR ObjectName
            _FitDex_Item _r0;

            _r0 = _MemoCall(_memo, "ObjectName", _index, ObjectName, null);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void ClassName(_FitDex_Memo _memo, int _index, _FitDex_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // CALLORVAR ObjectName
            _FitDex_Item _r0;

            _r0 = _MemoCall(_memo, "ObjectName", _index, ObjectName, null);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void Attribute(_FitDex_Memo _memo, int _index, _FitDex_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // CALLORVAR ObjectName
            _FitDex_Item _r0;

            _r0 = _MemoCall(_memo, "ObjectName", _index, ObjectName, null);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void Function(_FitDex_Memo _memo, int _index, _FitDex_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // CALLORVAR ObjectName
            _FitDex_Item _r0;

            _r0 = _MemoCall(_memo, "ObjectName", _index, ObjectName, null);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void Parameters(_FitDex_Memo _memo, int _index, _FitDex_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            _FitDex_Item p = null;
            _FitDex_Item ps = null;

            // OR 0
            int _start_i0 = _index;

            // AND 2
            int _start_i2 = _index;

            // AND 3
            int _start_i3 = _index;

            // CALLORVAR Param
            _FitDex_Item _r5;

            _r5 = _MemoCall(_memo, "Param", _index, Param, null);

            if (_r5 != null) _index = _r5.NextIndex;

            // BIND p
            p = _memo.Results.Peek();

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label3; }

            // CALLORVAR Comma
            _FitDex_Item _r6;

            _r6 = _MemoCall(_memo, "Comma", _index, Comma, null);

            if (_r6 != null) _index = _r6.NextIndex;

        label3: // AND
            var _r3_2 = _memo.Results.Pop();
            var _r3_1 = _memo.Results.Pop();

            if (_r3_1 != null && _r3_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i3, _index, _memo.InputEnumerable, _r3_1.Results.Concat(_r3_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i3;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label2; }

            // CALLORVAR Parameters
            _FitDex_Item _r8;

            _r8 = _MemoCall(_memo, "Parameters", _index, Parameters, null);

            if (_r8 != null) _index = _r8.NextIndex;

            // BIND ps
            ps = _memo.Results.Peek();

        label2: // AND
            var _r2_2 = _memo.Results.Pop();
            var _r2_1 = _memo.Results.Pop();

            if (_r2_1 != null && _r2_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i2, _index, _memo.InputEnumerable, _r2_1.Results.Concat(_r2_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i2;
            }

            // ACT
            var _r1 = _memo.Results.Peek();
            if (_r1 != null)
            {
                _memo.Results.Pop();
                _memo.Results.Push( new _FitDex_Item(_r1.StartIndex, _r1.NextIndex, _memo.InputEnumerable, _Thunk(_IM_Result => { return p + "," + ps ; }, _r1), true) );
            }

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i0; } else goto label0;

            // CALLORVAR Param
            _FitDex_Item _r11;

            _r11 = _MemoCall(_memo, "Param", _index, Param, null);

            if (_r11 != null) _index = _r11.NextIndex;

            // BIND p
            p = _memo.Results.Peek();

            // ACT
            var _r9 = _memo.Results.Peek();
            if (_r9 != null)
            {
                _memo.Results.Pop();
                _memo.Results.Push( new _FitDex_Item(_r9.StartIndex, _r9.NextIndex, _memo.InputEnumerable, _Thunk(_IM_Result => { return p; }, _r9), true) );
            }

        label0: // OR
            int _dummy_i0 = _index; // no-op for label

        }


        public void Param(_FitDex_Memo _memo, int _index, _FitDex_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            _FitDex_Item v = null;
            _FitDex_Item d = null;

            // OR 0
            int _start_i0 = _index;

            // CALLORVAR Variable
            _FitDex_Item _r3;

            _r3 = _MemoCall(_memo, "Variable", _index, Variable, null);

            if (_r3 != null) _index = _r3.NextIndex;

            // BIND v
            v = _memo.Results.Peek();

            // ACT
            var _r1 = _memo.Results.Peek();
            if (_r1 != null)
            {
                _memo.Results.Pop();
                _memo.Results.Push( new _FitDex_Item(_r1.StartIndex, _r1.NextIndex, _memo.InputEnumerable, _Thunk(_IM_Result => { return string.Concat( v.Inputs ); }, _r1), true) );
            }

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i0; } else goto label0;

            // AND 6
            int _start_i6 = _index;

            // AND 7
            int _start_i7 = _index;

            // AND 8
            int _start_i8 = _index;

            // AND 9
            int _start_i9 = _index;

            // AND 10
            int _start_i10 = _index;

            // OR 11
            int _start_i11 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r12;

            _r12 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r12 != null) _index = _r12.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i11; } else goto label11;

            // CALLORVAR ExpressionNumeric
            _FitDex_Item _r13;

            _r13 = _MemoCall(_memo, "ExpressionNumeric", _index, ExpressionNumeric, null);

            if (_r13 != null) _index = _r13.NextIndex;

        label11: // OR
            int _dummy_i11 = _index; // no-op for label

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label10; }

            // OR 15
            int _start_i15 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r16;

            _r16 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r16 != null) _index = _r16.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i15; } else goto label15;

            // CALLORVAR ExpressionNumeric
            _FitDex_Item _r17;

            _r17 = _MemoCall(_memo, "ExpressionNumeric", _index, ExpressionNumeric, null);

            if (_r17 != null) _index = _r17.NextIndex;

        label15: // OR
            int _dummy_i15 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label10: // AND
            var _r10_2 = _memo.Results.Pop();
            var _r10_1 = _memo.Results.Pop();

            if (_r10_1 != null && _r10_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i10, _index, _memo.InputEnumerable, _r10_1.Results.Concat(_r10_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i10;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label9; }

            // OR 19
            int _start_i19 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r20;

            _r20 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r20 != null) _index = _r20.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i19; } else goto label19;

            // CALLORVAR ExpressionNumeric
            _FitDex_Item _r21;

            _r21 = _MemoCall(_memo, "ExpressionNumeric", _index, ExpressionNumeric, null);

            if (_r21 != null) _index = _r21.NextIndex;

        label19: // OR
            int _dummy_i19 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label9: // AND
            var _r9_2 = _memo.Results.Pop();
            var _r9_1 = _memo.Results.Pop();

            if (_r9_1 != null && _r9_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i9, _index, _memo.InputEnumerable, _r9_1.Results.Concat(_r9_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i9;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label8; }

            // OR 23
            int _start_i23 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r24;

            _r24 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r24 != null) _index = _r24.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i23; } else goto label23;

            // CALLORVAR ExpressionNumeric
            _FitDex_Item _r25;

            _r25 = _MemoCall(_memo, "ExpressionNumeric", _index, ExpressionNumeric, null);

            if (_r25 != null) _index = _r25.NextIndex;

        label23: // OR
            int _dummy_i23 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label8: // AND
            var _r8_2 = _memo.Results.Pop();
            var _r8_1 = _memo.Results.Pop();

            if (_r8_1 != null && _r8_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i8, _index, _memo.InputEnumerable, _r8_1.Results.Concat(_r8_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i8;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label7; }

            // OR 27
            int _start_i27 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r28;

            _r28 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r28 != null) _index = _r28.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i27; } else goto label27;

            // CALLORVAR ExpressionNumeric
            _FitDex_Item _r29;

            _r29 = _MemoCall(_memo, "ExpressionNumeric", _index, ExpressionNumeric, null);

            if (_r29 != null) _index = _r29.NextIndex;

        label27: // OR
            int _dummy_i27 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label7: // AND
            var _r7_2 = _memo.Results.Pop();
            var _r7_1 = _memo.Results.Pop();

            if (_r7_1 != null && _r7_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i7, _index, _memo.InputEnumerable, _r7_1.Results.Concat(_r7_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i7;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label6; }

            // OR 31
            int _start_i31 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r32;

            _r32 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r32 != null) _index = _r32.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i31; } else goto label31;

            // CALLORVAR ExpressionNumeric
            _FitDex_Item _r33;

            _r33 = _MemoCall(_memo, "ExpressionNumeric", _index, ExpressionNumeric, null);

            if (_r33 != null) _index = _r33.NextIndex;

        label31: // OR
            int _dummy_i31 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label6: // AND
            var _r6_2 = _memo.Results.Pop();
            var _r6_1 = _memo.Results.Pop();

            if (_r6_1 != null && _r6_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i6, _index, _memo.InputEnumerable, _r6_1.Results.Concat(_r6_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i6;
            }

            // BIND d
            d = _memo.Results.Peek();

            // ACT
            var _r4 = _memo.Results.Peek();
            if (_r4 != null)
            {
                _memo.Results.Pop();
                _memo.Results.Push( new _FitDex_Item(_r4.StartIndex, _r4.NextIndex, _memo.InputEnumerable, _Thunk(_IM_Result => { return string.Concat( d.Inputs )+"(d)"; }, _r4), true) );
            }

        label0: // OR
            int _dummy_i0 = _index; // no-op for label

        }


        public void ObjectName(_FitDex_Memo _memo, int _index, _FitDex_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // AND 0
            int _start_i0 = _index;

            // CALLORVAR Letter
            _FitDex_Item _r1;

            _r1 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r1 != null) _index = _r1.NextIndex;

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label0; }

            // AND 2
            int _start_i2 = _index;

            // AND 3
            int _start_i3 = _index;

            // AND 4
            int _start_i4 = _index;

            // AND 5
            int _start_i5 = _index;

            // AND 6
            int _start_i6 = _index;

            // AND 7
            int _start_i7 = _index;

            // AND 8
            int _start_i8 = _index;

            // AND 9
            int _start_i9 = _index;

            // AND 10
            int _start_i10 = _index;

            // AND 11
            int _start_i11 = _index;

            // AND 12
            int _start_i12 = _index;

            // AND 13
            int _start_i13 = _index;

            // AND 14
            int _start_i14 = _index;

            // AND 15
            int _start_i15 = _index;

            // AND 16
            int _start_i16 = _index;

            // AND 17
            int _start_i17 = _index;

            // AND 18
            int _start_i18 = _index;

            // AND 19
            int _start_i19 = _index;

            // AND 20
            int _start_i20 = _index;

            // AND 21
            int _start_i21 = _index;

            // AND 22
            int _start_i22 = _index;

            // AND 23
            int _start_i23 = _index;

            // AND 24
            int _start_i24 = _index;

            // AND 25
            int _start_i25 = _index;

            // AND 26
            int _start_i26 = _index;

            // AND 27
            int _start_i27 = _index;

            // AND 28
            int _start_i28 = _index;

            // AND 29
            int _start_i29 = _index;

            // AND 30
            int _start_i30 = _index;

            // AND 31
            int _start_i31 = _index;

            // AND 32
            int _start_i32 = _index;

            // AND 33
            int _start_i33 = _index;

            // AND 34
            int _start_i34 = _index;

            // AND 35
            int _start_i35 = _index;

            // AND 36
            int _start_i36 = _index;

            // AND 37
            int _start_i37 = _index;

            // AND 38
            int _start_i38 = _index;

            // AND 39
            int _start_i39 = _index;

            // AND 40
            int _start_i40 = _index;

            // AND 41
            int _start_i41 = _index;

            // AND 42
            int _start_i42 = _index;

            // AND 43
            int _start_i43 = _index;

            // AND 44
            int _start_i44 = _index;

            // AND 45
            int _start_i45 = _index;

            // AND 46
            int _start_i46 = _index;

            // AND 47
            int _start_i47 = _index;

            // AND 48
            int _start_i48 = _index;

            // AND 49
            int _start_i49 = _index;

            // AND 50
            int _start_i50 = _index;

            // OR 52
            int _start_i52 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r53;

            _r53 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r53 != null) _index = _r53.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i52; } else goto label52;

            // CALLORVAR Letter
            _FitDex_Item _r54;

            _r54 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r54 != null) _index = _r54.NextIndex;

        label52: // OR
            int _dummy_i52 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label50; }

            // OR 56
            int _start_i56 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r57;

            _r57 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r57 != null) _index = _r57.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i56; } else goto label56;

            // CALLORVAR Letter
            _FitDex_Item _r58;

            _r58 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r58 != null) _index = _r58.NextIndex;

        label56: // OR
            int _dummy_i56 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label50: // AND
            var _r50_2 = _memo.Results.Pop();
            var _r50_1 = _memo.Results.Pop();

            if (_r50_1 != null && _r50_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i50, _index, _memo.InputEnumerable, _r50_1.Results.Concat(_r50_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i50;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label49; }

            // OR 60
            int _start_i60 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r61;

            _r61 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r61 != null) _index = _r61.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i60; } else goto label60;

            // CALLORVAR Letter
            _FitDex_Item _r62;

            _r62 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r62 != null) _index = _r62.NextIndex;

        label60: // OR
            int _dummy_i60 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label49: // AND
            var _r49_2 = _memo.Results.Pop();
            var _r49_1 = _memo.Results.Pop();

            if (_r49_1 != null && _r49_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i49, _index, _memo.InputEnumerable, _r49_1.Results.Concat(_r49_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i49;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label48; }

            // OR 64
            int _start_i64 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r65;

            _r65 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r65 != null) _index = _r65.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i64; } else goto label64;

            // CALLORVAR Letter
            _FitDex_Item _r66;

            _r66 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r66 != null) _index = _r66.NextIndex;

        label64: // OR
            int _dummy_i64 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label48: // AND
            var _r48_2 = _memo.Results.Pop();
            var _r48_1 = _memo.Results.Pop();

            if (_r48_1 != null && _r48_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i48, _index, _memo.InputEnumerable, _r48_1.Results.Concat(_r48_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i48;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label47; }

            // OR 68
            int _start_i68 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r69;

            _r69 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r69 != null) _index = _r69.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i68; } else goto label68;

            // CALLORVAR Letter
            _FitDex_Item _r70;

            _r70 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r70 != null) _index = _r70.NextIndex;

        label68: // OR
            int _dummy_i68 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label47: // AND
            var _r47_2 = _memo.Results.Pop();
            var _r47_1 = _memo.Results.Pop();

            if (_r47_1 != null && _r47_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i47, _index, _memo.InputEnumerable, _r47_1.Results.Concat(_r47_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i47;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label46; }

            // OR 72
            int _start_i72 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r73;

            _r73 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r73 != null) _index = _r73.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i72; } else goto label72;

            // CALLORVAR Letter
            _FitDex_Item _r74;

            _r74 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r74 != null) _index = _r74.NextIndex;

        label72: // OR
            int _dummy_i72 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label46: // AND
            var _r46_2 = _memo.Results.Pop();
            var _r46_1 = _memo.Results.Pop();

            if (_r46_1 != null && _r46_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i46, _index, _memo.InputEnumerable, _r46_1.Results.Concat(_r46_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i46;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label45; }

            // OR 76
            int _start_i76 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r77;

            _r77 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r77 != null) _index = _r77.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i76; } else goto label76;

            // CALLORVAR Letter
            _FitDex_Item _r78;

            _r78 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r78 != null) _index = _r78.NextIndex;

        label76: // OR
            int _dummy_i76 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label45: // AND
            var _r45_2 = _memo.Results.Pop();
            var _r45_1 = _memo.Results.Pop();

            if (_r45_1 != null && _r45_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i45, _index, _memo.InputEnumerable, _r45_1.Results.Concat(_r45_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i45;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label44; }

            // OR 80
            int _start_i80 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r81;

            _r81 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r81 != null) _index = _r81.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i80; } else goto label80;

            // CALLORVAR Letter
            _FitDex_Item _r82;

            _r82 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r82 != null) _index = _r82.NextIndex;

        label80: // OR
            int _dummy_i80 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label44: // AND
            var _r44_2 = _memo.Results.Pop();
            var _r44_1 = _memo.Results.Pop();

            if (_r44_1 != null && _r44_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i44, _index, _memo.InputEnumerable, _r44_1.Results.Concat(_r44_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i44;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label43; }

            // OR 84
            int _start_i84 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r85;

            _r85 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r85 != null) _index = _r85.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i84; } else goto label84;

            // CALLORVAR Letter
            _FitDex_Item _r86;

            _r86 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r86 != null) _index = _r86.NextIndex;

        label84: // OR
            int _dummy_i84 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label43: // AND
            var _r43_2 = _memo.Results.Pop();
            var _r43_1 = _memo.Results.Pop();

            if (_r43_1 != null && _r43_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i43, _index, _memo.InputEnumerable, _r43_1.Results.Concat(_r43_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i43;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label42; }

            // OR 88
            int _start_i88 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r89;

            _r89 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r89 != null) _index = _r89.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i88; } else goto label88;

            // CALLORVAR Letter
            _FitDex_Item _r90;

            _r90 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r90 != null) _index = _r90.NextIndex;

        label88: // OR
            int _dummy_i88 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label42: // AND
            var _r42_2 = _memo.Results.Pop();
            var _r42_1 = _memo.Results.Pop();

            if (_r42_1 != null && _r42_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i42, _index, _memo.InputEnumerable, _r42_1.Results.Concat(_r42_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i42;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label41; }

            // OR 92
            int _start_i92 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r93;

            _r93 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r93 != null) _index = _r93.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i92; } else goto label92;

            // CALLORVAR Letter
            _FitDex_Item _r94;

            _r94 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r94 != null) _index = _r94.NextIndex;

        label92: // OR
            int _dummy_i92 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label41: // AND
            var _r41_2 = _memo.Results.Pop();
            var _r41_1 = _memo.Results.Pop();

            if (_r41_1 != null && _r41_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i41, _index, _memo.InputEnumerable, _r41_1.Results.Concat(_r41_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i41;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label40; }

            // OR 96
            int _start_i96 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r97;

            _r97 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r97 != null) _index = _r97.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i96; } else goto label96;

            // CALLORVAR Letter
            _FitDex_Item _r98;

            _r98 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r98 != null) _index = _r98.NextIndex;

        label96: // OR
            int _dummy_i96 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label40: // AND
            var _r40_2 = _memo.Results.Pop();
            var _r40_1 = _memo.Results.Pop();

            if (_r40_1 != null && _r40_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i40, _index, _memo.InputEnumerable, _r40_1.Results.Concat(_r40_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i40;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label39; }

            // OR 100
            int _start_i100 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r101;

            _r101 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r101 != null) _index = _r101.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i100; } else goto label100;

            // CALLORVAR Letter
            _FitDex_Item _r102;

            _r102 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r102 != null) _index = _r102.NextIndex;

        label100: // OR
            int _dummy_i100 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label39: // AND
            var _r39_2 = _memo.Results.Pop();
            var _r39_1 = _memo.Results.Pop();

            if (_r39_1 != null && _r39_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i39, _index, _memo.InputEnumerable, _r39_1.Results.Concat(_r39_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i39;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label38; }

            // OR 104
            int _start_i104 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r105;

            _r105 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r105 != null) _index = _r105.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i104; } else goto label104;

            // CALLORVAR Letter
            _FitDex_Item _r106;

            _r106 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r106 != null) _index = _r106.NextIndex;

        label104: // OR
            int _dummy_i104 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label38: // AND
            var _r38_2 = _memo.Results.Pop();
            var _r38_1 = _memo.Results.Pop();

            if (_r38_1 != null && _r38_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i38, _index, _memo.InputEnumerable, _r38_1.Results.Concat(_r38_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i38;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label37; }

            // OR 108
            int _start_i108 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r109;

            _r109 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r109 != null) _index = _r109.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i108; } else goto label108;

            // CALLORVAR Letter
            _FitDex_Item _r110;

            _r110 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r110 != null) _index = _r110.NextIndex;

        label108: // OR
            int _dummy_i108 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label37: // AND
            var _r37_2 = _memo.Results.Pop();
            var _r37_1 = _memo.Results.Pop();

            if (_r37_1 != null && _r37_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i37, _index, _memo.InputEnumerable, _r37_1.Results.Concat(_r37_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i37;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label36; }

            // OR 112
            int _start_i112 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r113;

            _r113 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r113 != null) _index = _r113.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i112; } else goto label112;

            // CALLORVAR Letter
            _FitDex_Item _r114;

            _r114 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r114 != null) _index = _r114.NextIndex;

        label112: // OR
            int _dummy_i112 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label36: // AND
            var _r36_2 = _memo.Results.Pop();
            var _r36_1 = _memo.Results.Pop();

            if (_r36_1 != null && _r36_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i36, _index, _memo.InputEnumerable, _r36_1.Results.Concat(_r36_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i36;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label35; }

            // OR 116
            int _start_i116 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r117;

            _r117 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r117 != null) _index = _r117.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i116; } else goto label116;

            // CALLORVAR Letter
            _FitDex_Item _r118;

            _r118 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r118 != null) _index = _r118.NextIndex;

        label116: // OR
            int _dummy_i116 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label35: // AND
            var _r35_2 = _memo.Results.Pop();
            var _r35_1 = _memo.Results.Pop();

            if (_r35_1 != null && _r35_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i35, _index, _memo.InputEnumerable, _r35_1.Results.Concat(_r35_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i35;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label34; }

            // OR 120
            int _start_i120 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r121;

            _r121 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r121 != null) _index = _r121.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i120; } else goto label120;

            // CALLORVAR Letter
            _FitDex_Item _r122;

            _r122 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r122 != null) _index = _r122.NextIndex;

        label120: // OR
            int _dummy_i120 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label34: // AND
            var _r34_2 = _memo.Results.Pop();
            var _r34_1 = _memo.Results.Pop();

            if (_r34_1 != null && _r34_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i34, _index, _memo.InputEnumerable, _r34_1.Results.Concat(_r34_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i34;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label33; }

            // OR 124
            int _start_i124 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r125;

            _r125 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r125 != null) _index = _r125.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i124; } else goto label124;

            // CALLORVAR Letter
            _FitDex_Item _r126;

            _r126 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r126 != null) _index = _r126.NextIndex;

        label124: // OR
            int _dummy_i124 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label33: // AND
            var _r33_2 = _memo.Results.Pop();
            var _r33_1 = _memo.Results.Pop();

            if (_r33_1 != null && _r33_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i33, _index, _memo.InputEnumerable, _r33_1.Results.Concat(_r33_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i33;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label32; }

            // OR 128
            int _start_i128 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r129;

            _r129 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r129 != null) _index = _r129.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i128; } else goto label128;

            // CALLORVAR Letter
            _FitDex_Item _r130;

            _r130 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r130 != null) _index = _r130.NextIndex;

        label128: // OR
            int _dummy_i128 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label32: // AND
            var _r32_2 = _memo.Results.Pop();
            var _r32_1 = _memo.Results.Pop();

            if (_r32_1 != null && _r32_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i32, _index, _memo.InputEnumerable, _r32_1.Results.Concat(_r32_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i32;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label31; }

            // OR 132
            int _start_i132 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r133;

            _r133 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r133 != null) _index = _r133.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i132; } else goto label132;

            // CALLORVAR Letter
            _FitDex_Item _r134;

            _r134 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r134 != null) _index = _r134.NextIndex;

        label132: // OR
            int _dummy_i132 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label31: // AND
            var _r31_2 = _memo.Results.Pop();
            var _r31_1 = _memo.Results.Pop();

            if (_r31_1 != null && _r31_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i31, _index, _memo.InputEnumerable, _r31_1.Results.Concat(_r31_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i31;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label30; }

            // OR 136
            int _start_i136 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r137;

            _r137 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r137 != null) _index = _r137.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i136; } else goto label136;

            // CALLORVAR Letter
            _FitDex_Item _r138;

            _r138 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r138 != null) _index = _r138.NextIndex;

        label136: // OR
            int _dummy_i136 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label30: // AND
            var _r30_2 = _memo.Results.Pop();
            var _r30_1 = _memo.Results.Pop();

            if (_r30_1 != null && _r30_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i30, _index, _memo.InputEnumerable, _r30_1.Results.Concat(_r30_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i30;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label29; }

            // OR 140
            int _start_i140 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r141;

            _r141 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r141 != null) _index = _r141.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i140; } else goto label140;

            // CALLORVAR Letter
            _FitDex_Item _r142;

            _r142 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r142 != null) _index = _r142.NextIndex;

        label140: // OR
            int _dummy_i140 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label29: // AND
            var _r29_2 = _memo.Results.Pop();
            var _r29_1 = _memo.Results.Pop();

            if (_r29_1 != null && _r29_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i29, _index, _memo.InputEnumerable, _r29_1.Results.Concat(_r29_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i29;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label28; }

            // OR 144
            int _start_i144 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r145;

            _r145 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r145 != null) _index = _r145.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i144; } else goto label144;

            // CALLORVAR Letter
            _FitDex_Item _r146;

            _r146 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r146 != null) _index = _r146.NextIndex;

        label144: // OR
            int _dummy_i144 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label28: // AND
            var _r28_2 = _memo.Results.Pop();
            var _r28_1 = _memo.Results.Pop();

            if (_r28_1 != null && _r28_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i28, _index, _memo.InputEnumerable, _r28_1.Results.Concat(_r28_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i28;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label27; }

            // OR 148
            int _start_i148 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r149;

            _r149 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r149 != null) _index = _r149.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i148; } else goto label148;

            // CALLORVAR Letter
            _FitDex_Item _r150;

            _r150 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r150 != null) _index = _r150.NextIndex;

        label148: // OR
            int _dummy_i148 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label27: // AND
            var _r27_2 = _memo.Results.Pop();
            var _r27_1 = _memo.Results.Pop();

            if (_r27_1 != null && _r27_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i27, _index, _memo.InputEnumerable, _r27_1.Results.Concat(_r27_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i27;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label26; }

            // OR 152
            int _start_i152 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r153;

            _r153 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r153 != null) _index = _r153.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i152; } else goto label152;

            // CALLORVAR Letter
            _FitDex_Item _r154;

            _r154 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r154 != null) _index = _r154.NextIndex;

        label152: // OR
            int _dummy_i152 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label26: // AND
            var _r26_2 = _memo.Results.Pop();
            var _r26_1 = _memo.Results.Pop();

            if (_r26_1 != null && _r26_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i26, _index, _memo.InputEnumerable, _r26_1.Results.Concat(_r26_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i26;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label25; }

            // OR 156
            int _start_i156 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r157;

            _r157 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r157 != null) _index = _r157.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i156; } else goto label156;

            // CALLORVAR Letter
            _FitDex_Item _r158;

            _r158 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r158 != null) _index = _r158.NextIndex;

        label156: // OR
            int _dummy_i156 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label25: // AND
            var _r25_2 = _memo.Results.Pop();
            var _r25_1 = _memo.Results.Pop();

            if (_r25_1 != null && _r25_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i25, _index, _memo.InputEnumerable, _r25_1.Results.Concat(_r25_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i25;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label24; }

            // OR 160
            int _start_i160 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r161;

            _r161 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r161 != null) _index = _r161.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i160; } else goto label160;

            // CALLORVAR Letter
            _FitDex_Item _r162;

            _r162 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r162 != null) _index = _r162.NextIndex;

        label160: // OR
            int _dummy_i160 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label24: // AND
            var _r24_2 = _memo.Results.Pop();
            var _r24_1 = _memo.Results.Pop();

            if (_r24_1 != null && _r24_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i24, _index, _memo.InputEnumerable, _r24_1.Results.Concat(_r24_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i24;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label23; }

            // OR 164
            int _start_i164 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r165;

            _r165 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r165 != null) _index = _r165.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i164; } else goto label164;

            // CALLORVAR Letter
            _FitDex_Item _r166;

            _r166 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r166 != null) _index = _r166.NextIndex;

        label164: // OR
            int _dummy_i164 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label23: // AND
            var _r23_2 = _memo.Results.Pop();
            var _r23_1 = _memo.Results.Pop();

            if (_r23_1 != null && _r23_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i23, _index, _memo.InputEnumerable, _r23_1.Results.Concat(_r23_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i23;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label22; }

            // OR 168
            int _start_i168 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r169;

            _r169 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r169 != null) _index = _r169.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i168; } else goto label168;

            // CALLORVAR Letter
            _FitDex_Item _r170;

            _r170 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r170 != null) _index = _r170.NextIndex;

        label168: // OR
            int _dummy_i168 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label22: // AND
            var _r22_2 = _memo.Results.Pop();
            var _r22_1 = _memo.Results.Pop();

            if (_r22_1 != null && _r22_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i22, _index, _memo.InputEnumerable, _r22_1.Results.Concat(_r22_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i22;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label21; }

            // OR 172
            int _start_i172 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r173;

            _r173 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r173 != null) _index = _r173.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i172; } else goto label172;

            // CALLORVAR Letter
            _FitDex_Item _r174;

            _r174 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r174 != null) _index = _r174.NextIndex;

        label172: // OR
            int _dummy_i172 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label21: // AND
            var _r21_2 = _memo.Results.Pop();
            var _r21_1 = _memo.Results.Pop();

            if (_r21_1 != null && _r21_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i21, _index, _memo.InputEnumerable, _r21_1.Results.Concat(_r21_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i21;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label20; }

            // OR 176
            int _start_i176 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r177;

            _r177 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r177 != null) _index = _r177.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i176; } else goto label176;

            // CALLORVAR Letter
            _FitDex_Item _r178;

            _r178 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r178 != null) _index = _r178.NextIndex;

        label176: // OR
            int _dummy_i176 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label20: // AND
            var _r20_2 = _memo.Results.Pop();
            var _r20_1 = _memo.Results.Pop();

            if (_r20_1 != null && _r20_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i20, _index, _memo.InputEnumerable, _r20_1.Results.Concat(_r20_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i20;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label19; }

            // OR 180
            int _start_i180 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r181;

            _r181 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r181 != null) _index = _r181.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i180; } else goto label180;

            // CALLORVAR Letter
            _FitDex_Item _r182;

            _r182 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r182 != null) _index = _r182.NextIndex;

        label180: // OR
            int _dummy_i180 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label19: // AND
            var _r19_2 = _memo.Results.Pop();
            var _r19_1 = _memo.Results.Pop();

            if (_r19_1 != null && _r19_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i19, _index, _memo.InputEnumerable, _r19_1.Results.Concat(_r19_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i19;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label18; }

            // OR 184
            int _start_i184 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r185;

            _r185 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r185 != null) _index = _r185.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i184; } else goto label184;

            // CALLORVAR Letter
            _FitDex_Item _r186;

            _r186 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r186 != null) _index = _r186.NextIndex;

        label184: // OR
            int _dummy_i184 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label18: // AND
            var _r18_2 = _memo.Results.Pop();
            var _r18_1 = _memo.Results.Pop();

            if (_r18_1 != null && _r18_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i18, _index, _memo.InputEnumerable, _r18_1.Results.Concat(_r18_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i18;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label17; }

            // OR 188
            int _start_i188 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r189;

            _r189 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r189 != null) _index = _r189.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i188; } else goto label188;

            // CALLORVAR Letter
            _FitDex_Item _r190;

            _r190 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r190 != null) _index = _r190.NextIndex;

        label188: // OR
            int _dummy_i188 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label17: // AND
            var _r17_2 = _memo.Results.Pop();
            var _r17_1 = _memo.Results.Pop();

            if (_r17_1 != null && _r17_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i17, _index, _memo.InputEnumerable, _r17_1.Results.Concat(_r17_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i17;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label16; }

            // OR 192
            int _start_i192 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r193;

            _r193 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r193 != null) _index = _r193.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i192; } else goto label192;

            // CALLORVAR Letter
            _FitDex_Item _r194;

            _r194 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r194 != null) _index = _r194.NextIndex;

        label192: // OR
            int _dummy_i192 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label16: // AND
            var _r16_2 = _memo.Results.Pop();
            var _r16_1 = _memo.Results.Pop();

            if (_r16_1 != null && _r16_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i16, _index, _memo.InputEnumerable, _r16_1.Results.Concat(_r16_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i16;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label15; }

            // OR 196
            int _start_i196 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r197;

            _r197 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r197 != null) _index = _r197.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i196; } else goto label196;

            // CALLORVAR Letter
            _FitDex_Item _r198;

            _r198 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r198 != null) _index = _r198.NextIndex;

        label196: // OR
            int _dummy_i196 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label15: // AND
            var _r15_2 = _memo.Results.Pop();
            var _r15_1 = _memo.Results.Pop();

            if (_r15_1 != null && _r15_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i15, _index, _memo.InputEnumerable, _r15_1.Results.Concat(_r15_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i15;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label14; }

            // OR 200
            int _start_i200 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r201;

            _r201 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r201 != null) _index = _r201.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i200; } else goto label200;

            // CALLORVAR Letter
            _FitDex_Item _r202;

            _r202 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r202 != null) _index = _r202.NextIndex;

        label200: // OR
            int _dummy_i200 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label14: // AND
            var _r14_2 = _memo.Results.Pop();
            var _r14_1 = _memo.Results.Pop();

            if (_r14_1 != null && _r14_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i14, _index, _memo.InputEnumerable, _r14_1.Results.Concat(_r14_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i14;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label13; }

            // OR 204
            int _start_i204 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r205;

            _r205 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r205 != null) _index = _r205.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i204; } else goto label204;

            // CALLORVAR Letter
            _FitDex_Item _r206;

            _r206 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r206 != null) _index = _r206.NextIndex;

        label204: // OR
            int _dummy_i204 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label13: // AND
            var _r13_2 = _memo.Results.Pop();
            var _r13_1 = _memo.Results.Pop();

            if (_r13_1 != null && _r13_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i13, _index, _memo.InputEnumerable, _r13_1.Results.Concat(_r13_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i13;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label12; }

            // OR 208
            int _start_i208 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r209;

            _r209 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r209 != null) _index = _r209.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i208; } else goto label208;

            // CALLORVAR Letter
            _FitDex_Item _r210;

            _r210 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r210 != null) _index = _r210.NextIndex;

        label208: // OR
            int _dummy_i208 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label12: // AND
            var _r12_2 = _memo.Results.Pop();
            var _r12_1 = _memo.Results.Pop();

            if (_r12_1 != null && _r12_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i12, _index, _memo.InputEnumerable, _r12_1.Results.Concat(_r12_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i12;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label11; }

            // OR 212
            int _start_i212 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r213;

            _r213 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r213 != null) _index = _r213.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i212; } else goto label212;

            // CALLORVAR Letter
            _FitDex_Item _r214;

            _r214 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r214 != null) _index = _r214.NextIndex;

        label212: // OR
            int _dummy_i212 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label11: // AND
            var _r11_2 = _memo.Results.Pop();
            var _r11_1 = _memo.Results.Pop();

            if (_r11_1 != null && _r11_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i11, _index, _memo.InputEnumerable, _r11_1.Results.Concat(_r11_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i11;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label10; }

            // OR 216
            int _start_i216 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r217;

            _r217 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r217 != null) _index = _r217.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i216; } else goto label216;

            // CALLORVAR Letter
            _FitDex_Item _r218;

            _r218 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r218 != null) _index = _r218.NextIndex;

        label216: // OR
            int _dummy_i216 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label10: // AND
            var _r10_2 = _memo.Results.Pop();
            var _r10_1 = _memo.Results.Pop();

            if (_r10_1 != null && _r10_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i10, _index, _memo.InputEnumerable, _r10_1.Results.Concat(_r10_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i10;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label9; }

            // OR 220
            int _start_i220 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r221;

            _r221 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r221 != null) _index = _r221.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i220; } else goto label220;

            // CALLORVAR Letter
            _FitDex_Item _r222;

            _r222 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r222 != null) _index = _r222.NextIndex;

        label220: // OR
            int _dummy_i220 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label9: // AND
            var _r9_2 = _memo.Results.Pop();
            var _r9_1 = _memo.Results.Pop();

            if (_r9_1 != null && _r9_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i9, _index, _memo.InputEnumerable, _r9_1.Results.Concat(_r9_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i9;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label8; }

            // OR 224
            int _start_i224 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r225;

            _r225 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r225 != null) _index = _r225.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i224; } else goto label224;

            // CALLORVAR Letter
            _FitDex_Item _r226;

            _r226 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r226 != null) _index = _r226.NextIndex;

        label224: // OR
            int _dummy_i224 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label8: // AND
            var _r8_2 = _memo.Results.Pop();
            var _r8_1 = _memo.Results.Pop();

            if (_r8_1 != null && _r8_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i8, _index, _memo.InputEnumerable, _r8_1.Results.Concat(_r8_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i8;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label7; }

            // OR 228
            int _start_i228 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r229;

            _r229 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r229 != null) _index = _r229.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i228; } else goto label228;

            // CALLORVAR Letter
            _FitDex_Item _r230;

            _r230 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r230 != null) _index = _r230.NextIndex;

        label228: // OR
            int _dummy_i228 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label7: // AND
            var _r7_2 = _memo.Results.Pop();
            var _r7_1 = _memo.Results.Pop();

            if (_r7_1 != null && _r7_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i7, _index, _memo.InputEnumerable, _r7_1.Results.Concat(_r7_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i7;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label6; }

            // OR 232
            int _start_i232 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r233;

            _r233 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r233 != null) _index = _r233.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i232; } else goto label232;

            // CALLORVAR Letter
            _FitDex_Item _r234;

            _r234 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r234 != null) _index = _r234.NextIndex;

        label232: // OR
            int _dummy_i232 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label6: // AND
            var _r6_2 = _memo.Results.Pop();
            var _r6_1 = _memo.Results.Pop();

            if (_r6_1 != null && _r6_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i6, _index, _memo.InputEnumerable, _r6_1.Results.Concat(_r6_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i6;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label5; }

            // OR 236
            int _start_i236 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r237;

            _r237 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r237 != null) _index = _r237.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i236; } else goto label236;

            // CALLORVAR Letter
            _FitDex_Item _r238;

            _r238 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r238 != null) _index = _r238.NextIndex;

        label236: // OR
            int _dummy_i236 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label5: // AND
            var _r5_2 = _memo.Results.Pop();
            var _r5_1 = _memo.Results.Pop();

            if (_r5_1 != null && _r5_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i5, _index, _memo.InputEnumerable, _r5_1.Results.Concat(_r5_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i5;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label4; }

            // OR 240
            int _start_i240 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r241;

            _r241 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r241 != null) _index = _r241.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i240; } else goto label240;

            // CALLORVAR Letter
            _FitDex_Item _r242;

            _r242 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r242 != null) _index = _r242.NextIndex;

        label240: // OR
            int _dummy_i240 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label4: // AND
            var _r4_2 = _memo.Results.Pop();
            var _r4_1 = _memo.Results.Pop();

            if (_r4_1 != null && _r4_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i4, _index, _memo.InputEnumerable, _r4_1.Results.Concat(_r4_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i4;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label3; }

            // OR 244
            int _start_i244 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r245;

            _r245 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r245 != null) _index = _r245.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i244; } else goto label244;

            // CALLORVAR Letter
            _FitDex_Item _r246;

            _r246 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r246 != null) _index = _r246.NextIndex;

        label244: // OR
            int _dummy_i244 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label3: // AND
            var _r3_2 = _memo.Results.Pop();
            var _r3_1 = _memo.Results.Pop();

            if (_r3_1 != null && _r3_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i3, _index, _memo.InputEnumerable, _r3_1.Results.Concat(_r3_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i3;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label2; }

            // OR 248
            int _start_i248 = _index;

            // CALLORVAR Digit
            _FitDex_Item _r249;

            _r249 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r249 != null) _index = _r249.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i248; } else goto label248;

            // CALLORVAR Letter
            _FitDex_Item _r250;

            _r250 = _MemoCall(_memo, "Letter", _index, Letter, null);

            if (_r250 != null) _index = _r250.NextIndex;

        label248: // OR
            int _dummy_i248 = _index; // no-op for label

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _FitDex_Item(_index, _memo.InputEnumerable)); }

        label2: // AND
            var _r2_2 = _memo.Results.Pop();
            var _r2_1 = _memo.Results.Pop();

            if (_r2_1 != null && _r2_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i2, _index, _memo.InputEnumerable, _r2_1.Results.Concat(_r2_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i2;
            }

        label0: // AND
            var _r0_2 = _memo.Results.Pop();
            var _r0_1 = _memo.Results.Pop();

            if (_r0_1 != null && _r0_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i0, _index, _memo.InputEnumerable, _r0_1.Results.Concat(_r0_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i0;
            }

        }


        public void NewClass(_FitDex_Memo _memo, int _index, _FitDex_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // AND 0
            int _start_i0 = _index;

            // AND 1
            int _start_i1 = _index;

            // AND 2
            int _start_i2 = _index;

            // AND 3
            int _start_i3 = _index;

            // STAR 4
            int _start_i4 = _index;
            var _res4 = Enumerable.Empty<string>();
        label4:

            // CALLORVAR Space
            _FitDex_Item _r5;

            _r5 = _MemoCall(_memo, "Space", _index, Space, null);

            if (_r5 != null) _index = _r5.NextIndex;

            // STAR 4
            var _r4 = _memo.Results.Pop();
            if (_r4 != null)
            {
                _res4 = _res4.Concat(_r4.Results);
                goto label4;
            }
            else
            {
                _memo.Results.Push(new _FitDex_Item(_start_i4, _index, _memo.InputEnumerable, _res4.Where(_NON_NULL), true));
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label3; }

            // CALLORVAR Eq
            _FitDex_Item _r6;

            _r6 = _MemoCall(_memo, "Eq", _index, Eq, null);

            if (_r6 != null) _index = _r6.NextIndex;

        label3: // AND
            var _r3_2 = _memo.Results.Pop();
            var _r3_1 = _memo.Results.Pop();

            if (_r3_1 != null && _r3_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i3, _index, _memo.InputEnumerable, _r3_1.Results.Concat(_r3_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i3;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label2; }

            // STAR 7
            int _start_i7 = _index;
            var _res7 = Enumerable.Empty<string>();
        label7:

            // CALLORVAR Space
            _FitDex_Item _r8;

            _r8 = _MemoCall(_memo, "Space", _index, Space, null);

            if (_r8 != null) _index = _r8.NextIndex;

            // STAR 7
            var _r7 = _memo.Results.Pop();
            if (_r7 != null)
            {
                _res7 = _res7.Concat(_r7.Results);
                goto label7;
            }
            else
            {
                _memo.Results.Push(new _FitDex_Item(_start_i7, _index, _memo.InputEnumerable, _res7.Where(_NON_NULL), true));
            }

        label2: // AND
            var _r2_2 = _memo.Results.Pop();
            var _r2_1 = _memo.Results.Pop();

            if (_r2_1 != null && _r2_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i2, _index, _memo.InputEnumerable, _r2_1.Results.Concat(_r2_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i2;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label1; }

            // LITERAL "new "
            _ParseLiteralString(_memo, ref _index, "new ");

        label1: // AND
            var _r1_2 = _memo.Results.Pop();
            var _r1_1 = _memo.Results.Pop();

            if (_r1_1 != null && _r1_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i1, _index, _memo.InputEnumerable, _r1_1.Results.Concat(_r1_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i1;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label0; }

            // STAR 10
            int _start_i10 = _index;
            var _res10 = Enumerable.Empty<string>();
        label10:

            // CALLORVAR Space
            _FitDex_Item _r11;

            _r11 = _MemoCall(_memo, "Space", _index, Space, null);

            if (_r11 != null) _index = _r11.NextIndex;

            // STAR 10
            var _r10 = _memo.Results.Pop();
            if (_r10 != null)
            {
                _res10 = _res10.Concat(_r10.Results);
                goto label10;
            }
            else
            {
                _memo.Results.Push(new _FitDex_Item(_start_i10, _index, _memo.InputEnumerable, _res10.Where(_NON_NULL), true));
            }

        label0: // AND
            var _r0_2 = _memo.Results.Pop();
            var _r0_1 = _memo.Results.Pop();

            if (_r0_1 != null && _r0_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i0, _index, _memo.InputEnumerable, _r0_1.Results.Concat(_r0_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i0;
            }

        }


        public void ExpressionNumeric(_FitDex_Memo _memo, int _index, _FitDex_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // OR 0
            int _start_i0 = _index;

            // OR 2
            int _start_i2 = _index;

            // OR 3
            int _start_i3 = _index;

            // OR 4
            int _start_i4 = _index;

            // OR 5
            int _start_i5 = _index;

            // CALLORVAR Multi
            _FitDex_Item _r6;

            _r6 = _MemoCall(_memo, "Multi", _index, Multi, null);

            if (_r6 != null) _index = _r6.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i5; } else goto label5;

            // CALLORVAR Add
            _FitDex_Item _r7;

            _r7 = _MemoCall(_memo, "Add", _index, Add, null);

            if (_r7 != null) _index = _r7.NextIndex;

        label5: // OR
            int _dummy_i5 = _index; // no-op for label

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i4; } else goto label4;

            // CALLORVAR ClassAttributeValue
            _FitDex_Item _r8;

            _r8 = _MemoCall(_memo, "ClassAttributeValue", _index, ClassAttributeValue, null);

            if (_r8 != null) _index = _r8.NextIndex;

        label4: // OR
            int _dummy_i4 = _index; // no-op for label

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i3; } else goto label3;

            // CALLORVAR VariableValue
            _FitDex_Item _r9;

            _r9 = _MemoCall(_memo, "VariableValue", _index, VariableValue, null);

            if (_r9 != null) _index = _r9.NextIndex;

        label3: // OR
            int _dummy_i3 = _index; // no-op for label

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i2; } else goto label2;

            // CALLORVAR Digits
            _FitDex_Item _r10;

            _r10 = _MemoCall(_memo, "Digits", _index, Digits, null);

            if (_r10 != null) _index = _r10.NextIndex;

        label2: // OR
            int _dummy_i2 = _index; // no-op for label

            // ACT
            var _r1 = _memo.Results.Peek();
            if (_r1 != null)
            {
                _memo.Results.Pop();
                _memo.Results.Push( new _FitDex_Item(_r1.StartIndex, _r1.NextIndex, _memo.InputEnumerable, _Thunk(_IM_Result => { return string.Concat( _IM_Result.Results ); }, _r1), true) );
            }

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i0; } else goto label0;

            // AND 11
            int _start_i11 = _index;

            // AND 12
            int _start_i12 = _index;

            // AND 13
            int _start_i13 = _index;

            // AND 14
            int _start_i14 = _index;

            // LITERAL '('
            _ParseLiteralChar(_memo, ref _index, '(');

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label14; }

            // STAR 16
            int _start_i16 = _index;
            var _res16 = Enumerable.Empty<string>();
        label16:

            // CALLORVAR Space
            _FitDex_Item _r17;

            _r17 = _MemoCall(_memo, "Space", _index, Space, null);

            if (_r17 != null) _index = _r17.NextIndex;

            // STAR 16
            var _r16 = _memo.Results.Pop();
            if (_r16 != null)
            {
                _res16 = _res16.Concat(_r16.Results);
                goto label16;
            }
            else
            {
                _memo.Results.Push(new _FitDex_Item(_start_i16, _index, _memo.InputEnumerable, _res16.Where(_NON_NULL), true));
            }

        label14: // AND
            var _r14_2 = _memo.Results.Pop();
            var _r14_1 = _memo.Results.Pop();

            if (_r14_1 != null && _r14_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i14, _index, _memo.InputEnumerable, _r14_1.Results.Concat(_r14_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i14;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label13; }

            // CALLORVAR ExpressionNumeric
            _FitDex_Item _r18;

            _r18 = _MemoCall(_memo, "ExpressionNumeric", _index, ExpressionNumeric, null);

            if (_r18 != null) _index = _r18.NextIndex;

        label13: // AND
            var _r13_2 = _memo.Results.Pop();
            var _r13_1 = _memo.Results.Pop();

            if (_r13_1 != null && _r13_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i13, _index, _memo.InputEnumerable, _r13_1.Results.Concat(_r13_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i13;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label12; }

            // STAR 19
            int _start_i19 = _index;
            var _res19 = Enumerable.Empty<string>();
        label19:

            // CALLORVAR Space
            _FitDex_Item _r20;

            _r20 = _MemoCall(_memo, "Space", _index, Space, null);

            if (_r20 != null) _index = _r20.NextIndex;

            // STAR 19
            var _r19 = _memo.Results.Pop();
            if (_r19 != null)
            {
                _res19 = _res19.Concat(_r19.Results);
                goto label19;
            }
            else
            {
                _memo.Results.Push(new _FitDex_Item(_start_i19, _index, _memo.InputEnumerable, _res19.Where(_NON_NULL), true));
            }

        label12: // AND
            var _r12_2 = _memo.Results.Pop();
            var _r12_1 = _memo.Results.Pop();

            if (_r12_1 != null && _r12_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i12, _index, _memo.InputEnumerable, _r12_1.Results.Concat(_r12_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i12;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label11; }

            // LITERAL ')'
            _ParseLiteralChar(_memo, ref _index, ')');

        label11: // AND
            var _r11_2 = _memo.Results.Pop();
            var _r11_1 = _memo.Results.Pop();

            if (_r11_1 != null && _r11_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i11, _index, _memo.InputEnumerable, _r11_1.Results.Concat(_r11_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i11;
            }

        label0: // OR
            int _dummy_i0 = _index; // no-op for label

        }


        public void Add(_FitDex_Memo _memo, int _index, _FitDex_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            _FitDex_Item a = null;
            _FitDex_Item b = null;

            // OR 0
            int _start_i0 = _index;

            // AND 2
            int _start_i2 = _index;

            // AND 3
            int _start_i3 = _index;

            // AND 4
            int _start_i4 = _index;

            // AND 5
            int _start_i5 = _index;

            // CALLORVAR ExpressionNumeric
            _FitDex_Item _r7;

            _r7 = _MemoCall(_memo, "ExpressionNumeric", _index, ExpressionNumeric, null);

            if (_r7 != null) _index = _r7.NextIndex;

            // BIND a
            a = _memo.Results.Peek();

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label5; }

            // STAR 8
            int _start_i8 = _index;
            var _res8 = Enumerable.Empty<string>();
        label8:

            // CALLORVAR Space
            _FitDex_Item _r9;

            _r9 = _MemoCall(_memo, "Space", _index, Space, null);

            if (_r9 != null) _index = _r9.NextIndex;

            // STAR 8
            var _r8 = _memo.Results.Pop();
            if (_r8 != null)
            {
                _res8 = _res8.Concat(_r8.Results);
                goto label8;
            }
            else
            {
                _memo.Results.Push(new _FitDex_Item(_start_i8, _index, _memo.InputEnumerable, _res8.Where(_NON_NULL), true));
            }

        label5: // AND
            var _r5_2 = _memo.Results.Pop();
            var _r5_1 = _memo.Results.Pop();

            if (_r5_1 != null && _r5_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i5, _index, _memo.InputEnumerable, _r5_1.Results.Concat(_r5_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i5;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label4; }

            // LITERAL '+'
            _ParseLiteralChar(_memo, ref _index, '+');

        label4: // AND
            var _r4_2 = _memo.Results.Pop();
            var _r4_1 = _memo.Results.Pop();

            if (_r4_1 != null && _r4_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i4, _index, _memo.InputEnumerable, _r4_1.Results.Concat(_r4_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i4;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label3; }

            // STAR 11
            int _start_i11 = _index;
            var _res11 = Enumerable.Empty<string>();
        label11:

            // CALLORVAR Space
            _FitDex_Item _r12;

            _r12 = _MemoCall(_memo, "Space", _index, Space, null);

            if (_r12 != null) _index = _r12.NextIndex;

            // STAR 11
            var _r11 = _memo.Results.Pop();
            if (_r11 != null)
            {
                _res11 = _res11.Concat(_r11.Results);
                goto label11;
            }
            else
            {
                _memo.Results.Push(new _FitDex_Item(_start_i11, _index, _memo.InputEnumerable, _res11.Where(_NON_NULL), true));
            }

        label3: // AND
            var _r3_2 = _memo.Results.Pop();
            var _r3_1 = _memo.Results.Pop();

            if (_r3_1 != null && _r3_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i3, _index, _memo.InputEnumerable, _r3_1.Results.Concat(_r3_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i3;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label2; }

            // CALLORVAR ExpressionNumeric
            _FitDex_Item _r14;

            _r14 = _MemoCall(_memo, "ExpressionNumeric", _index, ExpressionNumeric, null);

            if (_r14 != null) _index = _r14.NextIndex;

            // BIND b
            b = _memo.Results.Peek();

        label2: // AND
            var _r2_2 = _memo.Results.Pop();
            var _r2_1 = _memo.Results.Pop();

            if (_r2_1 != null && _r2_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i2, _index, _memo.InputEnumerable, _r2_1.Results.Concat(_r2_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i2;
            }

            // ACT
            var _r1 = _memo.Results.Peek();
            if (_r1 != null)
            {
                _memo.Results.Pop();
                _memo.Results.Push( new _FitDex_Item(_r1.StartIndex, _r1.NextIndex, _memo.InputEnumerable, _Thunk(_IM_Result => { Console.WriteLine( string.Format("Add: {0} + {1}", string.Concat( a.Results ), string.Concat( b.Results ) ));
            return (Int32.Parse(string.Concat( a.Results )) + Int32.Parse(string.Concat( b.Results ))).ToString(); }, _r1), true) );
            }

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i0; } else goto label0;

            // AND 16
            int _start_i16 = _index;

            // AND 17
            int _start_i17 = _index;

            // AND 18
            int _start_i18 = _index;

            // AND 19
            int _start_i19 = _index;

            // CALLORVAR ExpressionNumeric
            _FitDex_Item _r21;

            _r21 = _MemoCall(_memo, "ExpressionNumeric", _index, ExpressionNumeric, null);

            if (_r21 != null) _index = _r21.NextIndex;

            // BIND a
            a = _memo.Results.Peek();

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label19; }

            // STAR 22
            int _start_i22 = _index;
            var _res22 = Enumerable.Empty<string>();
        label22:

            // CALLORVAR Space
            _FitDex_Item _r23;

            _r23 = _MemoCall(_memo, "Space", _index, Space, null);

            if (_r23 != null) _index = _r23.NextIndex;

            // STAR 22
            var _r22 = _memo.Results.Pop();
            if (_r22 != null)
            {
                _res22 = _res22.Concat(_r22.Results);
                goto label22;
            }
            else
            {
                _memo.Results.Push(new _FitDex_Item(_start_i22, _index, _memo.InputEnumerable, _res22.Where(_NON_NULL), true));
            }

        label19: // AND
            var _r19_2 = _memo.Results.Pop();
            var _r19_1 = _memo.Results.Pop();

            if (_r19_1 != null && _r19_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i19, _index, _memo.InputEnumerable, _r19_1.Results.Concat(_r19_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i19;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label18; }

            // LITERAL '-'
            _ParseLiteralChar(_memo, ref _index, '-');

        label18: // AND
            var _r18_2 = _memo.Results.Pop();
            var _r18_1 = _memo.Results.Pop();

            if (_r18_1 != null && _r18_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i18, _index, _memo.InputEnumerable, _r18_1.Results.Concat(_r18_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i18;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label17; }

            // STAR 25
            int _start_i25 = _index;
            var _res25 = Enumerable.Empty<string>();
        label25:

            // CALLORVAR Space
            _FitDex_Item _r26;

            _r26 = _MemoCall(_memo, "Space", _index, Space, null);

            if (_r26 != null) _index = _r26.NextIndex;

            // STAR 25
            var _r25 = _memo.Results.Pop();
            if (_r25 != null)
            {
                _res25 = _res25.Concat(_r25.Results);
                goto label25;
            }
            else
            {
                _memo.Results.Push(new _FitDex_Item(_start_i25, _index, _memo.InputEnumerable, _res25.Where(_NON_NULL), true));
            }

        label17: // AND
            var _r17_2 = _memo.Results.Pop();
            var _r17_1 = _memo.Results.Pop();

            if (_r17_1 != null && _r17_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i17, _index, _memo.InputEnumerable, _r17_1.Results.Concat(_r17_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i17;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label16; }

            // CALLORVAR ExpressionNumeric
            _FitDex_Item _r28;

            _r28 = _MemoCall(_memo, "ExpressionNumeric", _index, ExpressionNumeric, null);

            if (_r28 != null) _index = _r28.NextIndex;

            // BIND b
            b = _memo.Results.Peek();

        label16: // AND
            var _r16_2 = _memo.Results.Pop();
            var _r16_1 = _memo.Results.Pop();

            if (_r16_1 != null && _r16_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i16, _index, _memo.InputEnumerable, _r16_1.Results.Concat(_r16_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i16;
            }

            // ACT
            var _r15 = _memo.Results.Peek();
            if (_r15 != null)
            {
                _memo.Results.Pop();
                _memo.Results.Push( new _FitDex_Item(_r15.StartIndex, _r15.NextIndex, _memo.InputEnumerable, _Thunk(_IM_Result => { Console.WriteLine( string.Format("Minus: {0} - {1}", string.Concat( a.Results ), string.Concat( b.Results ) ));
            return (Int32.Parse(string.Concat( a.Results )) - Int32.Parse(string.Concat( b.Results ))).ToString(); }, _r15), true) );
            }

        label0: // OR
            int _dummy_i0 = _index; // no-op for label

        }


        public void Multi(_FitDex_Memo _memo, int _index, _FitDex_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            _FitDex_Item a = null;
            _FitDex_Item b = null;

            // OR 0
            int _start_i0 = _index;

            // AND 2
            int _start_i2 = _index;

            // AND 3
            int _start_i3 = _index;

            // AND 4
            int _start_i4 = _index;

            // AND 5
            int _start_i5 = _index;

            // CALLORVAR ExpressionNumeric
            _FitDex_Item _r7;

            _r7 = _MemoCall(_memo, "ExpressionNumeric", _index, ExpressionNumeric, null);

            if (_r7 != null) _index = _r7.NextIndex;

            // BIND a
            a = _memo.Results.Peek();

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label5; }

            // STAR 8
            int _start_i8 = _index;
            var _res8 = Enumerable.Empty<string>();
        label8:

            // CALLORVAR Space
            _FitDex_Item _r9;

            _r9 = _MemoCall(_memo, "Space", _index, Space, null);

            if (_r9 != null) _index = _r9.NextIndex;

            // STAR 8
            var _r8 = _memo.Results.Pop();
            if (_r8 != null)
            {
                _res8 = _res8.Concat(_r8.Results);
                goto label8;
            }
            else
            {
                _memo.Results.Push(new _FitDex_Item(_start_i8, _index, _memo.InputEnumerable, _res8.Where(_NON_NULL), true));
            }

        label5: // AND
            var _r5_2 = _memo.Results.Pop();
            var _r5_1 = _memo.Results.Pop();

            if (_r5_1 != null && _r5_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i5, _index, _memo.InputEnumerable, _r5_1.Results.Concat(_r5_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i5;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label4; }

            // LITERAL '/'
            _ParseLiteralChar(_memo, ref _index, '/');

        label4: // AND
            var _r4_2 = _memo.Results.Pop();
            var _r4_1 = _memo.Results.Pop();

            if (_r4_1 != null && _r4_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i4, _index, _memo.InputEnumerable, _r4_1.Results.Concat(_r4_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i4;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label3; }

            // STAR 11
            int _start_i11 = _index;
            var _res11 = Enumerable.Empty<string>();
        label11:

            // CALLORVAR Space
            _FitDex_Item _r12;

            _r12 = _MemoCall(_memo, "Space", _index, Space, null);

            if (_r12 != null) _index = _r12.NextIndex;

            // STAR 11
            var _r11 = _memo.Results.Pop();
            if (_r11 != null)
            {
                _res11 = _res11.Concat(_r11.Results);
                goto label11;
            }
            else
            {
                _memo.Results.Push(new _FitDex_Item(_start_i11, _index, _memo.InputEnumerable, _res11.Where(_NON_NULL), true));
            }

        label3: // AND
            var _r3_2 = _memo.Results.Pop();
            var _r3_1 = _memo.Results.Pop();

            if (_r3_1 != null && _r3_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i3, _index, _memo.InputEnumerable, _r3_1.Results.Concat(_r3_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i3;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label2; }

            // CALLORVAR ExpressionNumeric
            _FitDex_Item _r14;

            _r14 = _MemoCall(_memo, "ExpressionNumeric", _index, ExpressionNumeric, null);

            if (_r14 != null) _index = _r14.NextIndex;

            // BIND b
            b = _memo.Results.Peek();

        label2: // AND
            var _r2_2 = _memo.Results.Pop();
            var _r2_1 = _memo.Results.Pop();

            if (_r2_1 != null && _r2_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i2, _index, _memo.InputEnumerable, _r2_1.Results.Concat(_r2_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i2;
            }

            // ACT
            var _r1 = _memo.Results.Peek();
            if (_r1 != null)
            {
                _memo.Results.Pop();
                _memo.Results.Push( new _FitDex_Item(_r1.StartIndex, _r1.NextIndex, _memo.InputEnumerable, _Thunk(_IM_Result => { Console.WriteLine( string.Format("Divide: {0} / {1}", string.Concat( a.Results ), string.Concat( b.Results ) ));
            return (Int32.Parse(string.Concat( a.Results )) / Int32.Parse(string.Concat( b.Results ))).ToString(); }, _r1), true) );
            }

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i0; } else goto label0;

            // AND 16
            int _start_i16 = _index;

            // AND 17
            int _start_i17 = _index;

            // AND 18
            int _start_i18 = _index;

            // AND 19
            int _start_i19 = _index;

            // CALLORVAR ExpressionNumeric
            _FitDex_Item _r21;

            _r21 = _MemoCall(_memo, "ExpressionNumeric", _index, ExpressionNumeric, null);

            if (_r21 != null) _index = _r21.NextIndex;

            // BIND a
            a = _memo.Results.Peek();

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label19; }

            // STAR 22
            int _start_i22 = _index;
            var _res22 = Enumerable.Empty<string>();
        label22:

            // CALLORVAR Space
            _FitDex_Item _r23;

            _r23 = _MemoCall(_memo, "Space", _index, Space, null);

            if (_r23 != null) _index = _r23.NextIndex;

            // STAR 22
            var _r22 = _memo.Results.Pop();
            if (_r22 != null)
            {
                _res22 = _res22.Concat(_r22.Results);
                goto label22;
            }
            else
            {
                _memo.Results.Push(new _FitDex_Item(_start_i22, _index, _memo.InputEnumerable, _res22.Where(_NON_NULL), true));
            }

        label19: // AND
            var _r19_2 = _memo.Results.Pop();
            var _r19_1 = _memo.Results.Pop();

            if (_r19_1 != null && _r19_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i19, _index, _memo.InputEnumerable, _r19_1.Results.Concat(_r19_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i19;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label18; }

            // LITERAL '*'
            _ParseLiteralChar(_memo, ref _index, '*');

        label18: // AND
            var _r18_2 = _memo.Results.Pop();
            var _r18_1 = _memo.Results.Pop();

            if (_r18_1 != null && _r18_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i18, _index, _memo.InputEnumerable, _r18_1.Results.Concat(_r18_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i18;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label17; }

            // STAR 25
            int _start_i25 = _index;
            var _res25 = Enumerable.Empty<string>();
        label25:

            // CALLORVAR Space
            _FitDex_Item _r26;

            _r26 = _MemoCall(_memo, "Space", _index, Space, null);

            if (_r26 != null) _index = _r26.NextIndex;

            // STAR 25
            var _r25 = _memo.Results.Pop();
            if (_r25 != null)
            {
                _res25 = _res25.Concat(_r25.Results);
                goto label25;
            }
            else
            {
                _memo.Results.Push(new _FitDex_Item(_start_i25, _index, _memo.InputEnumerable, _res25.Where(_NON_NULL), true));
            }

        label17: // AND
            var _r17_2 = _memo.Results.Pop();
            var _r17_1 = _memo.Results.Pop();

            if (_r17_1 != null && _r17_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i17, _index, _memo.InputEnumerable, _r17_1.Results.Concat(_r17_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i17;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label16; }

            // CALLORVAR ExpressionNumeric
            _FitDex_Item _r28;

            _r28 = _MemoCall(_memo, "ExpressionNumeric", _index, ExpressionNumeric, null);

            if (_r28 != null) _index = _r28.NextIndex;

            // BIND b
            b = _memo.Results.Peek();

        label16: // AND
            var _r16_2 = _memo.Results.Pop();
            var _r16_1 = _memo.Results.Pop();

            if (_r16_1 != null && _r16_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i16, _index, _memo.InputEnumerable, _r16_1.Results.Concat(_r16_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i16;
            }

            // ACT
            var _r15 = _memo.Results.Peek();
            if (_r15 != null)
            {
                _memo.Results.Pop();
                _memo.Results.Push( new _FitDex_Item(_r15.StartIndex, _r15.NextIndex, _memo.InputEnumerable, _Thunk(_IM_Result => { Console.WriteLine( string.Format("Multiply: {0} x {1}", string.Concat( a.Results ), string.Concat( b.Results ) ));
            return (Int32.Parse(string.Concat( a.Results )) * Int32.Parse(string.Concat( b.Results ))).ToString(); }, _r15), true) );
            }

        label0: // OR
            int _dummy_i0 = _index; // no-op for label

        }


        public void ClassAttributeValue(_FitDex_Memo _memo, int _index, _FitDex_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            _FitDex_Item c = null;
            _FitDex_Item a = null;

            // AND 1
            int _start_i1 = _index;

            // AND 2
            int _start_i2 = _index;

            // CALLORVAR ClassName
            _FitDex_Item _r4;

            _r4 = _MemoCall(_memo, "ClassName", _index, ClassName, null);

            if (_r4 != null) _index = _r4.NextIndex;

            // BIND c
            c = _memo.Results.Peek();

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label2; }

            // LITERAL '.'
            _ParseLiteralChar(_memo, ref _index, '.');

        label2: // AND
            var _r2_2 = _memo.Results.Pop();
            var _r2_1 = _memo.Results.Pop();

            if (_r2_1 != null && _r2_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i2, _index, _memo.InputEnumerable, _r2_1.Results.Concat(_r2_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i2;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label1; }

            // CALLORVAR Attribute
            _FitDex_Item _r7;

            _r7 = _MemoCall(_memo, "Attribute", _index, Attribute, null);

            if (_r7 != null) _index = _r7.NextIndex;

            // BIND a
            a = _memo.Results.Peek();

        label1: // AND
            var _r1_2 = _memo.Results.Pop();
            var _r1_1 = _memo.Results.Pop();

            if (_r1_1 != null && _r1_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i1, _index, _memo.InputEnumerable, _r1_1.Results.Concat(_r1_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i1;
            }

            // ACT
            var _r0 = _memo.Results.Peek();
            if (_r0 != null)
            {
                _memo.Results.Pop();
                _memo.Results.Push( new _FitDex_Item(_r0.StartIndex, _r0.NextIndex, _memo.InputEnumerable, _Thunk(_IM_Result => { return Elements.Graphics.GetProperty (
                string.Concat( c.Inputs ),
                string.Concat( a.Inputs )
            ); }, _r0), true) );
            }

        }


        public void VariableValue(_FitDex_Memo _memo, int _index, _FitDex_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            _FitDex_Item v = null;

            // CALLORVAR Variable
            _FitDex_Item _r2;

            _r2 = _MemoCall(_memo, "Variable", _index, Variable, null);

            if (_r2 != null) _index = _r2.NextIndex;

            // BIND v
            v = _memo.Results.Peek();

            // ACT
            var _r0 = _memo.Results.Peek();
            if (_r0 != null)
            {
                _memo.Results.Pop();
                _memo.Results.Push( new _FitDex_Item(_r0.StartIndex, _r0.NextIndex, _memo.InputEnumerable, _Thunk(_IM_Result => { return Elements.Graphics.Variables[string.Concat( v.Inputs )].value; }, _r0), true) );
            }

        }


        public void ParameterStart(_FitDex_Memo _memo, int _index, _FitDex_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // LITERAL '('
            _ParseLiteralChar(_memo, ref _index, '(');

        }


        public void ParameterEnd(_FitDex_Memo _memo, int _index, _FitDex_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // LITERAL ')'
            _ParseLiteralChar(_memo, ref _index, ')');

        }


        public void Comma(_FitDex_Memo _memo, int _index, _FitDex_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // AND 0
            int _start_i0 = _index;

            // AND 1
            int _start_i1 = _index;

            // STAR 2
            int _start_i2 = _index;
            var _res2 = Enumerable.Empty<string>();
        label2:

            // CALLORVAR Space
            _FitDex_Item _r3;

            _r3 = _MemoCall(_memo, "Space", _index, Space, null);

            if (_r3 != null) _index = _r3.NextIndex;

            // STAR 2
            var _r2 = _memo.Results.Pop();
            if (_r2 != null)
            {
                _res2 = _res2.Concat(_r2.Results);
                goto label2;
            }
            else
            {
                _memo.Results.Push(new _FitDex_Item(_start_i2, _index, _memo.InputEnumerable, _res2.Where(_NON_NULL), true));
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label1; }

            // LITERAL ','
            _ParseLiteralChar(_memo, ref _index, ',');

        label1: // AND
            var _r1_2 = _memo.Results.Pop();
            var _r1_1 = _memo.Results.Pop();

            if (_r1_1 != null && _r1_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i1, _index, _memo.InputEnumerable, _r1_1.Results.Concat(_r1_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i1;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label0; }

            // STAR 5
            int _start_i5 = _index;
            var _res5 = Enumerable.Empty<string>();
        label5:

            // CALLORVAR Space
            _FitDex_Item _r6;

            _r6 = _MemoCall(_memo, "Space", _index, Space, null);

            if (_r6 != null) _index = _r6.NextIndex;

            // STAR 5
            var _r5 = _memo.Results.Pop();
            if (_r5 != null)
            {
                _res5 = _res5.Concat(_r5.Results);
                goto label5;
            }
            else
            {
                _memo.Results.Push(new _FitDex_Item(_start_i5, _index, _memo.InputEnumerable, _res5.Where(_NON_NULL), true));
            }

        label0: // AND
            var _r0_2 = _memo.Results.Pop();
            var _r0_1 = _memo.Results.Pop();

            if (_r0_1 != null && _r0_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i0, _index, _memo.InputEnumerable, _r0_1.Results.Concat(_r0_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i0;
            }

        }


        public void Eq(_FitDex_Memo _memo, int _index, _FitDex_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // AND 0
            int _start_i0 = _index;

            // AND 1
            int _start_i1 = _index;

            // STAR 2
            int _start_i2 = _index;
            var _res2 = Enumerable.Empty<string>();
        label2:

            // CALLORVAR Space
            _FitDex_Item _r3;

            _r3 = _MemoCall(_memo, "Space", _index, Space, null);

            if (_r3 != null) _index = _r3.NextIndex;

            // STAR 2
            var _r2 = _memo.Results.Pop();
            if (_r2 != null)
            {
                _res2 = _res2.Concat(_r2.Results);
                goto label2;
            }
            else
            {
                _memo.Results.Push(new _FitDex_Item(_start_i2, _index, _memo.InputEnumerable, _res2.Where(_NON_NULL), true));
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label1; }

            // LITERAL '='
            _ParseLiteralChar(_memo, ref _index, '=');

        label1: // AND
            var _r1_2 = _memo.Results.Pop();
            var _r1_1 = _memo.Results.Pop();

            if (_r1_1 != null && _r1_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i1, _index, _memo.InputEnumerable, _r1_1.Results.Concat(_r1_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i1;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label0; }

            // STAR 5
            int _start_i5 = _index;
            var _res5 = Enumerable.Empty<string>();
        label5:

            // CALLORVAR Space
            _FitDex_Item _r6;

            _r6 = _MemoCall(_memo, "Space", _index, Space, null);

            if (_r6 != null) _index = _r6.NextIndex;

            // STAR 5
            var _r5 = _memo.Results.Pop();
            if (_r5 != null)
            {
                _res5 = _res5.Concat(_r5.Results);
                goto label5;
            }
            else
            {
                _memo.Results.Push(new _FitDex_Item(_start_i5, _index, _memo.InputEnumerable, _res5.Where(_NON_NULL), true));
            }

        label0: // AND
            var _r0_2 = _memo.Results.Pop();
            var _r0_1 = _memo.Results.Pop();

            if (_r0_1 != null && _r0_2 != null)
            {
                _memo.Results.Push( new _FitDex_Item(_start_i0, _index, _memo.InputEnumerable, _r0_1.Results.Concat(_r0_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i0;
            }

        }


        public void Space(_FitDex_Memo _memo, int _index, _FitDex_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // LITERAL ' '
            _ParseLiteralChar(_memo, ref _index, ' ');

        }


        public void Digits(_FitDex_Memo _memo, int _index, _FitDex_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            _FitDex_Item d = null;

            // PLUS 2
            int _start_i2 = _index;
            var _res2 = Enumerable.Empty<string>();
        label2:

            // CALLORVAR Digit
            _FitDex_Item _r3;

            _r3 = _MemoCall(_memo, "Digit", _index, Digit, null);

            if (_r3 != null) _index = _r3.NextIndex;

            // PLUS 2
            var _r2 = _memo.Results.Pop();
            if (_r2 != null)
            {
                _res2 = _res2.Concat(_r2.Results);
                goto label2;
            }
            else
            {
                if (_index > _start_i2)
                    _memo.Results.Push(new _FitDex_Item(_start_i2, _index, _memo.InputEnumerable, _res2.Where(_NON_NULL), true));
                else
                    _memo.Results.Push(null);
            }

            // BIND d
            d = _memo.Results.Peek();

            // ACT
            var _r0 = _memo.Results.Peek();
            if (_r0 != null)
            {
                _memo.Results.Pop();
                _memo.Results.Push( new _FitDex_Item(_r0.StartIndex, _r0.NextIndex, _memo.InputEnumerable, _Thunk(_IM_Result => { return string.Concat( d.Inputs ); }, _r0), true) );
            }

        }


        public void Letter(_FitDex_Memo _memo, int _index, _FitDex_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // INPUT CLASS
            _ParseInputClass(_memo, ref _index, '\u0061', '\u0062', '\u0063', '\u0064', '\u0065', '\u0066', '\u0067', '\u0068', '\u0069', '\u006a', '\u006b', '\u006c', '\u006d', '\u006e', '\u006f', '\u0070', '\u0071', '\u0072', '\u0073', '\u0074', '\u0075', '\u0076', '\u0077', '\u0078', '\u0079', '\u007a', '\u0041', '\u0042', '\u0043', '\u0044', '\u0045', '\u0046', '\u0047', '\u0048', '\u0049', '\u004a', '\u004b', '\u004c', '\u004d', '\u004e', '\u004f', '\u0050', '\u0051', '\u0052', '\u0053', '\u0054', '\u0055', '\u0056', '\u0057', '\u0058', '\u0059', '\u005a', '-', '_');

        }


        public void Digit(_FitDex_Memo _memo, int _index, _FitDex_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // INPUT CLASS
            _ParseInputClass(_memo, ref _index, '\u0030', '\u0031', '\u0032', '\u0033', '\u0034', '\u0035', '\u0036', '\u0037', '\u0038', '\u0039');

        }


    } // class FitDex

} // namespace FitDex_svg_test

