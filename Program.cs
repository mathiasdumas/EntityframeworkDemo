using EntityTest.Database;
using EntityTest.Models;

using (var context = new DatabaseContext())
{
    context.Clients.Add(new Client { Name = "Dumas" });
    context.Animals.Add(new Animal { Nom = "Marley" });

    var client = context.Clients.FirstOrDefault(s => s.Id == 1);
    var animal = context.Animals.FirstOrDefault(s => s.Id == 1);
    Console.WriteLine("Adding");
    var reservation = new Reservation
    {
        Client = client,
        Animal = animal
    };

    context.Reservations.Add(reservation);
    context.SaveChanges();
};