namespace DesignPatterns.Source.BehaviourPatterns.Interpreter
{
    class MultiplicationExxpression: IExpression
    {
        IExpression _leftExpression;
        IExpression _rightExpression;

        public MultiplicationExxpression(IExpression leftExpression, IExpression rightExpression)
        {
            _leftExpression = leftExpression;
            _rightExpression = rightExpression;
        }
        public int Interpret(Context context)
        {
            return _leftExpression.Interpret(context) * _rightExpression.Interpret(context);
        }
    }
}
