﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WyattBussellC968Software1C_
{
    public partial class FormAreYouSure : Form
    {

        public event EventHandler onContinueDeletePart;
        public event EventHandler onCancelDeletePart;

        public event EventHandler onContinueDeleteProduct;
        public event EventHandler onCancelDeleteProduct;
        public FormAreYouSure()
        {
            InitializeComponent();
        }

        private void FormAreYouSure_Load(object sender, EventArgs e)
        {

        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            onContinueDeletePart?.Invoke(this, EventArgs.Empty);
            onContinueDeleteProduct?.Invoke(this, EventArgs.Empty);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            onCancelDeletePart?.Invoke(this, EventArgs.Empty);
            onCancelDeleteProduct?.Invoke(this, EventArgs.Empty);
        }
    }
}
