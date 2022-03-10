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

    public partial class Form1 : Form
    {
        public class ClientVehicul
    {
        public string Nume, Prenume, NumarTel, AdresaMail, Adresa, SerieSasiu;
        public int ModelID, MotorizareID, AnFab, CuloareID,Pret;

        public ClientVehicul()
        {
            Nume = "";
            Prenume = "";
            NumarTel = "";
            AdresaMail = "";
            Adresa = "";
            SerieSasiu = "";
            ModelID = 0;
            MotorizareID = 0;
            AnFab = 0;
            CuloareID = 0;
            Pret = 0;
        }

        public ClientVehicul(string Nume, string Prenume, string NumarTel, string AdresaMail, string Adresa, string SerieSasiu, int ModelID, int MotorizareID, int AnFab, int CuloareID, int Pret)
        {
            this.Nume = Nume;
            this.Prenume = Prenume;
            this.NumarTel = NumarTel;
            this.AdresaMail = AdresaMail;
            this.Adresa = Adresa;
            this.SerieSasiu = SerieSasiu;
            this.ModelID = ModelID;
            this.MotorizareID = MotorizareID;
            this.AnFab = AnFab;
            this.CuloareID = CuloareID;
            this.Pret = Pret;
        }
    }

        public Form1()
        {
            InitializeComponent();

        }


        private int pretDupaModel = 0, pretDupaDotare = 0, pretDupaMotorizare = 0;
        private int pretModel1 = 0, pretModel2 = 0, pretModel3 = 0, pretModel4 = 0;
        private int pretDotare1 = 0, pretDotare2 = 0, pretDotare3 = 0;
        private int pretMotorizare1 = 0, pretMotorizare2 = 0, pretMotorizare3 = 0, pretMotorizare4 = 0;
        private void PopulateFields()
        {
            using (SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-RARAV8G\\SQLEXPRESS;Initial Catalog=DealerAuto;Integrated Security=True"))
            {
                DataTable dt = new DataTable();
                con1.Open();
                //SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("select * from Model", con1);
                myCommand.ExecuteNonQuery();
                //myReader = myCommand.ExecuteReader();

                using (var dataAdapter = new SqlDataAdapter(myCommand))
                {
                    
                    dataAdapter.Fill(dt);
                    ModelText1.Text = (dt.Rows[0].ItemArray[1].ToString());
                    ModelPrice1.Text = (dt.Rows[0].ItemArray[2].ToString() + " Euro");
                    pretModel1 = ((int)dt.Rows[0].ItemArray[2]);

                    ModelText2.Text = (dt.Rows[1].ItemArray[1].ToString());
                    ModelPrice2.Text = (dt.Rows[1].ItemArray[2].ToString() + " Euro");
                    pretModel2 = ((int)dt.Rows[1].ItemArray[2]);

                    ModelText3.Text = (dt.Rows[2].ItemArray[1].ToString());
                    ModelPrice3.Text = (dt.Rows[2].ItemArray[2].ToString() + " Euro");
                    pretModel3 = ((int)dt.Rows[2].ItemArray[2]);

                    ModelText4.Text = (dt.Rows[3].ItemArray[1].ToString());
                    ModelPrice4.Text = (dt.Rows[3].ItemArray[2].ToString() + " Euro");
                    pretModel4 = ((int)dt.Rows[3].ItemArray[2]);
                }

              
                con1.Close();
            }//end using

        }


        private int nrDotZen = 0, nrDotIntense = 0, nrDotParis = 0, nrDot = 0;
        private void PopulatePachet()
        {
            using (SqlConnection conDot1 = new SqlConnection("Data Source=DESKTOP-RARAV8G\\SQLEXPRESS;Initial Catalog=DealerAuto;Integrated Security=True"))
            {
                NumePachet1.Text = "";
                NumePachet2.Text = "";
                NumePachet3.Text = "";
                String zen = "Zen", intense = "Intense", paris = "Initiale Paris";
                NumePachet1.Text = zen;
                NumePachet2.Text = intense;
                NumePachet3.Text = paris;
                    
                
                conDot1.Open();

                //Zen
                DataTable dtDot11 = new DataTable();
                SqlCommand commDot11 = new SqlCommand("select COUNT(DotareID) as NR, SUM(Pret) from Dotari where Pachet = @Zen", conDot1);
                commDot11.Parameters.AddWithValue("@Zen", zen.ToString());
                commDot11.ExecuteNonQuery();

                using (var dataAdapter = new SqlDataAdapter(commDot11))
                {
                    dataAdapter.Fill(dtDot11);
                    nrDotZen = ((int)dtDot11.Rows[0].ItemArray[0]);
                   // PretPachet1.Text = (dtDot11.Rows[0].ItemArray[1].ToString());
                    pretDotare1 = pretDupaModel + ((int)dtDot11.Rows[0].ItemArray[1]);
                    PretPachet1.Text = pretDotare1.ToString() + " Euro";
                }

                DataTable dtDot12 = new DataTable();
                SqlCommand commDot12 = new SqlCommand("select DotareID, Nume, Pret from Dotari where Pachet = @Zen group by DotareID, Nume, Pret", conDot1);
                commDot12.Parameters.AddWithValue("@Zen", zen.ToString());
                commDot12.ExecuteNonQuery();

                DotariPachet1.Text = "";
                TextDetalii1.Text = "";

                string newLine = Environment.NewLine;
                using (var dataAdapter = new SqlDataAdapter(commDot12))
                {
                    dataAdapter.Fill(dtDot12);
                    for (int i = 0; i < 11; i++)
                    {
                        DotariPachet1.Text = DotariPachet1.Text + dtDot12.Rows[i].ItemArray[1].ToString() + newLine;
                    }
                    for (int i = 0; i < nrDotZen; i++)
                    {
                        TextDetalii1.Text = TextDetalii1.Text + dtDot12.Rows[i].ItemArray[1].ToString() + newLine;
                    }
                }



                //Intense
                DataTable dtDot21 = new DataTable();
                SqlCommand commDot21 = new SqlCommand("select COUNT(DotareID) as NR, SUM(Pret) from Dotari where Pachet = @Zen or Pachet = @Intense", conDot1);
                commDot21.Parameters.AddWithValue("@Zen", zen.ToString());
                commDot21.Parameters.AddWithValue("@Intense", intense.ToString());
                commDot21.ExecuteNonQuery();

                using (var dataAdapter = new SqlDataAdapter(commDot21))
                {
                    dataAdapter.Fill(dtDot21);
                    nrDotIntense = ((int)dtDot21.Rows[0].ItemArray[0]);
                    //PretPachet2.Text = (dtDot21.Rows[0].ItemArray[1].ToString());
                    pretDotare2 = pretDupaModel + ((int)dtDot21.Rows[0].ItemArray[1]);
                    PretPachet2.Text = pretDotare2.ToString() + " Euro";
                }

                DataTable dtDot22 = new DataTable();
                SqlCommand commDot22 = new SqlCommand("select DotareID, Nume, Pret from Dotari where Pachet = @Zen or Pachet = @Intense group by DotareID, Nume, Pret", conDot1);
                commDot22.Parameters.AddWithValue("@Zen", zen.ToString());
                commDot22.Parameters.AddWithValue("@Intense", intense.ToString());
                commDot22.ExecuteNonQuery();

                DotariPachet2.Text = "";
                TextDetalii2.Text = "";

                using (var dataAdapter = new SqlDataAdapter(commDot22))
                {
                    dataAdapter.Fill(dtDot22);
                    for (int i = 0; i < 11; i++)
                    {
                        DotariPachet2.Text = DotariPachet2.Text + dtDot22.Rows[i].ItemArray[1].ToString() + newLine;
                    }
                    for (int i = 0; i < nrDotIntense; i++)
                    {
                        TextDetalii2.Text = TextDetalii2.Text + dtDot22.Rows[i].ItemArray[1].ToString() + newLine;
                    }
                }

                //Initiale Paris
                DataTable dtDot31 = new DataTable();
                SqlCommand commDot31 = new SqlCommand("select COUNT(DotareID) as NR, SUM(Pret) from Dotari where Pachet = @Zen or Pachet = @Intense or Pachet = @Paris", conDot1);
                commDot31.Parameters.AddWithValue("@Zen", zen.ToString());
                commDot31.Parameters.AddWithValue("@Intense", intense.ToString());
                commDot31.Parameters.AddWithValue("@Paris", paris.ToString());
                commDot31.ExecuteNonQuery();

                using (var dataAdapter = new SqlDataAdapter(commDot31))
                {
                    dataAdapter.Fill(dtDot31);
                    nrDotParis = ((int)dtDot31.Rows[0].ItemArray[0]);
                    //PretPachet3.Text = (dtDot31.Rows[0].ItemArray[1].ToString());
                    pretDotare3 = pretDupaModel + ((int)dtDot31.Rows[0].ItemArray[1]);
                    PretPachet3.Text = pretDotare3.ToString() + " Euro";
                }

                DataTable dtDot32 = new DataTable();
                SqlCommand commDot32 = new SqlCommand("select DotareID, Nume, Pret from Dotari where Pachet = @Zen or Pachet = @Intense or Pachet = @Paris group by DotareID, Nume, Pret", conDot1);
                commDot32.Parameters.AddWithValue("@Zen", zen.ToString());
                commDot32.Parameters.AddWithValue("@Intense", intense.ToString());
                commDot32.Parameters.AddWithValue("@Paris", paris.ToString());
                commDot32.ExecuteNonQuery();

                DotariPachet3.Text = "";
                TextDetalii3.Text = "";

                using (var dataAdapter = new SqlDataAdapter(commDot32))
                {
                    dataAdapter.Fill(dtDot32);
                    for (int i = 0; i < 11; i++)
                    {
                        DotariPachet3.Text = DotariPachet3.Text + dtDot32.Rows[i].ItemArray[1].ToString() + newLine;
                    }
                    for (int i = 0; i < nrDotParis; i++)
                    {
                        TextDetalii3.Text = TextDetalii3.Text + dtDot32.Rows[i].ItemArray[1].ToString() + newLine;
                    }
                }




                conDot1.Close();
            }
        }

        ClientVehicul a = new ClientVehicul();
        private int IDMotorizare1, IDMotorizare2, IDMotorizare3, IDMotorizare4;

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateFields();
            //PopulatePachet();
            a.AnFab = DateTime.Now.Year;
            IDMotorizare1 = 0;
            IDMotorizare2 = 0;
            IDMotorizare3 = 0;
            IDMotorizare4 = 0;
            //MoPanel.Visible = false;
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


        private void dbTextBoxNrTel__TextChanged(object sender, EventArgs e)
        {
            if (dbTextBoxNrTel.Texts.Length != 10)
            {
                if (dbTextBoxNrTel.Texts.Length != 0)
                    dbTextBoxNrTel.BorderColor = Color.Red;
            }
            else
                dbTextBoxNrTel.BorderColor = Color.Black;
        }


        private void PopulateMotor(int model)
        {
            using (SqlConnection con2 = new SqlConnection("Data Source=DESKTOP-RARAV8G\\SQLEXPRESS;Initial Catalog=DealerAuto;Integrated Security=True"))
            {
                DataTable dt1 = new DataTable();
                con2.Open();
                //SqlDataReader myReader = null;
                SqlCommand myCommand1 = new SqlCommand("select M.MotorizareID, M.NumeMotorizare, M.CostSuplimentar, M.TipMotorizare,M.TipCutieDeViteze, M.NumarViteze, M.CupluMax, M.EmisiiCO, M.Consum, M.PutereMotor, TipTractiune from Motorizare M left join RelatieModelMotorizare RMM on M.MotorizareID = RMM.MotorizareID where CodModel = @ModelID", con2);
                myCommand1.Parameters.AddWithValue("@ModelID", model.ToString());
                myCommand1.ExecuteNonQuery();
                //myReader = myCommand.ExecuteReader();

                using (var dataAdapter = new SqlDataAdapter(myCommand1))
                {

                    dataAdapter.Fill(dt1);
                    //ModelText1.Text = (dt.Rows[0].ItemArray[1].ToString());
                    IDMotorizare1 = ((int)dt1.Rows[0].ItemArray[0]);
                    MoName1.Text = (dt1.Rows[0].ItemArray[1].ToString());
                    //MoPret1.Text = (dt1.Rows[0].ItemArray[2].ToString());
                    pretMotorizare1 = ((int)dt1.Rows[0].ItemArray[2]);
                    MoPret1.Text = "";

                    TipMoText1.Text = (dt1.Rows[0].ItemArray[3].ToString());
                    TipCutie1.Text = (dt1.Rows[0].ItemArray[4].ToString());
                    TrepteNr1.Text = (dt1.Rows[0].ItemArray[5].ToString());
                    CupluNr1.Text = (dt1.Rows[0].ItemArray[6].ToString());
                    EmisiiNr1.Text = (dt1.Rows[0].ItemArray[7].ToString());
                    ConsumNr1.Text = (dt1.Rows[0].ItemArray[8].ToString());
                    PutereNr1.Text = (dt1.Rows[0].ItemArray[9].ToString());
                    TractiuneNr1.Text = (dt1.Rows[0].ItemArray[10].ToString());

                    IDMotorizare2 = ((int)dt1.Rows[1].ItemArray[0]);
                    MoName2.Text = (dt1.Rows[1].ItemArray[1].ToString());
                    //MoPret2.Text = (dt1.Rows[1].ItemArray[2].ToString());
                    pretMotorizare2 = ((int)dt1.Rows[1].ItemArray[2]);
                    MoPret2.Text = "";

                    TipMoText2.Text = (dt1.Rows[1].ItemArray[3].ToString());
                    TipCutie2.Text = (dt1.Rows[1].ItemArray[4].ToString());
                    TrepteNr2.Text = (dt1.Rows[1].ItemArray[5].ToString());
                    CupluNr2.Text = (dt1.Rows[1].ItemArray[6].ToString());
                    EmisiiNr2.Text = (dt1.Rows[1].ItemArray[7].ToString());
                    ConsumNr2.Text = (dt1.Rows[1].ItemArray[8].ToString());
                    PutereNr2.Text = (dt1.Rows[1].ItemArray[9].ToString());
                    TractiuneNr2.Text = (dt1.Rows[1].ItemArray[10].ToString());

                    IDMotorizare3 = ((int)dt1.Rows[2].ItemArray[0]);
                    MoName3.Text = (dt1.Rows[2].ItemArray[1].ToString());
                    //MoPret3.Text = (dt1.Rows[2].ItemArray[2].ToString());
                    pretMotorizare3 = ((int)dt1.Rows[2].ItemArray[2]);
                    MoPret3.Text = "";

                    TipMoText3.Text = (dt1.Rows[2].ItemArray[3].ToString());
                    TipCutie3.Text = (dt1.Rows[2].ItemArray[4].ToString());
                    TrepteNr3.Text = (dt1.Rows[2].ItemArray[5].ToString());
                    CupluNr3.Text = (dt1.Rows[2].ItemArray[6].ToString());
                    EmisiiNr3.Text = (dt1.Rows[2].ItemArray[7].ToString());
                    ConsumNr3.Text = (dt1.Rows[2].ItemArray[8].ToString());
                    PutereNr3.Text = (dt1.Rows[2].ItemArray[9].ToString());
                    TractiuneNr3.Text = (dt1.Rows[2].ItemArray[10].ToString());

                    IDMotorizare4 = ((int)dt1.Rows[3].ItemArray[0]);
                    MoName4.Text = (dt1.Rows[3].ItemArray[1].ToString());
                    //MoPret4.Text = (dt1.Rows[3].ItemArray[2].ToString());
                    pretMotorizare4 = ((int)dt1.Rows[3].ItemArray[2]);
                    MoPret4.Text = "";

                    TipMoText4.Text = (dt1.Rows[3].ItemArray[3].ToString());
                    TipCutie4.Text = (dt1.Rows[3].ItemArray[4].ToString());
                    TrepteNr4.Text = (dt1.Rows[3].ItemArray[5].ToString());
                    CupluNr4.Text = (dt1.Rows[3].ItemArray[6].ToString());
                    EmisiiNr4.Text = (dt1.Rows[3].ItemArray[7].ToString());
                    ConsumNr4.Text = (dt1.Rows[3].ItemArray[8].ToString());
                    PutereNr4.Text = (dt1.Rows[3].ItemArray[9].ToString());
                    TractiuneNr4.Text = (dt1.Rows[3].ItemArray[10].ToString());
                }

                con2.Close();
            }
        }

        #region AlegereModel
        private void ModelRadio1_CheckedChanged(object sender, EventArgs e)
        {
            if (ModelRadio1.Checked == true)
            {
                a.ModelID = 1;
                ModelRadio2.Checked = false;
                ModelRadio3.Checked = false;
                ModelRadio4.Checked = false;
                pretDupaModel = pretModel1;
                PopulateMotor(a.ModelID);
                PopulatePachet();
                MoPanel.Visible = true;
            }
        }

        private void ModelRadio2_CheckedChanged(object sender, EventArgs e)
        {
            if (ModelRadio2.Checked == true)
            {
                a.ModelID = 2;
                ModelRadio1.Checked = false;
                ModelRadio3.Checked = false;
                ModelRadio4.Checked = false;
                pretDupaModel = pretModel2;
                PopulateMotor(a.ModelID);
                PopulatePachet();
                MoPanel.Visible = true;
            }
        }

        private void ModelRadio3_CheckedChanged(object sender, EventArgs e)
        {
            if (ModelRadio3.Checked == true)
            {
                a.ModelID = 3;
                ModelRadio1.Checked = false;
                ModelRadio2.Checked = false;
                ModelRadio4.Checked = false;
                pretDupaModel = pretModel3;

                PopulateMotor(a.ModelID);
                PopulatePachet();
                MoPanel.Visible = true;
            }
        }

        private void ModelRadio4_CheckedChanged(object sender, EventArgs e)
        {
            if (ModelRadio4.Checked == true)
            {
                a.ModelID = 4;
                ModelRadio1.Checked = false;
                ModelRadio2.Checked = false;
                ModelRadio3.Checked = false;
                pretDupaModel = pretModel4;
                PopulateMotor(a.ModelID);
                PopulatePachet();
                MoPanel.Visible = true;
            }
        }
        #endregion
       


        private void RadioPachet1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioPachet1.Checked == true)
            {
                RadioPachet2.Checked = false;
                RadioPachet3.Checked = false;
                pretDupaDotare = pretDotare1;
                nrDot = nrDotZen;
                MoPret1.Text = (pretDotare1 + pretMotorizare1).ToString() + " Euro";
                MoPret2.Text = (pretDotare1 + pretMotorizare2).ToString() + " Euro";
                MoPret3.Text = (pretDotare1 + pretMotorizare3).ToString() + " Euro";
                MoPret4.Text = (pretDotare1 + pretMotorizare4).ToString() + " Euro";
            }
        }
        #region Culori

        private int pretCuloareMasina = 0;
        private void Culoare1_Click(object sender, EventArgs e)
        {
            String color1  = "";
            a.CuloareID = 1;
            using (SqlConnection conColor = new SqlConnection("Data Source=DESKTOP-RARAV8G\\SQLEXPRESS;Initial Catalog=DealerAuto;Integrated Security=True"))
            {
                DataTable dtColor = new DataTable();
                conColor.Open();
                SqlCommand myCommandColor = new SqlCommand("select NumeCuloare, Pret from Culori where CuloareID =1 ", conColor);
                // myCommandColor.Parameters.AddWithValue("@color", color.ToString());
                myCommandColor.ExecuteNonQuery();

                using (var dataAdapter = new SqlDataAdapter(myCommandColor))
                {

                    dataAdapter.Fill(dtColor);
                    // ModelText1.Text = (dt.Rows[0].ItemArray[1].ToString());
                    color1  = (dtColor.Rows[0].ItemArray[0].ToString());
                    pretCuloareMasina = ((int)dtColor.Rows[0].ItemArray[1]);

                }
                conColor.Close();
            }
            AfisareNumeCuloare.Text = color1;
            AfisarePretCuloare.Text = "+ " + pretCuloareMasina.ToString() + " Euro";


            a.Pret = pretDupaMotorizare + pretCuloareMasina;
            PretTotal.Text = "Pret final: " + a.Pret.ToString() + "Euro";
        }

        private void Culoare2_Click(object sender, EventArgs e)
        {
            String color1 = "White Univers";
            using (SqlConnection conColor = new SqlConnection("Data Source=DESKTOP-RARAV8G\\SQLEXPRESS;Initial Catalog=DealerAuto;Integrated Security=True"))
            {
                DataTable dtColor = new DataTable();
                conColor.Open();
                SqlCommand myCommandColor = new SqlCommand("select CuloareID, Pret from Culori where CuloareID =2 ", conColor);
                // myCommandColor.Parameters.AddWithValue("@color", color.ToString());
                myCommandColor.ExecuteNonQuery();

                using (var dataAdapter = new SqlDataAdapter(myCommandColor))
                {

                    dataAdapter.Fill(dtColor);
                    // ModelText1.Text = (dt.Rows[0].ItemArray[1].ToString());
                    a.CuloareID = ((int)dtColor.Rows[0].ItemArray[0]);
                    pretCuloareMasina = ((int)dtColor.Rows[0].ItemArray[1]);

                }
                conColor.Close();
            }
            AfisareNumeCuloare.Text = color1;
            AfisarePretCuloare.Text = "+ " + pretCuloareMasina.ToString() + " Euro";


            a.Pret = pretDupaMotorizare + pretCuloareMasina;
            PretTotal.Text = "Pret final: " + a.Pret.ToString() + "Euro";
        }

        private void Culoare3_Click(object sender, EventArgs e)
        {
            String color1 = "Rouge Flamme";
            using (SqlConnection conColor = new SqlConnection("Data Source=DESKTOP-RARAV8G\\SQLEXPRESS;Initial Catalog=DealerAuto;Integrated Security=True"))
            {
                DataTable dtColor = new DataTable();
                conColor.Open();
                SqlCommand myCommandColor = new SqlCommand("select CuloareID, Pret from Culori where CuloareID =3 ", conColor);
                // myCommandColor.Parameters.AddWithValue("@color", color.ToString());
                myCommandColor.ExecuteNonQuery();

                using (var dataAdapter = new SqlDataAdapter(myCommandColor))
                {

                    dataAdapter.Fill(dtColor);
                    // ModelText1.Text = (dt.Rows[0].ItemArray[1].ToString());
                    a.CuloareID = ((int)dtColor.Rows[0].ItemArray[0]);
                    pretCuloareMasina = ((int)dtColor.Rows[0].ItemArray[1]);

                }
                conColor.Close();
            }
            AfisareNumeCuloare.Text = color1;
            AfisarePretCuloare.Text = "+ " + pretCuloareMasina.ToString() + " Euro";

            a.Pret = pretDupaMotorizare + pretCuloareMasina;
            PretTotal.Text = "Pret final: " + a.Pret.ToString() + "Euro";
        }

        private void Culoare4_Click(object sender, EventArgs e)
        {
            String color1 = "Grey Medium";
            using (SqlConnection conColor = new SqlConnection("Data Source=DESKTOP-RARAV8G\\SQLEXPRESS;Initial Catalog=DealerAuto;Integrated Security=True"))
            {
                DataTable dtColor = new DataTable();
                conColor.Open();
                SqlCommand myCommandColor = new SqlCommand("select CuloareID, Pret from Culori where CuloareID =4 ", conColor);
                // myCommandColor.Parameters.AddWithValue("@color", color.ToString());
                myCommandColor.ExecuteNonQuery();

                using (var dataAdapter = new SqlDataAdapter(myCommandColor))
                {

                    dataAdapter.Fill(dtColor);
                    // ModelText1.Text = (dt.Rows[0].ItemArray[1].ToString());
                    a.CuloareID = ((int)dtColor.Rows[0].ItemArray[0]);
                    pretCuloareMasina = ((int)dtColor.Rows[0].ItemArray[1]);

                }
                conColor.Close();
            }
            AfisareNumeCuloare.Text = color1;
            AfisarePretCuloare.Text = "+ " + pretCuloareMasina.ToString() + " Euro";

            a.Pret = pretDupaMotorizare + pretCuloareMasina;
            PretTotal.Text = "Pret final: " + a.Pret.ToString() + "Euro";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String color1 = "Black Metallic";
; using (SqlConnection conColor = new SqlConnection("Data Source=DESKTOP-RARAV8G\\SQLEXPRESS;Initial Catalog=DealerAuto;Integrated Security=True"))
            {
                DataTable dtColor = new DataTable();
                conColor.Open();
                SqlCommand myCommandColor = new SqlCommand("select CuloareID, Pret from Culori where CuloareID =5 ", conColor);
                // myCommandColor.Parameters.AddWithValue("@color", color.ToString());
                myCommandColor.ExecuteNonQuery();

                using (var dataAdapter = new SqlDataAdapter(myCommandColor))
                {

                    dataAdapter.Fill(dtColor);
                    // ModelText1.Text = (dt.Rows[0].ItemArray[1].ToString());
                    a.CuloareID = ((int)dtColor.Rows[0].ItemArray[0]);
                    pretCuloareMasina = ((int)dtColor.Rows[0].ItemArray[1]);

                }
                conColor.Close();
            }
            AfisareNumeCuloare.Text = color1;
            AfisarePretCuloare.Text = "+ " + pretCuloareMasina.ToString() + " Euro";

            a.Pret = pretDupaMotorizare + pretCuloareMasina;
            PretTotal.Text = "Pret final: " + a.Pret.ToString() + "Euro";
        }

        private void Culoare6_Click(object sender, EventArgs e)
        {
            String color1 = "Black Metallic";
            using (SqlConnection conColor = new SqlConnection("Data Source=DESKTOP-RARAV8G\\SQLEXPRESS;Initial Catalog=DealerAuto;Integrated Security=True"))
            {
                DataTable dtColor = new DataTable();
                conColor.Open();
                SqlCommand myCommandColor = new SqlCommand("select CuloareID, Pret from Culori where CuloareID =6 ", conColor);
                // myCommandColor.Parameters.AddWithValue("@color", color.ToString());
                myCommandColor.ExecuteNonQuery();

                using (var dataAdapter = new SqlDataAdapter(myCommandColor))
                {

                    dataAdapter.Fill(dtColor);
                    // ModelText1.Text = (dt.Rows[0].ItemArray[1].ToString());
                    a.CuloareID = ((int)dtColor.Rows[0].ItemArray[0]);
                    pretCuloareMasina = ((int)dtColor.Rows[0].ItemArray[1]);

                }
                conColor.Close();
            }
            AfisareNumeCuloare.Text = color1;
            AfisarePretCuloare.Text = "+ " + pretCuloareMasina.ToString() + " Euro";

            a.Pret = pretDupaMotorizare + pretCuloareMasina;
            PretTotal.Text = "Pret final: " + a.Pret.ToString() + "Euro";
        }
        #endregion
        

        private void dbSerieSasiu__TextChanged(object sender, EventArgs e)
        {
            if (dbSerieSasiu.Texts.Length != 17)
            {
                if (dbSerieSasiu.Texts.Length != 0)
                    dbSerieSasiu.BorderColor = Color.Red;
            }
            else
                dbSerieSasiu.BorderColor = Color.Black;
        }

        private void dbFinalizare_Click(object sender, EventArgs e)
        {
            try
            {
                a.Nume = dbTextBoxNume.Texts;
                a.Prenume = dbTextBoxPrenume.Texts;
                a.NumarTel = dbTextBoxNrTel.Texts;
                a.AdresaMail = dbTextBoxMail.Texts;
                a.Adresa = dbTextBoxAdresa.Texts;
                a.SerieSasiu = dbSerieSasiu.Texts;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-RARAV8G\\SQLEXPRESS;Initial Catalog=DealerAuto;Integrated Security=True";
                con.Open();
                //String query = "delete from Client where ClientID = 2";
                String query = "insert into Client (Nume, Prenume, NumarTelefon, AdresaEmail, Adresa) values(@nume, @prenume, @nrtel, @adrmail, @adresa)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nume", dbTextBoxNume.Texts.ToString());
                cmd.Parameters.AddWithValue("@prenume", dbTextBoxPrenume.Texts.ToString());
                cmd.Parameters.AddWithValue("@nrtel", dbTextBoxNrTel.Texts.ToString());
                cmd.Parameters.AddWithValue("@adrmail", dbTextBoxMail.Texts.ToString());
                cmd.Parameters.AddWithValue("@adresa", dbTextBoxAdresa.Texts.ToString());
                cmd.ExecuteNonQuery();

                String query2 = "insert into Vehicule (ModelID, MotorizareID, SerieSasiu, AnFabricatie, CuloareID) values(@modelID, @motid, @seriesasiu, @anfab, @culoareID)";
                SqlCommand cmd2 = new SqlCommand(query2, con);
                cmd2.Parameters.AddWithValue("@modelID", a.ModelID);
                cmd2.Parameters.AddWithValue("@motid", a.MotorizareID);
                cmd2.Parameters.AddWithValue("@seriesasiu", a.SerieSasiu.ToString());
                cmd2.Parameters.AddWithValue("@anfab", a.AnFab.ToString());
                cmd2.Parameters.AddWithValue("@culoareID", a.CuloareID);
                cmd2.ExecuteNonQuery();

                int clientID = 0;
                int vehiculID = 0;
                int vanzatorID = 0;

                String query3 = "select ClientID from Client where NumarTelefon = @nrtel";
                SqlCommand cmd3 = new SqlCommand(query3, con);
                cmd3.Parameters.AddWithValue("@nrtel", dbTextBoxNrTel.Texts.ToString());
                cmd3.ExecuteNonQuery();
                using (SqlDataReader cReader = cmd3.ExecuteReader())
                {
                    while (cReader.Read())
                    {
                        clientID = (int)cReader["ClientID"];
                    }
                }


                String query4 = "select VehiculID from Vehicule where SerieSasiu = @seriesasiu";
                SqlCommand cmd4 = new SqlCommand(query4, con);
                cmd4.Parameters.AddWithValue("@seriesasiu", dbSerieSasiu.Texts.ToString());
                cmd4.ExecuteNonQuery();
                using (SqlDataReader vReader = cmd4.ExecuteReader())
                {
                    while (vReader.Read())
                    {
                        vehiculID = (int)vReader["VehiculID"];
                    }
                }

                String query5 = "select VanzatorID from Vanzator where Nume = @numev and Prenume = @prenumev";
                SqlCommand cmd5 = new SqlCommand(query5, con);
                cmd5.Parameters.AddWithValue("@numev", dbNumeVanzator.Texts.ToString());
                cmd5.Parameters.AddWithValue("@prenumev", dbPrenumeVanzator.Texts.ToString());
                cmd5.ExecuteNonQuery();
                using (SqlDataReader nReader = cmd5.ExecuteReader())
                {
                    while (nReader.Read())
                    {
                        vanzatorID = (int)nReader["VanzatorID"];
                    }
                }

                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");


                String query6 = "insert into VanzariVehicule (ClientID, VanzatorID, VehiculID, DataVanzare, PretVanzare) values(@clientID, @vanzatorID, @vehiculID, @data, @pret)";
                SqlCommand cmd6 = new SqlCommand(query6, con);
                cmd6.Parameters.AddWithValue("@clientID", clientID);
                cmd6.Parameters.AddWithValue("@vanzatorID", vanzatorID);
                cmd6.Parameters.AddWithValue("@vehiculID", vehiculID);
                cmd6.Parameters.AddWithValue("@data", sqlFormattedDate);
                cmd6.Parameters.AddWithValue("@pret", a.Pret);
                cmd6.ExecuteNonQuery();


                for (int i = 1; i <= nrDot; i++)
                {
                    String query7 = "insert into RelatieVehiculeDotari (VehiculID, DotareID) values(@vehiculID, @codDotare)";
                    SqlCommand cmd7 = new SqlCommand(query7, con);
                    cmd7.Parameters.AddWithValue("@vehiculID", vehiculID);
                    cmd7.Parameters.AddWithValue("@codDotare", i);
                    cmd7.ExecuteNonQuery();
                }

                //MessageBox.Show("connect with sql server");
                con.Close();
                MoPanel.Visible = false;
                dbTextBoxNume.Texts = "";
                dbTextBoxPrenume.Texts = "";
                dbTextBoxNrTel.Texts = "";
                dbTextBoxMail.Texts = "";
                dbNumeVanzator.Texts = "";
                dbPrenumeVanzator.Texts = "";
                dbTextBoxAdresa.Texts = "";
                dbSerieSasiu.Texts = "";
                ModelRadio1.Checked = false;
                ModelRadio2.Checked = false;
                ModelRadio3.Checked = false;
                ModelRadio4.Checked = false;
                RadioPachet1.Checked = false;
                RadioPachet2.Checked = false;
                RadioPachet3.Checked = false;
                MoRadio1.Checked = false;
                MoRadio2.Checked = false;
                MoRadio3.Checked = false;
                MoRadio4.Checked = false;
                AfisareNumeCuloare.Text = "";
                AfisarePretCuloare.Text = "";
                PretTotal.Text = "";


            }
            catch

            {
                MessageBox.Show("Nu au fost selectate toate campurile!");
            }
        }

        private void dbFinalizare_MouseEnter(object sender, EventArgs e)
        {
            dbFinalizare.BorderColor = Color.FromArgb(255, 191, 40);
        }

        private void dbFinalizare_MouseLeave(object sender, EventArgs e)
        {
            dbFinalizare.BorderColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();


            form3.Width = this.Width;
            form3.Height = this.Height;
            form3.StartPosition = FormStartPosition.Manual;
            form3.Location = new Point(this.Location.X, this.Location.Y);
            this.Visible = false;
            form3.ShowDialog();
            this.Visible = true;
            this.Close();
        }

        private void RadioPachet2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioPachet2.Checked == true)
            {
                RadioPachet1.Checked = false;
                RadioPachet3.Checked = false;
                pretDupaDotare = pretDotare2;
                nrDot = nrDotIntense;
                MoPret1.Text = (pretDotare2 + pretMotorizare1).ToString() + " Euro";
                MoPret2.Text = (pretDotare2 + pretMotorizare2).ToString() + " Euro";
                MoPret3.Text = (pretDotare2 + pretMotorizare3).ToString() + " Euro";
                MoPret4.Text = (pretDotare2 + pretMotorizare4).ToString() + " Euro";
            }
        }

        private void RadioPachet3_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioPachet3.Checked == true)
            {
                RadioPachet1.Checked = false;
                RadioPachet2.Checked = false;
                pretDupaDotare = pretDotare3;
                nrDot = nrDotParis;
                MoPret1.Text = (pretDotare3 + pretMotorizare1).ToString() + " Euro";
                MoPret2.Text = (pretDotare3 + pretMotorizare2).ToString() + " Euro";
                MoPret3.Text = (pretDotare3 + pretMotorizare3).ToString() + " Euro";
                MoPret4.Text = (pretDotare3 + pretMotorizare4).ToString() + " Euro";
            }
        }

        private void MoRadio1_CheckedChanged(object sender, EventArgs e)
        {
            if (MoRadio1.Checked == true)
            {
                a.MotorizareID = IDMotorizare1;
                MoRadio2.Checked = false;
                MoRadio3.Checked = false;
                MoRadio4.Checked = false;
                pretDupaMotorizare = pretDupaDotare + pretMotorizare1;
               
            }
        }

        #region DetaliiPachet

        private void DetaliiPachet1_MouseEnter(object sender, EventArgs e)
        {
            TextDetalii1.Visible = true;
            DetaliiPachet1.ForeColor = Color.FromArgb(255, 191, 40);
        }

        private void DetaliiPachet1_MouseLeave(object sender, EventArgs e)
        {
            TextDetalii1.Visible = false;
            DetaliiPachet1.ForeColor = Color.FromArgb(101, 102, 102);
        }

        private void DetaliiPachet2_MouseEnter(object sender, EventArgs e)
        {
            TextDetalii2.Visible = true;
            DetaliiPachet2.ForeColor = Color.FromArgb(255, 191, 40);
        }

        private void DetaliiPachet2_MouseLeave(object sender, EventArgs e)
        {
            TextDetalii2.Visible = false;
            DetaliiPachet2.ForeColor = Color.FromArgb(101, 102, 102);
        }

        private void DetaliiPachet3_MouseEnter(object sender, EventArgs e)
        {
            TextDetalii3.Visible = true;
            DetaliiPachet3.ForeColor = Color.FromArgb(255, 191, 40);
        }

        private void DetaliiPachet3_MouseLeave(object sender, EventArgs e)
        {
            TextDetalii3.Visible = false;
            DetaliiPachet3.ForeColor = Color.FromArgb(101, 102, 102);
        }

        #endregion


        private void MoRadio2_CheckedChanged(object sender, EventArgs e)
        {
            if (MoRadio2.Checked == true)
            {
                a.MotorizareID = IDMotorizare2;
                MoRadio1.Checked = false;
                MoRadio3.Checked = false;
                MoRadio4.Checked = false;
                pretDupaMotorizare = pretDupaDotare + pretMotorizare2;
                
            }
        }

        private void MoRadio3_CheckedChanged(object sender, EventArgs e)
        {
            if (MoRadio3.Checked == true)
            {
                a.MotorizareID = IDMotorizare3;
                MoRadio1.Checked = false;
                MoRadio2.Checked = false;
                MoRadio4.Checked = false;
                pretDupaMotorizare = pretDupaDotare + pretMotorizare3;
                
            }
        }

        private void MoRadio4_CheckedChanged(object sender, EventArgs e)
        {
            if (MoRadio4.Checked == true)
            {
                a.MotorizareID = IDMotorizare4;
                MoRadio1.Checked = false;
                MoRadio2.Checked = false;
                MoRadio3.Checked = false;
                pretDupaMotorizare = pretDupaDotare + pretMotorizare4;
                
            }
        }
    }

}