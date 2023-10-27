using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Interface
{
	public partial interface IChiTietHDNBUS
	{
		public List<ChiTietHDNModel> GetallChiTietHDN();
		bool Create(ChiTietHDNModel model);
		bool Update(ChiTietHDNModel model);
		bool Delete(int id);
	}
}
