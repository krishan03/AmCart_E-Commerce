﻿using AmCart.Core.Data.Transaction;
using AmCart.OrderModule.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmCart.OrderModule.Data.UoW
{
    public interface IOrderMongoDBUnitOfWork : IMongoDBUnitOfWork<Order>
    {
    }
}
