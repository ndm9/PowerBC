using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerBC
{
    public partial class frmMain : Form
    {
        private TextBox[] txbInputs;
        private ulong[] radixes = { 2, 8, 10, 12, 16, 20, 1, 1 };
        private PowerBCLib.BaseConverter baseConverter;
        private bool isProcessing = false;

        public frmMain()
        {
            InitializeComponent();
            baseConverter = new PowerBCLib.BaseConverter();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txbInputs = new TextBox[8];
            txbInputs[0] = txbInput0;
            txbInputs[1] = txbInput1;

            for (int i = 0; i < 8; i++)
            {
                if (i > 1)
                {
                    txbInputs[i] = new TextBox();
                }
                FormatInputTextBox(txbInputs[i], i);
                txbInputs[i].TextChanged += this.txbInput_TextChanged;
            }

            radixes[6] = (ulong)nudCustomBase1.Value;
            radixes[7] = (ulong)nudCustomBase2.Value;
        }

        private void FormatInputTextBox(TextBox txb, int index)
        {
            var template = txbInputs[0];

            txb.BackColor = template.BackColor;
            txb.BorderStyle = template.BorderStyle;
            txb.Font = template.Font;
            txb.Location = new Point(94, index * 24 + 7);
            txb.Name = $"txbInput{index}";
            txb.Size = template.Size;
            txb.TabIndex = (index < 6 ? index : (2 * (index - 5)) + 5);
            this.Controls.Add(txb);
        }

        private void txbInput_TextChanged(object sender, EventArgs e)
        {
            if (isProcessing) { return; }
            isProcessing = true;
            var txb = (TextBox)sender;
            int idx = int.Parse(txb.Name[^1].ToString());
            bool isValid = !string.IsNullOrWhiteSpace(txb.Text);
            ulong? decVal = 0;
            if (isValid)
            {
                string str = txb.Text.Trim();
                if (idx < 36) { str = str.ToUpper(); }
                decVal = baseConverter.StrToNum(str, radixes[idx]);
                isValid = decVal.HasValue;
            }

            for (int i = 0; i < 8; i++)
            {
                if (i == idx) { continue; }
                if (isValid)
                {
                    string converted = baseConverter.NumToStr(decVal.Value, radixes[i]);
                    txbInputs[i].Text = converted ?? "";
                }
                else
                {
                    txbInputs[i].Clear();
                }
            }
            isProcessing = false;
        }

        private void nudCustomBase_ValueChanged(object sender, EventArgs e)
        {
            radixes[6] = (ulong)nudCustomBase1.Value;
            radixes[7] = (ulong)nudCustomBase2.Value;
            txbInput_TextChanged(txbInputs[5], null);
        }
    }
}
