using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    class ChainOfResponsibility
    {
        static void Main(string[] args)
        {
            List<Problem> problems = new List<Problem>();
            problems.Add(new Problem() { Description = "easy", Complicacy = 2 });
            problems.Add(new Problem() { Description = "intermediate", Complicacy = 8 });
            problems.Add(new Problem() { Description = "hard", Complicacy = 87 });
            problems.Add(new Problem() { Description = "nightmare", Complicacy = 104 });


            Private @private = new Private();
            Captain captain = new Captain();
            Major major = new Major();

            @private.SetNext(captain).SetNext(major);

            Client client = new Client();

            foreach (Problem problem in problems)
            {
                client.ManageRequest(@private, problem);
            }
            Console.ReadLine();
        }
    }
}

