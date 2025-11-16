using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLGuga
{
    enum enCompagnie
    {
        Jakobs = 1,
        Hyperion,
        Vladof,
        Maliwan,
        Dahl,
        Tediore,
        Torgue,
        Bandit
    }

    public partial class Form3 : Form
    {
        private int m_nHP, m_nTTC, m_nRarita, m_nCompagnia;
        private string m_sAbilitaSpeciale;

        public Form3()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.ControlBox = true;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        public Form3(int rarity, int company)
        {
            InitializeComponent();
            this.m_nRarita = rarity;
            this.m_nCompagnia = company;
            this.m_sAbilitaSpeciale = "";
            this.KeyPreview = true;
            this.ControlBox = true;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void Form3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // check if ESC pressed, then close form
            if (e.KeyChar == (char) Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Show a Yes/No message box and ignore attempts to close it via the window close button (DialogResult.None)
            DialogResult result;
            result = MessageBox.Show(
                "Hai droppato uno scudo!\n" +
                    "Vuoi rollare il valore di hp?\n" +
                    "In caso contrario verrà preso il valore medio per ogni roll arrotondato per difetto",
                "To Roll or Not To Roll...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1
            );

            int nRoll1, nRoll2;
            switch (m_nRarita)
            {
                case int n when (n <= 10):
                    MessageBox.Show("LEGENDARY!", "ATTENZIONE");
                    nRoll1 = new Random().Next(1, 13);
                    System.Threading.Thread.Sleep(1000);
                    nRoll2 = new Random().Next(1, 13);
                    m_nHP = nRoll1 + nRoll2;
                    m_nHP += 6;
                    lblRarita.Text = "LEGENDARY";
                    lblRarita.ForeColor = Color.Red;
                    m_nTTC = 5;

                    switch ((enCompagnie)m_nCompagnia)
                    {
                        case enCompagnie.Jakobs:
                            int nRoll3, nRoll4;
                            lblNomeLeggendaria.Text = "FABLED TORTOISE";
                            m_nTTC = 12;
                            if (result == DialogResult.Yes)
                            {
                                nRoll3 = new Random().Next(1, 13);
                                System.Threading.Thread.Sleep(500);
                                nRoll4 = new Random().Next(1, 13);
                                m_nHP += nRoll3 + nRoll4 + 30;
                            }
                            else
                            {
                                m_nHP = 54;
                            }

                            m_sAbilitaSpeciale = "FABLED TORTOISE: Alti HP, Alto delay di ricarica\n" +
                                                    "Finchè lo scudo è attivo, la velocità di movimento è dimezzata\n" +
                                                    "Finchè lo scudo è scarico, la velocità di movimento è raddoppiata";
                            break;

                        case enCompagnie.Hyperion:
                            lblNomeLeggendaria.Text = "THE BEE";
                            if (result == DialogResult.No)
                            {
                                m_nHP = 18;
                            }

                            m_sAbilitaSpeciale = "THE BEE: Finchè lo scudo è COMPLETAMENTE carico, ogni attacco con arma da fuoco che fai, farà il DOPPIO del danno";
                            break;

                        case enCompagnie.Vladof:
                            lblNomeLeggendaria.Text = "THE SHAM";
                            if (result == DialogResult.No)
                            {
                                m_nHP = 18;
                            }

                            m_sAbilitaSpeciale = "THE SHAM: Finchè lo scudo è carico, quando subisci un attacco:\n" +
                                                    "Annuncia 1 numero di un d6 e procedi a tirare il dado\n" +
                                                    "Se NON esce quel numero, assorbi l'attacco";
                            break;

                        case enCompagnie.Maliwan:
                            lblNomeLeggendaria.Text = "BLACK HOLE";
                            if (result == DialogResult.No)
                            {
                                m_nHP = 18;
                            }

                            m_sAbilitaSpeciale = "BLACK HOLE: Quando lo scudo arriva a 0 HP dopo essere stato completamente caricato:\n" +
                                                    "Attira tutti i nemici nel raggio di 6m, poi esplode facendo 2d20 + explosive bonus danni";
                            break;

                        case enCompagnie.Dahl:
                            lblNomeLeggendaria.Text = "WISKY TANGO FOXTROT";
                            if (result == DialogResult.No)
                            {
                                m_nHP = 18;
                            }

                            m_sAbilitaSpeciale = "WiskyTangoFoxtrot: Finchè lo scudo è carico, quando vieni colpito:\n" +
                                                    "Annuncia 3 numeri di un d6 e procedi a tirare il dado\n" +
                                                    "Se esce uno di quei numeri droppi 3 shield booster che puoi usare su te stesso o darlo agli alleati\n" +
                                                    "Il booster riempe COMPLETAMENTE lo scudo\n" +
                                                    "ATTENZIONE: Se il booster non viene raccolto entro 1 turno, esplode per 10 danni 1.5/4.5/6 [full/half/quarter dmg]\n" +
                                                    "L'esplosione danneggia TUTTE le entità vicine, pure se stessi e alleati";
                            break;

                        case enCompagnie.Tediore:
                            lblNomeLeggendaria.Text = "THE NAUGHT";
                            m_nHP = 5;
                            m_nTTC = 0;
                            m_sAbilitaSpeciale = "THE NAUGHT: Scudo con pochissimi HP, ma si ricarica subito dopo aver finito `l'istanza` dell'attacco";
                            break;

                        case enCompagnie.Torgue:
                            lblNomeLeggendaria.Text = "THIRD PEC";
                            if (result == DialogResult.Yes)
                            {
                                nRoll1 = new Random().Next(1, 5);
                                nRoll2 = new Random().Next(1, 5);
                                m_nHP = nRoll1 + nRoll2 + 2;
                            }
                            else
                            {
                                m_nHP = 6;
                            }

                            m_sAbilitaSpeciale = "THIRD PEC: Finchè lo scudo è COMPLETAMENTE scarico:\n" +
                                                    "Aggiungi a TUTTI i tuoi danni +5, Ricevi 3 danni in meno";
                            break;

                        case enCompagnie.Bandit:
                            lblNomeLeggendaria.Text = "PUN-CHEE";
                            if (result == DialogResult.No)
                            {
                                m_nHP = 18;
                            }

                            m_sAbilitaSpeciale = "PUN-CHEE: Costante +7 danni c.a.c. e puoi fare danno critico con un 19 (solo c.a.c.)\n" +
                                                    "Quando lo scudo è COMPLETAMENTE scarico:\n" +
                                                    "Il tuo bonus danni c.a.c. aumenta a +15 c.a.c. dmg, puoi crittare con un 18 (o superiore, solo c.a.c.) e i tuoi attacchi c.a.c. ricevono un bonus di +2 di accuratezza (tiro per colpire)";
                            break;
                    }
                    break;

                case int n when (n >= 11 && n <= 23):
                    nRoll1 = new Random().Next(1, 13);
                    System.Threading.Thread.Sleep(1000);
                    nRoll2 = new Random().Next(1, 13);
                    m_nHP = nRoll1 + nRoll2;
                    m_nHP += 4;
                    lblRarita.Text = "EPIC";
                    lblRarita.ForeColor = Color.MediumOrchid;
                    m_nTTC = 5;
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show("Hai rollato: " + nRoll1 + " " + nRoll2 + ", Totale (2d12+6 EPIC): " + m_nHP);
                    }
                    else
                    {
                        m_nHP = 18;
                        MessageBox.Show("EPIC: 2d12 + 6. Totale: " + m_nHP);
                    }

                    switch ((enCompagnie)m_nCompagnia)
                    {
                        case enCompagnie.Jakobs:
                            m_nHP += 18;
                            m_nTTC += 4;
                            m_sAbilitaSpeciale = "Jakobs: +18 HP | +4 Turns To Charge";
                            break;

                        case enCompagnie.Hyperion:
                            m_sAbilitaSpeciale = "Hyperion: Quando lo scudo è COMPLETAMENTE carico\n" +
                                                    "Ogni tuo attacco da arma da fuoco fa 10 danni in più, ma danneggia lo scudo di 5 HP";
                            break;

                        case enCompagnie.Vladof:
                            m_sAbilitaSpeciale = "Vladof: Finchè lo scudo è attivo, quando vieni colpito: \n" +
                                                    "Annuncia un numero di un d6 e procedi a tirare il dado.\n" +
                                                    "Se esce il numero annunciato assorbi completamente l'attacco";
                            break;

                        case enCompagnie.Maliwan:
                            m_sAbilitaSpeciale = "Maliwan: Finchè lo scudo è attivo:\n" +
                                                    "+2 CA | -3 Danni ricevuti dagli elementi";
                            break;

                        case enCompagnie.Dahl:
                            m_sAbilitaSpeciale = "Dahl: Finchè lo scudo è attivo, quando vieni colpito: \n" +
                                                    "Annuncia un numero di un d6 e procedi a tirare il dado \n" +
                                                    "Se esce il numero annunciato droppi uno shield booster a terra. Puoi decidere se usarlo tu o darlo ad un compagno\n" +
                                                    "Lo shield booster ricarica COMPLETAMENTE lo scudo di chi lo usa\nIl booster rimane a terra per 1 turno";
                            break;

                        case enCompagnie.Tediore:
                            m_nHP += 6;
                            m_nTTC -= 3;
                            m_sAbilitaSpeciale = "Tediore: +6 HP | -3 Turns To Charge";
                            break;

                        case enCompagnie.Torgue:
                            m_sAbilitaSpeciale = "TORGUE: Quando lo scudo arriva a 0hp dopo essere stato completamente caricato:\n" +
                                                    "3d20 +exp bonus danni range 1.5/4.5/6 metri [full/half/quarter dmg]";
                            break;

                        case enCompagnie.Bandit:
                            m_nTTC += 3;
                            m_sAbilitaSpeciale = "Bandit: +3 Turns To Charge | Quando lo scudo è COMPLETAMENTE scarico:\n" +
                                                    "I tuoi colpi c.a.c. diventano più forti\n" +
                                                    "+10 danni ad ogni colpo c.a.c.";
                            break;
                    }
                    break;

                case int n when (n >= 24 && n <= 40):
                    nRoll1 = new Random().Next(1, 9);
                    System.Threading.Thread.Sleep(1000);
                    nRoll2 = new Random().Next(1, 9);
                    m_nHP = nRoll1 + nRoll2;
                    m_nHP += 3;
                    lblRarita.Text = "RARE";
                    lblRarita.ForeColor = Color.DeepSkyBlue;
                    m_nTTC = 6;
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show("Hai rollato: " + nRoll1 + " " + nRoll2 + ", Totale (2d8+4 RARE): " + m_nHP);
                    }
                    else
                    {
                        m_nHP = 12;
                        MessageBox.Show("RARE: 2d8 + 4. Totale: " + m_nHP);
                    }

                    switch ((enCompagnie)m_nCompagnia)
                    {
                        case enCompagnie.Jakobs:
                            m_nHP += 14;
                            m_nTTC += 3;
                            m_sAbilitaSpeciale = "Jakobs: +14 HP | +3 Turns To Charge";
                            break;

                        case enCompagnie.Hyperion:
                            m_sAbilitaSpeciale = "Hyperion: Quando lo scudo è COMPLETAMENTE carico\n" +
                                                    "Ogni tuo attacco da arma da fuoco fa 7 danni in più, ma danneggia lo scudo di 4 HP";
                            break;

                        case enCompagnie.Vladof:
                            m_sAbilitaSpeciale = "Vladof: Finchè lo scudo è attivo, quando vieni colpito: \n" +
                                                    "Annuncia un numero di un d8 e procedi a tirare il dado.\n" +
                                                    "Se esce il numero annunciato assorbi completamente l'attacco";
                            break;

                        case enCompagnie.Maliwan:
                            m_sAbilitaSpeciale = "Maliwan: Finchè lo scudo è attivo:\n" +
                                                    "+2 CA | -2 Danni ricevuti dagli elementi";
                            break;

                        case enCompagnie.Dahl:
                            m_sAbilitaSpeciale = "Dahl: Finchè lo scudo è attivo, quando vieni colpito: \n" +
                                                    "Annuncia un numero di un d8 e procedi a tirare il dado \n" +
                                                    "Se esce il numero annunciato droppi uno shield booster a terra. Puoi decidere se usarlo tu o darlo ad un compagno\n" +
                                                    "Lo shield booster ricarica COMPLETAMENTE lo scudo di chi lo usa\nIl booster rimane a terra per 1 turno";
                            break;

                        case enCompagnie.Tediore:
                            m_nHP += 5;
                            m_nTTC -= 2;
                            m_sAbilitaSpeciale = "Tediore: +5 HP | -2 Turns To Charge";
                            break;

                        case enCompagnie.Torgue:
                            m_sAbilitaSpeciale = "TORGUE: Quando lo scudo arriva a 0hp dopo essere stato completamente caricato:\n" +
                                                    "1d20 +exp bonus danni range 1.5/4.5/6 metri [full/half/quarter dmg]";
                            break;

                        case enCompagnie.Bandit:
                            m_nTTC += 2;
                            m_sAbilitaSpeciale = "Bandit: +2 Turns To Charge | Quando lo scudo è COMPLETAMENTE scarico:\n" +
                                                    "I tuoi colpi c.a.c. diventano più forti\n" +
                                                    "+7 danni ad ogni colpo c.a.c.";
                            break;
                    }
                    break;

                case int n when (n >= 41 && n <= 65):
                    nRoll1 = new Random().Next(1, 7);
                    System.Threading.Thread.Sleep(1000);
                    nRoll2 = new Random().Next(1, 7);
                    m_nHP = nRoll1 + nRoll2;
                    m_nHP += 3;
                    lblRarita.Text = "UNCOMMON";
                    lblRarita.ForeColor = Color.LimeGreen;
                    m_nTTC = 6;
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show("Hai rollato: " + nRoll1 + " " + nRoll2 + ", Totale (2d6+3 UNCOMMON): " + m_nHP);
                    }
                    else
                    {
                        m_nHP = 9;
                        MessageBox.Show("UNCOMMON: 2d6 + 3. Totale: " + m_nHP);
                    }

                    switch ((enCompagnie)m_nCompagnia)
                    {
                        case enCompagnie.Jakobs:
                            m_nHP += 10;
                            m_nTTC += 3;
                            m_sAbilitaSpeciale = "Jakobs: +10 HP | +3 Turns To Charge";
                            break;

                        case enCompagnie.Hyperion:
                            m_sAbilitaSpeciale = "Hyperion: Quando lo scudo è COMPLETAMENTE carico\n" +
                                                    "Ogni tuo attacco da arma da fuoco fa 4 danni in più, ma danneggia lo scudo di 3 HP";
                            break;

                        case enCompagnie.Vladof:
                            m_sAbilitaSpeciale = "Vladof: Finchè lo scudo è attivo, quando vieni colpito: \n" +
                                                    "Annuncia un numero di un d10 e procedi a tirare il dado.\n" +
                                                    "Se esce il numero annunciato assorbi completamente l'attacco";
                            break;

                        case enCompagnie.Maliwan:
                            m_sAbilitaSpeciale = "Maliwan: Finchè lo scudo è attivo:\n" +
                                                    "+1 CA | -2 Danni ricevuti dagli elementi";
                            break;

                        case enCompagnie.Dahl:
                            m_sAbilitaSpeciale = "Dahl: Finchè lo scudo è attivo, quando vieni colpito: \n" +
                                                    "Annuncia un numero di un d10 e procedi a tirare il dado \n" +
                                                    "Se esce il numero annunciato droppi uno shield booster a terra. Puoi decidere se usarlo tu o darlo ad un compagno\n" +
                                                    "Lo shield booster ricarica COMPLETAMENTE lo scudo di chi lo usa\nIl booster rimane a terra per 1 turno";
                            break;

                        case enCompagnie.Tediore:
                            m_nHP += 4;
                            m_nHP -= 2;
                            m_sAbilitaSpeciale = "Tediore: +4 HP | -2 Turns To Charge";
                            break;

                        case enCompagnie.Torgue:
                            m_sAbilitaSpeciale = "TORGUE: Quando lo scudo arriva a 0hp dopo essere stato completamente caricato:\n" +
                                                    "1d12 +exp bonus danni range 1.5/4.5/6 metri [full/half/quarter dmg]";
                            break;

                        case enCompagnie.Bandit:
                            m_nTTC += 2;
                            m_sAbilitaSpeciale = "Bandit: +2 Turns To Charge | Quando lo scudo è COMPLETAMENTE scarico:\n" +
                                                    "I tuoi colpi c.a.c. diventano più forti\n" +
                                                    "+5 danni ad ogni colpo c.a.c.";
                            break;
                    }
                    break;

                case int n when (n >= 66 && n <= 100):
                    nRoll1 = new Random().Next(1, 5);
                    System.Threading.Thread.Sleep(1000);
                    nRoll2 = new Random().Next(1, 5);
                    m_nHP = nRoll1 + nRoll2;
                    m_nHP += 2;
                    lblRarita.Text = "COMMON";
                    lblRarita.ForeColor = Color.White;
                    m_nTTC = 6;
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show("Hai rollato: " + nRoll1 + " " + nRoll2 + ", Totale (2d4+2 COMMON): " + m_nHP);
                    }
                    else
                    {
                        m_nHP = 6;
                        MessageBox.Show("COMMON: 2d4 + 2. Totale: " + m_nHP);
                    }

                    switch ((enCompagnie)m_nCompagnia)
                    {
                        case enCompagnie.Jakobs:
                            m_nHP += 8;
                            m_nTTC += 2;
                            m_sAbilitaSpeciale = "Jakobs: +8 HP | +2 Turns To Charge";
                            break;

                        case enCompagnie.Hyperion:
                            m_sAbilitaSpeciale = "Hyperion: Quando lo scudo è COMPLETAMENTE carico\n" +
                                                    "Ogni tuo attacco da arma da fuoco fa 2 danni in più, ma danneggia lo scudo di 2 HP";
                            break;

                        case enCompagnie.Vladof:
                            m_sAbilitaSpeciale = "Vladof: Finchè lo scudo è attivo, quando vieni colpito: \n" +
                                                    "Annuncia un numero di un d12 e procedi a tirare il dado.\n" +
                                                    "Se esce il numero annunciato assorbi completamente l'attacco";
                            break;

                        case enCompagnie.Maliwan:
                            m_sAbilitaSpeciale = "Maliwan: Finchè lo scudo è attivo:\n" +
                                                    "+1 CA | -1 Danni ricevuti dagli elementi";
                            break;

                        case enCompagnie.Dahl:
                            m_sAbilitaSpeciale = "Dahl: Finchè lo scudo è attivo, quando vieni colpito: \n" +
                                                    "Annuncia un numero di un d12 e procedi a tirare il dado \n" +
                                                    "Se esce il numero annunciato droppi uno shield booster a terra. Puoi decidere se usarlo tu o darlo ad un compagno\n" +
                                                    "Lo shield booster ricarica COMPLETAMENTE lo scudo di chi lo usa\nIl booster rimane a terra per 1 turno";
                            break;

                        case enCompagnie.Tediore:
                            m_nHP += 2;
                            m_nTTC -= 2;
                            m_sAbilitaSpeciale = "Tediore: +2 HP | -1 Turns To Charge";
                            break;

                        case enCompagnie.Torgue:
                            m_sAbilitaSpeciale = "TORGUE: Quando lo scudo arriva a 0hp dopo essere stato completamente caricato:\n" +
                                                    "1d8 +exp bonus danni range 1.5/4.5/6 metri [full/half/quarter dmg]";
                            break;

                        case enCompagnie.Bandit:
                            m_nTTC += 1;
                            m_sAbilitaSpeciale = "Bandit: +1 Turns To Charge | Quando lo scudo è COMPLETAMENTE scarico:\n" +
                                                    "I tuoi colpi c.a.c. diventano più forti\n" +
                                                    "+3 danni ad ogni colpo c.a.c.";
                            break;
                    }
                    break;

                default:
                    Debug.Print("ERR: Rarità invalida.");
                    break;
            }
            UpdateComponents();
        }

        private void UpdateComponents()
        {
            switch ((enCompagnie) m_nCompagnia)
            {
                case enCompagnie.Jakobs:
                    this.imgCompagnia.BackgroundImage = Properties.Resources.jakobs;
                    break;

                case enCompagnie.Hyperion:
                    this.imgCompagnia.BackgroundImage = Properties.Resources.hyperion;
                    break;

                case enCompagnie.Vladof:
                    this.imgCompagnia.BackgroundImage = Properties.Resources.vladof;
                    break;

                case enCompagnie.Maliwan:
                    this.imgCompagnia.BackgroundImage = Properties.Resources.maliwan;
                    break;

                case enCompagnie.Dahl:
                    this.imgCompagnia.BackgroundImage = Properties.Resources.dahl;
                    break;

                case enCompagnie.Tediore:
                    this.imgCompagnia.BackgroundImage = Properties.Resources.tediore;
                    break;

                case enCompagnie.Torgue:
                    this.imgCompagnia.BackgroundImage = Properties.Resources.torgue;
                    break;

                case enCompagnie.Bandit:
                    this.imgCompagnia.BackgroundImage = Properties.Resources.bandit;
                    break;
            }
            this.lblHP.Text = m_nHP.ToString();
            this.lblTurns.Text = m_nTTC.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(m_sAbilitaSpeciale, "Abilità Speciale");
        }
    }
}
