namespace ChainOfResponsibility
{
    public class AbstractHandler : IHandler
    {
        public IHandler _nexHandler;


        public virtual IHandler SetNext(IHandler request)
        {
            this._nexHandler = request;
            return request;
        }

        public virtual object Handle(Problem problem)
        {
            if (_nexHandler != null)
            {
                return this._nexHandler.Handle(problem); ;
            }
            else
            {
                return null;
            }
        }
    }
}

