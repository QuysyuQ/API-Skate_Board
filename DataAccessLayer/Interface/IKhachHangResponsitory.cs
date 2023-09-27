using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{

	public partial interface IKhachHangResponsitory
	{
		public List<KhachHangModel> GetallKhachHang();
		public bool create(KhachHangModel model);

		public bool update(KhachHangModel model);
		public bool delete(int id);

	}
}
