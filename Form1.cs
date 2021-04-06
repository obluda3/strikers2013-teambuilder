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
        string languageFile;
        public form1()
        {
            InitializeComponent();
            
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

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            languageFile = "StrikersPlayerGenerator.languages.English.txt";
            englishToolStripMenuItem.Checked = true;
            frenchToolStripMenuItem.Checked = false;
            germanToolStripMenuItem.Checked = false;
            updateText();
        }

        private void frenchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            languageFile = "StrikersPlayerGenerator.languages.French.txt";
            frenchToolStripMenuItem.Checked = true;
            englishToolStripMenuItem.Checked = false;
            germanToolStripMenuItem.Checked = false;
            updateText();
        }

        private void germanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            languageFile = "StrikersPlayerGenerator.languages.German.txt";
            frenchToolStripMenuItem.Checked = false;
            englishToolStripMenuItem.Checked = false;
            germanToolStripMenuItem.Checked = true;
            updateText();
        }

        private void updateText() 
        {
            var assembly = Assembly.GetExecutingAssembly();
            string[] programText;

            // Gets the names of the moves
            using (var file = assembly.GetManifestResourceStream(languageFile))
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    var programTextList = new List<string>();
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        programTextList.Add(line);
                    }

                    programText = programTextList.ToArray();
                }
            }

            tStripMenuItem_Team.Text = programText[1];
            tStripMenuItem_New.Text = programText[2];
            tStripMenuItem_Open.Text = programText[3];
            tStripMenuItem_Save.Text = programText[4];
            languageToolStripMenuItem.Text = programText[5];
            frenchToolStripMenuItem.Text = programText[6];
            englishToolStripMenuItem.Text = programText[7];
            germanToolStripMenuItem.Text = programText[8];
            btn_Add.Text = programText[10];
            btn_Remove.Text = programText[11];
            btn_Generate.Text = programText[12];
            tabPage_Info.Text = programText[13];
            label_Player.Text = programText[14];
            tabPage1.Text = programText[15];
            label_TeamName.Text = programText[16];
            label_TeamEmblem.Text = programText[17];
            label_TeamWear.Text = programText[18];
            label_TeamAuthor.Text = programText[19];
            label1.Text = programText[20];
            btn_Random.Text = programText[21];
        }
    }
}
