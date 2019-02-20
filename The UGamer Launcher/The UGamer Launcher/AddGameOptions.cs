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
            {
                finalReturn = "steam://rungameid/" + SteamCodeBox.Text;
            }
            else if (Tabs.SelectedTab == EXETab)
            {
                finalReturn = EXEFilePathBox.Text;
            }
            else if (Tabs.SelectedTab == BattleNETTab)
            {
                finalReturn = BattleNETFilePathBox.Text;
                if (BattleNetGameComboBox.Text == "Call of Duty: Black Ops 4")
                {
                    finalReturn += "";
                }
                else if (BattleNetGameComboBox.Text == "Destiny 2")
                {

                }
                else if (BattleNetGameComboBox.Text == "Diablo 3")
                {

                }
                else if (BattleNetGameComboBox.Text == "Hearthstone")
                {

                }
                else if (BattleNetGameComboBox.Text == "Heroes of the Storm")
                {

                }
                else if (BattleNetGameComboBox.Text == "Overwatch")
                {

                }
                else if (BattleNetGameComboBox.Text == "Starcraft Remastered")
                {

                }
                else if (BattleNetGameComboBox.Text == "Starcraft 2")
                {

                }
                else if (BattleNetGameComboBox.Text == "World of Warcraft")
                {

                }
                else if (BattleNetGameComboBox.Text == "")
                {

                }
            }
            else if (Tabs.SelectedTab == EmulationTab)
            {
                if (EmulatorTabs.SelectedTab == HiganTab)
                {

                }
                else if (EmulatorTabs.SelectedTab == N64Tab)
                {

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
