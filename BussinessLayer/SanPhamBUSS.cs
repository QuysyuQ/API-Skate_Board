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
	public partial class SanPhamBUSS : ISanPhamBUS
	{
		public ISanPhamResponsitory _res;
		public SanPhamBUSS(ISanPhamResponsitory res)
		{
			_res = res;
		}
		public List<SanPhamModel> GetallSanPham()
		{
			return _res.GetallSanPham();
		}

		public bool Create(SanPhamModel model)
		{
			return _res.Create(model);
		}
		public bool Update(SanPhamModel model)
		{
			return _res.Update(model);
		}
		public bool Delete(int id)
		{
			return _res.Delete(id);
		}
	}
}
