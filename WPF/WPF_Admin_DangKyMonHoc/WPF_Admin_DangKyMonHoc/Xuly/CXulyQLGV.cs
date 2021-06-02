using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WPF_Admin_DangKyMonHoc.ModelsClass;

namespace WPF_Admin_DangKyMonHoc.XuLy
{
	class CXulyQLGV
	{
		private static HttpClient hc = new HttpClient();
		public static List<GiangVien> getAllGV()
		{
			string url = @"https://localhost:44357/api/qlgv";
			var kq = hc.GetAsync(url);
			kq.Wait();
			if (kq.Result.IsSuccessStatusCode == false)
				return null;
			var ok = kq.Result.Content;
			var list = ok.ReadAsAsync<List<GiangVien>>();
			return list.Result.ToList();
		}
		public static bool PostThemGV(GiangVien a)
		{
			try
			{
				string url = @"https://localhost:44357/api/qlgv";
				var kq = hc.PostAsJsonAsync(url, a);
				kq.Wait();
				return kq.Result.IsSuccessStatusCode;
			}
			catch(Exception)
			{
				return false;
			}
		}
		public static bool DeleteXoaGV(string id)
		{
			try
			{
				string url = @"https://localhost:44357/api/qlgv/"+id;
				var kq = hc.DeleteAsync(url);
				kq.Wait();
				return kq.Result.IsSuccessStatusCode;
			}
			catch (Exception)
			{
				return false;
			}
		}
		public static bool PutSuaGiangVien(GiangVien a)
		{
			try
			{
				string url = @"https://localhost:44357/api/qlgv";
				var kq = hc.PutAsJsonAsync(url, a);
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
