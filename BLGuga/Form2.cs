using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace BLGuga
{
    public partial class Form2 : Form
    {
        private int rarity, weaponType, company, ability;
        private Label lbl4;

        public Form2(int rarity, int weaponType, int company, int ability, Label lbl4)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.rarity = rarity;
            this.weaponType = weaponType;
            this.company = company;
            this.ability = ability;
            this.lblSpecial.Text = "";
            this.lbl4 = lbl4;
            this.lblDmg.Text = this.lblAcc.Text = this.lblMag.Text = "";
            this.lblReload.Text = "Range: ";
            this.lblRof.Text = "1 action";
            this.lblCrit.Text = "Crit: +50% damage";

            UpdateComponents();
        }

        private void UpdateComponents()
        {
            SetRarity();
            SetWeaponIcon();
            SetAbility();
        }

        private void SetRarity()
        {
            if (this.rarity <= 10)
            {
                this.lblRarity.Text = "LEGENDARY";
                this.lblRarity.ForeColor = Color.Gold;
            }
            else if (rarity >= 11 && rarity <= 23)
            {
                this.lblRarity.Text = "EPIC";
                this.lblRarity.ForeColor = Color.MediumOrchid;
            }
            else if (rarity >= 24 && rarity <= 40)
            {
                this.lblRarity.Text = "RARE";
                this.lblRarity.ForeColor = Color.DeepSkyBlue;
            }
            else if (rarity >= 41 && rarity <= 65)
            {
                this.lblRarity.Text = "UNCOMMON";
                this.lblRarity.ForeColor = Color.LimeGreen;
            }
            else if (rarity >= 66 && rarity <= 100)
            {
                this.lblRarity.Text = "COMMON";
                this.lblRarity.ForeColor = Color.White;
            }
        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void SetWeaponIcon()
        {
            switch (this.weaponType)
            {
                case 1:
                    this.iconPistol.Show();
                    break;
                case 2:
                    this.iconShotgun.Show();
                    break;
                case 3:
                    this.iconRifle.Show();
                    break;
                case 4:
                    this.iconSmg.Show();
                    break;
                case 5:
                    this.iconSniper.Show();
                    break;
                case 6:
                    this.iconRpg.Show();
                    break;
            }

            DisplayWeaponStats();
            this.lblSpecial.Show();
            switch (this.company)
            {
                case 1:
                    this.iconJakobs.Show();
                    this.lblSpecial.Text += "Jakobs | +10%crit+d6 -1to crit\n";
                    return;
                case 2:
                    this.iconHyperion.Show();
                    this.lblSpecial.Text += "Hyperion | Every shot +d4-1 acc\n";
                    return;
                case 3:
                    this.iconVladof.Show();
                    this.lblSpecial.Text += "Vladof | every shot 1in6 chance no ammo consumption\n";
                    return;
                case 4:
                    this.iconMaliwan.Show();
                    this.lblSpecial.Text += "Maliwan | +2 to Element\n";
                    int element = new Random().Next(1, 5);
                    lbl4.Text = element.ToString();
                    lbl4.Show();
                    switch (element)
                    {
                        case 1:
                            this.iconShock.Show();
                            this.lblSpecial.Text += "Shock | +7 damage to any shielded enemy vs flesh and armor 0\n";
                            break;
                        case 2:
                            this.iconCorrosive.Show();
                            this.lblSpecial.Text += "Corrosive | +6 damage to any unshielded enemy who primarily armor (robots, vehicles, stone golems, etc.) vs shild -0\n";
                            break;
                        case 3:
                            this.iconFire.Show();
                            this.lblSpecial.Text += "Fire | +6 damage to any unshielded enemy who's primarily animal or vegetable (e.g., anything living). vs shild 0\n";
                            break;
                        case 4:
                            this.iconSlag.Show();
                            this.lblSpecial.Text += "Slag | gives advantage for 5 turn\n";
                            break;
                    }
                    return;
                case 5:
                    this.iconDahl.Show();
                    this.lblSpecial.Text += "Dahl | 3 amm consumption, fixed damage\n";
                    switch (this.weaponType)
                    {
                        case 1:
                            if (rarity <= 10) this.lblDmg.Text = "0";
                            else if (rarity >= 11 && rarity <= 23) this.lblDmg.Text = "16";
                            else if (rarity >= 24 && rarity <= 40) this.lblDmg.Text = "15";
                            else if (rarity >= 41 && rarity <= 65) this.lblDmg.Text = "14";
                            else if (rarity >= 66 && rarity <= 100) this.lblDmg.Text = "12";
                            break;
                        case 2:
                            if (rarity <= 10) this.lblDmg.Text = "0";
                            else if (rarity >= 11 && rarity <= 23) this.lblDmg.Text = "19";
                            else if (rarity >= 24 && rarity <= 40) this.lblDmg.Text = "18";
                            else if (rarity >= 41 && rarity <= 65) this.lblDmg.Text = "17";
                            else if (rarity >= 66 && rarity <= 100) this.lblDmg.Text = "15";
                            break;
                        case 3:
                            if (rarity <= 10) this.lblDmg.Text = "0";
                            else if (rarity >= 11 && rarity <= 23) this.lblDmg.Text = "18";
                            else if (rarity >= 24 && rarity <= 40) this.lblDmg.Text = "17";
                            else if (rarity >= 41 && rarity <= 65) this.lblDmg.Text = "16";
                            else if (rarity >= 66 && rarity <= 100) this.lblDmg.Text = "14";
                            break;
                        case 4:
                            if (rarity <= 10) this.lblDmg.Text = "0";
                            else if (rarity >= 11 && rarity <= 23) this.lblDmg.Text = "14";
                            else if (rarity >= 24 && rarity <= 40) this.lblDmg.Text = "13";
                            else if (rarity >= 41 && rarity <= 65) this.lblDmg.Text = "12";
                            else if (rarity >= 66 && rarity <= 100) this.lblDmg.Text = "10";
                            break;
                        case 5:
                            if (rarity <= 10) this.lblDmg.Text = "0";
                            else if (rarity >= 11 && rarity <= 23) this.lblDmg.Text = "22";
                            else if (rarity >= 24 && rarity <= 40) this.lblDmg.Text = "21";
                            else if (rarity >= 41 && rarity <= 65) this.lblDmg.Text = "20";
                            else if (rarity >= 66 && rarity <= 100) this.lblDmg.Text = "18";
                            break;
                        case 6:
                            if (rarity <= 10) this.lblDmg.Text = "0";
                            else if (rarity >= 11 && rarity <= 23) this.lblDmg.Text = "30";
                            else if (rarity >= 24 && rarity <= 40) this.lblDmg.Text = "29";
                            else if (rarity >= 41 && rarity <= 65) this.lblDmg.Text = "28";
                            else if (rarity >= 66 && rarity <= 100) this.lblDmg.Text = "26";
                            break;
                    }
                    return;
                case 6:
                    this.iconTediore.Show();
                    this.lblSpecial.Text += "Tediore | Weapon Reload: Ammo left + Explosive Multiplier\n";
                    return;
                case 7:
                    this.iconTorgue.Show();
                    this.iconExplosive.Show();
                    this.lblSpecial.Text += "Explosive | +3 damage vs flesh and shild -3 vs armor\n";
                    this.lblSpecial.Text += "Torgue | 1.5/3/4.5 exp range\n";
                    this.lblCrit.Text = "No Crit";
                    return;
                case 8:
                    this.iconBandit.Show();
                    this.lblSpecial.Text += "Bandit | +25% Mags\n";
                    int mag = int.Parse(this.lblMag.Text);
                    mag += (int) ((mag / 100.0) * 25);
                    mag += 1;
                    this.lblMag.Text = mag.ToString();
                    return;
            }
        }
        
        private void DisplayWeaponStats()
        {
            switch (this.weaponType)
            {
                case 1:
                    this.lblDmg.Text = "d6";
                    this.lblAcc.Text = "d20+1";
                    this.lblReload.Text += "25.5";

                    if (rarity <= 10) this.lblMag.Text = "0";
                    else if (rarity >= 11 && rarity <= 23) this.lblMag.Text = "12";
                    else if (rarity >= 24 && rarity <= 40) this.lblMag.Text = "10";
                    else if (rarity >= 41 && rarity <= 65) this.lblMag.Text = "8";
                    else if (rarity >= 66 && rarity <= 100) this.lblMag.Text = "6";

                    break;
                case 2:
                    this.lblDmg.Text = "d10";
                    this.lblAcc.Text = "d20+3/0/-3";
                    this.lblReload.Text += "3/6/10.5";

                    if (rarity <= 10) this.lblMag.Text = "0";
                    else if (rarity >= 11 && rarity <= 23) this.lblMag.Text = "8";
                    else if (rarity >= 24 && rarity <= 40) this.lblMag.Text = "6";
                    else if (rarity >= 41 && rarity <= 65) this.lblMag.Text = "4";
                    else if (rarity >= 66 && rarity <= 100) this.lblMag.Text = "2";

                    break;
                case 3:
                    this.lblDmg.Text = "d8";
                    this.lblAcc.Text = "d20+2";
                    this.lblReload.Text += "30";

                    if (rarity <= 10) this.lblMag.Text = "0";
                    else if (rarity >= 11 && rarity <= 23) this.lblMag.Text = "60";
                    else if (rarity >= 24 && rarity <= 40) this.lblMag.Text = "50";
                    else if (rarity >= 41 && rarity <= 65) this.lblMag.Text = "35";
                    else if (rarity >= 66 && rarity <= 100) this.lblMag.Text = "25";

                    break;
                case 4:
                    this.lblDmg.Text = "d4x2";
                    this.lblAcc.Text = "d20-1";
                    this.lblReload.Text += "6/10.5/16.5";

                    if (rarity <= 10) this.lblMag.Text = "0";
                    else if (rarity >= 11 && rarity <= 23) this.lblMag.Text = "36";
                    else if (rarity >= 24 && rarity <= 40) this.lblMag.Text = "30";
                    else if (rarity >= 41 && rarity <= 65) this.lblMag.Text = "24";
                    else if (rarity >= 66 && rarity <= 100) this.lblMag.Text = "20";

                    break;
                case 5:
                    this.lblDmg.Text = "d12";
                    this.lblAcc.Text = "d20-4/+4";
                    this.lblReload.Text += "10.5/45";

                    if (rarity <= 10) this.lblMag.Text = "0";
                    else if (rarity >= 11 && rarity <= 23) this.lblMag.Text = "9";
                    else if (rarity >= 24 && rarity <= 40) this.lblMag.Text = "7";
                    else if (rarity >= 41 && rarity <= 65) this.lblMag.Text = "5";
                    else if (rarity >= 66 && rarity <= 100) this.lblMag.Text = "3";

                    break;
                case 6:
                    this.lblDmg.Text = "d20";
                    this.lblAcc.Text = "d20";
                    this.lblReload.Text += "25.5 | Exp. Rng.: 1/3/4";
                    this.lblCrit.Text = "No Crit";

                    if (rarity <= 10) this.lblMag.Text = "0";
                    else if (rarity >= 11 && rarity <= 23) this.lblMag.Text = "6";
                    else if (rarity >= 24 && rarity <= 40) this.lblMag.Text = "5";
                    else if (rarity >= 41 && rarity <= 65) this.lblMag.Text = "3";
                    else if (rarity >= 66 && rarity <= 100) this.lblMag.Text = "2";

                    break;
            }

            if (rarity >= 11 && rarity <= 23) this.lblDmg.Text = "3" + this.lblDmg.Text;
            else if (rarity >= 24 && rarity <= 40) this.lblDmg.Text = "2" + this.lblDmg.Text;
            else if (rarity >= 41 && rarity <= 65) this.lblDmg.Text = "1" + this.lblDmg.Text + "+4";
            else if (rarity >= 66 && rarity <= 100) this.lblDmg.Text = "1" + this.lblDmg.Text;

            this.lblDmg.Show();
        }
        
        private void SetAbility()
        {
            switch (this.ability)
            {
                case 1:
                    return;
                case 2:
                    this.lblSpecial.Text += "+1d6 c.a.c while wielding this weapon\n";
                    return;
                case 3:
                    if (this.company == 3)
                    {
                        this.lblSpecial.Text = "Vladof + Greed ability | 2 in 6 chance not to use ammo shot\n";
                        return;
                    }
                    this.lblSpecial.Text += "1 in 6 chance to not use ammo\n";
                    return;
                case 4:
                    this.lblSpecial.Text += "+1 Accuracy\n";
                    this.lblAcc.Text += " (calculate +1)";
                    return;
                case 5:
                    this.lblSpecial.Text += "Double Penetrating: +1 damage dice, +1 ammo consumption\n";
                    this.lblDmg.Text = "1d+" + this.lblDmg.Text;
                    return;
                case 6:
                    if (this.company == 4 || this.company == 1 || this.company == 7)
                    {
                        this.lblSpecial.Text += "Halves target movement speed on hit\n";
                        return;
                    }
                    this.lblSpecial.Text += "Adds shock element: +5 damage to any shielded enemy vs flesh and armor -2\n";
                    this.iconShock.Show();
                    return;
                case 7:
                    if (this.company == 4 || this.company == 1 || this.company == 7)
                    {
                        this.lblSpecial.Text += "Deals 1 extra damage every turn\n";
                        return;
                    }
                    this.lblSpecial.Text += "Adds corrosive element: +4 damage to any unshielded enemy who primarily armor (robots, vehicles, stone golems, etc.) vs shild -2\n";
                    this.iconCorrosive.Show();
                    return;
                case 8:
                    if (this.company == 4 || this.company == 1 || this.company == 7)
                    {
                        this.lblSpecial.Text += "Every time you hit someone, get money based on damage done (post calculations)\n";
                        return;
                    }
                    this.lblSpecial.Text += "Adds fire element: +4 damage to any unshielded enemy who's primarily animal or vegetable (e.g., anything living). vs shild -2\n";
                    this.iconFire.Show();
                    return;
                case 9:
                    if (this.company == 4 || this.company == 1 || this.company == 7)
                    {
                        this.lblSpecial.Text += "You can reroll the damage dice\n";
                        return;
                    }
                    this.lblSpecial.Text += "Adds slag element: Gives advantage for 3 turns\n";
                    this.iconSlag.Show();
                    return;
                case 10:
                    this.lblSpecial.Text += "+10% Damage\n";
                    this.lblDmg.Text += " +10%";
                    return;
                case 11:
                    this.lblSpecial.Text += "+20% Mag Size\n";
                    int mag = int.Parse(this.lblMag.Text);
                    mag += (int) ((mag / 100.0) * 20);
                    mag += 1;
                    this.lblMag.Text = mag.ToString();
                    return;
                case 12:
                    this.lblSpecial.Text += "+10% +1d6 crit damage\n";
                    return;
            }
        }
    }
}
