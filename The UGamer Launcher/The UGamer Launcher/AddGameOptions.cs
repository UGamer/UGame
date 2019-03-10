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
        private string file;
        public string finalReturn;

        public AddGameOptions()
        {
            InitializeComponent();
        }

        

        private void SteamCodeLabel_Click(object sender, EventArgs e)
        {

        }

        private void SteamCodeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CompleteButton_Click(object sender, EventArgs e)
        {
            bool exit = false;

            if (Tabs.SelectedTab == SteamTab)
            {
                finalReturn = "steam://rungameid/" + SteamCodeBox.Text;
                exit = true;
            }
            
            else if (Tabs.SelectedTab == EXETab)
            {
                finalReturn = EXEFilePathBox.Text;
                exit = true;
            }
            
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
                        exit = true;
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
                            finalReturn += " --fullscreen \"" + HiganROMBox.Text + "\"";
                        }
                        else
                            finalReturn += " - \"" + HiganROMBox.Text + "\"";

                        exit = true;
                    }
                    else
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, caption, buttons);
                        if (result == DialogResult.Yes)
                        {
                            exit = true;
                        }
                    }
                    
                }
                else if (EmulatorTabs.SelectedTab == N64Tab)
                {
                    finalReturn = N64EmulatorBox.Text;
                    if (N64ROMBox.Text != "")
                    {
                        finalReturn += " - \"" + N64ROMBox.Text + "\"";

                        exit = true;
                    }
                    else
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, caption, buttons);
                        if (result == DialogResult.Yes)
                        {
                            exit = true;
                        }
                    }
                }
                else if (EmulatorTabs.SelectedTab == PS1Tab)
                {
                    finalReturn = PS1EmulatorBox.Text;
                    if (PS1ROMBox.Text != "")
                    {
                        finalReturn += " -loadbin \"" + PS1ROMBox.Text + "\" -nogui";
                        exit = true;
                    }
                    else
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, caption, buttons);
                        if (result == DialogResult.Yes)
                        {
                            exit = true;
                        }
                    }
                }
                else if (EmulatorTabs.SelectedTab == DSTab)
                {
                    finalReturn = DSEmulatorBox.Text;
                    if (DSROMBox.Text != "")
                    {
                        finalReturn += " \"" + DSROMBox.Text + "\"";
                        exit = true;
                    }
                    else
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, caption, buttons);
                        if (result == DialogResult.Yes)
                        {
                            exit = true;
                        }
                    }
                }
                else if (EmulatorTabs.SelectedTab == DolphinTab)
                {
                    finalReturn = DolphinEmulatorBox.Text;
                    if (DolphinROMBox.Text != "")
                    {
                        finalReturn += " --exec=\"" + DolphinROMBox.Text + "\"";
                        exit = true;
                    }
                    else
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, caption, buttons);
                        if (result == DialogResult.Yes)
                        {
                            exit = true;
                        }
                    }
                }
                else if (EmulatorTabs.SelectedTab == PS2Tab)
                {
                    finalReturn = PS2EmulatorBox.Text;
                    if (PS2ROMBox.Text != "")
                    {
                        finalReturn += " \"" + PS2ROMBox.Text + "\"";

                        if (PS2ShowEmulatorCheck.Checked == false)
                            finalReturn += " --nogui";
                        
                        if (PS2FullBootCheck.Checked == true)
                            finalReturn += " --fullboot";
                        
                        if (PS2FullScreenCheck.Checked == true)
                            finalReturn += " --fullscreen";

                        exit = true;
                    }
                    else
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, caption, buttons);
                        if (result == DialogResult.Yes)
                        {
                            exit = true;
                        }
                    }
                }
                else if (EmulatorTabs.SelectedTab == PSPTab)
                {
                    finalReturn = PSPEmulatorBox.Text;
                    if (PSPROMBox.Text != "")
                    {
                        finalReturn += " \"" + PSPROMBox.Text + "\"";
                        exit = true;
                    }
                    else
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, caption, buttons);
                        if (result == DialogResult.Yes)
                        {
                            exit = true;
                        }
                    }
                }
                else if (EmulatorTabs.SelectedTab == WiiUTab)
                {
                    finalReturn = CEMUEmulatorBox.Text;
                    if (CEMUROMBox.Text != "")
                    {
                        finalReturn += " -g \"" + CEMUROMBox.Text + "\"";

                        if (CEMUFullscreenCheck.Checked == true)
                            finalReturn += " -f";

                        exit = true;
                    }
                    else
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, caption, buttons);
                        if (result == DialogResult.Yes)
                        {
                            exit = true;
                        }
                    }
                }
            }

            if (exit == true)
                this.Close();
        }

        private void FindFile()
        {
            DialogResult result = EXEFileDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
                file = EXEFileDialog.FileName;
        }

        private void EXEButton_Click(object sender, EventArgs e)
        {
            FindFile();
            EXEFilePathBox.Text = file;
        }

        private void BattleNetBrowseButton_Click(object sender, EventArgs e)
        {
            FindFile();
            BattleNETFilePathBox.Text = file;
        }

        private void HiganEmulatorBrowse_Click(object sender, EventArgs e)
        {
            FindFile();
            HiganEmulatorBox.Text = file;
        }

        private void HiganROMBrowse_Click(object sender, EventArgs e)
        {
            FindFile();
            HiganROMBox.Text = file;
        }

        private void N64EmulatorBrowsse_Click(object sender, EventArgs e)
        {
            FindFile();
            N64EmulatorBox.Text = file;
        }

        private void N64ROMBrowse_Click(object sender, EventArgs e)
        {
            FindFile();
            N64ROMBox.Text = file;
        }

        private void PS1EmulatorButton_Click(object sender, EventArgs e)
        {
            FindFile();
            PS1EmulatorBox.Text = file;
        }

        private void PS1ROMButton_Click(object sender, EventArgs e)
        {
            FindFile();
            PS1ROMBox.Text = file;
        }

        private void DSEmulatorButton_Click(object sender, EventArgs e)
        {
            FindFile();
            DSEmulatorBox.Text = file;
        }

        private void DSROMButton_Click(object sender, EventArgs e)
        {
            FindFile();
            DSROMBox.Text = file;
        }

        private void DolphinEmulatorButton_Click(object sender, EventArgs e)
        {
            FindFile();
            DolphinEmulatorBox.Text = file;
        }

        private void DolphinROMButton_Click(object sender, EventArgs e)
        {
            FindFile();
            DolphinROMBox.Text = file;
        }

        private void PS2EmulatorButton_Click(object sender, EventArgs e)
        {
            FindFile();
            PS2EmulatorBox.Text = file;
        }

        private void PS2ROMButton_Click(object sender, EventArgs e)
        {
            FindFile();
            PS2ROMBox.Text = file;
        }

        private void PSPEmulatorButton_Click(object sender, EventArgs e)
        {
            FindFile();
            PSPEmulatorBox.Text = file;
        }

        private void PSPROMButton_Click(object sender, EventArgs e)
        {
            FindFile();
            PSPROMBox.Text = file;
        }

        private void CEMUEmulatorButton_Click(object sender, EventArgs e)
        {
            FindFile();
            CEMUEmulatorBox.Text = file;
        }

        private void CEMUROMButton_Click(object sender, EventArgs e)
        {
            FindFile();
            CEMUROMBox.Text = file;
        }
    }
}
