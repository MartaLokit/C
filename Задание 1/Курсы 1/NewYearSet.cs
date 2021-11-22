using System.IO;
namespace Курсы_1
{
    public class NewYearSet
    {
        public string SetName()
        {
            if (WeightSet == "500 гр")
            {
                return "Огонек";
            }
            if (WeightSet == "700 гр")
            {
                return "Светлячок";
            }
            if (WeightSet == "850 гр")
            {
                return "Игра";
            }
            if (WeightSet == "1000 гр" || WeightSet == "1 кг")
            {
                return "Санта";
            }
            return " ";
        }
        public string MaterialPack { get; set; }
        public string WeightSet { get; set; }
        public double Price()
        {
            if(WeightSet == "500 гр")
            {
                return 6.48;
            }
            if (WeightSet == "700 гр")
            {
                return 9.44;
            }
            if (WeightSet == "850 гр")
            {
                return 11.61;
            }
            if (WeightSet == "1000 гр"|| WeightSet == "1 кг")
            {
                return 13.99 ;
            }
            return 0 ;
        }
        public string Composition()
        {               
           string[] ChocolateSweet = File.ReadAllLines("fier.txt");
           string[] Lollipops = File.ReadAllLines("Lollipops.txt");
            
           foreach (var item in ChocolateSweet)
           {
                foreach (var items in Lollipops)
                {
                    return item +"\n "+ items;
                    //return items;
                }
                
           }          
            return " ";
        }
    }
}