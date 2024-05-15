
using System.Collections.Immutable;
using System.Diagnostics;
namespace Lab2
{
    public class Lab2
    {
        static void Main(string[] args)
        {
            Lab2 lab2 = new  Lab2();
            lab2.bai1a();
            lab2.bai1b();
            Userdatalab2 userdata = new Userdatalab2();
            userdata.bai1c();
            Bai2 bai2 = new Bai2();
            bai2.bai2a();
            bai2.bai2b();

            Console.WriteLine("ID: " );
            string id = Console.ReadLine();
            Console.WriteLine("UserName: " );
            string username = Console.ReadLine();
            List<float> scores = new List<float>();
            for( int i = 0; i < 6; i++)
            {
                Console.Write($"Enter score {i + 1}: ");
                string input = Console.ReadLine();
                if (float.TryParse(input, out float score))
                {
                    scores.Add(score);
                }
                else
                {
                    Console.WriteLine($"Invalid score: {input}");
                    i--; 
                }
            }

            
            Bai3 bai3 = new Bai3(id, username, scores);
            Console.WriteLine("\nUserData Information:");
            Console.WriteLine("ID: " + id);
            Console.WriteLine("UserName: " + username);
            Console.WriteLine("Scores:");
            foreach (float score in scores)
            {
                Console.WriteLine(score);
            }
        }

        dynamic x = 10;

        public void bai1a()
        {
            Console.WriteLine("X: " + x);
        }
        public void bai1b()
        {
            getDetail(10);
            getDetail("Game");
            getDetail(true);
            getDetail(9.5);
        }
        public void getDetail(dynamic value)
        {
            Console.WriteLine("value" + value);
        }
    }
    public class Userdatalab2
    {
        public string id;
        public string username;
        public int level;
        public Userdatalab2(string id, string username, int level)
        {
            this.id = id;
            this.username = username;
            this.level = level;
        }
        public Userdatalab2()
        {
        }

        public void getInfo()
        {
            Console.WriteLine("ID: " + id + "Username: " + username + "Level: " + level);
        }
        public void bai1c()
        {
            Userdatalab2 data = new Userdatalab2("2024", "Hide on bush", 100);
            data.getInfo();
        }
    }
    
        
}