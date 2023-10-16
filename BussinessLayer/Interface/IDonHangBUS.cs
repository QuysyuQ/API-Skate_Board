using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Interface
{
	public partial interface IDonHangBUS
	{
		public List<DonHangModel> GetallDonHang();
		bool Create(DonHangModel model);
		bool Update(DonHangModel model);
	}
}
