using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment01.Models
{
	internal class Book
	{
		public int Id { get; set; }                 
		public string Title { get; set; } 
		public string Isbn { get; set; } 
		public decimal Price { get; set; }
		public int NumberOfPages { get; set; }
		public int PublicationYear { get; set; }
		public bool InStock { get; set; }
	}
}
