using System;

namespace ChainOfResponsibility
{
    public class Client
    {

        public void ManageRequest(IHandler handler, Problem problem)
        {
            var result = handler.Handle(problem);
            if (result != null)
            {
                Console.WriteLine(result.ToString());
            }
            else
            {
                Console.WriteLine($"Problem {problem.Description}, {problem.Complicacy} has not been managed!!!");
            }
        }
    }
}

