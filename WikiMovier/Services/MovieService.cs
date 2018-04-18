using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WikiMovier.Services
{
	public class MovieService : IMovie
	{
		//http://www.omdbapi.com/?i=tt3896198&apikey=2299f21b

		private string BASE_URL = "http://www.omdbapi.com/";
		private string API_KEY = "&apikey=2299f21b";

		//TODO: PUT API KEY TO SECRET JSON.

		

		public async Task<string> DownlaodApiDataAsync(string searchQuery)
		{
			string _MovieJson;
			string url = BASE_URL + "?t=" + searchQuery + API_KEY;
			using (HttpClient hc = new HttpClient())
			{
				string justforquery = searchQuery;
				
				//string url = "http://www.omdbapi.com/?i=tt3896198&apikey=2299f21b";
				var Moviejson = await hc.GetStringAsync(url);
				_MovieJson = Moviejson;
				Debug.WriteLine(url);
			}
			
			return _MovieJson;
		}

	


	}
}
