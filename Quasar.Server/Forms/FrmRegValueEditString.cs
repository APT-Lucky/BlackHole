﻿using Quasar.Common.Models;
using Quasar.Common.Utilities;
using Quasar.Server.Forms.DarkMode;
using Quasar.Server.Registry;
using System;
using System.Windows.Forms;

namespace Quasar.Server.Forms
{
    public partial class FrmRegValueEditString : Form
    {
        private readonly RegValueData _value;

        public FrmRegValueEditString(RegValueData value)
        {
            _value = value;

            InitializeComponent();

            DarkModeManager.ApplyDarkMode(this);

            this.valueNameTxtBox.Text = RegValueHelper.GetName(value.Name);
            this.valueDataTxtBox.Text = ByteConverter.ToString(value.Data);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            _value.Data = ByteConverter.GetBytes(valueDataTxtBox.Text);
            this.Tag = _value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
