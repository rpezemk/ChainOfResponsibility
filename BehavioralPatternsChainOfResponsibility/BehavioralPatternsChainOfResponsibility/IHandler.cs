﻿namespace ChainOfResponsibility
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        object Handle(Problem problem);
    }
}

