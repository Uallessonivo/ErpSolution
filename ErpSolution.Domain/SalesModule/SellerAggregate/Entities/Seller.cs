﻿using ErpSolution.Domain.Shared.Common;
using ErpSolution.Domain.Shared.Entities;

namespace ErpSolution.Domain.SalesModule.SellerAggregate.Entities
{
    public class Seller : BaseEntity
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Status SellerStatus { get; set; } = Status.Active;
        public Supervisor Supervisor { get; set; }
    }
}
