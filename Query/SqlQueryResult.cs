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
