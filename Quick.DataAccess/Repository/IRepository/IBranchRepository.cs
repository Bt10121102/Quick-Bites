
using Quick.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quick.DataAccess.Repository.IRepository;

namespace Quick.DataAccess.Repository.IRepository
{
    public interface IBranchRepository : IRepository<Branch>
    {
        IEnumerable<Branch> GetAll();
        Branch GetById(int branchId);
        void Add(Branch branch);
        void Update(Branch branch);
        void Delete(int branchId);
        void Save();
        void Remove(Branch obj);
    }
}