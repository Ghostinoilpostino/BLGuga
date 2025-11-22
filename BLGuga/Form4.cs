using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLGuga
{
    public partial class Form4 : Form
    {
        private string m_sCsv;
        private string[] m_sItemsZaino;

        public Form4(string csv)
        {
            InitializeComponent();
            this.m_sCsv = csv;
            string[] m_sItemsZaino = m_sCsv.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            foreach (string sItem in m_sItemsZaino)
            {
                if (!string.IsNullOrEmpty(sItem))
                {
                    string[] sItemValues = sItem.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    lswZaino.Items.Add(sItemValues[0]);
                    switch (sItemValues[0])
                    {
                        case "ARMA":
                            lswZaino.Items[lswZaino.Items.Count - 1].SubItems.Add(sItemValues[1]); // Nome
                            lswZaino.Items[lswZaino.Items.Count - 1].SubItems.Add(sItemValues[2]); // Tipo
                            lswZaino.Items[lswZaino.Items.Count - 1].SubItems.Add(sItemValues[3]); // Compagnia
                            break;
                    }
                }
            }
        }
    }
}
