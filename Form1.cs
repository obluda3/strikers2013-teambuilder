using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using Newtonsoft.Json;

namespace StrikersPlayerGenerator
{
    
    public partial class form1 : Form
    {
        InazumaTeam team = new InazumaTeam();
        public form1()
        {
            InitializeComponent();
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label_Player_Click(object sender, EventArgs e)
        {

        }

        private void label_TP_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Kick_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Body_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Control_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Guard_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Speed_Click(object sender, EventArgs e)
        {

        }


        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Catch_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            team.teamName = txtBox_TeamName.Text;
        }

        private void tStripMenuItem_New_Click(object sender, EventArgs e)
        {
            enableEverything();
            // Create a new team
            team = new InazumaTeam();

            
        }

        private void textBox_Code_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            CheatCode cheat = new CheatCode();
            txtBox_Code.Clear();
            // Add the team name if there's one
            if (team.teamName != null) 
            {
                var teamCheatCode = string.Join("\r\n", cheat.TeamNameCode(team.teamName));
                txtBox_Code.Text += teamCheatCode + "\r\n";
            }

            // Add the emblem if there's one
            if (team.teamEmblem.emblemID != 0)
            {
                var emblemCheatCode = cheat.emblemCheatCode(team.teamEmblem.emblemID);
                txtBox_Code.Text += emblemCheatCode + "\r\n";
            }
            
            // Add the wear if there's one
            if (team.teamWear.wearID != 0)
            {
                var wearCheatCode = cheat.wearCheatCode(team.teamWear.wearID);
                txtBox_Code.Text += wearCheatCode + "\r\n";
            }

            for(int i = 1; i < team.playerList.Count+1; i++)
            {
                var playerCheatCode = cheat.playerCheatCode(team.playerList[i-1].playerID, i);
                txtBox_Code.Text += playerCheatCode + "\r\n";
            }


        }

