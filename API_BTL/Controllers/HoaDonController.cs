using BussinessLayer;
using BussinessLayer.Interface;
using DataAccessLayer.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API_BTL.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class HoaDonController : ControllerBase
	{
		private IHoaDonBUS _hoadonBUS;
		public HoaDonController(IHoaDonBUS hoaDonBUSS)
		{
			_hoadonBUS = hoaDonBUSS;
		}

		[Route("get-by-id")]
		[HttpGet]
		public HoaDonModel GetDataByID(int ID)
		{
			return _hoadonBUS.Getbyid(ID);
		}

		[Route("get-by-id")]
		[HttpGet]
		public HoaDonModel Create(int id)
		{
			return _hoadonBUS.Create(id);
		}

		[Route("get-by-id")]
		[HttpGet]
		public HoaDonModel Update(int id)
		{
			return _hoadonBUS.Update(id);
		}
	}
}
