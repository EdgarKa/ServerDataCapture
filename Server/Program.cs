using Newtonsoft.Json;
using System.Net;
using System.Net.Sockets;

namespace Server
{
	internal class Program
	{
		static string url = "http://dev-sample-api.tsl-timing.com/sample-data";
		static Int32 port = 8000;
		static IPAddress localAddress = IPAddress.Parse("127.0.0.1");

		static async Task Main(string[] args)
		{
			// retrieve data
			var socketsHandler = new SocketsHttpHandler
			{
				PooledConnectionLifetime = TimeSpan.FromMinutes(5)
			};
			using var client = new HttpClient(socketsHandler);
			client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

			while (true)
			{
				Thread.Sleep(1000);
				var response = client.GetStringAsync(url).Result;
				Root updatedDeserializedClass = JsonConvert.DeserializeObject<Root>(response);
			}
		}

		public static async void SendInfo()
		{
			TcpListener server = new TcpListener(localAddress, port);
			server.Start();
		}

	}
}