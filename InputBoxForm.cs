using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace RandomNumber
{
    public partial class InputBoxForm : MaterialForm
    {
        public string inputText { get; private set; }
        public InputBoxForm()
        {
            InitializeComponent();
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            inputText = inputTextBox.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
