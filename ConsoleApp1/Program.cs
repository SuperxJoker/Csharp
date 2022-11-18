// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

using ConsoleApp1;

MobileApplication app1 = new MobileApplication("HBOMAX",40);
WebApplication app2 = new WebApplication("Facebook",56);
List<Application> appList = new List<Application>();

appList.Add(app1);
appList.Add(app2);

Admin superUser = new Admin(Console.ReadLine(), appList);

User user1 = new User("alexia", "superalexia","alexiaoaida@gmail.com");
User user2 = new User("razvan", "superrazvan","razvan@gmail.com");
User user3 = new User("ana","superana","ana@gmail.com");
User user4 = new User("andrei", "superandrei", "andrei@gmail.com");
User user5 = new User("maria", "supermaria", "maria@gmail.com");
User user6 = new User("stefan", "superstefan", "stefan@gmail.com");

superUser.AddUser(user1,app1);
superUser.AddUser(user2,app1);
superUser.AddUser(user3,app1);
superUser.AddUser(user4,app2);
superUser.AddUser(user5,app2);
superUser.AddUser(user6,app2);

Console.WriteLine(app1.GetNumberOfUsers());
Console.WriteLine(app1);
superUser.RemoveUser(user1,app1);
Console.WriteLine(app1);

app2.HttpRequest(user2);
user3.ChangePassword("newsuper");
user3.GetPassword();
Console.WriteLine(app2);
Console.WriteLine("Review {0} ", app1.RateApp());