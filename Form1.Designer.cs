namespace StrikersPlayerGenerator
{
    partial class form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tab_Player = new System.Windows.Forms.TabControl();
            this.tabPage_Info = new System.Windows.Forms.TabPage();
            this.cmbBox_Player = new System.Windows.Forms.ComboBox();
            this.label_Player = new System.Windows.Forms.Label();
            this.txtBox_Code = new System.Windows.Forms.TextBox();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.tab_Team = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtBox_TeamDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_TeamAuthor = new System.Windows.Forms.Label();
            this.txtBox_TeamAuthor = new System.Windows.Forms.TextBox();
            this.label_TeamWear = new System.Windows.Forms.Label();
            this.cmb_TeamWear = new System.Windows.Forms.ComboBox();
            this.cmb_TeamEmblem = new System.Windows.Forms.ComboBox();
            this.label_TeamEmblem = new System.Windows.Forms.Label();
            this.txtBox_TeamName = new System.Windows.Forms.TextBox();
            this.label_TeamName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tStripMenuItem_Team = new System.Windows.Forms.ToolStripMenuItem();
            this.tStripMenuItem_New = new System.Windows.Forms.ToolStripMenuItem();
            this.tStripMenuItem_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.tStripMenuItem_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tab_Player.SuspendLayout();
            this.tabPage_Info.SuspendLayout();
            this.tab_Team.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(187, 199);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tab_Player
            // 
            this.tab_Player.Controls.Add(this.tabPage_Info);
            this.tab_Player.Enabled = false;
            this.tab_Player.Location = new System.Drawing.Point(205, 27);
            this.tab_Player.Name = "tab_Player";
            this.tab_Player.SelectedIndex = 0;
            this.tab_Player.Size = new System.Drawing.Size(316, 100);
            this.tab_Player.TabIndex = 1;
            // 
            // tabPage_Info
            // 
            this.tabPage_Info.Controls.Add(this.cmbBox_Player);
            this.tabPage_Info.Controls.Add(this.label_Player);
            this.tabPage_Info.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Info.Name = "tabPage_Info";
            this.tabPage_Info.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Info.Size = new System.Drawing.Size(308, 74);
            this.tabPage_Info.TabIndex = 0;
            this.tabPage_Info.Text = "Info";
            this.tabPage_Info.UseVisualStyleBackColor = true;
            this.tabPage_Info.Click += new System.EventHandler(this.tabPage_Info_Click);
            // 
            // cmbBox_Player
            // 
            this.cmbBox_Player.FormattingEnabled = true;
            this.cmbBox_Player.Location = new System.Drawing.Point(48, 16);
            this.cmbBox_Player.Name = "cmbBox_Player";
            this.cmbBox_Player.Size = new System.Drawing.Size(121, 21);
            this.cmbBox_Player.TabIndex = 1;
            this.cmbBox_Player.SelectedIndexChanged += new System.EventHandler(this.cmbBox_Player_SelectedIndexChanged);
            // 
            // label_Player
            // 
            this.label_Player.AutoSize = true;
            this.label_Player.Location = new System.Drawing.Point(6, 19);
            this.label_Player.Name = "label_Player";
            this.label_Player.Size = new System.Drawing.Size(36, 13);
            this.label_Player.TabIndex = 0;
            this.label_Player.Text = "Player";
            this.label_Player.Click += new System.EventHandler(this.label_Player_Click);
            // 
            // txtBox_Code
            // 
            this.txtBox_Code.Enabled = false;
            this.txtBox_Code.Location = new System.Drawing.Point(12, 261);
            this.txtBox_Code.Multiline = true;
            this.txtBox_Code.Name = "txtBox_Code";
            this.txtBox_Code.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox_Code.Size = new System.Drawing.Size(187, 182);
            this.txtBox_Code.TabIndex = 2;
            this.txtBox_Code.TextChanged += new System.EventHandler(this.textBox_Code_TextChanged);
            // 
            // btn_Generate
            // 
            this.btn_Generate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Generate.Enabled = false;
            this.btn_Generate.Location = new System.Drawing.Point(65, 453);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(75, 23);
            this.btn_Generate.TabIndex = 3;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Add.Enabled = false;
            this.btn_Add.Location = new System.Drawing.Point(12, 232);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Enabled = false;
            this.btn_Remove.Location = new System.Drawing.Point(123, 232);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.btn_Remove.TabIndex = 5;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // tab_Team
            // 
            this.tab_Team.Controls.Add(this.tabPage1);
            this.tab_Team.Enabled = false;
            this.tab_Team.Location = new System.Drawing.Point(209, 133);
            this.tab_Team.Name = "tab_Team";
            this.tab_Team.SelectedIndex = 0;
            this.tab_Team.Size = new System.Drawing.Size(312, 320);
            this.tab_Team.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtBox_TeamDescription);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label_TeamAuthor);
            this.tabPage1.Controls.Add(this.txtBox_TeamAuthor);
            this.tabPage1.Controls.Add(this.label_TeamWear);
            this.tabPage1.Controls.Add(this.cmb_TeamWear);
            this.tabPage1.Controls.Add(this.cmb_TeamEmblem);
            this.tabPage1.Controls.Add(this.label_TeamEmblem);
            this.tabPage1.Controls.Add(this.txtBox_TeamName);
            this.tabPage1.Controls.Add(this.label_TeamName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(304, 294);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Team";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtBox_TeamDescription
            // 
            this.txtBox_TeamDescription.Location = new System.Drawing.Point(75, 130);
            this.txtBox_TeamDescription.Multiline = true;
            this.txtBox_TeamDescription.Name = "txtBox_TeamDescription";
            this.txtBox_TeamDescription.Size = new System.Drawing.Size(167, 139);
            this.txtBox_TeamDescription.TabIndex = 9;
            this.txtBox_TeamDescription.TextChanged += new System.EventHandler(this.txtBox_TeamDescription_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Description";
            // 
            // label_TeamAuthor
            // 
            this.label_TeamAuthor.AutoSize = true;
            this.label_TeamAuthor.Location = new System.Drawing.Point(6, 105);
            this.label_TeamAuthor.Name = "label_TeamAuthor";
            this.label_TeamAuthor.Size = new System.Drawing.Size(38, 13);
            this.label_TeamAuthor.TabIndex = 7;
            this.label_TeamAuthor.Text = "Author";
            // 
            // txtBox_TeamAuthor
            // 
            this.txtBox_TeamAuthor.Location = new System.Drawing.Point(75, 102);
            this.txtBox_TeamAuthor.Name = "txtBox_TeamAuthor";
            this.txtBox_TeamAuthor.Size = new System.Drawing.Size(167, 20);
            this.txtBox_TeamAuthor.TabIndex = 6;
            this.txtBox_TeamAuthor.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label_TeamWear
            // 
            this.label_TeamWear.AutoSize = true;
            this.label_TeamWear.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_TeamWear.Location = new System.Drawing.Point(6, 75);
            this.label_TeamWear.Name = "label_TeamWear";
            this.label_TeamWear.Size = new System.Drawing.Size(33, 13);
            this.label_TeamWear.TabIndex = 5;
            this.label_TeamWear.Text = "Wear";
            // 
            // cmb_TeamWear
            // 
            this.cmb_TeamWear.FormattingEnabled = true;
            this.cmb_TeamWear.Location = new System.Drawing.Point(75, 72);
            this.cmb_TeamWear.Name = "cmb_TeamWear";
            this.cmb_TeamWear.Size = new System.Drawing.Size(167, 21);
            this.cmb_TeamWear.TabIndex = 4;
            this.cmb_TeamWear.SelectedIndexChanged += new System.EventHandler(this.cmb_TeamWear_SelectedIndexChanged);
            // 
            // cmb_TeamEmblem
            // 
            this.cmb_TeamEmblem.FormattingEnabled = true;
            this.cmb_TeamEmblem.Location = new System.Drawing.Point(75, 45);
            this.cmb_TeamEmblem.Name = "cmb_TeamEmblem";
            this.cmb_TeamEmblem.Size = new System.Drawing.Size(167, 21);
            this.cmb_TeamEmblem.TabIndex = 3;
            this.cmb_TeamEmblem.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label_TeamEmblem
            // 
            this.label_TeamEmblem.AutoSize = true;
            this.label_TeamEmblem.Location = new System.Drawing.Point(6, 48);
            this.label_TeamEmblem.Name = "label_TeamEmblem";
            this.label_TeamEmblem.Size = new System.Drawing.Size(44, 13);
            this.label_TeamEmblem.TabIndex = 2;
            this.label_TeamEmblem.Text = "Emblem";
            // 
            // txtBox_TeamName
            // 
            this.txtBox_TeamName.Location = new System.Drawing.Point(75, 16);
            this.txtBox_TeamName.Name = "txtBox_TeamName";
            this.txtBox_TeamName.Size = new System.Drawing.Size(118, 20);
            this.txtBox_TeamName.TabIndex = 1;
            this.txtBox_TeamName.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label_TeamName
            // 
            this.label_TeamName.AutoSize = true;
            this.label_TeamName.Location = new System.Drawing.Point(6, 19);
            this.label_TeamName.Name = "label_TeamName";
            this.label_TeamName.Size = new System.Drawing.Size(35, 13);
            this.label_TeamName.TabIndex = 0;
            this.label_TeamName.Text = "Name";
            this.label_TeamName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripMenuItem_Team});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(540, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tStripMenuItem_Team
            // 
            this.tStripMenuItem_Team.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripMenuItem_New,
            this.tStripMenuItem_Open,
            this.tStripMenuItem_Save});
            this.tStripMenuItem_Team.Name = "tStripMenuItem_Team";
            this.tStripMenuItem_Team.Size = new System.Drawing.Size(47, 20);
            this.tStripMenuItem_Team.Text = "Team";
            // 
            // tStripMenuItem_New
            // 
            this.tStripMenuItem_New.Name = "tStripMenuItem_New";
            this.tStripMenuItem_New.Size = new System.Drawing.Size(103, 22);
            this.tStripMenuItem_New.Text = "New";
            this.tStripMenuItem_New.Click += new System.EventHandler(this.tStripMenuItem_New_Click);
            // 
            // tStripMenuItem_Open
            // 
            this.tStripMenuItem_Open.Name = "tStripMenuItem_Open";
            this.tStripMenuItem_Open.Size = new System.Drawing.Size(103, 22);
            this.tStripMenuItem_Open.Text = "Open";
            this.tStripMenuItem_Open.Click += new System.EventHandler(this.tStripMenuItem_Open_Click);
            // 
            // tStripMenuItem_Save
            // 
            this.tStripMenuItem_Save.Name = "tStripMenuItem_Save";
            this.tStripMenuItem_Save.Size = new System.Drawing.Size(103, 22);
            this.tStripMenuItem_Save.Text = "Save";
            this.tStripMenuItem_Save.Click += new System.EventHandler(this.tStripMenuItem_Save_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 494);
            this.Controls.Add(this.tab_Team);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.txtBox_Code);
            this.Controls.Add(this.tab_Player);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "form1";
            this.Text = "Inazuma Eleven Go Strikers 2013 Teambuilder";
            this.tab_Player.ResumeLayout(false);
            this.tabPage_Info.ResumeLayout(false);
            this.tabPage_Info.PerformLayout();
            this.tab_Team.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabControl tab_Player;
        private System.Windows.Forms.TabPage tabPage_Info;
        private System.Windows.Forms.TextBox txtBox_Code;
        private System.Windows.Forms.ComboBox cmbBox_Player;
        private System.Windows.Forms.Label label_Player;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.TabControl tab_Team;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtBox_TeamName;
        private System.Windows.Forms.Label label_TeamName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tStripMenuItem_Team;
        private System.Windows.Forms.ToolStripMenuItem tStripMenuItem_New;
        private System.Windows.Forms.TextBox txtBox_TeamDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_TeamAuthor;
        private System.Windows.Forms.TextBox txtBox_TeamAuthor;
        private System.Windows.Forms.Label label_TeamWear;
        private System.Windows.Forms.ComboBox cmb_TeamWear;
        private System.Windows.Forms.ComboBox cmb_TeamEmblem;
        private System.Windows.Forms.Label label_TeamEmblem;
        private System.Windows.Forms.ToolStripMenuItem tStripMenuItem_Open;
        private System.Windows.Forms.ToolStripMenuItem tStripMenuItem_Save;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

