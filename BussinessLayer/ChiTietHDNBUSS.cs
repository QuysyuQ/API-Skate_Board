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
	public partial class ChiTietHDNBUSS : IChiTietHDNBUS
	{
		public IChiTietHDNResponsitory _res;
		public ChiTietHDNBUSS(IChiTietHDNResponsitory res)
		{
			_res = res;
		}

		public List<ChiTietHDNModel> GetallChiTietHDN()
		{
			return _res.GetallChiTietHDN();
		}

		public bool Create(ChiTietHDNModel model)
		{
			return _res.Create(model);
		}

		public bool Update(ChiTietHDNModel model)
		{
			return _res.Update(model);
		}

		public bool Delete(int id)
		{
			return _res.Delete(id);
		}
	}
}
