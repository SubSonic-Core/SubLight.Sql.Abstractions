using SubLight.Query;
using System.Data.Common;

namespace SubLight.Sql.Query
{
    public class SqlQueryResult(string sql, IReadOnlyList<DbParameter> parameters)
        : IQueryResult
    {
        public string Sql { get; } = sql ?? throw new ArgumentNullException(nameof(sql));
        public IReadOnlyList<DbParameter> Parameters { get; } = parameters ?? throw new ArgumentNullException(nameof(parameters));
    }
}
