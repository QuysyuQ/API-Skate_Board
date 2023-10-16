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
	public partial class NhaCungCapBUSS : INhaCungCapBUS
	{
		public INhaCungCapResponsitory _res;
		public NhaCungCapBUSS(INhaCungCapResponsitory res)
		{
			_res = res;
		}
		public List<NhaCungCapModel> GetallNhaCungCap()
		{
			return _res.GetallNhaCungCap();
		}

		public bool Create(NhaCungCapModel model)
		{
			return _res.Create(model);
		}

		public bool Update(NhaCungCapModel model)
		{
			return _res.Create(model);
		}



		List<NhaCungCapModel> INhaCungCapBUS.GetallNhaCungCap()
		{
			throw new NotImplementedException();
		}

		public bool Delete(int id)
		{
			return _res.delete(id);
		}


	}
}
