using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
	public partial interface ISanPhamResponsitory
	{
		public List<SanPhamModel> GetallSanPham();
		public bool Create(SanPhamModel model);
		public bool Update(SanPhamModel model);
		bool Delete(int id);
	}
}
