// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

UserModel userModel = new()
{
    FirstName = "Kishor",
    LastName = "Naik"
};
Console.WriteLine($"{userModel.FirstName} {userModel.LastName}");

CustomerModel customerModel = new()
{
    FullName = "Kishor Naik",
    EmailId = "kishor.naik011.net@gmail.com"
};
Console.WriteLine($"{customerModel.FullName} {customerModel.EmailId}");