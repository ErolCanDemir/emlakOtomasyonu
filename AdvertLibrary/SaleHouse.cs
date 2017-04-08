using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertLibrary
{
    public class SaleHouse : House
    {

        decimal salePrice;

        public SaleHouse(int rooms, int floor, string state, double area) : base (rooms, floor, state, area) // inheritance
        {

        }
        public SaleHouse(int rooms, int floor, string state, double area, DateTime constructionDate) : base(rooms, floor, state, area, constructionDate)
        {

        }
        public SaleHouse(int rooms, int floor, string state, double area, DateTime constructionDate, Boolean status) : base(rooms, floor, state, area, constructionDate, status)
        {

        }
        public SaleHouse(int rooms, int floor, string state, double area, DateTime constructionDate, Boolean status, houseType htype): base(rooms, floor, state, area, constructionDate, status, htype)
        {

        }

        public decimal SalePrice
        {
            get
            {
                return salePrice;
            }

            set
            {
                salePrice = value;
            }
        }

        public override string Info() // House sınfındaki Info() metodunu override edebilmek için
        {
            return string.Format("<house><id>{0}</id><rooms>{1}</rooms><floor>{2}</floor><state>{3}</state><area>{4}</area><constructionDate>{5}</constructionDate><status>{6}</status><houseType>{7}</houseType><salePrice>{8}</salePrice></house>", this.Id, this.Rooms, this.Floor, this.State, this.Area, this.ConstructionDate, this.Status, this.HouseType,this.SalePrice);
        }
    }
}
