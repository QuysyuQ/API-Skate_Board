using BussinessLayer;
using BussinessLayer.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace BTL_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ChiTietHDNController : ControllerBase
	{
		private IChiTietHDNBUS _chitiethdnBUS;
		public ChiTietHDNController(IChiTietHDNBUS ChiTietHDN)
		{
			_chitiethdnBUS = ChiTietHDN;
		}

		[Route("get_all_chitietHDN")]
		[HttpGet]
		public IEnumerable<ChiTietHDNController> GetallChiTietHDN()
		{
			return (IEnumerable<ChiTietHDNController>)_chitiethdnBUS.GetallChiTietHDN();
		}

		[Route("create-chitietHDN")]
		[HttpPost]
		public bool Create(ChiTietHDNModel model)
		{
			return _chitiethdnBUS.Create(model);
		}

		[Route("update-chitietHDN")]
		[HttpPut]
		public bool Update(ChiTietHDNModel model)
		{
			return _chitiethdnBUS.Update(model);
		}

		[Route("delete-chitietHDN")]
		[HttpDelete]
		public bool Delete(int id)
		{
			return _chitiethdnBUS.Delete(id);
		}
	}
}
