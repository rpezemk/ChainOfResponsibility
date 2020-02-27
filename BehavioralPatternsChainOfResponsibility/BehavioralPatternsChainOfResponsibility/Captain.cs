namespace ChainOfResponsibility
{
    public class Captain : AbstractHandler
    {
        public override object Handle(Problem problem)
        {
            if (problem.Complicacy >= 3 && problem.Complicacy <= 10)
            {
                return $"Captain managed {problem.Description} problem of {problem.Complicacy} complicacy";
            }
            else
            {
                return base.Handle(problem);
            }
        }

    }
}

