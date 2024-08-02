using Quick.Models;
using Quick.DataAccess.Data;
using Quick.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick.DataAccess.Repository
{


    public class BranchRepository : Repository<Branch>, IBranchRepository

    {
        private readonly ApplicationDbContext _context;

        public BranchRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Branch> GetAll()
        {
            return _context.Branches.ToList();
        }

        public Branch GetById(int branchId)
        {
            return _context.Branches.Find(branchId);
        }

        public void Add(Branch branch)
        {
            _context.Branches.Add(branch);
            Save();
        }

        public void Update(Branch branch)
        {
            _context.Branches.Update(branch);
            Save();
        }

        public void Delete(int branchId)
        {
            Branch branch = _context.Branches.Find(branchId);
            _context.Branches.Remove(branch);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Remove(Branch obj)
        {
            _context.Branches.Remove(obj);
            Save();
        }
    }
}
