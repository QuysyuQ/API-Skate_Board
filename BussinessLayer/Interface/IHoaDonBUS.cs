using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Interface
{
	public partial interface IHoaDonBUS
	{
		public List<HoaDonModel> GetallHoaDon();
		bool Create(HoaDonModel model);
		bool Update(HoaDonModel model);
		bool Delete(int id);

	}
}
