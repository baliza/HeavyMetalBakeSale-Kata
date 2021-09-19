using MetalBakeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MetalBakeWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        private Inventory inventory;

        public Service1()
        {
            inventory = new Inventory();
        }

        public double calculateAmountPrice(double priceList, int amountList)
        {
            return inventory.calculateAmountPrice(priceList, amountList);
        }

        public Item checkItemByChar(char code)
        {
            return inventory.checkItemByChar(code);
        }

        public void DelItem(Item item)
        {
            inventory.DelItem(item);
        }

        public double getRepayment(double totalMoney, double userMoney)
        {
            RepaymentCalculator rCalc = RepaymentCalculator.GetInstance();
            return rCalc.getRepayment(totalMoney, userMoney);
        }

        public bool isOnStock(Item item)
        {
            return inventory.isOnStock(item);
        }

        public override string ToString()
        {
            string first = string.Join("\n", inventory.ItemList.Select(e => e.ToString()).ToArray());
            return first;
        }
    }
}