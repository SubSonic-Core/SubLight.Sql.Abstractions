namespace SubLight
{
    public interface ISqlDialect
    {
        string QouteIdentifier(string identifier);
        string FormatParameterName(string name, int index);
        string GetLimitOffsetClause(int? limit, int? offset);
    }
}
