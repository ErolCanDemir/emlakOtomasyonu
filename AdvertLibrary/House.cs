using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdvertLibrary
{
    public class House
    {
        private int rooms;
        private int floor;
        private string state;
        private double area;
        private DateTime constructionDate;
        public enum houseType
        {
            Apartment,
            withGarden,
            Dublex,
            Sparate
        };
        private houseType hType;
        private bool status;
        private uint ıd;

        public int Rooms
        {
            get
            {
                return rooms;
            }

            set
            {
                if (value < 0)
                    rooms = 0;
                else
                    rooms = value;
            }
        }

        public int Floor
        {
            get
            {
                return floor;
            }

            set
            {
                floor = value;
            }
        }

        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }

        public double Area
        {
            get
            {
                return area;
            }

            set
            {
                area = value;
            }
        }

        public DateTime ConstructionDate
        {
            get
            {
                return constructionDate;
            }

            set
            {
                constructionDate = value;
            }
        }

        public houseType HouseType
        {
            get
            {
                return hType;
            }

            set
            {
                hType = value;
            }
        }

        public bool Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public uint Id
        {
            get
            {
                return ıd;
            }

            set
            {
                ıd = value;
            }
        }

        public int Age()
        {
            DateTime today = DateTime.Today;
            return (int)Math.Floor((today - this.ConstructionDate).TotalDays / 365.25);
        }
        public House(int rooms, int floor, string state, double area)
        {
            Rooms = rooms;
            Floor = floor;
            State = state;
            Area = area;
        }
        public House(int rooms, int floor, string state, double area, DateTime constructionDate)
        {
            Rooms = rooms;
            Floor = floor;
            State = state;
            Area = area;
            ConstructionDate = constructionDate;
        }
        public House(int rooms, int floor, string state, double area, DateTime contructionDate, Boolean status)
        {
            Rooms = rooms;
            Floor = floor;
            State = state;
            Area = area;
            ConstructionDate = contructionDate;
            Status = status;
        }

        public House(int rooms, int floor, string state, double area, DateTime contructionDate, Boolean status, houseType htype)
        {
            Rooms = rooms;
            Floor = floor;
            State = state;
            Area = area;
            ConstructionDate = contructionDate;
            Status = status;
            HouseType = htype;
        }
        public virtual string Info() // 'virtual' override anahtar kelimesini kullanmak için 
        {
            return string.Format("<house><id>{0}</id><rooms>{1}</rooms><floor>{2}</floor><state>{3}</state><area>{4}</area><constructionDate>{5}</constructionDate><status>{6}</status><houseType>{7}</houseType></house>", this.Id, this.Rooms, this.Floor, this.State, this.Area, this.ConstructionDate, this.Status, this.HouseType);
        }
        public decimal Price()
        {
            decimal price = 0;

            if (File.Exists("room_cost.txt"))
            {
                string txt = File.ReadAllText("room_cost.txt");
                price = Decimal.Parse("room_cost.txt") * Rooms;
            }
            else
            {
                price = 200 * Rooms;
            }
            return price;
        }
    }
}
