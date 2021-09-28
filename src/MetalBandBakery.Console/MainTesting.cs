using MetalBandBakery.Core.Services;
using MetalBandBakey.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBandBakey.Infra.Repository.HTTP
{
    public class MainTesting
    {
        private static void Main(string[] args)
        {
            IRecipeService rService = new InMemoryRecipeServices();
            List<Recipe> rList = rService.GetAllRecipes();
            string dictionaryString = "{";
            foreach (var i in rList)
            {
                foreach (KeyValuePair<string, int> keyValues in i.Ingredients)
                {
                    dictionaryString += keyValues.Key + " : " + keyValues.Value + ", ";
                }
                dictionaryString += "\n\n";
            }
            dictionaryString = dictionaryString.TrimEnd(',', ' ') + "}";
            Console.WriteLine(dictionaryString);
            Console.ReadLine();
        }
    }
}