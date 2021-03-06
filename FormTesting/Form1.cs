﻿using EntitiesLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaseShape f = null;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    f = new BaseTriangle(float.Parse(txtWidth.Text), float.Parse(txtHeight.Text));
                    break;
                case 1:
                    f = new BaseRectangle(float.Parse(txtWidth.Text), float.Parse(txtHeight.Text));
                    break;
                case 2:
                    f = new BaseSector(float.Parse(txtWidth.Text), int.Parse(txtHeight.Text));
                    break;
                default:
                    break;
            }

            var p = new ConcreteParameters(float.Parse(txtX.Text), float.Parse(txtY.Text), int.Parse(txtAngle.Text));
            var c = new ConcreteShape(f, p);
            ResultLabel.Text = c.ToString() + "\n" + c.GetMaxDistance(new PointF(0, 0)).ToString();
        }
    }
}
