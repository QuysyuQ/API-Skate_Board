using BussinessLayer.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace BTL_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class NhaCungCapController : ControllerBase
	{
		private INhaCungCapBUS _nhacungcapBUS;
		public NhaCungCapController(INhaCungCapBUS NhaCungCap)
		{
			_nhacungcapBUS = NhaCungCap;
		}


		[Route("get_all_nhacungcap")]
		[HttpGet]
		public IEnumerable<NhaCungCapModel> GetallNhaCungCap()
		{
			return _nhacungcapBUS.GetallNhaCungCap();
		}

		[Route("create-nhacungcap")]
		[HttpPost]

		public bool Create(NhaCungCapModel model)
		{
			return _nhacungcapBUS.Create(model);
		}

		[Route("update-nhacungcap")]
		[HttpPut]

		public bool Update(NhaCungCapModel model)
		{
			return _nhacungcapBUS.Update(model);
		}

		[Route("delete-nhacungcap")]
		[HttpPut]

		public bool Delete(int ID)
		{
			return _nhacungcapBUS.Delete(ID);
		}
	}
}
