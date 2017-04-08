using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using AdvertLibrary;
using System.Xml;
using System.IO;

namespace AdvertApplication
{
    public partial class AdvertAdd : Form
    {
        House house;
        bool isEdit = false;

        public AdvertAdd()
        {
            InitializeComponent();
        }

        public AdvertAdd(House house)
        {
            InitializeComponent();

            this.isEdit = true;
            this.house = house;
        }

        private void AdvertAdd_Load(object sender, EventArgs e)
        {
            // 'cities' 
            foreach (var city in Program.cities)//şehirler cbox doldur
            {
                CBCity.Items.Add(city.Key);
            }

            if (this.isEdit)
            {
                Text = "Advert Edit";
                ButtonAdd.Image = AdvertApplication.Properties.Resources._1478167791_InterfaceExpendet_01;
                btnArchive.Visible = true;
                ButtonAdd.Size = new Size(255, 81);
                this.NUDRooms.Value = this.house.Rooms;
                this.NUDFloor.Value = this.house.Floor;
                this.NUDArea.Value = decimal.Parse(this.house.Area.ToString());
                this.CBActive.Checked = this.house.Status;
                this.DPConstructionDate.Value = this.house.ConstructionDate;

                if(this.house.HouseType == House.houseType.Apartment)
                {
                    this.RBApartment.Checked = true;
                } else if (this.house.HouseType == House.houseType.Dublex)
                {
                    this.RBDublex.Checked = true;
                } else if (this.house.HouseType == House.houseType.Sparate)
                {
                    this.RBSparate.Checked = true;
                } else if(this.house.HouseType == House.houseType.withGarden)
                {
                    this.RBGarden.Checked = true;
                }

                int i = 0, s = 0;
                foreach (var city in Program.cities)//şehirler cbox doldur
                {
                    foreach(string state in city.Value)
                    {
                        if(state == this.house.State)
                        {
                            this.CBCity.SelectedIndex = i;
                            this.CBState.SelectedIndex = s;
                        }
                        s++;
                    }
                    s = 0;
                    i++;
                }

                if (this.house.GetType().ToString() == "AdvertLibrary.RentHouse")
                {
                    this.RDRent.Checked = true;
                    RentHouse rh = this.house as RentHouse;
                    // Kiralik
                    this.TBRentPrice.Text = rh.RentPrice.ToString();
                    this.TBDeposit.Text = rh.Deposit.ToString();
                } else
                {
                    this.RDSale.Checked = true;
                    SaleHouse sh = this.house as SaleHouse;
                    // Satılık
                    this.TBSalePrice.Text = sh.SalePrice.ToString();
                }


            }
        }

