using BussinessLayer;
using BussinessLayer.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace BTL_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SanPhamController : ControllerBase
	{
		private ISanPhamBUS _sanphamBUS;
		public SanPhamController(ISanPhamBUS SanPham)
		{
			_sanphamBUS = SanPham;
		}

		[Route("get_all_sanpham")]
		[HttpGet]
		public IEnumerable<SanPhamModel> GetallSanPham()
		{
			return _sanphamBUS.GetallSanPham();
		}

		[Route("create-sanpham")]
		[HttpPost]
		public bool Create(SanPhamModel model)
		{
			return _sanphamBUS.Create(model);
		}

		[Route("update-sanpham")]
		[HttpPut]
		public bool Update(SanPhamModel model)
		{
			return _sanphamBUS.Update(model);
		}


		[Route("delete-sanpham")]
		[HttpPut]
		public bool Delete(int id)
		{
			return _sanphamBUS.Delete(id);
		}
	}

}
