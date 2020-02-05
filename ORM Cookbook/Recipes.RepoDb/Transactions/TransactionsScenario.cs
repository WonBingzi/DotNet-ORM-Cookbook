﻿using Recipes.RepoDb.Models;
using Recipes.Transactions;
using RepoDb;
using RDB = RepoDb;
using System;
using System.Data;
using System.Linq;
using System.Data.SqlClient;

namespace Recipes.RepoDb.Transactions
{
    public class TransactionsScenario : BaseRepository<EmployeeClassification, SqlConnection>,
        ITransactionsScenario<EmployeeClassification>
    {
        public TransactionsScenario(string connectionString)
            : base(connectionString, RDB.Enumerations.ConnectionPersistency.Instance)
        { }

        public int Create(EmployeeClassification classification, bool shouldRollBack)
        {
            if (classification == null)
                throw new ArgumentNullException(nameof(classification), $"{nameof(classification)} is null.");

            using (var transanction = CreateConnection().EnsureOpen().BeginTransaction())
            {
                var result = Insert<int>(classification, transanction);

                if (shouldRollBack)
                    transanction.Rollback();
                else
                    transanction.Commit();

                return result;
            }
        }

        public int CreateWithIsolationLevel(EmployeeClassification classification, bool shouldRollBack, IsolationLevel isolationLevel)
        {
            if (classification == null)
                throw new ArgumentNullException(nameof(classification), $"{nameof(classification)} is null.");

            using (var transanction = CreateConnection().EnsureOpen().BeginTransaction(isolationLevel))
            {
                var result = Insert<int>(classification, transanction);

                if (shouldRollBack)
                    transanction.Rollback();
                else
                    transanction.Commit();

                return result;
            }
        }

        public EmployeeClassification? GetByKey(int employeeClassificationKey)
        {
            return Query(e => e.EmployeeClassificationKey == employeeClassificationKey).FirstOrDefault();
        }
    }
}
