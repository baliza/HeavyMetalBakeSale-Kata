using KataMuffin.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KataMuffin.Controllers
{
    public class StockController : Controller
    {
        private string PathJason = @"C:\Users\Nobody\source\repos\HeavyMetalBakeSale-Kata\KataMuffin\App_Data\Stock.json";

        // GET: Stocks
        public ActionResult Index()
        {
            return View(GetStock());
        }

        private List<Stock> GetStock()
        {
            using (StreamReader r = new StreamReader(PathJason)) //lectura de ficheros con la ruta
            {
                string fileContent = r.ReadToEnd(); //guarda lectura de todo el fichero como un string
                r.Close(); //antes de escribir es importante cerrar el fichero (la lectura)
                var stockList = JsonConvert.DeserializeObject<List<Stock>>(fileContent);
                return stockList;
            }
        }

        public ActionResult AddItemToStock(string idToStock)
        {
            using (StreamReader r = new StreamReader(PathJason)) //lectura de ficheros con la ruta
            {
                string fileContent = r.ReadToEnd(); //guarda lectura de todo el fichero como un string
                r.Close(); //antes de escribir es importante cerrar el fichero (la lectura)
                var stockList = JsonConvert.DeserializeObject<List<Stock>>(fileContent);
                var stockBuscado = stockList.FirstOrDefault(x => x.Id == idToStock);
                if (stockBuscado != null)
                {
                    stockBuscado.Amount++; //modifica la cantidad
                    System.IO.File.WriteAllText(PathJason, JsonConvert.SerializeObject(stockList)); //sobrescribe el texto serializandolo
                }
            }
            return RedirectToAction("Index");
        }

        public ActionResult RemoveItemFromStock(string idToStock)
        {
            using (StreamReader r = new StreamReader(PathJason)) //lectura de ficheros con la ruta
            {
                string fileContent = r.ReadToEnd(); //guarda lectura de todo el fichero como un string
                r.Close(); //antes de escribir es importante cerrar el fichero (la lectura)
                var stockList = JsonConvert.DeserializeObject<List<Stock>>(fileContent);
                var stockBuscado = stockList.FirstOrDefault(x => x.Id == idToStock);
                if (stockBuscado != null)
                {
                    stockBuscado.Amount--; //modifica la cantidad
                    System.IO.File.WriteAllText(PathJason, JsonConvert.SerializeObject(stockList)); //sobrescribe el texto serializandolo
                }
            }
            return RedirectToAction("Index");
        }
    }
}