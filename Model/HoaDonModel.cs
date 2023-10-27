using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class HoaDonModel
	{
		public int InvoiceID { get; set; }
		public DateTime InvoiceDate { get; set; }

		public int SupplierID { get; set; }

		public List<ChiTietHDNModel> list_json_chitietHDN { get;set; }
	}
}
