using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using AdvertLibrary;
using System.IO;
using System.Diagnostics;

namespace AdvertApplication
{
    public partial class AdvertsForm : Form
    {

        public AdvertsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.newForm = new LoginForm();
            Program.close = false;
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            uint ID = UInt32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (e.ColumnIndex == 12)
            {
                string photoPath = Application.StartupPath + "/photos/" + ID.ToString();

                if (Directory.Exists(photoPath) == true)
                {
                    // varsa
                    Process.Start(photoPath);
                    Program.Log(Application.StartupPath + "/photos/" + ID.ToString() + " folder has been opened", "PROCESS");
                }
                else
                {
                    // yoksa
                    MessageBox.Show("Not File!...");
                }
            }

            if(e.ColumnIndex == 13)
            {
                Program.newForm = new AdvertAdd(Program.adverts[ID]);
                Program.close = false;
                Close();
            }

            if(e.ColumnIndex == 14)
            {
                DialogResult result = MessageBox.Show("Are you want delete or archive? Click on 'Yes' if you want delete, click on 'No' if you want archive, click on 'Cancel' if you want cancel action.", "Sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
                switch (result)
                {
                    case DialogResult.Yes:
                        Program.advertDelete(ID);
                        reloadTable();
                        MessageBox.Show("Advert successfully deleted!");
                        break;

                    case DialogResult.No:
                        Program.advertArchive(ID);
                        reloadTable();
                        MessageBox.Show("Advert successfully archived!");
                        break;

                    case DialogResult.Cancel:
                        MessageBox.Show("Advert not deleted and not archived.");
                        break;
                }
            }
        }

        private void reloadTable()
        {
            Program.readXML();

            this.dataGridView1.Rows.Clear();
            foreach (var advert in Program.adverts)
            {
                string cat = "";
                string slPrice = "";
                string rnPrice = "";
                string deposit = "";
                if (advert.Value.GetType().ToString() == "AdvertLibrary.RentHouse")
                {
                    cat = "Rent";
                    RentHouse rhouse = advert.Value as RentHouse;
                    rnPrice = rhouse.RentPrice.ToString("#,##0.00"); // # --> para formatı
                    deposit = rhouse.Deposit.ToString("#,##0.00");
                }
                else if (advert.Value.GetType().ToString() == "AdvertLibrary.SaleHouse")
                {
                    cat = "Sale";
                    SaleHouse shouse = advert.Value as SaleHouse;
                    slPrice = shouse.SalePrice.ToString("#,##0.00");
                }
                this.dataGridView1.Rows.Add(advert.Key, cat, advert.Value.Rooms, advert.Value.Floor, advert.Value.State, advert.Value.Area, advert.Value.Age(), advert.Value.HouseType, advert.Value.Status ? "Active " : "Passive", slPrice, rnPrice, deposit);
            }
        }

        private void AdvertsForm_Load(object sender, EventArgs e)
        {
            foreach (var city in Program.cities)//şehirler cbox doldurtcas..
            {
                CBCity.Items.Add(city.Key);
            }
            reloadTable(); // Tabloyu Güncelledimm..

            DataGridViewButtonColumn fotoBtn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(fotoBtn);
            fotoBtn.HeaderText = "Photos";
            fotoBtn.Text = "Photos";
            fotoBtn.Name = "btnPhoto";
            fotoBtn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn duzenleBtn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(duzenleBtn);
            duzenleBtn.HeaderText = "Edit";
            duzenleBtn.Text = "Edit";
            duzenleBtn.Name = "btnEdit";
            duzenleBtn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn silBtn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(silBtn);
            silBtn.HeaderText = "Delete";
            silBtn.Text = "Delete";
            silBtn.Name = "btnDelete";
            silBtn.UseColumnTextForButtonValue = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.newForm = new AdvertAdd();
            Program.close = false;
            Close();
        }

