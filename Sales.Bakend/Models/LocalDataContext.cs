﻿

namespace Sales.Bakend.Models
{
    using Domain.Models;
    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<Sales.Common.Models.Products> Products { get; set; }
    }
}