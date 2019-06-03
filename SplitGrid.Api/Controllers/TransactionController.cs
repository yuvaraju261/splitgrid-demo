using SplitGridDomainModel;
using System.Web.Http;

namespace DemoSplitGridAPI.Controllers
{
	public class TransactionController : ApiController
	{
		#region MockData
		/// <summary>
		/// mocking the response object for testing purpose
		/// </summary>
		private readonly TransactionItem[] transactions = new[] {
		new TransactionItem { Error= "sample string 1",
							  ReceiptDate = "03-06-2019",
							  DateTime = "sample string 3",
							  ReceiptNr = 1,
							  PriceWithVat = 5,
							  PriceWithoutVat =6,
							  Discount = 7,
							  WholeSalePrice = 8,
							  BrandName ="sample string 9",
							  ArticleNr= "sample string 10",
							  EAN="sample string 11",
							  Quantity= 12,
							  InventoryStock= 13,
							  Size= "sample string 14",
							  Color= "sample string 15" },
		new TransactionItem
		{
							  Error= "sample string 2",
							  ReceiptDate = "03-06-2019",
							  DateTime = "sample string 4",
							  ReceiptNr = 2,
							  PriceWithVat = 6,
							  PriceWithoutVat =7,
							  Discount = 8,
							  WholeSalePrice = 9,
							  BrandName ="sample string 10",
							  ArticleNr= "sample string 10",
							  EAN="sample string 11",
							  Quantity= 13,
							  InventoryStock= 14,
							  Size= "sample string 14",
							  Color= "sample string 15"
		},
		new TransactionItem {
							  Error= "sample string 3",
							  ReceiptDate = "03-06-2019",
							  DateTime = "sample string 3",
							  ReceiptNr = 3,
							  PriceWithVat = 7,
							  PriceWithoutVat =8,
							  Discount = 9,
							  WholeSalePrice = 10,
							  BrandName ="sample string 9",
							  ArticleNr= "sample string 10",
							  EAN="sample string 11",
							  Quantity= 15,
							  InventoryStock= 18,
							  Size= "sample string 14",
							  Color= "sample string 15"
		}
		};
		#endregion

		#region transactionsByDate
		/// <summary>
		/// method to get the transaction date details
		/// </summary>
		/// <param name="Date"></param>
		/// <param name="Format"></param>
		/// <returns></returns>
		[Route("api/v1/transactionsByDate")]
		public IHttpActionResult Get(string Date, string Format)
		{
			foreach (var obj in transactions)
			{
				obj.ReceiptDate = Date;
			}
			return Ok(transactions);
		}
		#endregion
	}
}
