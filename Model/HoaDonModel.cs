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

		public List<ChiTietHoaDonModel> list_json_chitiethoadonnhap { get;set; }
	}

    public class  ChiTietHoaDonModel
    {
		public int InvoiceDetailID { get; set; }
		public int InvoiceID { get; set; }
		public int ProductID { get; set; }
		public int Quantity { get; set; }
		public decimal UnitPrice { get; set; }
	}
}
