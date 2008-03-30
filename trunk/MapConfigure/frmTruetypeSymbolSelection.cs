using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;

namespace MapConfigure
{
    public partial class frmTruetypeSymbolSelection : Form
    {
        public frmTruetypeSymbolSelection()
        {
            InitializeComponent();

            InstalledFontCollection oInstalledFonts = new InstalledFontCollection();
            foreach (FontFamily item in oInstalledFonts.Families)
            {
                if(item.Name.Contains("ESRI"))
                this.comboBox1.Items.Add(item.Name);
            }

            this.comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectedIndex = 0;
        
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.symbolSelectorControl1.ListSymbols(new Font(comboBox1.SelectedItem.ToString(), 12f, FontStyle.Regular, GraphicsUnit.Pixel));
        }

        private void symbolSelectorControl1_SymbolSelected(object sender, SymbolSelector.SymbolSelectedEventArgs e)
        {
            Font oFont = new Font(e.CurrentFont.Name, 50, FontStyle.Bold, GraphicsUnit.Pixel);
            this.label1.Font = oFont;

            this.label1.Text = new String((char)e.SymbolIndex,1);
            this.label1.ForeColor = Color.Blue;
        }
    }
}