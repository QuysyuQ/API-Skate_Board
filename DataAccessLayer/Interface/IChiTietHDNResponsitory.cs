using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
	public partial interface IChiTietHDNResponsitory
	{
		public List<ChiTietHDNModel> GetallChiTietHDN();
		public bool Create(ChiTietHDNModel model);
		public bool Update(ChiTietHDNModel model);
		public bool Delete(int id);
	}
}
