using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Interface
{
	public partial interface IKhachHangBUSS
	{
		public List<KhachHangModel> GetallKhachHang();
		bool Create(KhachHangModel model);
		bool Update(KhachHangModel model);
		bool Delete(int ID);
	}
}
