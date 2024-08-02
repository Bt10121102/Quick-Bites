
using Quick.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quick.DataAccess.Repository.IRepository;
using Quick.Models.ViewModels;

namespace Quick.DataAccess.Repository.IRepository
{
    public interface ISpecialOfferRepository : IRepository<SpecialOffer> { 
        IEnumerable<SpecialOffer> GetAll();
        SpecialOffer GetById(int SpecialOfferId);
        void Add(SpecialOffer SpecialOffer);
        void Update(SpecialOffer SpecialOffer);
        void Delete(int SpecialOfferId);
        void Save();
        void Remove(SpecialOffer obj);
    }
}
