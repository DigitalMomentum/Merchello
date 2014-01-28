﻿using System;
using System.Collections.Generic;
using Merchello.Core.Models;
using Umbraco.Core.Services;

namespace Merchello.Core.Services
{
    /// <summary>
    /// Defines the InvoiceService
    /// </summary>
    public interface IInvoiceService : IService
    {
        IInvoice CreateInvoice(Guid invoiceStatusKey);

        /// <summary>
        /// Saves a single <see cref="IInvoice"/>
        /// </summary>
        /// <param name="invoice">The <see cref="IInvoice"/> to save</param>
        /// <param name="raiseEvents">Optional boolean indicating whether or not to raise events</param>
        void Save(IInvoice invoice, bool raiseEvents = true);

        /// <summary>
        /// Saves a collection of <see cref="IInvoice"/>
        /// </summary>
        /// <param name="invoices">The collection of <see cref="IInvoice"/></param>
        /// <param name="raiseEvents">Optional boolean indicating whether or not to raise events</param>
        void Save(IEnumerable<IInvoice> invoices, bool raiseEvents = true);
        
        /// <summary>
        /// Deletes a single <see cref="IInvoice"/>
        /// </summary>
        /// <param name="invoice">The <see cref="IInvoice"/> to be deleted</param>
        /// <param name="raiseEvents">Optional boolean indicating whether or not to raise events</param>
        void Delete(IInvoice invoice, bool raiseEvents = true);

        /// <summary>
        /// Deletes a collection <see cref="IInvoice"/>
        /// </summary>
        /// <param name="invoices">The collection of <see cref="IInvoice"/> to be deleted</param>
        /// <param name="raiseEvents">Optional boolean indicating whether or not to raise events</param>
        void Delete(IEnumerable<IInvoice> invoices, bool raiseEvents = true);

        /// <summary>
        /// Gets a <see cref="IInvoice"/> given it's unique 'key' (Guid)
        /// </summary>
        /// <param name="key">The <see cref="IInvoice"/>'s unique 'key' (Guid)</param>
        /// <returns><see cref="IInvoice"/></returns>
        IInvoice GetByKey(Guid key);

        /// <summary>
        /// Gets a <see cref="IInvoice"/> given it's unique 'InvoiceNumber'
        /// </summary>
        /// <param name="invoiceNumber">The invoice number of the <see cref="IInvoice"/> to be retrieved</param>
        /// <returns><see cref="IInvoice"/></returns>
        IInvoice GetByInvoiceNumber(int invoiceNumber);

        /// <summary>
        /// Gets list of <see cref="IInvoice"/> objects given a list of Keys
        /// </summary>
        /// <param name="keys">List of guid 'key' for the invoices to retrieve</param>
        /// <returns>List of <see cref="IInvoice"/></returns>
        IEnumerable<IInvoice> GetByKeys(IEnumerable<Guid> keys);

    }
}