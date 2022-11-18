namespace ConsoleApp1;

public class Admin
{
    public string nameAdmin;
    public List<Application> adminApps;

    public Admin(string name, List<Application> adminApps)
    {
        this.nameAdmin = nameAdmin;
        this.adminApps = adminApps;
    }

    public void AddUser(User user, Application app)
    {
        if (app.AddUser(user) == false)
        {
            Console.WriteLine("New user cannot be added");
        }
        else
        {
            Console.WriteLine("User added");
        }
    }

    public void RemoveUser(User user, Application app)
    {
        if (app.DeleteUser(user) == false)
        {
            Console.WriteLine("User cannot be deleted");
        }
        else
        {
            Console.WriteLine("User deleted");
        }
    }
}