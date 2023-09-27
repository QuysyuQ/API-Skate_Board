﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
	public partial interface IHoaDonResponsitory
	{
		HoaDonModel GetDatabyID(int id);
		bool Create(HoaDonModel model);
		bool Update(HoaDonModel model);
		public List<ThongKeKhachModel> Search(int pageIndex, int pageSize, out long total, string ten_khach, DateTime? fr_NgayTao, DateTime? to_NgayTao);
	}
}