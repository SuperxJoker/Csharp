namespace ConsoleApp1;

public class MobileApplication : Application
{
    private double ratings;
    
    public MobileApplication(string name, int maxNumberOfUsers) : base(name,  maxNumberOfUsers)
    {
        
    }

    public double RateApp()
    {
        double review = 0;

        for (int i = 0; i < this.numberOfUsers; i++)
        {
            Console.WriteLine("Review {0} ", userArray[i].GetUsername());
            review = Convert.ToDouble(Console.ReadLine());
            ratings = ratings + review;
        }

        return (ratings / numberOfUsers);
    }
}