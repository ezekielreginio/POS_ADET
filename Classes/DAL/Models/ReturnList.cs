using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_ADET.Classes.DAL.Models
{
    public class ReturnList
    {
        private List<ReturnData> returndata = new List<ReturnData>();

        public List<ReturnData> Returndata { get => returndata; set => returndata = value; }

        public void setItemsFromDataTable(DataTable datatable)
        {
            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                returndata.Add(new ReturnData
                {
                    Name = datatable.Rows[i]["Name"].ToString(),
                    Qty = Convert.ToInt32(datatable.Rows[i]["Qty"]),
                    Type = datatable.Rows[i]["Type"].ToString(),
                    
                });
            }
        }
    }

}
