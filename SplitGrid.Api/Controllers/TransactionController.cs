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
		new TransactionItem { Error= "sample data",
							  ReceiptDate = "2019-06-03",
							  DateTime = "2019-06-03 00:00",
							  ReceiptNr = 1,
							  PriceWithVat = 5,
							  PriceWithoutVat =6,
							  Discount = 7,
							  WholeSalePrice = 8,
							  BrandName ="Tesla",
							  ArticleNr= "1234",
							  EAN="C345",
							  Quantity= 12,
							  InventoryStock= 13,
							  Size= "14",
							  Color= "Black" },
		new TransactionItem
		{
							  Error= "sample data",
							  ReceiptDate = "2019-03-06",
							  DateTime = "2019-03-06 00:00",
							  ReceiptNr = 2,
							  PriceWithVat = 6,
							  PriceWithoutVat =7,
							  Discount = 8,
							  WholeSalePrice = 9,
							  BrandName ="BMW",
							  ArticleNr= "345",
							  EAN="3456",
							  Quantity= 13,
							  InventoryStock= 14,
							  Size= "15",
							  Color= "Red"
		},
		new TransactionItem {
							  Error= "sample",
							  ReceiptDate = "2019-06-03",
							  DateTime = "2019-06-03 00:00",
							  ReceiptNr = 3,
							  PriceWithVat = 7,
							  PriceWithoutVat =8,
							  Discount = 9,
							  WholeSalePrice = 10,
							  BrandName ="Ford",
							  ArticleNr= "6543",
							  EAN="8765",
							  Quantity= 15,
							  InventoryStock= 18,
							  Size= "25",
							  Color= "Blue"
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
