namespace ConsoleApp1;

public class Application
{
    public string name = null;
    public int numberOfUsers;
    public int maxNumberOfUsers;
    public User[] userArray;
    

    public Application(string name, int maxNumberOfUsers)
    {
        this.name = name;
        this.maxNumberOfUsers = maxNumberOfUsers;
        this.userArray = new User[maxNumberOfUsers];
    }

    public string GetName()
    {
        return name;
    }

    public int GetNumberOfUsers()
    {
        return numberOfUsers;
    }
    
    public override string ToString()
    {
        return name + $" {numberOfUsers}";
    }

    public bool AddUser(User newUser)
    {
        if (numberOfUsers == maxNumberOfUsers)
        {
            return false;
        }
        else
        {
            userArray[numberOfUsers] = newUser;
            numberOfUsers++;
            return true;

        }
    }

    public bool DeleteUser(User toBeDeleted)
    {
        for (int i = 0; i < numberOfUsers; i++)
        {
            if (string.Equals(userArray[i].GetUsername(), toBeDeleted.GetUsername()))
            {
                for (int j = i; j < numberOfUsers - 1; j++)
                {
                    userArray[j] = userArray[j + 1];
                }

                userArray[numberOfUsers - 1] = null;
                numberOfUsers--;
                return true;
            }
        }

        return false;
    }
    
}