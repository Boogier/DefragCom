namespace DefragCom;

public readonly struct LRESULT// : IEquatable<LRESULT>
{
    public readonly long Value;

    public LRESULT(long value)
    {
        Value = value;
    }

    public static implicit operator LRESULT(long value)
    {
        return (LRESULT)value;
    }
}