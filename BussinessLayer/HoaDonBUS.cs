using BussinessLayer.Interface;
using DataAccessLayer.Interface;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
		public bool Update(HoaDonModel model)
		{
			return _res.Update(model);
		}

		public bool Delete(int id)
		{
			return _res.Delete(id);
		}

		public HoaDonModel Create(int id)
		{
			return _res.Create(id);
		}

		public HoaDonModel Update(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<HoaDonModel> GetallHoaDon()
		{
			throw new NotImplementedException();
		}

		public bool Create(HoaDonModel model)
		{
			throw new NotImplementedException();
		}
	}
}

