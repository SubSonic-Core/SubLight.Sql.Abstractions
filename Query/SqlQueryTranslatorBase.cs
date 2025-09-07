﻿#region Copyright (c) 2025
// RM / Hybrid ORM: Resource Manager / Hybrid ORM
//
// License: Dual-license
//  - Free for educational, research, personal, or nonprofit projects that are not directly or indirectly used to generate revenue
//  - Commercial use requires a per-service paid license
//
// Disclaimer: Provided "as-is"; no warranty; author not liable for any damages, data loss, or business interruptions.
// Production use must be fully tested and validated within the enterprise environment.
//
// Contributions: All contributions are voluntary and licensed under this project’s dual-license; may be included in commercial releases.
// See CLA.md for Contributor License Agreement.
//
// For commercial licensing or paid support inquiries: Kenneth Carter
#endregion
using SubLight.Query;
using SubLight.Sql;
using System.Linq.Expressions;

namespace SubLight.Sql.Query
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
