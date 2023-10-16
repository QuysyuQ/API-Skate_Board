using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Interface
{
	public partial interface ISanPhamBUS
	{
		public List<SanPhamModel> GetallSanPham();
		bool Create(SanPhamModel model);
		bool Update(SanPhamModel model);
		bool Delete(int id);
	}
}
