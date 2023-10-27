using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Interface
{
	public partial interface ILoaiTaiKhoanBUS
	{
		public List<LoaiTaiKhoanModel> GetallLoaiTaiKhoan();
		bool Create(LoaiTaiKhoanModel model);
		bool Update(LoaiTaiKhoanModel model);
		bool Delete(int id);
	}
}
