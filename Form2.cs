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
    public partial class Form2 : Form
    {
        public Form2()
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

        int nrDotF2 = 0;
        String Nume = "" , Prenume = "", Telefon = "", Mail = "", Adresa ="";
        int IDClient = 0, Pret = 0;

        #region DeModificat
       
        

        private void TelTextF2__TextChanged(object sender, EventArgs e)
        {
            if (TelTextF2.Texts.Length != 10)
            {
                if (TelTextF2.Texts.Length != 0)
                    TelTextF2.BorderColor = Color.Red;
            }
            else
                TelTextF2.BorderColor = Color.Black;
        }


       

        #endregion

        #region Modificare
        private void dbModificare_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection con2 = new SqlConnection("Data Source=DESKTOP-RARAV8G\\SQLEXPRESS;Initial Catalog=DealerAuto;Integrated Security=True"))
            {
                con2.Open();
                String query9 = "update Client set Nume = @nume , Prenume = @prenume, NumarTelefon = @nrtel, AdresaEmail = @adrmail, Adresa =  @adresa where ClientID = (select VV.ClientID from VanzariVehicule VV join Vehicule V on VV.VehiculID = V.VehiculID where SerieSasiu = @seriesasiucautare9)";
                SqlCommand myCommand9 = new SqlCommand(query9, con2);
                myCommand9.Parameters.AddWithValue("@seriesasiucautare9", CautareSSText.Texts.ToString());
                if (NumeTextF2.Texts == "")
                    myCommand9.Parameters.AddWithValue("@nume", Nume);
                else
                    myCommand9.Parameters.AddWithValue("@nume", NumeTextF2.Texts);

                if (PrenumeTextF2.Texts == "")
                    myCommand9.Parameters.AddWithValue("@prenume", Prenume);
                else
                    myCommand9.Parameters.AddWithValue("@prenume", PrenumeTextF2.Texts);

                if (TelTextF2.Texts == "")
                    myCommand9.Parameters.AddWithValue("@nrtel", Telefon);
                else
                    myCommand9.Parameters.AddWithValue("@nrtel", TelTextF2.Texts);

                if (MailTextF2.Texts == "")
                    myCommand9.Parameters.AddWithValue("@adrmail", Mail);
                else
                    myCommand9.Parameters.AddWithValue("@adrmail", MailTextF2.Texts);

                if (AdresaF2.Texts == "")
                    myCommand9.Parameters.AddWithValue("@adresa", Adresa);
                else
                    myCommand9.Parameters.AddWithValue("@adresa", AdresaF2.Texts);
                myCommand9.ExecuteNonQuery();

                String query10 = "update VanzariVehicule set PretVanzare = @pret where VehiculID = (select V.VehiculID from Vehicule V where V.SerieSasiu = @seriesasiucautare10)";
                SqlCommand myCommand10 = new SqlCommand(query10, con2);
                myCommand10.Parameters.AddWithValue("@seriesasiucautare10", CautareSSText.Texts.ToString());
                if (PretF2.Texts == "")
                    myCommand10.Parameters.AddWithValue("@pret", Pret);
                else
                    myCommand10.Parameters.AddWithValue("@pret", PretF2.Texts);

                myCommand10.ExecuteNonQuery();
                con2.Close();

            }//end using
            MessageBox.Show("Ai aplicat modificatile!");
        }

        private void dbModificare_MouseEnter(object sender, EventArgs e)
        {
            dbModificare.BorderColor = Color.FromArgb(255, 191, 40);
        }

        private void dbModificare_MouseLeave(object sender, EventArgs e)
        {
            dbModificare.BorderColor = Color.Black;
        }

        #endregion




        #region Stergere
        private void dbStergere_Click(object sender, EventArgs e)
        {
            using (SqlConnection con3 = new SqlConnection("Data Source=DESKTOP-RARAV8G\\SQLEXPRESS;Initial Catalog=DealerAuto;Integrated Security=True"))
            {

                con3.Open();
                String query11 = "select VV.ClientID from VanzariVehicule VV where VV.VehiculID = (select V.VehiculID from Vehicule V where SerieSasiu = @seriesasiucautare11)";
                SqlCommand myCommand11 = new SqlCommand(query11, con3);
                myCommand11.Parameters.AddWithValue("@seriesasiucautare11", CautareSSText.Texts.ToString());
                myCommand11.ExecuteNonQuery();
                using (SqlDataReader cReader = myCommand11.ExecuteReader())
                {
                    while (cReader.Read())
                    {
                        IDClient = (int)cReader["ClientID"];
                    }
                }

                String query12 = "delete from VanzariVehicule where VanzareID = (select VV.VanzareID from VanzariVehicule VV join Vehicule V on VV.VehiculID = V.VehiculID where SerieSasiu = @seriesasiucautare12)";
                SqlCommand myCommand12 = new SqlCommand(query12, con3);
                myCommand12.Parameters.AddWithValue("@seriesasiucautare12", CautareSSText.Texts.ToString());
                myCommand12.ExecuteNonQuery();


                String query13 = "delete from RelatieVehiculeDotari where VehiculID = (select V.VehiculID from Vehicule V where SerieSasiu = @seriesasiucautare13)";
                SqlCommand myCommand13 = new SqlCommand(query13, con3);
                myCommand13.Parameters.AddWithValue("@seriesasiucautare13", CautareSSText.Texts.ToString());
                myCommand13.ExecuteNonQuery();


                String query14 = "delete from Vehicule where SerieSasiu = @seriesasiucautare14";
                SqlCommand myCommand14 = new SqlCommand(query14, con3);
                myCommand14.Parameters.AddWithValue("@seriesasiucautare14", CautareSSText.Texts.ToString());
                myCommand14.ExecuteNonQuery();

                String query15 = "delete from Client where ClientID = @idclient";
                SqlCommand myCommand15 = new SqlCommand(query15, con3);
                myCommand15.Parameters.AddWithValue("@idclient", IDClient.ToString());
                myCommand15.ExecuteNonQuery();

                IDClient = 0;

                con3.Close();
            }//end using
            panel1.Visible = false;
            MessageBox.Show("Ai sters vanzarea masinii cu seria de sasiu: " + CautareSSText.Texts);
            CautareSSText.Texts = "";

        }

        private void dbStergere_MouseEnter(object sender, EventArgs e)
        { 
           dbStergere.BorderColor = Color.FromArgb(255, 191, 40);
        }

        private void dbStergere_MouseLeave(object sender, EventArgs e)
        {
            dbStergere.BorderColor = Color.Black;
        }

        private void Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdaugareVanzare_Click(object sender, EventArgs e)
        {

        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void TopBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PerformanteDealership_Click(object sender, EventArgs e)
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



        #endregion

        #region Cautare
        private void dbCautare_Click(object sender, EventArgs e)
        {
            try
            {
                DotariPachetF2.Text = "";
                TextDetaliiF2.Text = "";
                using (SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-RARAV8G\\SQLEXPRESS;Initial Catalog=DealerAuto;Integrated Security=True"))
                {
                    con1.Open();
                    DataTable dt1 = new DataTable();
                    SqlCommand myCommand = new SqlCommand("select C.Nume, C.Prenume, C.NumarTelefon, C.AdresaEmail, C.Adresa from Client C join VanzariVehicule VV on C.ClientID = VV.ClientID join Vehicule VE on VE.VehiculID = VV.VehiculID where SerieSasiu = @seriesasiucautare", con1);
                    myCommand.Parameters.AddWithValue("@seriesasiucautare", CautareSSText.Texts.ToString());
                    myCommand.ExecuteNonQuery();

                    using (var dataAdapter = new SqlDataAdapter(myCommand))
                    {

                        dataAdapter.Fill(dt1);
                        Nume = (dt1.Rows[0].ItemArray[0].ToString());
                        Prenume = (dt1.Rows[0].ItemArray[1].ToString());
                        Telefon = (dt1.Rows[0].ItemArray[2].ToString());
                        Mail = (dt1.Rows[0].ItemArray[3].ToString());
                        Adresa = (dt1.Rows[0].ItemArray[4].ToString());

                        NumeTextF2.Texts = Nume;
                        PrenumeTextF2.Texts = Prenume;
                        TelTextF2.Texts = Telefon;
                        MailTextF2.Texts = Mail;
                        AdresaF2.Texts = Adresa;
                    }

                    DataTable dt2 = new DataTable();
                    SqlCommand myCommand2 = new SqlCommand("select V.Nume, V.Prenume from Vanzator V join VanzariVehicule VV on V.VanzatorID = VV.VanzatorID join Vehicule VE on VE.VehiculID = VV.VehiculID where SerieSasiu = @seriesasiucautare2", con1);
                    myCommand2.Parameters.AddWithValue("@seriesasiucautare2", CautareSSText.Texts.ToString());
                    myCommand2.ExecuteNonQuery();

                    using (var dataAdapter = new SqlDataAdapter(myCommand2))
                    {

                        dataAdapter.Fill(dt2);
                        NumeVanzatorTextF2.Texts = (dt2.Rows[0].ItemArray[0].ToString());
                        PrenumeVanzatorF2.Texts = (dt2.Rows[0].ItemArray[1].ToString());
                    }


                    String query3 = "select M.NumeModel from Model M join Vehicule V on V.ModelID =  M.ModelID where V.SerieSasiu = @seriesasiucautare3";
                    SqlCommand myCommand3 = new SqlCommand(query3, con1);
                    myCommand3.Parameters.AddWithValue("@seriesasiucautare3", CautareSSText.Texts.ToString());
                    myCommand3.ExecuteNonQuery();
                    using (SqlDataReader cReader = myCommand3.ExecuteReader())
                    {
                        while (cReader.Read())
                        {
                            ModelTextF2.Texts = (String)cReader["NumeModel"];
                        }
                    }

                    String query4 = "select C.NumeCuloare from Culori C join Vehicule V on C.CuloareID = V.CuloareID where V.SerieSasiu = @seriesasiucautare4";
                    SqlCommand myCommand4 = new SqlCommand(query4, con1);
                    myCommand4.Parameters.AddWithValue("@seriesasiucautare4", CautareSSText.Texts.ToString());
                    myCommand4.ExecuteNonQuery();
                    using (SqlDataReader cReader = myCommand4.ExecuteReader())
                    {
                        while (cReader.Read())
                        {
                            CuloareTextF2.Texts = (String)cReader["NumeCuloare"];
                        }
                    }


                    DataTable dt3 = new DataTable();
                    SqlCommand myCommand5 = new SqlCommand("select M.NumeMotorizare, M.TipMotorizare, M.TipCutieDeViteze, M.NumarViteze, M.CupluMax, M.EmisiiCO, M.Consum, M.PutereMotor, M.TipTractiune from Motorizare M join Vehicule V on M.MotorizareID = V.MotorizareID where V.SerieSasiu = @seriesasiucautare5", con1);
                    myCommand5.Parameters.AddWithValue("@seriesasiucautare5", CautareSSText.Texts.ToString());
                    myCommand5.ExecuteNonQuery();

                    using (var dataAdapter = new SqlDataAdapter(myCommand5))
                    {

                        dataAdapter.Fill(dt3);
                        MoNameF2.Text = (dt3.Rows[0].ItemArray[0].ToString());
                        TipMoTextF2.Text = (dt3.Rows[0].ItemArray[1].ToString());
                        TipCutieF2.Text = (dt3.Rows[0].ItemArray[2].ToString());
                        TrepteNrF2.Text = (dt3.Rows[0].ItemArray[3].ToString());
                        CupluNrF2.Text = (dt3.Rows[0].ItemArray[4].ToString());
                        EmisiiNrF2.Text = (dt3.Rows[0].ItemArray[5].ToString());
                        ConsumNrF2.Text = (dt3.Rows[0].ItemArray[6].ToString());
                        PutereNrF2.Text = (dt3.Rows[0].ItemArray[7].ToString());
                        TractiuneNrF2.Text = (dt3.Rows[0].ItemArray[8].ToString());

                    }


                    String query6 = "select VV.PretVanzare from VanzariVehicule VV join Vehicule V on VV.VehiculID = V.VehiculID where V.SerieSasiu = @seriesasiucautare6";
                    SqlCommand myCommand6 = new SqlCommand(query6, con1);
                    myCommand6.Parameters.AddWithValue("@seriesasiucautare6", CautareSSText.Texts.ToString());
                    myCommand6.ExecuteNonQuery();
                    using (SqlDataReader cReader = myCommand6.ExecuteReader())
                    {
                        while (cReader.Read())
                        {
                            Pret = (int)cReader["PretVanzare"];
                            PretF2.Texts = Pret.ToString();
                        }
                    }

                    String query7 = "select count(RD.DotareID) as NrDot from RelatieVehiculeDotari RD join Vehicule V on V.VehiculID = RD.VehiculID where V.SerieSasiu = @seriesasiucautare7 group by RD.VehiculID";
                    SqlCommand myCommand7 = new SqlCommand(query7, con1);
                    myCommand7.Parameters.AddWithValue("@seriesasiucautare7", CautareSSText.Texts.ToString());
                    myCommand7.ExecuteNonQuery();
                    using (SqlDataReader cReader = myCommand7.ExecuteReader())
                    {
                        while (cReader.Read())
                        {
                            nrDotF2 = (int)cReader["NrDot"];
                        }
                    }


                    DataTable dt8 = new DataTable();
                    SqlCommand myCommand8 = new SqlCommand("select D.Nume, D.Pachet, D.DotareID from Dotari D join RelatieVehiculeDotari RD on RD.DotareID = D.DotareID join Vehicule V on V.VehiculID = RD.VehiculID where SerieSasiu = @seriesasiucautare8", con1);
                    myCommand8.Parameters.AddWithValue("@seriesasiucautare8", CautareSSText.Texts.ToString());
                    myCommand8.ExecuteNonQuery();
                    string newLine = Environment.NewLine;
                    using (var dataAdapter = new SqlDataAdapter(myCommand8))
                    {
                        dataAdapter.Fill(dt8);
                        for (int i = 0; i < 15; i++)
                        {
                            DotariPachetF2.Text = DotariPachetF2.Text + dt8.Rows[i].ItemArray[0].ToString() + newLine;
                        }
                        for (int i = 0; i < nrDotF2; i++)
                        {
                            TextDetaliiF2.Text = TextDetaliiF2.Text + dt8.Rows[i].ItemArray[0].ToString() + newLine;
                        }
                    }


                    con1.Close();
                }//end using

                if (nrDotF2 == 20)
                    NumePachetF2.Text = "Zen";
                else if(nrDotF2 == 28)
                    NumePachetF2.Text = "Intense";
                else if(nrDotF2 == 36)
                    NumePachetF2.Text = "Initiale Paris";

                panel1.Visible = true;
            }
            catch
            {
                MessageBox.Show("Seria de sasiu este gresita sau nu exista.");
            }
        }

        private void dbCautare_MouseEnter(object sender, EventArgs e)
        {
            dbCautare.BorderColor = Color.FromArgb(255, 191, 40);
        }

        private void dbCautare_MouseLeave(object sender, EventArgs e)
        {
            dbCautare.BorderColor = Color.Black;
        }

        #endregion


        private void DetaliiPachetF2_MouseEnter(object sender, EventArgs e)
        {
            TextDetaliiF2.Visible = true;
            DetaliiPachetF2.ForeColor = Color.FromArgb(255, 191, 40);
        }

        private void DetaliiPachetF2_MouseLeave(object sender, EventArgs e)
        {
            TextDetaliiF2.Visible = false;
            DetaliiPachetF2.ForeColor = Color.FromArgb(101, 102, 102);
        }

       

        
    }


    
}
