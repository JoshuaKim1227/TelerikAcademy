using System;

public class InvalidRangeException<T> : ApplicationException
{
    private T minValue;
    private T maxValue;
    private string message;

    public InvalidRangeException(T rangeDownBorder, T rangeUpBorder, string message = null, Exception causeException = null)
        : base(message, causeException)
    {
        this.minValue = rangeDownBorder;
        this.maxValue = rangeUpBorder;
        this.message = message;
    }

    public T RangeDownBorder
    {
        get { return this.minValue; }
    }

    public T RangeUpBorder
    {
        get { return this.maxValue; }
    }

    public override string Message
    {
        get
        {
            if (this.message == null)
            {
                return string.Format("The number is out of range. The allowed range is [{0} - {1}].", this.minValue, this.maxValue);
            }
            else
            {
                return this.message;
            }
        }
    }
}