using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text.Json.Nodes;

class Quiz
{
    string playerResponse = "";
    string playerResponse2 = "";
    string playerResponse3 = "";
    string playerResponse4 = "";
    string playerResponse5 = "";
    string playerResponse6 = "a";

    public static void Main(string[] args)
    {
        Quiz qz = new Quiz();
        while (qz.playerResponse6 == "a")
            {
            qz.playerResponse6 = "";
            Console.WriteLine("The quiz will begin");
            
            Console.WriteLine(qz.Firstquestion());
            Console.WriteLine(qz.Secondquestion());
            Console.WriteLine(qz.Thirdquestion());
            Console.WriteLine(qz.Fourthquestion());
            Console.WriteLine(qz.Fifthquestion());
            qz.yourgrade();
        }
       
    }
   
    

    
        

    
    public string Firstquestion()
    {
        Console.WriteLine("Which team led the league in wins this season?(No caps and only the mascot)");
        playerResponse = Console.ReadLine();
            if (playerResponse == "dodgers")
            return "Correct!";
        else return "Incorrect";

        return playerResponse;
    }
    public bool Secondquestion()
    {
        Console.WriteLine("Did Julio Rodriguez have a 20/20 season? True or false?");
        playerResponse2 = Console.ReadLine();
        if (playerResponse2 == "True")
            return true;
        else return false;
    }
    public int Thirdquestion()
    {
        Console.WriteLine("How many home runs did Aaron Judge hit in 2022?(if 0 is returned, it is correct)");
        playerResponse3 = Console.ReadLine();
        if (playerResponse3 == "62")
            return 0;
        else return 62;
    }
    public string Fourthquestion()
    {
        Console.WriteLine("Who recorded the most WAR for the Braves, Dansby Swanson, or Michael Harris?");
        playerResponse4 = Console.ReadLine();
        if (playerResponse4 == "Dansby Swanson")
            return "Correct";
        else return "Incorrect";
    }
    public string Fifthquestion()
    {
        Console.WriteLine("Who has the most home runs in the National League, Ronald Acuna Jr. or Kyle Schwarber?");
        playerResponse5 = Console.ReadLine();
        if (playerResponse5 == "Kyle Schwarber")
            return "Correct";
        else return "Incorrect";
    }
    public void yourgrade()
    {
        if (playerResponse == "dodgers" && playerResponse2 == "True" && playerResponse3 == "62" && playerResponse4 == "Dansby Swanson" && playerResponse5 == "Kyle Schwarber") Console.WriteLine("100%");
        else if (playerResponse == "dodgers" && playerResponse2 == "True" && playerResponse3 == "62" && playerResponse4 == "Dansby Swanson" && playerResponse5 != "Kyle Schwarber") Console.WriteLine("80%");
        else if (playerResponse == "dodgers" && playerResponse2 == "True" && playerResponse3 == "62" && playerResponse4 != "Dansby Swanson" && playerResponse5 == "Kyle Schwarber") Console.WriteLine("80%");
        else if (playerResponse == "dodgers" && playerResponse2 == "True" && playerResponse3 != "62" && playerResponse4 == "Dansby Swanson" && playerResponse5 == "Kyle Schwarber") Console.WriteLine("80%");
        else if (playerResponse == "dodgers" && playerResponse2 != "True" && playerResponse3 == "62" && playerResponse4 == "Dansby Swanson" && playerResponse5 == "Kyle Schwarber") Console.WriteLine("80%");
        else if (playerResponse != "dodgers" && playerResponse2 == "True" && playerResponse3 == "62" && playerResponse4 == "Dansby Swanson" && playerResponse5 == "Kyle Schwarber") Console.WriteLine("80%");
        else if (playerResponse != "dodgers" && playerResponse2 != "True" && playerResponse3 == "62" && playerResponse4 == "Dansby Swanson" && playerResponse5 == "Kyle Schwarber") Console.WriteLine("60%");
        else if (playerResponse != "dodgers" && playerResponse2 == "True" && playerResponse3 != "62" && playerResponse4 == "Dansby Swanson" && playerResponse5 == "Kyle Schwarber") Console.WriteLine("60%");
        else if (playerResponse != "dodgers" && playerResponse2 == "True" && playerResponse3 == "62" && playerResponse4 != "Dansby Swanson" && playerResponse5 == "Kyle Schwarber") Console.WriteLine("60%");
        else if (playerResponse != "dodgers" && playerResponse2 == "True" && playerResponse3 == "62" && playerResponse4 == "Dansby Swanson" && playerResponse5 != "Kyle Schwarber") Console.WriteLine("60%");
        else if (playerResponse == "dodgers" && playerResponse2 != "True" && playerResponse3 != "62" && playerResponse4 == "Dansby Swanson" && playerResponse5 == "Kyle Schwarber") Console.WriteLine("60%");
        else if (playerResponse == "dodgers" && playerResponse2 != "True" && playerResponse3 == "62" && playerResponse4 != "Dansby Swanson" && playerResponse5 == "Kyle Schwarber") Console.WriteLine("60%");
        else if (playerResponse == "dodgers" && playerResponse2 != "True" && playerResponse3 == "62" && playerResponse4 == "Dansby Swanson" && playerResponse5 != "Kyle Schwarber") Console.WriteLine("60%");
        else if (playerResponse == "dodgers" && playerResponse2 == "True" && playerResponse3 != "62" && playerResponse4 != "Dansby Swanson" && playerResponse5 == "Kyle Schwarber") Console.WriteLine("60%");
        else if (playerResponse == "dodgers" && playerResponse2 == "True" && playerResponse3 != "62" && playerResponse4 == "Dansby Swanson" && playerResponse5 != "Kyle Schwarber") Console.WriteLine("60%");
        else if (playerResponse != "dodgers" && playerResponse2 != "True" && playerResponse3 != "62" && playerResponse4 == "Dansby Swanson" && playerResponse5 == "Kyle Schwarber") Console.WriteLine("40%");
        else if (playerResponse != "dodgers" && playerResponse2 != "True" && playerResponse3 == "62" && playerResponse4 != "Dansby Swanson" && playerResponse5 == "Kyle Schwarber") Console.WriteLine("40%");
        else if (playerResponse != "dodgers" && playerResponse2 != "True" && playerResponse3 == "62" && playerResponse4 == "Dansby Swanson" && playerResponse5 != "Kyle Schwarber") Console.WriteLine("40%");
        else if (playerResponse != "dodgers" && playerResponse2 == "True" && playerResponse3 != "62" && playerResponse4 != "Dansby Swanson" && playerResponse5 == "Kyle Schwarber") Console.WriteLine("40%");
        else if (playerResponse != "dodgers" && playerResponse2 == "True" && playerResponse3 != "62" && playerResponse4 == "Dansby Swanson" && playerResponse5 != "Kyle Schwarber") Console.WriteLine("40%");
        else if (playerResponse == "dodgers" && playerResponse2 != "True" && playerResponse3 != "62" && playerResponse4 != "Dansby Swanson" && playerResponse5 == "Kyle Schwarber") Console.WriteLine("40%");
        else if (playerResponse == "dodgers" && playerResponse2 != "True" && playerResponse3 != "62" && playerResponse4 == "Dansby Swanson" && playerResponse5 != "Kyle Schwarber") Console.WriteLine("40%");
        else if (playerResponse == "dodgers" && playerResponse2 != "True" && playerResponse3 == "62" && playerResponse4 != "Dansby Swanson" && playerResponse5 != "Kyle Schwarber") Console.WriteLine("40%");
        else if (playerResponse == "dodgers" && playerResponse2 == "True" && playerResponse3 != "62" && playerResponse4 != "Dansby Swanson" && playerResponse5 != "Kyle Schwarber") Console.WriteLine("40%");
        else if (playerResponse == "dodgers" && playerResponse2 != "True" && playerResponse3 != "62" && playerResponse4 != "Dansby Swanson" && playerResponse5 != "Kyle Schwarber") Console.WriteLine("20%");
        else if (playerResponse != "dodgers" && playerResponse2 == "True" && playerResponse3 != "62" && playerResponse4 != "Dansby Swanson" && playerResponse5 != "Kyle Schwarber") Console.WriteLine("20%");
        else if (playerResponse != "dodgers" && playerResponse2 != "True" && playerResponse3 == "62" && playerResponse4 != "Dansby Swanson" && playerResponse5 != "Kyle Schwarber") Console.WriteLine("20%");
        else if (playerResponse != "dodgers" && playerResponse2 != "True" && playerResponse3 != "62" && playerResponse4 == "Dansby Swanson" && playerResponse5 != "Kyle Schwarber") Console.WriteLine("20%");
        else if (playerResponse != "dodgers" && playerResponse2 != "True" && playerResponse3 != "62" && playerResponse4 != "Dansby Swanson" && playerResponse5 == "Kyle Schwarber") Console.WriteLine("20%");
        else Console.WriteLine("0%");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Congrats!!! You finished the quiz! Would you like to play again? Press a to play again.");

        }
        playerResponse6 = Console.ReadLine();
        
            


    }
}
