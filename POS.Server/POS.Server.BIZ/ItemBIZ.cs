using POS.Server.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Server.DAL;
using System.Data.SqlClient;
using System.Data;


namespace POS.Server.BIZ
{
    public class ItemBIZ
    {
        private ADO_NET _Provider;
        private static List<Item> _items = new List<Item>();
        public int ADD(Item item)
        {
            try
            {
                _items.Add(item);
                return 1;
                // _Provider = new ADO_NET();
                // _Provider.Connect();
                //using(SqlCommand _command =new SqlCommand ())
                //{
                //    _command.CommandText = "";
                //    _command.CommandType = CommandType.StoredProcedure;

                //}
            }
            catch (Exception ex )
            {

                throw ex;
            }
        }
    }
}
