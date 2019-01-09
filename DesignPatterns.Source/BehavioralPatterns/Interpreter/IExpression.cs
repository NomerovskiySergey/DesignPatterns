namespace DesignPatterns.Source.BehaviourPatterns.Interpreter
{
    interface IExpression
    {
        int Interpret(Context context);
    }
}
