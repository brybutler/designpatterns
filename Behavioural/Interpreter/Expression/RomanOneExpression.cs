﻿using GangOf4Patterns.Behavioural.Interpreter.Context;
namespace GangOf4Patterns.Behavioural.Interpreter.Expression;
public class RomanOneExpression : RomanExpression
{
    public override void Interpret(RomanContext value)
    {
        while ((value.Input - 9) >= 0)
        {
            value.Output += "IX";
            value.Input -= 9;
        }

        while ((value.Input - 5) >= 0)
        {
            value.Output += "V";
            value.Input -= 5;
        }

        while ((value.Input - 4) >= 0)
        {
            value.Output += "IV";
            value.Input -= 4;
        }

        while ((value.Input - 1) >= 0)
        {
            value.Output += "I";
            value.Input -= 1;
        }
    }
}