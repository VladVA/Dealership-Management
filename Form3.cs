using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dealer_Auto
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void VanzariPred_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Width = this.Width;
            form1.Height = this.Height;
            form1.StartPosition = FormStartPosition.Manual;
            form1.Location = new Point(this.Location.X, this.Location.Y);
            this.Visible = false;
            form1.ShowDialog();
            this.Visible = true;
            this.Close();
        }

        private void AdaugareVanzare_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();


            form2.Width = this.Width;
            form2.Height = this.Height;
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = new Point(this.Location.X, this.Location.Y);
            this.Visible = false;
            form2.ShowDialog();
            this.Visible = true;
            this.Close();
        }

        private void QueryButton1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-RARAV8G\\SQLEXPRESS;Initial Catalog=DealerAuto;Integrated Security=True"))
                {

                    con1.Open();
                    String query1 = @"select C.NumeCuloare
                                from Culori C join Vehicule V on C.CuloareID = V.CuloareID join Model M1 on M1.ModelID = V.ModelID
                                where M1.NumeModel = @model
                                group by C.NumeCuloare, C.CuloareID
                                having C.CuloareID = (select top 1 V1.CuloareID from Vehicule V1 join Model M2 on M2.ModelID = V1.ModelID
                                group by V1.CuloareID
                                having count(V1.CuloareID) = (select top 1 count(V2.CuloareID) from Vehicule V2 group by V2.CuloareID order by count(V2.CuloareID) desc))";
                    SqlCommand myCommand1 = new SqlCommand(query1, con1);
                    myCommand1.Parameters.AddWithValue("@model", NumeModel.Texts.ToString());
                    myCommand1.ExecuteNonQuery();
                    using (SqlDataReader cReader = myCommand1.ExecuteReader())
                    {
                        while (cReader.Read())
                        {
                            Query1.Texts = (String)cReader["NumeCuloare"];
                        }
                    }

                    con1.Close();
                }
            }
            catch
            {
                if (NumeModel.Texts == "Megane Sedan")
                MessageBox.Show("Nu au fost vandute masini de aceasta culoare din acest model.");
                else MessageBox.Show("Ati intrudus gresit modelul.");
            }

        }

        private void QueryButton2_Click(object sender, EventArgs e)
        {
            try
            {
                String aux = "";
                using (SqlConnection con2 = new SqlConnection("Data Source=DESKTOP-RARAV8G\\SQLEXPRESS;Initial Catalog=DealerAuto;Integrated Security=True"))
                {

                    con2.Open();
                    String query2 = @"select top 1 V.Nume, V.Prenume
                                from Vanzator V join VanzariVehicule VV on V.VanzatorID = VV.VanzatorID
                                where VV.VehiculID in (select VE.VehiculID from Vehicule VE join Motorizare M on M.MotorizareID = VE.MotorizareID where M.PutereMotor >= @pret)
                                group by VV.VanzatorID, V.Nume, V.Prenume
                                having count(VV.VanzatorID) = (select top 1 count(VV2.VanzatorID) from VanzariVehicule VV2 group by VV2.VanzatorID order by count(VV2.VanzatorID) desc)";
                    SqlCommand myCommand2 = new SqlCommand(query2, con2);
                    myCommand2.Parameters.AddWithValue("@pret", NrCai.Texts.ToString());
                    myCommand2.ExecuteNonQuery();
                    using (SqlDataReader cReader = myCommand2.ExecuteReader())
                    {
                        while (cReader.Read())
                        {
                            aux = (String)cReader["Nume"] + " " + (String)cReader["Prenume"];
                            Query2.Texts = aux;
                        }
                    }

                    con2.Close();
                }
            }
            catch
            {
                if (int.Parse(NrCai.Texts) > 200)
                    MessageBox.Show("Numarul de cai este peste numarul maxim de cai.");

            }
        }

        private void QueryButton3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con3 = new SqlConnection("Data Source=DESKTOP-RARAV8G\\SQLEXPRESS;Initial Catalog=DealerAuto;Integrated Security=True"))
                {

                    con3.Open();
                    String query3 = @"select sum(VV.PretVanzare) as SumaCuEmisii
                                from VanzariVehicule VV 
                                where VV.PretVanzare >= (select avg(VV.PretVanzare) from VanzariVehicule VV 
                                join Vehicule V on V.VehiculID = VV.VehiculID 
                                join Motorizare M on M.MotorizareID = V.MotorizareID where M.EmisiiCO < @emisii)";
                    SqlCommand myCommand3 = new SqlCommand(query3, con3);
                    myCommand3.Parameters.AddWithValue("@emisii", Emisii.Texts.ToString());
                    myCommand3.ExecuteNonQuery();
                    using (SqlDataReader cReader = myCommand3.ExecuteReader())
                    {
                        while (cReader.Read())
                        {
                            Query3.Texts = ((int)cReader["SumaCuEmisii"]).ToString() + " Euro";
                        }
                    }

                    con3.Close();
                }
            }
            catch
            {
                if (int.Parse(Emisii.Texts) < 118)
                    MessageBox.Show("Valoarea este sub valoarea minima a emisiilor de CO2.");

            }
        }


        private void QueryButton4_Click_1(object sender, EventArgs e)
        {
            try
            {
                String aux = "";
                using (SqlConnection con4 = new SqlConnection("Data Source=DESKTOP-RARAV8G\\SQLEXPRESS;Initial Catalog=DealerAuto;Integrated Security=True"))
                {

                    con4.Open();
                    String query4 = @"select VA.Nume, VA.Prenume 
                                from Vanzator VA join VanzariVehicule VV on VV.VanzatorID = VA.VanzatorID 
                                where VV.VehiculID in (select V.VehiculID from Vehicule V where V.AnFabricatie = year(getdate()))
                                group by VV.PretVanzare, VA.Nume, VA.Prenume
                                having VV.PretVanzare = (select max(VV2.PretVanzare) from VanzariVehicule VV2 join Vanzator VA2 on VV2.VanzatorID = VA2.VanzatorID  where VA2.SalariuBaza <= @salariu)";
                    SqlCommand myCommand4 = new SqlCommand(query4, con4);
                    myCommand4.Parameters.AddWithValue("@salariu", Salariu.Texts.ToString());
                    myCommand4.ExecuteNonQuery();
                    using (SqlDataReader cReader = myCommand4.ExecuteReader())
                    {
                        while (cReader.Read())
                        {
                            aux = (String)cReader["Nume"] + " " + (String)cReader["Prenume"];
                            Query4.Texts = aux;
                        }
                    }


                    con4.Close();
                }
            }
            catch
            {
                if (int.Parse(Emisii.Texts) < 7500)
                    MessageBox.Show("Valoarea este sub valoarea minima a salariilor de baza.");

            }
        }

        private void QueryButton1_MouseEnter(object sender, EventArgs e)
        {
            QueryButton1.BorderColor = Color.FromArgb(255, 191, 40);
        }

        private void QueryButton1_MouseLeave(object sender, EventArgs e)
        {
            QueryButton1.BorderColor = Color.Black;
        }

        private void QueryButton2_MouseEnter(object sender, EventArgs e)
        {
            QueryButton2.BorderColor = Color.FromArgb(255, 191, 40);
        }

        private void QueryButton2_MouseLeave(object sender, EventArgs e)
        {
            QueryButton2.BorderColor = Color.Black;
        }

        private void QueryButton3_MouseEnter(object sender, EventArgs e)
        {
            QueryButton3.BorderColor = Color.FromArgb(255, 191, 40);
        }

        private void QueryButton3_MouseLeave(object sender, EventArgs e)
        {
            QueryButton3.BorderColor = Color.Black;
        }

        private void QueryButton4_MouseEnter(object sender, EventArgs e)
        {
            QueryButton4.BorderColor = Color.FromArgb(255, 191, 40);
        }

        private void QueryButton4_MouseLeave(object sender, EventArgs e)
        {
            QueryButton4.BorderColor = Color.Black;
        }
    }
}
