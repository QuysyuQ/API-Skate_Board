using BussinessLayer.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API_BTL.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class KhachHangController : ControllerBase
	{
		private IKhachHangBUSS _khachhangBUS;
		public KhachHangController(IKhachHangBUSS KhachHang)
		{
			_khachhangBUS = KhachHang;
		}
		[Route("get_all_khachhang")]
		[HttpGet]
		public IEnumerable<KhachHangModel> GetallKhachHangModel()
		{
			return _khachhangBUS.GetallKhachHang();
		}

		[Route("create-khachhang")]
		[HttpPost]

		public bool Create(KhachHangModel model)
		{
			return _khachhangBUS.Create(model);
		}

		[Route("update-khachhang")]
		[HttpPut]

		public bool Update(KhachHangModel model)
		{
			return _khachhangBUS.Update(model);
		}

		[Route("delete-khachhang")]
		[HttpPut]

		public bool Delete(int ID)
		{
			return _khachhangBUS.delete(ID);
		}
	}
}

