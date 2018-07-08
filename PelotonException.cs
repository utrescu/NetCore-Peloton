using System;

public class PelotonException : Exception
{
    public PelotonException()
    {
    }

    public PelotonException(string message)
        : base(message)
    {
    }

    public PelotonException(string message, Exception inner)
        : base(message, inner)
    {
    }
}