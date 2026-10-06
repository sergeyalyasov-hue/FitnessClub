using FitnessClub.DAL;
using FitnessClub.Models;

ClientRepository2 repository = new ClientRepository2();

Client client = new Client
{
    Name = "Сергей",
    Phone = "111-22-33"
};

repository.Add(client);

Console.WriteLine("После добавления:");
foreach (Client item in repository.GetAll())
{
    Console.WriteLine(item.Id + " " + item.Name + " " + item.Phone);
}

client.Name = "Сергей Евгеньевич";
repository.Update(client);

Console.WriteLine();

Console.WriteLine("После изменения:");
Client updatedClient = repository.GetById(client.Id);
Console.WriteLine(updatedClient.Id + " " + updatedClient.Name + " " + updatedClient.Phone);

repository.Delete(client.Id);

Console.WriteLine();

Console.WriteLine("После удаления:");
Console.WriteLine("Количество клиентов: " + repository.GetAll().Count());