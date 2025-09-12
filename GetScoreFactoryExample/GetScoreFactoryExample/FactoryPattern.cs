using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetScoreFactoryExample
{
    public interface INews
    {
        string Get();
    }

    public class DDSports : INews
    {
        public string Get()
        {
            return "Score from DDSports";
        }
    }

    public class StarSports : INews
    {
        public string Get()
        {
            return "Score from StarSports";
        }
    }

    public interface INewsFactory
    {
        INews CreateNews();
    }

    public class DDSportsFactory : INewsFactory
    {
        public INews CreateNews()
        {
            return new DDSports();
        }
    }

    public class StarSportsFactory : INewsFactory
    {
        public INews CreateNews()
        {
            return new StarSports();
        }
    }

    class NewsFactory
    {
        private INewsFactory news;

        public INews GetScore(string type) 
        {
            switch (type)
            {
                case "DDSports":
                    news = new DDSportsFactory();
                    break;
                case "StarSports":      
                    news = new StarSportsFactory();
                    break;
                default:
                throw new Exception("Invalid news type");
            }; 
            return news.CreateNews();
        }  
    }
}
