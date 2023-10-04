using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace API_BTL.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		//private IUserBUSS _userBUS;
		//public UserController(IUserBUSS userBUSS)
		//{
		//	_userBUS = userBUSS;
		//}
		//[AllowAnonymous]
		//[HttpPost("login")]
		//public IActionResult Login([FromBody] AuthenticateModel model)
		//{
		//	var user = _userBUS.Login(model.Username, model.Password);
		//	if (user == null)
		//		return BadRequest(new { message = "Tài khoản hoặc mật khẩu không đúng!" });
		//	return Ok(new { taikhoan = user.TenTaiKhoan, email = user.Email, token = user.token });
		//}
	}
}
