using RestSharp;
using SplitGridDomainModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SplitGrid.Client
{
	class Program
	{
		#region constants
		private const string baseUrl = "http://localhost:61440/api/v1";
		#endregion

		#region Main
		static void Main(string[] args)
		{
			var response = GetTransactions();
			var message = response.Any() ? "Success" : "Failure";
			Console.WriteLine(message);
			Console.ReadKey();
		}
		#endregion

		#region GetTransactionResonse
		/// <summary>
		/// Method to get the transaction date response details
		/// </summary>
		public static List<TransactionItem> GetTransactions()
		{
			var restClient = new RestClient(baseUrl);

			var request = new RestRequest("transactionsByDate", Method.GET);
			request.AddQueryParameter("Date", "03-06-2019");
			request.AddQueryParameter("Format", "JSON");

			var result = restClient.Execute<List<TransactionItem>>(request);

			return result.Data;
		}
		#endregion
	}
}
