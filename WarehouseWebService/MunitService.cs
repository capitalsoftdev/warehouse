using System.Collections.Generic;
using System.Linq;
using WarehouseBL.ProductManagement;
using WarehouseWebService.DataContracts;

namespace WarehouseWebService
{
    public partial class WarehouseService
    {
        public IList<Munit> GetMunits()
        {
            var munitMeneger = new MunitManager();

            return munitMeneger.GetMunit().Select(m => m.ToServiceMunit()).ToList();

        }

        public Munit GetMunit(int id)
        {
            var munitMeneger = new MunitManager();

            return munitMeneger.GetMunit(id).ToServiceMunit();
        }

        public int CreateOrUpdateMunit(Munit munit)
        {
            var munitMeneger = new MunitManager();

            return munitMeneger.CreateOrUpdateMunit(munit.ToDatMunit());
        }


        public int DisableMunit(int id)
        {
            var munitMeneger = new MunitManager();

            return munitMeneger.DisableMunit(id);
        }

        public IList<Munit> GetActiveMunit()
        {

            var munitMeneger = new MunitManager();

            return munitMeneger.GetActiveMunit().Select(m => m.ToServiceMunit()).ToList();
        }
        
    }
}
