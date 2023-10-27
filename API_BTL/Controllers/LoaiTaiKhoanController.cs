using BussinessLayer;
using BussinessLayer.Interface;
using DataAccessLayer.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace BTL_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class LoaiTaiKhoanController : ControllerBase
	{
		private ILoaiTaiKhoanBUS _loaitaikhoanBUS;
		public LoaiTaiKhoanController(ILoaiTaiKhoanBUS LoaiTaiKhoan)
		{
			_loaitaikhoanBUS = LoaiTaiKhoan;
		}

		[Route("get_all_loaitaikhoan")]
		[HttpGet]
		public IEnumerable<LoaiTaiKhoanModel> GetallLoaiTaiKhoan()
		{
			return _loaitaikhoanBUS.GetallLoaiTaiKhoan();
		}

		[Route("create-loaitaikhoan")]
		[HttpPost]
		public bool Create(LoaiTaiKhoanModel model)
		{
			return _loaitaikhoanBUS.Create(model);
		}

		[Route("update-loaitaikhoan")]
		[HttpPut]
		public bool Update(LoaiTaiKhoanModel model)
		{
			return _loaitaikhoanBUS.Update(model);
		}

		[Route("delete-loaitaikhoan")]
		[HttpPut]
		public bool Delete(int id)
		{
			return _loaitaikhoanBUS.Delete(id);
		}
	}
}
