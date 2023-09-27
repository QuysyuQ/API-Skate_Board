using BussinessLayer.Interface;
using DataAccessLayer;
using DataAccessLayer.Interface;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
	public class HoaDonBUS:IHoaDonBUSS
	{
		private IHoaDonResponsitory _res;
		
		public HoaDonBUS(IHoaDonResponsitory res)
		{
			res = _res;
		}

		public HoaDonModel GetDataByID(int ID)
		{
			return _res.GetDatabyID(ID);
		}
		

	}
}
