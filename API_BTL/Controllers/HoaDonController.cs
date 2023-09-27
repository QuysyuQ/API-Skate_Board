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
		private IHoaDonBUSS _hoadonBUS;
		public HoaDonController(IHoaDonBUSS hoaDonBUSS)
		{
			_hoadonBUS = hoaDonBUSS;
		}

		[Route("get-by-id/{id}")]
		[HttpGet]
		public HoaDonModel GetDataByID(int ID)
		{
			return _hoadonBUS.GetDatabyID(ID);
		}

		[Route("get-by-id/{id}")]
		[HttpGet]
		public HoaDonModel CreateItem([FromBody] HoaDonModel model)
		{
			_hoadonBUS.Create(model);
			return model;
		}

		[Route("get-by-id/{id}")]
		[HttpGet]
		public HoaDonModel Update([FromBody] HoaDonModel model)
		{
			_hoadonBUS.Update(model);
			return model;
		}

		[Route("search")]
		[HttpPost]
		public IActionResult Search([FromBody] Dictionary<string, object> formData)
		{
			{
				try
				{
					var page = int.Parse(formData["page"].ToString());
					var pageSize = int.Parse(formData["pageSize"].ToString());
					string ten_khach = "";
					if (formData.Keys.Contains("ten_khach") && !string.IsNullOrEmpty(Convert.ToString(formData["ten_khach"]))) { ten_khach = Convert.ToString(formData["ten_khach"]); }
					DateTime? fr_NgayTao = null;
					if (formData.Keys.Contains("fr_NgayTao") && formData["fr_NgayTao"] != null && formData["fr_NgayTao"].ToString() != "")
					{
						var dt = Convert.ToDateTime(formData["fr_NgayTao"].ToString());
						fr_NgayTao = new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0, 0);
					}
					DateTime? to_NgayTao = null;
					if (formData.Keys.Contains("to_NgayTao") && formData["to_NgayTao"] != null && formData["to_NgayTao"].ToString() != "")
					{
						var dt = Convert.ToDateTime(formData["to_NgayTao"].ToString());
						to_NgayTao = new DateTime(dt.Year, dt.Month, dt.Day, 23, 59, 59, 999);
					}
					long total = 0;
					var data = _hoadonBUS.Search(page, pageSize, out total, ten_khach, fr_NgayTao, to_NgayTao);
					return Ok(
						new
						{
							TotalItems = total,
							Data = data,
							Page = page,
							PageSize = pageSize
						}
						);
				}
				catch (Exception ex)
				{
					throw new Exception(ex.Message);
				}
			}
		}
	}
}
