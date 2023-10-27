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
	public partial class LoaiTaiKhoanBUSS : ILoaiTaiKhoanBUS
	{
		public ILoaiTaiKhoanResponsitory _res;
		public LoaiTaiKhoanBUSS (ILoaiTaiKhoanResponsitory res)
		{
			_res = res;
		}
		public List<LoaiTaiKhoanModel> GetallLoaiTaiKhoan()
		{
			return _res.GetallLoaiTaiKhoan();
		}
		
		public bool Create(LoaiTaiKhoanModel model)
		{
			return _res.Create(model);
		}

		public bool Update(LoaiTaiKhoanModel model)
		{
			return _res.Update(model);
		}

		public bool Delete(int it)
		{
			return _res.Delete(it);
		}
	}
}
