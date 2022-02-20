using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1._5_;
class Program
{
    public static void ShowAds()
    {
        Console.WriteLine("Поситите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
        Thread.Sleep(1000);
        Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
        Thread.Sleep(2000);
        Console.WriteLine("Поситите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
        Thread.Sleep(3000);

    }

    public static void Main(string[] args)
    {
        List<User> listUsr = new List<User>();
        listUsr.Add(item: new User("papapa", "Sasha", "No"));
        listUsr.Add(item: new User("mamama", "Ivan", "Yes"));
        listUsr.Add(item: new User("sasasa", "Katja", "Yes"));
        listUsr.Add(item: new User("tatata", "Nastja", "No"));
        listUsr.Add(item: new User("jajaja", "Natasha", "Yes"));
        listUsr.Add(item: new User("dadada", "Dasha", "No"));

        foreach (User usr in listUsr)
        {
            Console.WriteLine("Приветствую тебя " + usr.Name + " !");
            if (usr.IsPremium != "Yes")
            {
                Console.WriteLine("Напоминаем Вам, что у Вас нет до сих пор Премиум доступа!");
                ShowAds();
            }
        }
    }
}