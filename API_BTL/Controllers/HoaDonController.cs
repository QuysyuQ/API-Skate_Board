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
		private IHoaDonBUSS _hoadonBUS;
		public HoaDonController(IHoaDonBUSS hoaDonBUSS)
		{
			_hoadonBUS = hoaDonBUSS;
		}

		[Route("get-by-id/{id}")]
		[HttpGet]
		public HoaDonModel GetDataByID(int ID)
		{
			return _hoadonBUS.GetDataByID(ID);
		}
	}
}
