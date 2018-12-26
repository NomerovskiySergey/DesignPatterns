using System;

namespace DesignPatterns.Source.BehaviourPatterns.Interpreter
{
    class DivisionExpression : IExpression
    {
        IExpression _leftExpression;
        IExpression _rightExpression;

        public DivisionExpression(IExpression leftExpression, IExpression rightExpression)
        {
            _leftExpression = leftExpression;
            _rightExpression = rightExpression;
        }
        public int Interpret(Context context)
        {
            return _leftExpression.Interpret(context) / _rightExpression.Interpret(context);
        }
    }
}
