using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
	public partial interface IDonHangResponsitory
	{
		public List<DonHangModel> GetallDonHang();
		public bool Create(DonHangModel model);
		public bool Update(DonHangModel model);
		bool Delete(int id);
	}
}