        private void tabPage_Info_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            team.teamAuthor = txtBox_TeamAuthor.Text;
        }

        private void txtBox_TeamDescription_TextChanged(object sender, EventArgs e)
        {
            team.teamDescription = txtBox_TeamDescription.Text;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            team.teamEmblem.updateEmblem(cmb_TeamEmblem.SelectedIndex);
        }

        private void cmb_TeamWear_SelectedIndexChanged(object sender, EventArgs e)
        {
            team.teamWear.updateWear(cmb_TeamWear.SelectedIndex);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Add("Player " + Convert.ToString(listBox1.Items.Count + 1));
            Player newPlayer = new Player();
            team.playerList.Add(newPlayer);
            btn_Remove.Enabled = true;
            // Disables the button if the team is full
            if (listBox1.Items.Count == 16) { btn_Add.Enabled = false; }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(listBox1.SelectedIndex);
            var listboxindex = listBox1.SelectedIndex;
            if (listboxindex >= 0)
            {
                if (team.playerList[listboxindex].playerID != 0) {
                    cmbBox_Player.SelectedIndex = team.playerList[listBox1.SelectedIndex].playerID - 1;
                    cmbBox_Player.Text = team.playerList[listBox1.SelectedIndex].playerName;
                }
                else
                {
                    cmbBox_Player.Text = "";
                }
                tab_Player.Enabled = true;


            }
        }

        private void cmbBox_Player_SelectedIndexChanged(object sender, EventArgs e)
        {
            var indexlistbox = listBox1.SelectedIndex;
            team.playerList[indexlistbox].updatePlayer(cmbBox_Player.SelectedIndex);
            listBox1.Items[indexlistbox] = team.playerList[indexlistbox].playerName;
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            // Get the last index in the list, and removes the last player
            var lastindex = listBox1.Items.Count - 1;
            team.playerList.RemoveAt(lastindex);
            listBox1.Items.RemoveAt(lastindex);
            // Disable the button if there's no player
            if (lastindex == 0) { btn_Remove.Enabled = false; }
            // Enables the add button if there's less than 16 players
            if (lastindex == 15) { btn_Add.Enabled = true; }
        }

        private void tStripMenuItem_Save_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Strikers Team Files (*.stf)|*.stf|All files (*.*)|*.*";
                sfd.DefaultExt = ".stf";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.NullValueHandling = NullValueHandling.Ignore;

                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    using(JsonWriter writer = new JsonTextWriter(sw))
                    {
                        serializer.Serialize(writer, team);
                    }
                }
            }
        }

        private void tStripMenuItem_Open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Strikers Team Files (*.stf)|*.stf|All files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    enableEverything();

                    JsonSerializer serializer = new JsonSerializer();
                    serializer.NullValueHandling = NullValueHandling.Ignore;

                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    using (JsonReader reader = new JsonTextReader(sr))
                    {
                        team = (InazumaTeam)serializer.Deserialize<InazumaTeam>(reader);
                    }
                    for(int i = 0;i < team.playerList.Count; i++)
                    {
                        // Add the players to the listbox
                        if (team.playerList[i].playerName != null) { listBox1.Items.Add(team.playerList[i].playerName); }
                        else { listBox1.Items.Add("Player " + i.ToString()); }
                    }
                    // Add the text stuff
                    cmb_TeamEmblem.Text = team.teamEmblem.emblemName;
                    cmb_TeamWear.Text = team.teamWear.wearName;
                    txtBox_TeamAuthor.Text = team.teamAuthor;
                    txtBox_TeamDescription.Text = team.teamDescription;
                    txtBox_TeamName.Text = team.teamName;

                    if(team.playerList.Count > 0) { btn_Remove.Enabled = true; }
                    else { btn_Add.Enabled = false; }


                }
            }
        }

        private void enableEverything()
        {
            // Enables everything
            listBox1.Items.Clear();
            listBox1.Enabled = true;
            btn_Add.Enabled = true;
            btn_Generate.Enabled = true;

            tab_Team.Enabled = true;
            txtBox_Code.Clear();
            txtBox_Code.Enabled = true;
            txtBox_Code.ReadOnly = true;
            txtBox_Code.BackColor = System.Drawing.SystemColors.Window;
            tStripMenuItem_Team.Enabled = true;

            // Fill the ComboBoxes
            cmb_TeamEmblem.Items.AddRange(Database.emblemNames);
            cmb_TeamWear.Items.AddRange(Database.wearNames);
            cmbBox_Player.Items.AddRange(Database.playerNames);
        }



        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void btn_Random_Click(object sender, EventArgs e)
        {
            enableEverything();
            team.playerList = new List<Player>();
            listBox1.Items.Clear();
            Random rand = new Random();

            for (var i = 0; i < 16; i++) {
                Player newPlayer = new Player();
                team.playerList.Add(newPlayer);

                
                var index = rand.Next(0, Database.playerNames.Length - 1);
                var unused = new int[] { 195,196,197,198,199,200,201,202,203,278,279,280,281,282,283,204,205,206,207,267,268,269,271,284,285,286,287,288,289,290,291,292,293,294,295,296,297,298,299,300,301,302,349,361,392,397,398,404,405,406,407,408,409,410,411};
                while (unused.Contains<int>(index)) { index = rand.Next(0, Database.playerNames.Length - 1); }

                team.playerList[i].updatePlayer(index);
                listBox1.Items.Add(team.playerList[i].playerName);

            }

            var wearIndex = rand.Next(0, Database.wearNames.Length - 1);
            var emblemIndex = rand.Next(0, Database.emblemNames.Length - 1);


            team.teamWear.updateWear(wearIndex);
            team.teamEmblem.updateEmblem(emblemIndex);

            cmb_TeamEmblem.SelectedIndex = emblemIndex;
            cmb_TeamWear.SelectedIndex = wearIndex;


        }
    }
}
