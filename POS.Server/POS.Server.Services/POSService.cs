using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using POS.Server.BIZ;

namespace POS.Server.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AppService" in both code and config file together.
    public class POSService : IPOSService
    {

        public int Add(Item item)
        {
            try
            {
                ItemBIZ biz = new ItemBIZ();
                var x = biz.ADD(item);
                return x;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public int Save(List<Item> items)
        {
            throw new NotImplementedException();
        }

        public List<Item> Get()
        {
            throw new NotImplementedException();
        }
    }
}
