// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


using (var client = new UserService.SessionManagerClient())
{
    var userResponse = client.AuthByIdNumber(Guid.Parse(""), "", "", "");
}