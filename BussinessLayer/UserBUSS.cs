using BussinessLayer.Interface;
using DataAccessLayer.Interface;
using Microsoft.Extensions.Configuration;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
	internal class UserBUSS: IUserBUSS
	{
		private IUserResponsitory _res;
		private string secret;
		public UserBUSS(IUserResponsitory res, IConfiguration configuration)
		{
			_res = res;
			secret = configuration["AppSettings:Secret"];
		}

		public UserModel Login(string taikhoan, string matkhau) 
		{
			var user = _res.Login(taikhoan, matkhau);
			if (user == null)
				return null;

		}
	}
}
