using System;

namespace DesignPatterns.Source.BehaviourPatterns.Visitor
{
    class HtmlVisitor: IVisitor
    {
        public void VisitPersonAcc(Person acc)
        {
            string result = $"<table><tr><td>Свойство<td><td>Значение</td></tr>" +
                            $"<tr><td>Name<td><td>{acc.Name}</td></tr>" +
                            $"<tr><td>Number<td><td>{acc.Number}</td></tr></table>";

            Console.WriteLine(result);
        }

        public void VisitCompanyAc(Company acc)
        {
            string result = $"<table><tr><td>Свойство<td><td>Значение</td></tr>" +
                            $"<tr><td>Name<td><td>{acc.Name}</td></tr>" +
                            $"<tr><td>RegNumber<td><td>{acc.RegNumber}</td></tr>" +
                            $"<tr><td>Number<td><td>{acc.Number}</td></tr></table>";

            Console.WriteLine(result);
        }
    }
}
