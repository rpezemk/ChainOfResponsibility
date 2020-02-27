namespace ChainOfResponsibility
{
    public class Private : AbstractHandler
    {
        public override object Handle(Problem problem)
        {
            if (problem.Complicacy <= 2)
            {
                return $"Private managed {problem.Description} problem of {problem.Complicacy} complicacy";
            }
            else
            {
                return base.Handle(problem);
            }
        }

    }
}

