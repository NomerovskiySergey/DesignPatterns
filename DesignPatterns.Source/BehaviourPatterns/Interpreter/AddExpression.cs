namespace DesignPatterns.Source.BehaviourPatterns.Interpreter
{
    class AddExpression : IExpression
    {
        IExpression _leftExpression;
        IExpression _rightExpression;

        public AddExpression(IExpression leftExpression, IExpression rightExpression)
        {
            _leftExpression = leftExpression;
            _rightExpression = rightExpression;
        }

        public int Interpret(Context context)
        {
            return _leftExpression.Interpret(context) + _rightExpression.Interpret(context);
        }
    }
}
