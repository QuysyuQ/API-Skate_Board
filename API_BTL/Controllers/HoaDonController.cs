using BussinessLayer;
using BussinessLayer.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace BTL_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class HoaDonController : ControllerBase
	{
		private IHoaDonBUS _hoadonBUS;
		public HoaDonController(IHoaDonBUS HoaDon)
		{
			_hoadonBUS = HoaDon;
		}

		[Route("get_all_hoadon")]
		[HttpGet]
		public IEnumerable<HoaDonModel> GetallHoaDonModel()
		{
			return _hoadonBUS.GetallHoaDon();
		}

		[Route("create-hoadon")]
		[HttpPost]

		public bool Create(HoaDonModel model)
		{
			return _hoadonBUS.Create(model);
		}

		[Route("update-hoadon")]
		[HttpPut]
		public bool Update(HoaDonModel model)
		{
			return _hoadonBUS.Update(model);
		}

		[Route("delete-hoadon")]
		[HttpPut]

		public bool Delete(int ID)
		{
			return _hoadonBUS.Delete(ID);
		}
	}
}
