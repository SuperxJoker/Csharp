namespace ConsoleApp1;

public class WebApplication : Application
{
    public WebApplication(string name, int maxNumberOfUsers) : base(name,  maxNumberOfUsers)
    {
        
    }

    public void HttpRequest(User user)
    {
        int exists = 0;
        for (int i = 0; i < this.numberOfUsers; i++)
        {
            if (user.GetUsername().Equals(userArray[i].GetUsername()))
            {
                exists = 1;
            }
        }

        if (exists == 1)
        {
            Console.WriteLine("OK Request");
        }
        else
        {
            Console.WriteLine("Bad Request");
        }
    }
}