using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WPF_Admin_DangKyMonHoc.ModelsClass;

namespace WPF_Admin_DangKyMonHoc.XuLy
{
	class CXulyKhoa
	{
		private static HttpClient hc = new HttpClient();
		public static List<Khoa> getAllGV()
		{
			string url = @"https://localhost:44357/api/qlkhoa";
			var kq = hc.GetAsync(url);
			kq.Wait();
			if (kq.Result.IsSuccessStatusCode == false)
				return null;
			var ok = kq.Result.Content;
			var list = ok.ReadAsAsync<List<Khoa>>();
			return list.Result.ToList();
		}
	}
}
