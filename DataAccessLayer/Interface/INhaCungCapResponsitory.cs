using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
	public partial interface INhaCungCapResponsitory
	{
		public List<NhaCungCapModel> GetallNhaCungCap();
		public bool Create(NhaCungCapModel model);
		public bool Update(NhaCungCapModel model);
		public bool delete(int id);
	}
}
