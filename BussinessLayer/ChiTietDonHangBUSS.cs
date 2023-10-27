using BussinessLayer.Interface;
using DataAccessLayer.Interface;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
	public partial class ChiTietDonHangBUSS : IChiTietDonHangBUS
	{
		public IChiTietDonHangBUS _res;
		public ChiTietDonHangBUSS(IChiTietDonHangBUS res)
		{
			_res = res;
		}

		public List<ChiTietDonHangModel> GetallChiTietDonHang()
		{
			return _res.GetallChiTietDonHang();
		}

		public bool Create(ChiTietDonHangModel model)
		{
			return _res.Create(model);
		}

		public bool Update(ChiTietDonHangModel model)
		{
			return _res.Update(model);
		}
		public bool Delete(int id)
		{
			return _res.Delete(id);
		}
	}
}
