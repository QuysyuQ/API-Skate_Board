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
		public HoaDonModel Getbyid(int id);
		public HoaDonModel Create(int id);
		public HoaDonModel Update(int id);
		bool Delete(int id);
		bool Update(HoaDonModel model);
		bool Create(HoaDonModel model);
		IEnumerable<HoaDonModel> GetallHoaDon();
	}
}
