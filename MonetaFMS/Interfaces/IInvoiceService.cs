﻿using MonetaFMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonetaFMS.Interfaces
{
    public interface IInvoiceService : ITableService<Invoice>
    {
        decimal GetInvoiceTotal(int id);
        decimal GetInvoiceTotal(Invoice invoice);
    }
}