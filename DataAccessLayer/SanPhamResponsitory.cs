using DataAccessLayer.Interface;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
	public partial class SanPhamResponsitory : ISanPhamResponsitory
	{
		public IDatabaseHelper _dbHelper;
		public SanPhamResponsitory(IDatabaseHelper databaseHelper)
		{
			_dbHelper = databaseHelper;
		}
		public List<SanPhamModel> GetallSanPham()
		{
			string msgError = "";
			try
			{
				var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_get_all_sanpham");
				if (!string.IsNullOrEmpty(msgError))
					throw new Exception(msgError);
				return dt.ConvertTo<SanPhamModel>().ToList();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public bool Create(SanPhamModel model)
		{
			string msgError = "";
			try
			{
				string result = "";
				var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_create_sanpham",
					"@ProductID", model.ProductID,
					"@ProductName", model.ProductName,
					"Price", model.Price,
					"@Description", model.Description,
					"@AnhDaiDien", model.AnhDaiDien,
					"@Size", model.Size);
				if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
				{
					throw new Exception(Convert.ToString(result) + msgError);
				}
				return true;
			}
			catch (Exception ex)
			{
				throw ex;
			}

		}

		public bool Update(SanPhamModel model)
		{
			string msgError = "";
			try
			{
				string result = "";
				var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_update_sanpham",
					"@ProductID", model.ProductID,
					"@ProductName", model.ProductName,
					"Price", model.Price,
					"@Description", model.Description,
					"@AnhDaiDien", model.AnhDaiDien,
					"@Size", model.Size);
				if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
				{
					throw new Exception(Convert.ToString(result) + msgError);
				}
				return true;
			}
			catch (Exception ex)
			{ 
				throw ex;
			}
		}

		public bool Delete(int id)
		{
			string msgError = "";
			try
			{
				string result = "";
				var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_delete_sanpham",
					"@ProductID", id);
				if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
				{
					throw new Exception(Convert.ToString(result) + msgError);
				}
				return true;
			}
			catch (Exception ex)
			{
				throw ex;
			}

		}
	}
}
