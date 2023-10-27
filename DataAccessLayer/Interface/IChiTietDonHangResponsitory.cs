using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
	public partial interface IChiTietDonHangResponsitory
	{
		public List<ChiTietDonHangModel> GetallChiTietDonHang();
		public bool Create(ChiTietDonHangModel model);
		public bool Update(ChiTietDonHangModel model);
		bool Delete(int id);
	}
}
