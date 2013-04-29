//-----------------------------------------------------------------------
// <copyright file="TransactionType.cs" company="Stephan Dev">
//     Copyright (c) Stephan Dev. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Sdev.BudgetManager.Entities
{
    /// <summary>
    /// Class for the possible types of a transaction.
    /// </summary>
    public enum TransactionType
    {
        /// <summary>
        /// The transaction is an income.
        /// </summary>
        Income,

        /// <summary>
        /// the transaction is an outcome.
        /// </summary>
        Outcome,
    }
}