        private void CBCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectCity;
            CBState.Items.Clear();
            if (CBCity.SelectedIndex != -1) // itemn seçili olmaması durumuna -1 veriliyorimiş.. [il kutusundan herhangi bir il seçiliyse]
            {
                SelectCity = CBCity.SelectedItem.ToString();
                foreach (string state in Program.cities[SelectCity])
                {
                    CBState.Items.Add(state);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string state = CBState.SelectedIndex != -1 ? CBState.SelectedItem.ToString() : "";
            decimal roomsMin = NUDRoomsMin.Value;
            decimal roomsMax = NUDRoomsMax.Value;
            decimal floorMin = NUDFloorMin.Value;
            decimal floorMax = NUDFloorMax.Value;
            decimal areaMin = NUDAreaMin.Value;
            decimal areaMax = NUDAreaMax.Value;
            decimal ageMin = NUDAgeMin.Value;
            decimal ageMax = NUDAgeMax.Value;
            string type = CBHType.SelectedIndex != -1 ? CBHType.SelectedItem.ToString() : "";
            bool oaa = CBOAA.Checked;
            decimal priceMin = NUDPriceMin.Value;
            decimal priceMax = NUDPriceMax.Value;
            decimal depositMin = NUDDepositMin.Value;
            decimal depositMax = NUDDepositMax.Value;
            decimal SearchID = NUDIDSearch.Value;

            //MessageBox.Show("State: " + state + "\nRooms: " + roomsMin.ToString() + "-" + roomsMax.ToString() + "\nFloor: " + floorMin.ToString() + "-" + floorMax.ToString() + "\nArea: " + areaMin.ToString() + "\nAge: " + ageMin.ToString() + "-" + ageMax.ToString() + "\nH.Type: " + type + "\nOnly Active? " + oaa.ToString() + "\nPrice: " + priceMin.ToString() + "-" + priceMax.ToString() + "\nDeposit: " + depositMin.ToString() + "-" + depositMax.ToString() + "\nID: " + SearchID.ToString());

            House.houseType Htype;
            if (type == "Dublex")
            {
                Htype = House.houseType.Dublex;
            }
            else if (type == "Apartment")
            {
                Htype = House.houseType.Apartment;
            }
            else if (type == "withGarden")
            {
                Htype = House.houseType.withGarden;
            }
            else if (type == "Sparate")
            {
                Htype = House.houseType.Sparate;
            }
            else
            {
                Htype = House.houseType.Dublex;
            }

            Dictionary<uint, House> results = new Dictionary<uint, House>();

            foreach (var advert in Program.adverts)
            {
                bool right = true;

                decimal price = 0;
                decimal deposit = 0;
                if (advert.Value.GetType().ToString() == "AdvertLibrary.RentHouse")
                {
                    RentHouse rh = advert.Value as RentHouse;
                    price = rh.RentPrice;
                    deposit = rh.Deposit;
                } else
                {
                    SaleHouse sh = advert.Value as SaleHouse;
                    price = sh.SalePrice;
                }

                if (state != "")
                {
                    if (right && advert.Value.State == state)
                    {
                        right = true;
                    }
                    else
                    {
                        right = false;
                    }
                }
                //for rooms
                if (roomsMin != 0 || roomsMax != 0)
                {
                    if (roomsMin != 0 && roomsMax == 0)
                    {
                        if (right && advert.Value.Rooms >= roomsMin)
                        {
                            right = true;
                        }
                        else
                        {
                            right = false;
                        }
                    }
                    else
                    {
                        if (right && advert.Value.Rooms >= roomsMin && advert.Value.Rooms <= roomsMax)
                        {
                            right = true;
                        }
                        else
                        {
                            right = false;
                        }
                    }
                }
                //for floor
                if (floorMin != 0 || floorMax != 0)
                {
                    if (floorMin != 0 && floorMax == 0)
                    {
                        if (right && advert.Value.Floor >= floorMin)
                        {
                            right = true;
                        }
                        else
                        {
                            right = false;
                        }
                    }
                    else
                    {
                        if (right && advert.Value.Floor >= floorMin && advert.Value.Floor <= floorMax)
                        {
                            right = true;
                        }
                        else
                        {
                            right = false;
                        }
                    }
                }
                //for area
                if (areaMin != 0 || areaMax != 0)
                {
                    if (areaMin != 0 && areaMax == 0)
                    {
                        if (right && advert.Value.Area >= double.Parse(areaMin.ToString()))
                        {
                            right = true;
                        }
                        else
                        {
                            right = false;
                        }
                    }
                    else
                    {
                        if (right && advert.Value.Area >= double.Parse(areaMin.ToString()) && advert.Value.Area <= double.Parse(areaMax.ToString()))
                        {
                            right = true;
                        }
                        else
                        {
                            right = false;
                        }
                    }
                }
                //for age
                if (ageMin != 0 || ageMax != 0)
                {
                    if (ageMin != 0 && ageMax == 0)
                    {
                        if (right && advert.Value.Age() >= ageMin)
                        {
                            right = true;
                        }
                        else
                        {
                            right = false;
                        }
                    }
                    else
                    {
                        if (right && advert.Value.Age() >= ageMin && advert.Value.Age() <= ageMax)
                        {
                            right = true;
                        }
                        else
                        {
                            right = false;
                        }
                    }
                }
                //for htype
                if (type != "")
                {
                    if(right && advert.Value.HouseType == Htype)
                    {
                        right = true;
                    }else
                    {
                        right = false;
                    }
                }

                //for price

                // Todo:
                if (priceMin != 0 || priceMax != 0)
                {
                    if (priceMin != 0 && priceMax == 0)
                    {
                        if(right && price >= priceMin)
                        {
                            right = true;
                        } else
                        {
                            right = false;
                        }
                    }
                    else
                    {
                        if(right && price >= priceMin && price <= priceMax)
                        {
                            right = true;
                        } else
                        {
                            right = false;
                        }
                    }
                }
                //for deposit
                if (depositMin != 0 || depositMax != 0)
                {
                    if (depositMin != 0 && depositMax == 0)
                    {
                        if(right && deposit >= depositMin)
                        {
                            right = true;
                        } else
                        {
                            right = false;
                        }
                    }
                    else
                    {
                        if(right && deposit >= depositMin && deposit <= depositMax)
                        {
                            right = true;
                        } else
                        {
                            right = false;
                        }
                    }
                }
                //for active
                if (oaa)
                {
                    if (right && advert.Value.Status)
                    {
                        right = true;
                    }
                    else
                    {
                        right = false;
                    }
                }
                //for ID
                if (SearchID != 0)
                {
                    if (right && advert.Key == SearchID)
                    {
                        right = true;
                    }
                    else
                    {
                        right = false;
                    }
                }

                if (right)
                {
                    results.Add(advert.Key, advert.Value);
                }
            }

            this.dataGridView1.Rows.Clear();
            foreach (var advert in results)
            {
                string cat = "";
                string slPrice = "";
                string rnPrice = "";
                string deposit = "";
                if (advert.Value.GetType().ToString() == "AdvertLibrary.RentHouse")
                {
                    cat = "Rent";
                    RentHouse rhouse = advert.Value as RentHouse;
                    rnPrice = rhouse.RentPrice.ToString();
                    deposit = rhouse.Deposit.ToString();
                }
                else if (advert.Value.GetType().ToString() == "AdvertLibrary.SaleHouse")
                {
                    cat = "Sale";
                    SaleHouse shouse = advert.Value as SaleHouse;
                    slPrice = shouse.SalePrice.ToString();
                }
                this.dataGridView1.Rows.Add(advert.Key, cat, advert.Value.Rooms, advert.Value.Floor, advert.Value.State, advert.Value.Area, advert.Value.Age(), advert.Value.HouseType, advert.Value.Status, slPrice, rnPrice, deposit);
            }
            Program.Log("Advert search form submitted", "ACTION");
        }

        private void BTClearSearch_Click(object sender, EventArgs e)
        {
            RBAll.Checked = true;
            NUDRoomsMin.Value = 0;
            NUDRoomsMax.Value = 0;
            NUDFloorMin.Value = 0;
            NUDFloorMax.Value = 0;
            NUDAreaMin.Value = 0;
            NUDAreaMax.Value = 0;
            NUDAgeMin.Value = 0;
            NUDAgeMax.Value = 0;
            NUDPriceMin.Value = 0;
            NUDPriceMax.Value = 0;
            NUDDepositMin.Value = 0;
            NUDDepositMax.Value = 0;
            CBOAA.Checked = false;
            NUDIDSearch.Value = 0;
            CBHType.SelectedIndex = -1;
            CBState.SelectedIndex = -1;
            CBCity.SelectedIndex = -1;

            this.dataGridView1.Rows.Clear();
            foreach (var advert in Program.adverts)
            {
                string cat = "";
                string slPrice = "";
                string rnPrice = "";
                string deposit = "";
                if (advert.Value.GetType().ToString() == "AdvertLibrary.RentHouse")
                {
                    cat = "Rent";
                    RentHouse rhouse = advert.Value as RentHouse;
                    rnPrice = rhouse.RentPrice.ToString();
                    deposit = rhouse.Deposit.ToString();
                }
                else if (advert.Value.GetType().ToString() == "AdvertLibrary.SaleHouse")
                {
                    cat = "Sale";
                    SaleHouse shouse = advert.Value as SaleHouse;
                    slPrice = shouse.SalePrice.ToString();
                }
                this.dataGridView1.Rows.Add(advert.Key, cat, advert.Value.Rooms, advert.Value.Floor, advert.Value.State, advert.Value.Area, advert.Value.Age(), advert.Value.HouseType, advert.Value.Status, slPrice, rnPrice, deposit);
            }

        }

        private void RDSale_CheckedChanged(object sender, EventArgs e)
        {
            if (RDSale.Checked)
            {
                label15.Enabled = false;
                NUDDepositMax.Enabled = false;
                NUDDepositMin.Enabled = false;
            } else
            {
                label15.Enabled = true;
                NUDDepositMax.Enabled = true;
                NUDDepositMin.Enabled = true;
            }
        }
    }
}