using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvertLibrary;
using System.Xml.Linq;
using System.IO;
using System.Linq;

namespace AdvertApplication
{
    static class Program
    {
        public static Dictionary<string, List<string>> cities = new Dictionary<string, List<string>>();
        public static bool close = true;
        public static Form newForm;

        public static Dictionary<uint, House> adverts = new Dictionary<uint, House>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Program.Log("Started application", "PROCESS");
            readXML(); // XML leri okuyup adverts Dic. doldurcam...
            readcities(); // XML i okuyup cities Dic. doldurcam..
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());

            while (!close)
            {
                close = true;
                Application.Run(newForm);
            }
        }

        // Loglama işlemii..... --> Varsayılan parametre debug
        public static void Log(string text, string type = "DEBUG")
        {
            DateTime dateTime = DateTime.Now;

            string logLine = "["+dateTime.ToString()+"] ["+type+"] " + text;

            if (!File.Exists("log.log"))
            {
                File.Create("log.log").Close();
                Program.Log("Created log file", "INIT");
            }

            using (StreamWriter sw = File.AppendText("log.log"))
            {
                sw.WriteLine(logLine);
            }
        }

        public static void advertDelete(uint advertID)
        {
            Program.Log("Deleted advert " + advertID, "ACTION");
            Program.adverts.Remove(advertID);
            Program.save();
        }

        public static void advertArchive(uint advertID)
        {
            Program.Log("Archived advert " + advertID, "ACTION");
            Program.adverts[advertID].Status = false;
            Program.save();
        }

        public static void save()
        {
            List<RentHouse> rentHouses = new List<RentHouse>();
            List<SaleHouse> saleHouses = new List<SaleHouse>();

            foreach (var ilan in Program.adverts)
            {
                ilan.Value.Id = ilan.Key;
                if (ilan.Value.GetType().ToString() == "AdvertLibrary.RentHouse")
                {
                    rentHouses.Add(ilan.Value as RentHouse);
                }
                else
                {
                    saleHouses.Add(ilan.Value as SaleHouse);
                }
            }
            XDocument rentDoc = XDocument.Load("Rent.xml");
            rentDoc.Element("houses").Elements("house").Remove();
            rentDoc.Save("Rent.xml");
            Program.Log("Cleared Rent.xml", "FILE");

            XDocument saleDoc = XDocument.Load("Sale.xml");
            saleDoc.Element("houses").Elements("house").Remove();
            saleDoc.Save("Sale.xml");
            Program.Log("Cleared Sale.xml", "FILE");

            foreach (RentHouse house in rentHouses)
            {
                XElement yeniEklenecek = XElement.Parse(house.Info()); // XML için sanal Node oluşturuyor. https://msdn.microsoft.com/en-us/library/bb468714(v=vs.110).aspx
                rentDoc.Root.Add(yeniEklenecek);
                rentDoc.Save("Rent.xml");
            }
            Program.Log("Saved Rent.xml!", "FILE");
            foreach (SaleHouse house in saleHouses)
            {
                XElement yeniEklenecek = XElement.Parse(house.Info()); // XML için sanal Node oluşturuyor. https://msdn.microsoft.com/en-us/library/bb468714(v=vs.110).aspx
                saleDoc.Root.Add(yeniEklenecek);
                saleDoc.Save("Sale.xml");
            }
            Program.Log("Saved Sale.xml!", "FILE");
        }

        public static void readXML()
        {
            adverts = new Dictionary<uint, House>();
            XDocument doc = XDocument.Load("Sale.xml"); //XDocument xml i açıp okumak için yardımcı lib.
            Program.Log("Loaded Sale.xml!", "FILE");
            var satiliklar = doc.Descendants("house");
            foreach (var satilik in satiliklar)
            {
                uint id = UInt32.Parse(satilik.Element("id").Value);
                int rooms = Int32.Parse(satilik.Element("rooms").Value);
                int floor = Int32.Parse(satilik.Element("floor").Value);
                string state = satilik.Element("state").Value;
                double area = double.Parse(satilik.Element("area").Value);
                DateTime constructionDate = DateTime.Parse(satilik.Element("constructionDate").Value);
                bool status = bool.Parse(satilik.Element("status").Value);
                string houseType = satilik.Element("houseType").Value;
                decimal Price = decimal.Parse(satilik.Element("salePrice").Value);

                House.houseType htype;
                if (houseType == "Apartment")
                {
                    htype = House.houseType.Apartment;
                }
                else if (houseType == "withGarden")
                {
                    htype = House.houseType.withGarden;
                }
                else if (houseType == "Dublex")
                {
                    htype = House.houseType.Dublex;
                }
                else
                {
                    htype = House.houseType.Sparate;
                }

                SaleHouse ev = new SaleHouse(rooms, floor, state, area, constructionDate, status, htype);
                ev.SalePrice = Price;
                ev.Id = id;
                adverts.Add(id, ev);
            }

            Program.Log("Loaded Rent.xml!", "FILE");
            doc = XDocument.Load("Rent.xml");
            var kiraliklar = doc.Descendants("house");
            foreach (var kiralik in kiraliklar)
            {
                uint id = UInt32.Parse(kiralik.Element("id").Value);
                int rooms = Int32.Parse(kiralik.Element("rooms").Value);
                int floor = Int32.Parse(kiralik.Element("floor").Value);
                string state = kiralik.Element("state").Value;
                double area = double.Parse(kiralik.Element("area").Value);
                DateTime constructionDate = DateTime.Parse(kiralik.Element("constructionDate").Value);
                bool status = bool.Parse(kiralik.Element("status").Value);
                string houseType = kiralik.Element("houseType").Value;
                decimal Price = decimal.Parse(kiralik.Element("rentPrice").Value);
                decimal Deposit = decimal.Parse(kiralik.Element("deposit").Value);

                House.houseType htype;
                if (houseType == "Apartment")
                {
                    htype = House.houseType.Apartment;
                }
                else if (houseType == "withGarden")
                {
                    htype = House.houseType.withGarden;
                }
                else if (houseType == "Dublex")
                {
                    htype = House.houseType.Dublex;
                }
                else
                {
                    htype = House.houseType.Sparate;
                }

                RentHouse ev = new RentHouse(rooms, floor, state, area, constructionDate, status, htype);

                ev.RentPrice = Price;
                ev.Deposit = Deposit;
                ev.Id = id;
                adverts.Add(id, ev);
            }
        }


        public static void readcities()
        {

            // XML'i oku
            XDocument doc = XDocument.Load("cities.xml");

            Program.Log("Loaded cities.xml!", "FILE");

            // XML'deki şehir ve ilçeleri 'cities' değişkenine taşı
            foreach (var city in doc.Descendants("city"))
            {
                List<string> states = new List<string>();
                foreach (var state in city.Descendants("state"))
                {
                    states.Add(state.Value);
                }
                cities.Add(city.Attribute("name").Value, states);
            }

        }
        public static uint lastId()
        {
            uint enBuyuk = 0;
            foreach (var i in Program.adverts)
            {
                //i.Key
                if (i.Key > enBuyuk)
                {
                    enBuyuk = i.Key;
                }

            }
            return enBuyuk;
        }
    }
}
