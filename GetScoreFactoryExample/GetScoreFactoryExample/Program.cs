using GetScoreFactoryExample;

class Program
{
    public static void Main()
    {
       NewsFactory newsFactory = new NewsFactory();
       INews news = newsFactory.GetScore("DDSports");
       System.Console.WriteLine(news.Get());
    }
}