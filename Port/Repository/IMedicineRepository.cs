using Port.Model;
using System.Collections.Generic;

namespace Port.Repository
{
    public interface IMedicineRepository
    {
        List<Medicine> Find(int skip, int take);
        Medicine FindById(long id);
        Medicine Create(Medicine medicine);
        Medicine Update(Medicine medicine);
        void Delete(long id);
    }
}
