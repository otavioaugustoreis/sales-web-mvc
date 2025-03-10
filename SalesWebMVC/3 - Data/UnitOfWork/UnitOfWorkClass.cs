﻿using SalesWebMVC._2___Domain.Interfaces;
using SalesWebMVC._2___Domain.Services;
using SalesWebMVC.Data;
using SalesWebMVC.Models.Repositories;
using SalesWebMVC.Models.Services;

namespace SalesWebMVC.UnitOfWork
{
    public class UnitOfWorkClass : IUnitOfWork
    {
        private IDepartmentService? Department;

        private ISellerService? Seller;

        private ISalesRecordService? SalesRecord;

        private IProductService ProductService;

        public AppDbContext _context;

        public UnitOfWorkClass(AppDbContext context)
        {
            _context = context;
        }

        public IProductService _Product
        {
            get
            {
                return ProductService = ProductService ?? new ProductService(_context);
            }
        }
        public IDepartmentService _Department
        {
            get
            {
                return Department = Department ?? new DepartmentService(_context);
            }
        }

        public ISalesRecordService _Sales
        {
            get
            {
                return SalesRecord = SalesRecord ?? new SalesRecordService(_context);
            }
        }

        public ISellerService _Seller
        {
            get
            {
                return Seller = Seller ?? new SellerService(_context);
            }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
