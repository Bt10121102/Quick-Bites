using Quick.DataAccess.Repository.IRepository;
using Quick.DataAccess.Data;
using System;


namespace Quick.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            Product = new ProductRepository(_db);
            SpecialOffer = new SpecialOfferRepository(_db);
            Branch = new BranchRepository(_db);
        }

        public ICategoryRepository Category { get; private set; }
        public IProductRepository Product { get; private set; }
        public IBranchRepository Branch { get; private set; }
        public ISpecialOfferRepository SpecialOffer { get; private set; }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
