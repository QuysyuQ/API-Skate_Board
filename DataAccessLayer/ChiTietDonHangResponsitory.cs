using DataAccessLayer.Interface;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
	public class ChiTietDonHangResponsitory : IChiTietDonHangResponsitory
	{
		private IDatabaseHelper _dbHelper;
		public ChiTietDonHangResponsitory(IDatabaseHelper dbHelper)
		{
			_dbHelper = dbHelper;
		}
		public List<ChiTietDonHangModel> GetallChiTietDonHang()
		{
			string msgError = "";
			try
			{
				var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "getallchitietdonhang");
				if (!string.IsNullOrEmpty(msgError))
					throw new Exception(msgError);
				return dt.ConvertTo<ChiTietDonHangModel>().ToList();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public bool Create(ChiTietDonHangModel model)
		{
			string msgError = "";
			try
			{
				string result = "";
				var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_create_chitietdonhang",
					"@OrderDetailID", model.OrderDetailID,
					"@OrderID", model.OrderID,
					"@ProductID", model.ProductID,
					"@Quantity", model.Quantity);
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

		public bool Update(ChiTietDonHangModel model)
		{
			string msgError = "";
			try
			{
				string result = "";
				var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_update_chitietdonhang",
					"@OrderDetailID", model.OrderDetailID,
					"@OrderID", model.OrderID,
					"@ProductID", model.ProductID,
					"@Quantity", model.Quantity);
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
				var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_delele_chitietdonhang",
					"@OrderDetailID", id);
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
