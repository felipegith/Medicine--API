using Microsoft.EntityFrameworkCore;
using Port.Context;
using Port.Model;
using System.Collections.Generic;
using System.Linq;

namespace Port.Repository.Implementation
{
    public class MedicineRepository : IMedicineRepository
    {
        private readonly MyContext _context;

        public MedicineRepository(MyContext context)
        {
            _context = context;
        }

        public Medicine Create(Medicine medicine)
        {
            try
            {
                _context.Medicines.Add(medicine);
                _context.SaveChanges();
            }
            catch (System.Exception)
            {

                throw;
            }
            return medicine;
        }

        public List<Medicine> Find(int skip , int take)
        {
            return _context.Medicines.AsNoTracking().Skip(skip).Take(take).ToList();
        }

        public Medicine FindById(long id)
        {
            return _context.Medicines.SingleOrDefault(c => c.Id == id);
        }
        public Medicine Update(Medicine medicine)
        {
            try
            {
                var updated = _context.Medicines.SingleOrDefault(c => c.Id.Equals(medicine.Id));

                if (updated != null)
                {
                    _context.Entry(updated).CurrentValues.SetValues(medicine);
                    _context.SaveChanges();
                }
            }
            catch (System.Exception)
            {

                throw;
            }
            return medicine;
        }

        public void Delete(long id)
        {
            var deleted = _context.Medicines.SingleOrDefault(c => c.Id == id);

            if(deleted != null)
            {
                _context.Medicines.Remove(deleted);
                _context.SaveChanges();
            }
        }

        
    }
}
