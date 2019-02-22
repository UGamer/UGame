using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_UGamer_Launcher
{
    public partial class AddGameOptions : Form
    {
        string finalReturn;

        public AddGameOptions()
        {
            InitializeComponent();
        }

        private void EXEButton_Click(object sender, EventArgs e)
        {
            DialogResult result = EXEFileDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = EXEFileDialog.FileName;
                EXEFilePathBox.Text = file;
            }
        }

        private void SteamCodeLabel_Click(object sender, EventArgs e)
        {

        }

        private void SteamCodeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CompleteButton_Click(object sender, EventArgs e)
        {
            if (Tabs.SelectedTab == SteamTab)
                finalReturn = "steam://rungameid/" + SteamCodeBox.Text;
            
            else if (Tabs.SelectedTab == EXETab)
                finalReturn = EXEFilePathBox.Text;
            
            else if (Tabs.SelectedTab == BattleNETTab)
            {
                finalReturn = BattleNETFilePathBox.Text;
                
                if (BattleNetGameComboBox.Text != "")
                {
                    finalReturn += " --exec=\"launch ";

                    if (BattleNetGameComboBox.Text == "Call of Duty: Black Ops 4")
                        finalReturn += "VIPR\"";
                    
                    else if (BattleNetGameComboBox.Text == "Destiny 2")
                        finalReturn += "DST2\"";
                    
                    else if (BattleNetGameComboBox.Text == "Diablo 3")
                        finalReturn += "D3\"";
                    
                    else if (BattleNetGameComboBox.Text == "Hearthstone")
                        finalReturn += "WTCG\"";
                    
                    else if (BattleNetGameComboBox.Text == "Heroes of the Storm")
                        finalReturn += "Hero\"";
                    
                    else if (BattleNetGameComboBox.Text == "Overwatch")
                        finalReturn += "Pro\"";
                    
                    else if (BattleNetGameComboBox.Text == "Starcraft Remastered")
                        finalReturn += "S1\"";
                    
                    else if (BattleNetGameComboBox.Text == "Starcraft 2")
                        finalReturn += "S2\"";

                    else if (BattleNetGameComboBox.Text == "World of Warcraft")
                        finalReturn += "WoW\"";
                }
                else
                {
                    string message = "No specific game chosen to launch, meaning launching this entry will only" +
                        "open Battle.NET. Are you sure this is what you want?";
                    string caption = "No Battle.NET Game Provided";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, caption, buttons);
                    if (result == DialogResult.Yes)
                    {
                        // return finalReturn;
                    }

                }
            }
            else if (Tabs.SelectedTab == EmulationTab)
            {
                string message = "No specific game chosen to launch, meaning launching this entry will only" +
                        "open the emulator. Are you sure this is what you want?";
                string caption = "No ROM File Provided";

                if (EmulatorTabs.SelectedTab == HiganTab)
                {
                    finalReturn = HiganEmulatorBox.Text;
                    if (HiganROMBox.Text != "")
                    {
                        if (HiganFullscreen.Checked == true)
                        {
                            finalReturn += " --fullscreen " + HiganROMBox.Text;
                        }
                        else
                            finalReturn += " - " + HiganROMBox.Text;
                    }
                    else
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, caption, buttons);
                        if (result == DialogResult.Yes)
                        {
                            // return finalReturn;
                        }
                    }
                    
                }
                else if (EmulatorTabs.SelectedTab == N64Tab)
                {
                    finalReturn = N64EmulatorBox.Text;
                    if (N64ROMBox.Text != "")
                    {
                        if (HiganFullscreen.Checked == true)
                        {
                            finalReturn += " --fullscreen " + HiganROMBox.Text;
                        }
                        else
                            finalReturn += " - " + HiganROMBox.Text;
                    }
                    else
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, caption, buttons);
                        if (result == DialogResult.Yes)
                        {
                            // return finalReturn;
                        }
                    }
                }
                else if (EmulatorTabs.SelectedTab == PS1Tab)
                {

                }
                else if (EmulatorTabs.SelectedTab == DSTab)
                {

                }
                else if (EmulatorTabs.SelectedTab == DolphinTab)
                {

                }
                else if (EmulatorTabs.SelectedTab == PS2Tab)
                {

                }
                else if (EmulatorTabs.SelectedTab == PSPTab)
                {

                }
                else if (EmulatorTabs.SelectedTab == WiiUTab)
                {

                }
            }
        }
    }
}
