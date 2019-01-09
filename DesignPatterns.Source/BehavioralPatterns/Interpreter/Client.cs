using System;

namespace DesignPatterns.Source.BehaviourPatterns.Interpreter
{
    public class Client : IClient
    {
        public void Run()
        {
            int x = 5;
            int y = 8;
            int z = 2;

            Context context = new Context();
            context.SetVariable("x", x);
            context.SetVariable("y", y);
            context.SetVariable("z", z);

            // создаем объект для вычисления выражения x + y - z
            IExpression expression = new SubtractExpression(
                new AddExpression(new NumberExpression("x"), new NumberExpression("y")),
                new NumberExpression("z")
            );

            int result = expression.Interpret(context);
            Console.WriteLine("вычисление выражения x + y - z результат: {0}", result);

            // создаем объект для вычисления выражения x * y / z
            expression = new DivisionExpression(
                new MultiplicationExxpression(new NumberExpression("x"), new NumberExpression("y")), 
                new NumberExpression("z")
            );

            result = expression.Interpret(context);
            Console.WriteLine("вычисление выражения x * y / z результат: {0}", result);
        }
    }
}
