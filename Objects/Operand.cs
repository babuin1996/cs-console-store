namespace console_store.Objects;

public class Operator : MathMember
{
    private List<char> _operands;
    
    public Operator(string value) : base(value)
    {
        _operands = new List<char> {'+','-','/','*','^',')','('};
    }
    
    protected override void Validate(string value)
    {
        if (value.Length > 1 || !_operands.Contains(value.ToCharArray()[0]))
        {
            throw new ArgumentException("Value must be one of the following: +, -, /, *, ^");
        }
    }
}