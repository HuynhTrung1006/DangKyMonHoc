using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WPF_Admin_DangKyMonHoc.ModelsClass;

namespace WPF_Admin_DangKyMonHoc.XuLy
{
	class CXulyDangNhap
	{
		private static HttpClient hc = new HttpClient();
		public static bool Login(NhanVien nv)
		{
			try
			{
				string url = @"https://localhost:44357/api/signin";
				var kq = hc.PostAsJsonAsync(url, nv);
				kq.Wait();
				return kq.Result.IsSuccessStatusCode;
			}
			catch (Exception)
			{
				return false;
			}

		}
	}
}
