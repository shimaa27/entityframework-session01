using Microsoft.EntityFrameworkCore;

namespace EFCoreAssignment01
{
	internal class Program
	{
		static void Main(string[] args)
		{
			using var context = new ReadMoreBooksContext();

			Console.WriteLine("Applied migrations:");
			foreach (var i in context.Database.GetAppliedMigrations())
				Console.WriteLine($"  [applied] {i}");

			var pending = context.Database.GetPendingMigrations().ToList();
			Console.WriteLine($"Pending migrations: {pending.Count}");
			foreach (var m in pending)
				Console.WriteLine($"  [pending] {m}");

		}
	}
}
