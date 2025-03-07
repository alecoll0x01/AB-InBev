﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Sale.CreateSale
{
    /// <summary>
    /// Result of the CreateSale operation.
    /// </summary>
    /// <remarks>
    /// This response contains the unique identifier of the newly created sale,
    /// which can be used for subsequent operations or reference.
    /// </remarks>
    /// 
    public class CreateSaleResult
    {
        /// <summary>
        /// Gets or sets the unique identifier of the newly created sale.
        /// </summary>
        /// <value>A GUID that uniquely identifies the created sale in the system.</value>
        public Guid Id { get; set; }
    }
}
