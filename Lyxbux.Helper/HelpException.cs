namespace Lyxbux.Helper
{
    public abstract class HelpException : Exception
    {
        public HelpException() : base() { }
        public HelpException(string message) : base(message) { }
        public HelpException(string message, Exception innerException) : base(message, innerException) { }
    }
}
