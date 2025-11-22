using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BLGuga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ControlBox = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.lbl12.Hide();
            this.lbl100.Hide();
            this.lbl10.Hide();
            this.lbl20.Hide();
            this.lbl4.Hide();
            this.lbl6.Hide();
            this.lbl8.Hide();
        }


        private int[] RollDice(int rarityModifier)
        {
            Random rnd = new Random();
            int rarity = rnd.Next(1, 101) + rarityModifier;
            int equipment = rnd.Next(1, 11);
            int company = rnd.Next(1, 9);
            int ability = rnd.Next(1, 13);

            this.lbl100.Text = rarity.ToString();
            this.lbl10.Text = equipment.ToString();
            this.lbl8.Text = company.ToString();
            this.lbl12.Text = ability.ToString();

            return new int[] { rarity, equipment, company, ability };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lbl12.Hide();
            this.lbl100.Hide();
            this.lbl10.Hide();
            this.lbl20.Hide();
            this.lbl4.Hide();
            this.lbl6.Hide();
            this.lbl8.Hide();

            int[] rolls = RollDice((int) this.inputRarMod.Value);
            switch (this.inputRollMod.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    rolls[1] = new Random().Next(1, 7);
                    this.lbl10.Text = rolls[1].ToString();
                    break;
                case 2:
                    rolls[1] = 7;
                    this.lbl10.Text = rolls[1].ToString();
                    break;
                case 3:
                    rolls[1] = 10;
                    this.lbl10.Text = rolls[1].ToString();
                    break;
                case 4:
                    rolls[1] = 8;
                    this.lbl10.Text = rolls[1].ToString();
                    break;
                case 5:
                    if (rolls[1] == 9) rolls[1] = 10;
                    this.lbl10.Text = rolls[1].ToString();
                    break;
            }
            this.lbl100.Show();
            if (rolls[0] > 100)
            {
                MessageBox.Show("Nessun Drop.", this.Text);
                return;
            }

            this.lbl10.Show();
            switch (rolls[1])
            {
                case 10:
                    GenerateRelic(rolls[0]);
                    return;
                case 9:
                    MessageBox.Show("2x MONEY!", this.Text);
                    return;
                case 8:
                    GenerateShield(rolls[0], rolls[2]);
                    return;
                case 7:
                    GenerateGrenade(rolls[0] , rolls[2]);
                    return;
                default:
                    this.lbl12.Show();
                    this.lbl8.Show();
                    GenerateWeapon(rolls[0], rolls[1], rolls[2], rolls[3]);
                    return;
            }
        }

        private void GenerateRelic(int rarity)
        {
            string relicType = "";
            if (rarity <= 10) relicType = "LEGENDARY ";
            else if (rarity >= 11 && rarity <= 23) relicType = "EPIC ";
            else if (rarity >= 24 && rarity <= 40) relicType = "RARE ";
            else if (rarity >= 41 && rarity <= 65) relicType = "UNCOMMON ";
            else if (rarity >= 66 && rarity <= 100) relicType = "COMMON ";

            int relic = new Random().Next(1, 21);
            switch (relic)
            {
                case 1:
                    relicType += "Shield turn charge";
                    break;
                case 2:
                    relicType += "Ammo supply";
                    break;
                case 3:
                    relicType += "C.A.C";
                    break;
                case 4:
                    relicType += "Elemental";
                    break;
                case 5:
                    relicType += "Non Elemental";
                    break;
                case 6:
                    relicType += "Explosive";
                    break;
                case 7:
                    relicType += "Max HP";
                    break;
                case 8:
                    relicType += "Fight For Your Life";
                    break;
                case 9:
                    relicType += "Armor Class";
                    break;
                case 10:
                    relicType += "Luck";
                    break;
                case 11:
                    relicType += "Action Skill";
                    break;
                case 12:
                    relicType += "Leech";
                    break;
                case 13:
                    relicType += "Weapon Affinity";
                    break;
                case 14:
                    relicType += "Company Loyalty";
                    break;
                case 15:
                    relicType += "Critical";
                    break;
                case 16:
                    relicType += "Range";
                    break;
                case 17:
                    relicType += "Magazine";
                    break;
                case 18:
                    relicType += "Crit %";
                    break;
                case 19:
                    relicType += "Weapon Accuracy";
                    break;
                case 20:
                    relicType += "Gold Fever";
                    break;
            }

            this.lbl20.Text = relic.ToString();
            this.lbl20.Show();
            relicType += " Relic (" + relic.ToString() + ")";
            MessageBox.Show(relicType, this.Text);
        }

        private void GenerateShield(int rarity, int company)
        {
            string shieldType = "";
            if (rarity <= 10) shieldType = "LEGENDARY ";
            else if (rarity >= 11 && rarity <= 23) shieldType = "EPIC ";
            else if (rarity >= 24 && rarity <= 40) shieldType = "RARE ";
            else if (rarity >= 41 && rarity <= 65) shieldType = "UNCOMMON ";
            else if (rarity >= 66 && rarity <= 100) shieldType = "COMMON ";

            switch (company)
            {
                case 1:
                    shieldType += "Jakobs";
                    break;
                case 2:
                    shieldType += "Hyerion";
                    break;
                case 3:
                    shieldType += "Vladof";
                    break;
                case 4:
                    shieldType += "Maliwan";
                    break;
                case 5:
                    shieldType += "Dahl";
                    break;
                case 6:
                    shieldType += "Tediore";
                    break;
                case 7:
                    shieldType += "Torgue";
                    break;
                case 8:
                    shieldType += "Bandit";
                    break;
            }

            this.lbl8.Show();
            shieldType += " Shield";
            Form3 frmShield = new Form3(rarity, company);
            frmShield.ShowDialog();
            frmShield.Dispose();
        }

        private void GenerateGrenade(int rarity, int company)
        {
            string grenadeType = "";
            if (rarity <= 10) grenadeType = "LEGENDARY ";
            else if (rarity >= 11 && rarity <= 23) grenadeType = "EPIC ";
            else if (rarity >= 24 && rarity <= 40) grenadeType = "RARE ";
            else if (rarity >= 41 && rarity <= 65) grenadeType = "UNCOMMON ";
            else if (rarity >= 66 && rarity <= 100) grenadeType = "COMMON ";

            switch (company)
            {
                case 1:
                    grenadeType += "Jakobs";
                    break;
                case 2:
                    grenadeType += "Hyerion";
                    break;
                case 3:
                    grenadeType += "Vladof";
                    break;
                case 4:
                    grenadeType += "Maliwan";
                    break;
                case 5:
                    grenadeType += "Dahl";
                    break;
                case 6:
                    grenadeType += "Tediore";
                    break;
                case 7:
                    grenadeType += "Torgue";
                    break;
                case 8:
                    grenadeType += "Bandit";
                    break;
            }

            this.lbl8.Show();
            grenadeType += " Grenade";
            MessageBox.Show(grenadeType, this.Text);
        }

        private void GenerateWeapon(int rarity, int weaponType, int company, int ability)
        {
            Form2 frmWeapon = new Form2(rarity, weaponType, company, ability, this.lbl4);
            frmWeapon.ShowDialog();
            frmWeapon.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inputRollMod.SelectedIndex = 0;
        }

        private void btnZaino_Click(object sender, EventArgs e)
        {
            const string FILEPATH = "C:\\ProgramData\\zaino.csv";

            try
            {
                string csv = File.ReadAllText(FILEPATH);
                Form4 frmZaino = new Form4(csv);
                frmZaino.ShowDialog();
                frmZaino.Dispose();
            } catch (Exception)
            {
                MessageBox.Show("Non hai nessun elemento nello zaino.", "Borderlands Loot Generator");
            }
        }

        private void btnZainoDebug_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter s = File.CreateText("C:\\ProgramData\\zaino.csv");
                s.WriteLine("mamaguevo");
                s.Close();
                s.Dispose();
            } catch (Exception)
            {
                MessageBox.Show("impossibile creare file");
            }
        }
    }
}