        private void CBCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectCity;
            CBState.Items.Clear();
            SelectCity = CBCity.SelectedItem.ToString();
            foreach (string state in Program.cities[SelectCity])
            {
                CBState.Items.Add(state);
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string category;

            if (RDSale.Checked)
            {
                category = "sale";
            }
            else
            {
                category = "rent";
            }

            int rooms = Int32.Parse(NUDRooms.Value.ToString());
            int floor = Int32.Parse(NUDFloor.Value.ToString());
            string city = CBCity.SelectedItem.ToString();
            string state = CBState.SelectedItem.ToString();
            double area = double.Parse(NUDArea.Value.ToString());
            House.houseType type;
            if (RBApartment.Checked)
            {
                type = House.houseType.Apartment;
            }
            else if (RBDublex.Checked)
            {
                type = House.houseType.Dublex;
            }
            else if (RBGarden.Checked)
            {
                type = House.houseType.withGarden;
            }
            else
            {
                type = House.houseType.Sparate;
            }
            bool status;
            if (CBActive.Checked)
            {
                status = true;
            }
            else
            {
                status = false;
            }

            DateTime datepicker = DPConstructionDate.Value.Date;

            if (category == "sale")
            {
                decimal salePrice = decimal.Parse(TBSalePrice.Text);
                SaleHouse salehouse = new SaleHouse(rooms, floor, state, area, datepicker, status);
                salehouse.HouseType = type;
                salehouse.SalePrice = salePrice;

                if (this.isEdit)
                {
                    Program.adverts[this.house.Id] = salehouse;
                    Program.Log("Edited sale advert " + this.house.Id + " with " + NUDRooms.Value.ToString() + " rooms", "ACTION");
                    Program.save();
                } else
                {
                    uint SaleHouseID = Program.lastId() + 105;
                    salehouse.Id = SaleHouseID;
                    Directory.CreateDirectory(Application.StartupPath + "/photos/" + SaleHouseID.ToString());
                    Program.Log("Created new directory: " + Application.StartupPath + "/photos/" + SaleHouseID.ToString(), "FILE");

                    XElement yeniEklenecek = XElement.Parse(salehouse.Info()); // XML için sanal Node oluşturuyor. https://msdn.microsoft.com/en-us/library/bb468714(v=vs.110).aspx
                    XDocument doc = XDocument.Load("Sale.xml");
                    doc.Root.Add(yeniEklenecek);
                    doc.Save("Sale.xml");
                    Program.Log("Created sale advert " + SaleHouseID + " with " + NUDRooms.Value.ToString() + " rooms", "ACTION");
                    Program.Log("Inserted new advert in Sale.xml file", "FILE");
                }
            }
            else
            {
                decimal rentPrice = decimal.Parse(TBRentPrice.Text);
                decimal deposit = decimal.Parse(TBDeposit.Text);
                RentHouse renthouse = new RentHouse(rooms, floor, state, area, datepicker, status);
                renthouse.HouseType = type;
                renthouse.RentPrice = rentPrice;
                renthouse.Deposit = deposit;

                if (this.isEdit)
                {
                    Program.adverts[this.house.Id] = renthouse;
                    Program.Log("Edited rent advert " + this.house.Id + " with " + NUDRooms.Value.ToString() + " rooms", "ACTION");
                    Program.save();
                } else
                {
                    uint RentHouseID = Program.lastId() + 105;
                    renthouse.Id = RentHouseID;
                    Directory.CreateDirectory(Application.StartupPath + "/photos/" + RentHouseID.ToString());
                    Program.Log("Created new directory: "+ Application.StartupPath + "/photos/" + RentHouseID.ToString(), "FILE");


                    XElement yeniEklenecek = XElement.Parse(renthouse.Info()); // XML için sanal Node oluşturuyor. https://msdn.microsoft.com/en-us/library/bb468714(v=vs.110).aspx
                    XDocument doc = XDocument.Load("Rent.xml");
                    doc.Root.Add(yeniEklenecek);
                    doc.Save("Rent.xml");
                    Program.Log("Inserted new advert in Rent.xml file", "FILE");
                }
            }

            Program.newForm = new AdvertsForm();
            Program.close = false;
            Close();
        }

        private void RDSale_CheckedChanged(object sender, EventArgs e)
        {
            if (RDSale.Checked)
            {
                TBDeposit.Visible = false;
                TBRentPrice.Visible = false;
                TBSalePrice.Visible = true;
                label10.Visible = true;
                label8.Visible = false;
                label9.Visible = false;

                lblPriceCost.Visible = false;
                lblGuestPricee.Visible = false;
            }
            else
            {
                TBSalePrice.Visible = false;
                label10.Visible = false;
                TBDeposit.Visible = true;
                TBRentPrice.Visible = true;
                label8.Visible = true;
                label9.Visible = true;

                lblPriceCost.Visible = true;
                lblGuestPricee.Visible = true;

                string guestPrice;
                lblGuestPricee.Visible = true;
                RentHouse rh = new RentHouse(Int32.Parse(NUDRooms.Value.ToString()), 1, "", 1);
                guestPrice = rh.Price().ToString() + " TL";
                lblPriceCost.Text = guestPrice;
            }
        }

        private void AdvertAdd_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void AdvertAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.newForm = new AdvertsForm();
            Program.close = false;
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            Program.adverts[this.house.Id].Status = false;
            Program.save();
            Program.newForm = new AdvertsForm();
            Program.close = false;
            Close();
        }

        private void NUDRooms_ValueChanged(object sender, EventArgs e)
        {
            string guestPrice = "";

            if(RDRent.Checked)
            {
                lblGuestPricee.Visible = true;
                RentHouse rh = new RentHouse(Int32.Parse(NUDRooms.Value.ToString()), 1, "", 1);
                guestPrice = rh.Price().ToString() + " TL";
            } else { 
                lblGuestPricee.Visible = false;
            }

            lblPriceCost.Text = guestPrice;
        }
    }
}