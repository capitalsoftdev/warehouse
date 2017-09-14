using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBL.Interfaces;
using WarehouseDAL;
using WarehouseDAL.DataContracts;

namespace WarehouseBL.ProductManagement
{
    public class MunitManager : IMunitManager
    {
        public IList<Munit> GetMunit()
        {
            var munitAdaptor = new MunitAdaptor();

            var result = munitAdaptor.GetMunit();

            return result;
        }

        public Munit GetMunit(int id)
        {
            var munitAdaptor = new MunitAdaptor();

            var result = munitAdaptor.GetMunit(id);

            return result;
        }

        public int CreateOrUpdateMunit(Munit munit)
        {
            var munitAdaptor = new MunitAdaptor();

            var result = munitAdaptor.CreateOrUpdateMunit(munit);

            return result;
        }


        public int DisableMunit(int id)
        {
            var munitAdaptor = new MunitAdaptor();

            var result = munitAdaptor.DisableMunit(id);

            return result;
        }

        public IList<Munit> GetActiveMunit()
        {
            var munitAdaptor = new MunitAdaptor();

            var result = munitAdaptor.GetActiveMunit();

            return result;
        }

    }
}
