using System;
using EntityTest.Database;

namespace EntityTest.Models
{
	public class Reservation
	{
		public virtual Animal Animal { get; set; }
		public virtual Client Client { get; set; }


		public void Create(DatabaseContext context)
		{
			using (context)
			{
				context.Reservations.Add(this);

				context.SaveChanges();

				Console.WriteLine("ça a marché");
			}
		}

	}
}

