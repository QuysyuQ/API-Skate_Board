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
	public partial class DonHangBUSS : IDonHangBUS
	{
		public IDonHangResponsitory _res;
		public DonHangBUSS(IDonHangResponsitory res)
		{
			_res = res;
		}

		public List<DonHangModel> GetallDonHang()
		{
			return _res.GetallDonHang();
		}
		public bool Create(DonHangModel model)
		{
			return _res.Create(model);
		}

		public bool Update(DonHangModel model)
		{
			return _res.Update(model);
		}
	}
}
