//-----------------------------------------------------------------------
// <copyright file="Transaction.cs" company="Stephan Dev">
//     Copyright (c) Stephan Dev. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Sdev.BudgetManager.Entities
{
    using System;

    /// <summary>
    /// Class for a transaction. A Transaction is an income or an outcome.
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// Gets or sets the transactionId.
        /// </summary>
        public Guid TransactionId { get; set; }

        /// <summary>
        /// Gets or sets the type of the transaction.
        /// </summary>
        public TransactionType TransactionType { get; set; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        public decimal Amount { get; set; }
    }
}
