using BussinessLayer.Interface;
using DataAccessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
	public partial class KhachHangBUS : IKhachHangBUSS
	{
		public IKhachHangResponsitory _res;
		public KhachHangBUS(IKhachHangResponsitory res)
		{
			_res = res;
		}

		public List<KhachHangModel> getall()
		{
			return _res.GetallKhachHang();
		}

		public bool Create(KhachHangModel model)
		{
			return _res.create(model);
		}
		public bool Update(KhachHangModel model)
		{
			return _res.update(model);
		}

		public bool Delete(int ID)
		{
			return _res.delete(ID);
		}
	}
}
