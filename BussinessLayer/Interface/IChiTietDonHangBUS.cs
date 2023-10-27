using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Interface
{
	public partial interface IChiTietDonHangBUS
	{
		public List<ChiTietDonHangModel> GetallChiTietDonHang();
		bool Create(ChiTietDonHangModel model);
		bool Update(ChiTietDonHangModel model);
		bool Delete(int it);
	}
}
