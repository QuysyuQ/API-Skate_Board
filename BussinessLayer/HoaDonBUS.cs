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
	public partial class HoaDonBUS : IHoaDonBUS
	{
		private IHoaDonResponsitory _res;

		public HoaDonBUS(IHoaDonResponsitory res)
		{
			_res = res;
		}

		public HoaDonModel Getbyid(int id)
		{
			return _res.Getbyid(id);
		}

		public bool Create(HoaDonModel model)
		{
			return _res.Create(model);
		}

		public bool Update(HoaDonModel model)
		{
			return _res.Update(model);
		}

		public bool Delete(int id)
		{
			return _res.Delete(id);
		}
	}
}

