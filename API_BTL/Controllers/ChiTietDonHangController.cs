using BussinessLayer.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace BTL_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ChiTietDonHangController : ControllerBase
	{
		private IChiTietDonHangBUS _chitietdonhangBUS;
		public ChiTietDonHangController(IChiTietDonHangBUS ChiTietDonHang)
		{
			_chitietdonhangBUS = ChiTietDonHang;
		}

		[Route("get_all_chitietdonhang")]
		[HttpGet]
		public IEnumerable<ChiTietDonHangModel> GetallChiTietDonHang()
		{
			return _chitietdonhangBUS.GetallChiTietDonHang();
		}

		[Route("create-chitietdonhang")]
		[HttpPost]
		public bool Create(ChiTietDonHangModel model)
		{
			return _chitietdonhangBUS.Create(model);
		}

		[Route("update-chitietdonhang")]
		[HttpPut]
		public bool Update(ChiTietDonHangModel model)
		{
			return _chitietdonhangBUS.Update(model);
		}

		[Route("delete-chitietdonhang")]
		[HttpPut]
		public bool Delete(int id)
		{
			return _chitietdonhangBUS.Delete(id);
		}
	}
}


