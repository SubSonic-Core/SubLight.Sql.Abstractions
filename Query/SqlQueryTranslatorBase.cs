using System.Linq.Expressions;

namespace SubLight.Query
{
    public abstract class SqlQueryTranslatorBase
        : IQueryTranslator<SqlQueryResult>
    {
        protected readonly ISqlDialect _dialect;

        protected SqlQueryTranslatorBase(ISqlDialect dialect)
        {
            _dialect = dialect ?? throw new ArgumentNullException(nameof(dialect));
        }

        public SqlQueryResult Translate(Expression expression)
        {
            throw new NotImplementedException();
        }
    }
}
