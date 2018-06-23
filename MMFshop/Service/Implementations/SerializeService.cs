using Models;
using Service;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Service.ImplementationBD
{
    public class SerializeService : ISerializeService
    {
        private MMFdbContext context;

        public SerializeService(MMFdbContext context)
        {
            this.context = context;
        }

        public void GetData()
        {


            DataContractJsonSerializer accountJS = new DataContractJsonSerializer(typeof(List<Furniture>));
            MemoryStream msAccountJS = new MemoryStream();
            accountJS.WriteObject(msAccountJS, context.Furnitures.ToList());
            msAccountJS.Position = 0;
            StreamReader srAccountJS = new StreamReader(msAccountJS);
            string AccountJSON = srAccountJS.ReadToEnd();
            srAccountJS.Close();
            msAccountJS.Close();

            DataContractJsonSerializer customerJS = new DataContractJsonSerializer(typeof(List<Customer>));
            MemoryStream msClient = new MemoryStream();
            customerJS.WriteObject(msClient, context.Customers.ToList());
            msClient.Position = 0;
            StreamReader srClient = new StreamReader(msClient);
            string customersJSON = srClient.ReadToEnd();
            srClient.Close();
            msClient.Close();

            DataContractJsonSerializer entryJS = new DataContractJsonSerializer(typeof(List<Entry>));
            MemoryStream msEntry = new MemoryStream();
            entryJS.WriteObject(msEntry, context.Entrys.ToList());
            msEntry.Position = 0;
            StreamReader srEntry = new StreamReader(msEntry);
            string entryJSON = srEntry.ReadToEnd();
            srEntry.Close();
            msEntry.Close();

            DataContractJsonSerializer OrderFurnitureJS = new DataContractJsonSerializer(typeof(List<OrderFurniture>));
            MemoryStream msOrderFurniture = new MemoryStream();
            OrderFurnitureJS.WriteObject(msOrderFurniture, context.OrderFurnitures.ToList());
            msOrderFurniture.Position = 0;
            StreamReader srOrderFurniture = new StreamReader(msOrderFurniture);
            string OrderFurnitureJSON = srOrderFurniture.ReadToEnd();
            srOrderFurniture.Close();
            msOrderFurniture.Close();

            DataContractJsonSerializer OrderJS = new DataContractJsonSerializer(typeof(List<Order>));
            MemoryStream msOrder = new MemoryStream();
            OrderJS.WriteObject(msOrder, context.Orders.ToList());
            msOrder.Position = 0;
            StreamReader srOrder = new StreamReader(msOrder);
            string OrderJSON = srOrder.ReadToEnd();
            srOrder.Close();
            msOrder.Close();

            File.WriteAllText(@"D:\MMFshopBackup.txt", "{\n" +
                "    \"Clients\": " + customersJSON + ",\n" +
                "    \"Furnitures\": " + AccountJSON + "\n" +
                "    \"Entrys\": " + entryJSON + "\n" +
                "    \"OrderFurnitures\": " + OrderFurnitureJSON + "\n" +
                "    \"Orders\": " + OrderJSON + "\n" +
                "}");
        }
    }
}
