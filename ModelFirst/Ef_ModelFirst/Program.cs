using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_ModelFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AccountingSystemContainer())
            {
                var invHeader = db.InvoiceHeaders.Create();
                var invDetail = db.InvoiceDetailSet.Create();

                invHeader.Total = 150m;

                invDetail.ItemDescription = "Some Item";
                invDetail.Price = 75m;
                invDetail.Quantity = 2;

                var invDetails = db.InvoiceDetailSet.Add(invDetail);

                db.InvoiceHeaders.Add(invHeader);
                db.SaveChanges();


               

                
            }
        }
    }
}
