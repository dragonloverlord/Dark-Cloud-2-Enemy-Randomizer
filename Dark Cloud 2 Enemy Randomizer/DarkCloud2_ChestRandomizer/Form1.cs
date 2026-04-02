using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace DarkCloud2_EnemyRandomizer
{
    public partial class Form1 : Form
    {
        static bool differentEnemiesChoice = true;
        static bool differentSoundChoice = true;
        static bool differentHPChoice = false;
        static bool differentABSChoice = false;
        static bool differentGildaChoice = false;
        static bool differentRageChoice = true;
        static bool differentAttackChoice = false;
        static bool differentDefenseChoice = false;
        static bool differentWeaknessesChoice = true;
        static bool differentEffectivenessChoice = true;
        static bool differentItemsChoice = true;
        static bool randomNameChoice = false;
        static bool randomSoundChoice = false;
        static bool randomHPChoice = false;
        static bool randomABSChoice = false;
        static bool randomGildaChoice = false;
        static bool randomRageChoice = false;
        static bool randomAttackChoice = false;
        static bool randomDefenseChoice = false;
        static bool randomWeaknessesChoice = false;
        static bool randomEffectivenessChoice = false;
        static bool randomItemsChoice = false;

        public bool gameCheck = false;
        public static bool versionCheck;
        public Form1()
        {
            InitializeComponent();
            if (Memory.PID != 0)
            {
                label2.Text = "This mod randomizes enemies in Dark Cloud 2. You must be using PCSX2 and have Dark Cloud 2 (USA).";

                if (Memory.ReadInt(Program.BaseAddress + 0x003694D0) == 1701667175)
                {
                    gameCheck = false;
                    Randomizer.gameVersion = 1;
                    button1.Enabled = false;
                    label3.Text = "Detected Dark Chronicle (PAL version)! However, this mod only works with the USA version. Sorry.";
                }
                else if (Memory.ReadInt(Program.BaseAddress + 0x00364BD0) == 1701667175)
                {
                    gameCheck = true;
                    Randomizer.gameVersion = 2;
                    label3.Text = "Detected Dark Cloud 2 (USA version)! Press begin to start randomizing enemies.";
                }
                else
                {
                    button1.Enabled = false;
                    label3.Text = "Cannot find active Dark Cloud 2 game, please launch Dark Cloud 2 and restart this mod.";
                }
            }
            else
            {
                label3.Enabled = false;
                button1.Enabled = false;               
            }
        }

        public static Thread enemyThread = new Thread(() => Randomizer.EnemyRandomizer(Form1.differentEnemiesChoice, Form1.differentSoundChoice, Form1.differentHPChoice, 
            Form1.differentDefenseChoice, Form1.differentAttackChoice, Form1.differentABSChoice, Form1.differentGildaChoice, Form1.differentRageChoice, Form1.differentWeaknessesChoice,
            Form1.differentEffectivenessChoice, Form1.differentItemsChoice, Form1.randomNameChoice, Form1.randomSoundChoice, Form1.randomHPChoice, Form1.randomABSChoice, Form1.randomGildaChoice, Form1.randomRageChoice,
            Form1.randomAttackChoice, Form1.randomDefenseChoice, Form1.randomWeaknessesChoice, Form1.randomEffectivenessChoice, Form1.randomItemsChoice));

        private void button1_Click(object sender, EventArgs e)
        {
            // if every choice is false, reject begin
            if(differentEnemiesChoice == false && differentSoundChoice == false && differentHPChoice == false && differentDefenseChoice == false && differentAttackChoice == false && differentABSChoice == false
                && differentGildaChoice == false && differentRageChoice == false && differentWeaknessesChoice == false && differentEffectivenessChoice == false && differentItemsChoice == false)
            {
                MessageBox.Show("If you're going to disable all randomization, why are you running this mod?", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                label3.Text = "Randomizing enemies! Do not use save states, as they can break the mod. If or when you exit the game, this program closes automatically.";
                label3.Font = new Font(label3.Font, FontStyle.Bold);
                Console.WriteLine("Different sound: " + differentSoundChoice);
                Console.WriteLine("Random sound: " + randomSoundChoice);
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                checkBox9.Enabled = false;
                checkBox10.Enabled = false;
                checkBox11.Enabled = false;
                checkBox13.Enabled = false;
                checkBox14.Enabled = false;
                checkBox15.Enabled = false;
                checkBox16.Enabled = false;
                checkBox17.Enabled = false;
                checkBox18.Enabled = false;
                checkBox19.Enabled = false;
                checkBox20.Enabled = false;
                checkBox21.Enabled = false;
                checkBox22.Enabled = false;
                checkBox23.Enabled = false;
                if (!enemyThread.IsAlive) //If we are not already running
                    enemyThread.Start(); //Start thread
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            differentEnemiesChoice = !differentEnemiesChoice;
            if (differentEnemiesChoice)
            {
                checkBox13.Enabled = true;
            }
            else
            {
                checkBox13.Enabled = false;
            }
            if (checkBox13.Checked)
            {
                randomNameChoice = false;
                checkBox13.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            differentSoundChoice = !differentSoundChoice;
            if (differentSoundChoice)
            {
                checkBox14.Enabled = true;
            }
            else
            {
                checkBox14.Enabled = false;
            }
            if (checkBox14.Checked)
            {
                randomSoundChoice = false;
                checkBox14.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            differentHPChoice = !differentHPChoice;
            if (differentHPChoice)
            {
                checkBox15.Enabled = true;
            }
            else
            {
                checkBox15.Enabled = false;
            }
            if (checkBox15.Checked)
            {
                randomHPChoice = false;
                checkBox15.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            differentABSChoice = !differentABSChoice;
            if (differentABSChoice)
            {
                checkBox16.Enabled = true;
            }
            else
            {
                checkBox16.Enabled = false;
            }
            if (checkBox16.Checked)
            {
                randomABSChoice = false;
                checkBox16.Checked = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            differentGildaChoice = !differentGildaChoice;
            if (differentGildaChoice)
            {
                checkBox18.Enabled = true;
            }
            else
            {
                checkBox18.Enabled = false;
            }
            if (checkBox18.Checked)
            {
                randomGildaChoice = false;
                checkBox18.Checked = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            differentRageChoice = !differentRageChoice;
            if (differentRageChoice)
            {
                checkBox17.Enabled = true;
            }
            else
            {
                checkBox17.Enabled = false;
            }
            if (checkBox17.Checked)
            {
                randomRageChoice = false;
                checkBox17.Checked = false;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            differentAttackChoice = !differentAttackChoice;
            if (differentAttackChoice)
            {
                checkBox20.Enabled = true;
            }
            else
            {
                checkBox20.Enabled = false;
            }
            if (checkBox20.Checked)
            {
                randomAttackChoice = false;
                checkBox20.Checked = false;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            differentDefenseChoice = !differentDefenseChoice;
            if (differentDefenseChoice)
            {
                checkBox19.Enabled = true;
            }
            else
            {
                checkBox19.Enabled = false;
            }
            if (checkBox19.Checked)
            {
                randomDefenseChoice = false;
                checkBox19.Checked = false;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            differentWeaknessesChoice = !differentWeaknessesChoice;
            if (differentWeaknessesChoice)
            {
                checkBox22.Enabled = true;
            }
            else
            {
                checkBox22.Enabled = false;
            }
            if (checkBox22.Checked)
            {
                randomWeaknessesChoice = false;
                checkBox22.Checked = false;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            differentEffectivenessChoice = !differentEffectivenessChoice;
            if (differentEffectivenessChoice)
            {
                checkBox21.Enabled = true;
            }
            else
            {
                checkBox21.Enabled = false;
            }
            if (checkBox21.Checked)
            {
                randomEffectivenessChoice = false;
                checkBox21.Checked = false;
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            differentItemsChoice = !differentItemsChoice;
            if (differentItemsChoice)
            {
                checkBox23.Enabled = true;
            }
            else
            {
                checkBox23.Enabled = false;
            }
            if (checkBox23.Checked)
            {
                randomItemsChoice = false;
                checkBox23.Checked = false;
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            randomNameChoice = !randomNameChoice;
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            randomSoundChoice = !randomSoundChoice;
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            randomHPChoice = !randomHPChoice;
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            randomABSChoice = !randomABSChoice;
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            randomGildaChoice = !randomGildaChoice;
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            randomRageChoice = !randomRageChoice;
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            randomAttackChoice = !randomAttackChoice;
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            randomDefenseChoice = !randomDefenseChoice;
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            randomWeaknessesChoice = !randomWeaknessesChoice;
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            randomEffectivenessChoice = !randomEffectivenessChoice;
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            randomItemsChoice = !randomItemsChoice;
        }

        private void setValues(bool value)
        {
            Form1.differentEnemiesChoice = value;
            differentSoundChoice = value;
            differentHPChoice = value;
            differentABSChoice = value;
            differentGildaChoice = value;
            differentRageChoice = value;
            differentAttackChoice = value;
            differentDefenseChoice = value;
            differentWeaknessesChoice = value;
            differentEffectivenessChoice = value;
            differentItemsChoice = value;
            randomNameChoice = value;
            randomSoundChoice = value;
            randomHPChoice = value;
            randomABSChoice = value;
            randomGildaChoice = value;
            randomRageChoice = value;
            randomAttackChoice = value;
            randomDefenseChoice = value;
            randomWeaknessesChoice = value;
            randomEffectivenessChoice = value;
            randomItemsChoice = value;
        }
        private void setCheckboxes(bool value)
        {
            checkBox1.Checked = value;
            checkBox2.Checked = value;
            checkBox3.Checked = value;
            checkBox4.Checked = value;
            checkBox5.Checked = value;
            checkBox6.Checked = value;
            checkBox7.Checked = value;
            checkBox8.Checked = value;
            checkBox9.Checked = value;
            checkBox11.Checked = value;
            checkBox10.Checked = value;
            checkBox13.Checked = value;
            checkBox13.Enabled = value;
            checkBox14.Checked = value;
            checkBox14.Enabled = value;
            checkBox15.Checked = value;
            checkBox15.Enabled = value;
            checkBox16.Checked = value;
            checkBox16.Enabled = value;
            checkBox17.Checked = value;
            checkBox17.Enabled = value;
            checkBox18.Checked = value;
            checkBox18.Enabled = value;
            checkBox19.Checked = value;
            checkBox19.Enabled = value;
            checkBox20.Checked = value;
            checkBox20.Enabled = value;
            checkBox21.Checked = value;
            checkBox21.Enabled = value;
            checkBox22.Checked = value;
            checkBox22.Enabled = value;
            checkBox23.Checked = value;
            checkBox23.Enabled = value;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            setCheckboxes(true); 
            setValues(true);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setCheckboxes(false);
            setValues(false);
        }
    }
}
