using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Interface
{
	public partial interface INhaCungCapBUS
	{
		public List<NhaCungCapModel> GetallNhaCungCap();
		bool Create(NhaCungCapModel model);
		bool Update(NhaCungCapModel model);
		bool Delete(int id);
	}
}
