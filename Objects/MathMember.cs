namespace console_store.Objects;

abstract public class MathMember
{
    protected string _value;

    public MathMember(string value)
    {
        Validate(value);
        _value = value;
    }
    
    public string GetValue()
    {
        return _value;
    }

    protected abstract void Validate(string value);
}