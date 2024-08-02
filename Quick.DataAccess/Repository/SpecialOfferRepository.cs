
using Quick.Models;
using Quick.DataAccess.Data;
using Quick.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quick.Models.ViewModels;

namespace Quick.DataAccess.Repository
{


    public class SpecialOfferRepository : Repository<SpecialOffer>, ISpecialOfferRepository

    {
        private readonly ApplicationDbContext _context;

        public SpecialOfferRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<SpecialOffer> GetAll()
        {
            return _context.SpecialOffers.ToList();
        }

        public SpecialOffer GetById(int SpecialOfferId)
        {
            return _context.SpecialOffers.Find(SpecialOfferId);
        }

        public void Add(SpecialOffer specialOffer)
        {
            _context.SpecialOffers.Add(specialOffer);
            Save();
        }

        public void Update(SpecialOffer specialOffer)
        {
            _context.SpecialOffers.Update(specialOffer);
            Save();
        }

        public void Delete(int specialOfferId)
        {
            SpecialOffer specialOffer = _context.SpecialOffers.Find(specialOfferId);
            _context.SpecialOffers.Remove(specialOffer);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Remove(SpecialOffer obj)
        {
            _context.SpecialOffers.Remove(obj);
            Save();
        }
    }
}