using BussinessLayer;
using BussinessLayer.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace BTL_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DonHangController : ControllerBase
	{
		private IDonHangBUS _donhangBUS;
		public DonHangController (IDonHangBUS DonHang)
		{
			_donhangBUS = DonHang;
		}

		[Route("get_all_donhang")]
		[HttpGet]
		public IEnumerable<DonHangModel> GetallDonHang()
		{
			return _donhangBUS.GetallDonHang();
		}

		[Route("create-donhang")]
		[HttpPost]

		public bool Create(DonHangModel model)
		{
			return _donhangBUS.Create(model);
		}

		[Route("update-donhang")]
		[HttpPut]

		public bool Update(DonHangModel model)
		{
			return _donhangBUS.Update(model);
		}

		[Route("delete-donhang")]
		[HttpPut]

		public bool Delete(int id)
		{
			return _donhangBUS.Delete(id);
		}
	}

}
