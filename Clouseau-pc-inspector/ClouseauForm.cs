﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace PC_Inspector
{
    public partial class ClouseauForm : Form
    {
        public ClouseauForm()
        {
            InitializeComponent();
        }

        private void inAppLogTextbox_TextChanged(object sender, EventArgs e)
        {
            this.inAppLogTextBox.SelectionStart = this.inAppLogTextBox.Text.Length;

            this.inAppLogTextBox.ScrollToCaret();
        }
    }
}
