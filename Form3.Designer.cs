
namespace Dealer_Auto
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.AdaugareVanzare = new System.Windows.Forms.Button();
            this.VanzariPred = new System.Windows.Forms.Button();
            this.TopBar = new System.Windows.Forms.Panel();
            this.Menu = new System.Windows.Forms.Panel();
            this.PerformanteDealership = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.panelForm3 = new System.Windows.Forms.Panel();
            this.Salariu = new Dealer_Auto.Properties.DBTextBox();
            this.Emisii = new Dealer_Auto.Properties.DBTextBox();
            this.CerintaQ4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CerintaQ2 = new System.Windows.Forms.TextBox();
            this.CerintaQ1 = new System.Windows.Forms.TextBox();
            this.QueryButton4 = new Dealer_Auto.Properties.DBButton();
            this.QueryButton3 = new Dealer_Auto.Properties.DBButton();
            this.QueryButton2 = new Dealer_Auto.Properties.DBButton();
            this.QueryButton1 = new Dealer_Auto.Properties.DBButton();
            this.NrCai = new Dealer_Auto.Properties.DBTextBox();
            this.NumeModel = new Dealer_Auto.Properties.DBTextBox();
            this.Query4 = new Dealer_Auto.Properties.DBTextBox();
            this.Query2 = new Dealer_Auto.Properties.DBTextBox();
            this.Query3 = new Dealer_Auto.Properties.DBTextBox();
            this.Query1 = new Dealer_Auto.Properties.DBTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.Menu.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            this.panelForm3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(200, 120);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // AdaugareVanzare
            // 
            this.AdaugareVanzare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(40)))));
            this.AdaugareVanzare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdaugareVanzare.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdaugareVanzare.FlatAppearance.BorderSize = 0;
            this.AdaugareVanzare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(169)))));
            this.AdaugareVanzare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(169)))));
            this.AdaugareVanzare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdaugareVanzare.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdaugareVanzare.ForeColor = System.Drawing.SystemColors.Desktop;
            this.AdaugareVanzare.Location = new System.Drawing.Point(0, 180);
            this.AdaugareVanzare.Name = "AdaugareVanzare";
            this.AdaugareVanzare.Size = new System.Drawing.Size(200, 60);
            this.AdaugareVanzare.TabIndex = 2;
            this.AdaugareVanzare.Text = "Vanzari Precedente";
            this.AdaugareVanzare.UseVisualStyleBackColor = false;
            this.AdaugareVanzare.Click += new System.EventHandler(this.AdaugareVanzare_Click);
            // 
            // VanzariPred
            // 
            this.VanzariPred.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(40)))));
            this.VanzariPred.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VanzariPred.Dock = System.Windows.Forms.DockStyle.Top;
            this.VanzariPred.FlatAppearance.BorderSize = 0;
            this.VanzariPred.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(169)))));
            this.VanzariPred.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(169)))));
            this.VanzariPred.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VanzariPred.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VanzariPred.ForeColor = System.Drawing.SystemColors.Desktop;
            this.VanzariPred.Location = new System.Drawing.Point(0, 120);
            this.VanzariPred.Name = "VanzariPred";
            this.VanzariPred.Size = new System.Drawing.Size(200, 60);
            this.VanzariPred.TabIndex = 1;
            this.VanzariPred.Text = "Adaugare Vanzare";
            this.VanzariPred.UseVisualStyleBackColor = false;
            this.VanzariPred.Click += new System.EventHandler(this.VanzariPred_Click);
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.Black;
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(200, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(1704, 120);
            this.TopBar.TabIndex = 4;
            // 
            // Menu
            // 
            this.Menu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(40)))));
            this.Menu.Controls.Add(this.PerformanteDealership);
            this.Menu.Controls.Add(this.AdaugareVanzare);
            this.Menu.Controls.Add(this.VanzariPred);
            this.Menu.Controls.Add(this.LogoPanel);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(200, 1041);
            this.Menu.TabIndex = 3;
            // 
            // PerformanteDealership
            // 
            this.PerformanteDealership.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(40)))));
            this.PerformanteDealership.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PerformanteDealership.Dock = System.Windows.Forms.DockStyle.Top;
            this.PerformanteDealership.FlatAppearance.BorderSize = 0;
            this.PerformanteDealership.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(169)))));
            this.PerformanteDealership.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(169)))));
            this.PerformanteDealership.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PerformanteDealership.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PerformanteDealership.ForeColor = System.Drawing.SystemColors.Desktop;
            this.PerformanteDealership.Location = new System.Drawing.Point(0, 240);
            this.PerformanteDealership.Name = "PerformanteDealership";
            this.PerformanteDealership.Size = new System.Drawing.Size(200, 60);
            this.PerformanteDealership.TabIndex = 5;
            this.PerformanteDealership.Text = "Performante Dealership";
            this.PerformanteDealership.UseVisualStyleBackColor = false;
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.Black;
            this.LogoPanel.Controls.Add(this.Logo);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(200, 120);
            this.LogoPanel.TabIndex = 0;
            // 
            // panelForm3
            // 
            this.panelForm3.Controls.Add(this.Salariu);
            this.panelForm3.Controls.Add(this.Emisii);
            this.panelForm3.Controls.Add(this.CerintaQ4);
            this.panelForm3.Controls.Add(this.textBox2);
            this.panelForm3.Controls.Add(this.CerintaQ2);
            this.panelForm3.Controls.Add(this.CerintaQ1);
            this.panelForm3.Controls.Add(this.QueryButton4);
            this.panelForm3.Controls.Add(this.QueryButton3);
            this.panelForm3.Controls.Add(this.QueryButton2);
            this.panelForm3.Controls.Add(this.QueryButton1);
            this.panelForm3.Controls.Add(this.NrCai);
            this.panelForm3.Controls.Add(this.NumeModel);
            this.panelForm3.Controls.Add(this.Query4);
            this.panelForm3.Controls.Add(this.Query2);
            this.panelForm3.Controls.Add(this.Query3);
            this.panelForm3.Controls.Add(this.Query1);
            this.panelForm3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm3.Location = new System.Drawing.Point(200, 120);
            this.panelForm3.Name = "panelForm3";
            this.panelForm3.Size = new System.Drawing.Size(1704, 921);
            this.panelForm3.TabIndex = 5;
            // 
            // Salariu
            // 
            this.Salariu.BackColor = System.Drawing.SystemColors.Window;
            this.Salariu.BorderColor = System.Drawing.Color.Black;
            this.Salariu.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(40)))));
            this.Salariu.BorderRadius = 8;
            this.Salariu.BorderSize = 2;
            this.Salariu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Salariu.ForeColor = System.Drawing.Color.DimGray;
            this.Salariu.Location = new System.Drawing.Point(896, 317);
            this.Salariu.Margin = new System.Windows.Forms.Padding(4);
            this.Salariu.Multiline = false;
            this.Salariu.Name = "Salariu";
            this.Salariu.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Salariu.PasswordChar = false;
            this.Salariu.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Salariu.PlaceholderText = "Introduceti salariul";
            this.Salariu.Size = new System.Drawing.Size(250, 31);
            this.Salariu.TabIndex = 40;
            this.Salariu.Texts = "";
            this.Salariu.UnderlineStyle = false;
            // 
            // Emisii
            // 
            this.Emisii.BackColor = System.Drawing.SystemColors.Window;
            this.Emisii.BorderColor = System.Drawing.Color.Black;
            this.Emisii.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(40)))));
            this.Emisii.BorderRadius = 8;
            this.Emisii.BorderSize = 2;
            this.Emisii.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Emisii.ForeColor = System.Drawing.Color.DimGray;
            this.Emisii.Location = new System.Drawing.Point(896, 149);
            this.Emisii.Margin = new System.Windows.Forms.Padding(4);
            this.Emisii.Multiline = false;
            this.Emisii.Name = "Emisii";
            this.Emisii.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Emisii.PasswordChar = false;
            this.Emisii.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Emisii.PlaceholderText = "Introduceti valoarea emisiilor ";
            this.Emisii.Size = new System.Drawing.Size(250, 31);
            this.Emisii.TabIndex = 39;
            this.Emisii.Texts = "";
            this.Emisii.UnderlineStyle = false;
            // 
            // CerintaQ4
            // 
            this.CerintaQ4.BackColor = System.Drawing.SystemColors.Control;
            this.CerintaQ4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CerintaQ4.Location = new System.Drawing.Point(896, 287);
            this.CerintaQ4.Name = "CerintaQ4";
            this.CerintaQ4.Size = new System.Drawing.Size(554, 16);
            this.CerintaQ4.TabIndex = 38;
            this.CerintaQ4.Text = "Vanzatorul care a vandut cea mai scumpa masina anul acesta care are salariul de b" +
    "aza sub valoarea de:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(896, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(530, 16);
            this.textBox2.TabIndex = 37;
            this.textBox2.Text = "Totalul vanzarilor cu pretul de peste pretul mediu al unei masini cu emisiile mai" +
    " mici decat valoarea:";
            // 
            // CerintaQ2
            // 
            this.CerintaQ2.BackColor = System.Drawing.SystemColors.Control;
            this.CerintaQ2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CerintaQ2.ForeColor = System.Drawing.Color.Black;
            this.CerintaQ2.Location = new System.Drawing.Point(239, 290);
            this.CerintaQ2.Name = "CerintaQ2";
            this.CerintaQ2.Size = new System.Drawing.Size(480, 16);
            this.CerintaQ2.TabIndex = 36;
            this.CerintaQ2.Text = "Vanzatorul care a vandut cele mai multe masini cu puterea peste un numar de cai p" +
    "utere:";
            // 
            // CerintaQ1
            // 
            this.CerintaQ1.BackColor = System.Drawing.SystemColors.Control;
            this.CerintaQ1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CerintaQ1.Location = new System.Drawing.Point(239, 120);
            this.CerintaQ1.Name = "CerintaQ1";
            this.CerintaQ1.Size = new System.Drawing.Size(372, 16);
            this.CerintaQ1.TabIndex = 35;
            this.CerintaQ1.Text = "Cea mai vanduta culoare pe un anumit model:";
            // 
            // QueryButton4
            // 
            this.QueryButton4.BackColor = System.Drawing.SystemColors.Control;
            this.QueryButton4.BackgroundColor = System.Drawing.SystemColors.Control;
            this.QueryButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.QueryButton4.BorderColor = System.Drawing.Color.Black;
            this.QueryButton4.BorderRadius = 8;
            this.QueryButton4.BorderSize = 2;
            this.QueryButton4.FlatAppearance.BorderSize = 0;
            this.QueryButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.QueryButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.QueryButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QueryButton4.ForeColor = System.Drawing.Color.Black;
            this.QueryButton4.Location = new System.Drawing.Point(1207, 317);
            this.QueryButton4.Name = "QueryButton4";
            this.QueryButton4.Size = new System.Drawing.Size(111, 31);
            this.QueryButton4.TabIndex = 34;
            this.QueryButton4.Text = "Afiseaza";
            this.QueryButton4.TextColor = System.Drawing.Color.Black;
            this.QueryButton4.UseVisualStyleBackColor = false;
            this.QueryButton4.Click += new System.EventHandler(this.QueryButton4_Click_1);
            this.QueryButton4.MouseEnter += new System.EventHandler(this.QueryButton4_MouseEnter);
            this.QueryButton4.MouseLeave += new System.EventHandler(this.QueryButton4_MouseLeave);
            // 
            // QueryButton3
            // 
            this.QueryButton3.BackColor = System.Drawing.SystemColors.Control;
            this.QueryButton3.BackgroundColor = System.Drawing.SystemColors.Control;
            this.QueryButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.QueryButton3.BorderColor = System.Drawing.Color.Black;
            this.QueryButton3.BorderRadius = 8;
            this.QueryButton3.BorderSize = 2;
            this.QueryButton3.FlatAppearance.BorderSize = 0;
            this.QueryButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.QueryButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.QueryButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QueryButton3.ForeColor = System.Drawing.Color.Black;
            this.QueryButton3.Location = new System.Drawing.Point(1207, 149);
            this.QueryButton3.Name = "QueryButton3";
            this.QueryButton3.Size = new System.Drawing.Size(111, 31);
            this.QueryButton3.TabIndex = 33;
            this.QueryButton3.Text = "Afiseaza";
            this.QueryButton3.TextColor = System.Drawing.Color.Black;
            this.QueryButton3.UseVisualStyleBackColor = false;
            this.QueryButton3.Click += new System.EventHandler(this.QueryButton3_Click);
            this.QueryButton3.MouseEnter += new System.EventHandler(this.QueryButton3_MouseEnter);
            this.QueryButton3.MouseLeave += new System.EventHandler(this.QueryButton3_MouseLeave);
            // 
            // QueryButton2
            // 
            this.QueryButton2.BackColor = System.Drawing.SystemColors.Control;
            this.QueryButton2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.QueryButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.QueryButton2.BorderColor = System.Drawing.Color.Black;
            this.QueryButton2.BorderRadius = 8;
            this.QueryButton2.BorderSize = 2;
            this.QueryButton2.FlatAppearance.BorderSize = 0;
            this.QueryButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.QueryButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.QueryButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QueryButton2.ForeColor = System.Drawing.Color.Black;
            this.QueryButton2.Location = new System.Drawing.Point(563, 317);
            this.QueryButton2.Name = "QueryButton2";
            this.QueryButton2.Size = new System.Drawing.Size(111, 31);
            this.QueryButton2.TabIndex = 32;
            this.QueryButton2.Text = "Afiseaza";
            this.QueryButton2.TextColor = System.Drawing.Color.Black;
            this.QueryButton2.UseVisualStyleBackColor = false;
            this.QueryButton2.Click += new System.EventHandler(this.QueryButton2_Click);
            this.QueryButton2.MouseEnter += new System.EventHandler(this.QueryButton2_MouseEnter);
            this.QueryButton2.MouseLeave += new System.EventHandler(this.QueryButton2_MouseLeave);
            // 
            // QueryButton1
            // 
            this.QueryButton1.BackColor = System.Drawing.SystemColors.Control;
            this.QueryButton1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.QueryButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.QueryButton1.BorderColor = System.Drawing.Color.Black;
            this.QueryButton1.BorderRadius = 8;
            this.QueryButton1.BorderSize = 2;
            this.QueryButton1.FlatAppearance.BorderSize = 0;
            this.QueryButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.QueryButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.QueryButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QueryButton1.ForeColor = System.Drawing.Color.Black;
            this.QueryButton1.Location = new System.Drawing.Point(563, 149);
            this.QueryButton1.Name = "QueryButton1";
            this.QueryButton1.Size = new System.Drawing.Size(111, 31);
            this.QueryButton1.TabIndex = 31;
            this.QueryButton1.Text = "Afiseaza";
            this.QueryButton1.TextColor = System.Drawing.Color.Black;
            this.QueryButton1.UseVisualStyleBackColor = false;
            this.QueryButton1.Click += new System.EventHandler(this.QueryButton1_Click);
            this.QueryButton1.MouseEnter += new System.EventHandler(this.QueryButton1_MouseEnter);
            this.QueryButton1.MouseLeave += new System.EventHandler(this.QueryButton1_MouseLeave);
            // 
            // NrCai
            // 
            this.NrCai.BackColor = System.Drawing.SystemColors.Window;
            this.NrCai.BorderColor = System.Drawing.Color.Black;
            this.NrCai.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(40)))));
            this.NrCai.BorderRadius = 8;
            this.NrCai.BorderSize = 2;
            this.NrCai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NrCai.ForeColor = System.Drawing.Color.DimGray;
            this.NrCai.Location = new System.Drawing.Point(239, 317);
            this.NrCai.Margin = new System.Windows.Forms.Padding(4);
            this.NrCai.Multiline = false;
            this.NrCai.Name = "NrCai";
            this.NrCai.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.NrCai.PasswordChar = false;
            this.NrCai.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.NrCai.PlaceholderText = "Introduceti numarul de cai putere";
            this.NrCai.Size = new System.Drawing.Size(250, 31);
            this.NrCai.TabIndex = 20;
            this.NrCai.Texts = "";
            this.NrCai.UnderlineStyle = false;
            // 
            // NumeModel
            // 
            this.NumeModel.BackColor = System.Drawing.SystemColors.Window;
            this.NumeModel.BorderColor = System.Drawing.Color.Black;
            this.NumeModel.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(40)))));
            this.NumeModel.BorderRadius = 8;
            this.NumeModel.BorderSize = 2;
            this.NumeModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumeModel.ForeColor = System.Drawing.Color.DimGray;
            this.NumeModel.Location = new System.Drawing.Point(239, 149);
            this.NumeModel.Margin = new System.Windows.Forms.Padding(4);
            this.NumeModel.Multiline = false;
            this.NumeModel.Name = "NumeModel";
            this.NumeModel.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.NumeModel.PasswordChar = false;
            this.NumeModel.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.NumeModel.PlaceholderText = "Introduceti modelul";
            this.NumeModel.Size = new System.Drawing.Size(250, 31);
            this.NumeModel.TabIndex = 19;
            this.NumeModel.Texts = "";
            this.NumeModel.UnderlineStyle = false;
            // 
            // Query4
            // 
            this.Query4.BackColor = System.Drawing.SystemColors.Window;
            this.Query4.BorderColor = System.Drawing.Color.Black;
            this.Query4.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(40)))));
            this.Query4.BorderRadius = 8;
            this.Query4.BorderSize = 2;
            this.Query4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Query4.ForeColor = System.Drawing.Color.Black;
            this.Query4.Location = new System.Drawing.Point(896, 356);
            this.Query4.Margin = new System.Windows.Forms.Padding(4);
            this.Query4.Multiline = false;
            this.Query4.Name = "Query4";
            this.Query4.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Query4.PasswordChar = false;
            this.Query4.PlaceholderColor = System.Drawing.Color.Black;
            this.Query4.PlaceholderText = "";
            this.Query4.Size = new System.Drawing.Size(250, 31);
            this.Query4.TabIndex = 18;
            this.Query4.Texts = "";
            this.Query4.UnderlineStyle = false;
            // 
            // Query2
            // 
            this.Query2.BackColor = System.Drawing.SystemColors.Window;
            this.Query2.BorderColor = System.Drawing.Color.Black;
            this.Query2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(40)))));
            this.Query2.BorderRadius = 8;
            this.Query2.BorderSize = 2;
            this.Query2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Query2.ForeColor = System.Drawing.Color.Black;
            this.Query2.Location = new System.Drawing.Point(239, 356);
            this.Query2.Margin = new System.Windows.Forms.Padding(4);
            this.Query2.Multiline = false;
            this.Query2.Name = "Query2";
            this.Query2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Query2.PasswordChar = false;
            this.Query2.PlaceholderColor = System.Drawing.Color.Black;
            this.Query2.PlaceholderText = "";
            this.Query2.Size = new System.Drawing.Size(250, 31);
            this.Query2.TabIndex = 17;
            this.Query2.Texts = "";
            this.Query2.UnderlineStyle = false;
            // 
            // Query3
            // 
            this.Query3.BackColor = System.Drawing.SystemColors.Window;
            this.Query3.BorderColor = System.Drawing.Color.Black;
            this.Query3.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(40)))));
            this.Query3.BorderRadius = 8;
            this.Query3.BorderSize = 2;
            this.Query3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Query3.ForeColor = System.Drawing.Color.Black;
            this.Query3.Location = new System.Drawing.Point(896, 188);
            this.Query3.Margin = new System.Windows.Forms.Padding(4);
            this.Query3.Multiline = false;
            this.Query3.Name = "Query3";
            this.Query3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Query3.PasswordChar = false;
            this.Query3.PlaceholderColor = System.Drawing.Color.Black;
            this.Query3.PlaceholderText = "";
            this.Query3.Size = new System.Drawing.Size(250, 31);
            this.Query3.TabIndex = 16;
            this.Query3.Texts = "";
            this.Query3.UnderlineStyle = false;
            // 
            // Query1
            // 
            this.Query1.BackColor = System.Drawing.SystemColors.Window;
            this.Query1.BorderColor = System.Drawing.Color.Black;
            this.Query1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(40)))));
            this.Query1.BorderRadius = 8;
            this.Query1.BorderSize = 2;
            this.Query1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Query1.ForeColor = System.Drawing.Color.Black;
            this.Query1.Location = new System.Drawing.Point(239, 188);
            this.Query1.Margin = new System.Windows.Forms.Padding(4);
            this.Query1.Multiline = false;
            this.Query1.Name = "Query1";
            this.Query1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Query1.PasswordChar = false;
            this.Query1.PlaceholderColor = System.Drawing.Color.Black;
            this.Query1.PlaceholderText = "";
            this.Query1.Size = new System.Drawing.Size(250, 31);
            this.Query1.TabIndex = 15;
            this.Query1.Texts = "";
            this.Query1.UnderlineStyle = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panelForm3);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.Menu);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.Menu.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            this.panelForm3.ResumeLayout(false);
            this.panelForm3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button AdaugareVanzare;
        private System.Windows.Forms.Button VanzariPred;
        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Panel panelForm3;
        private System.Windows.Forms.Button PerformanteDealership;
        private Properties.DBTextBox Query4;
        private Properties.DBTextBox Query2;
        private Properties.DBTextBox Query3;
        private Properties.DBTextBox Query1;
        private Properties.DBTextBox NrCai;
        private Properties.DBTextBox NumeModel;
        private Properties.DBButton QueryButton4;
        private Properties.DBButton QueryButton3;
        private Properties.DBButton QueryButton2;
        private Properties.DBButton QueryButton1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox CerintaQ2;
        private System.Windows.Forms.TextBox CerintaQ1;
        private System.Windows.Forms.TextBox CerintaQ4;
        private Properties.DBTextBox Salariu;
        private Properties.DBTextBox Emisii;
    }
}