﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    public partial class Form1 : Form
    {
        TestLabel _testLabel;
        TestTextBox _textBox;

        public Form1()
        {
            InitializeComponent();

            string[] buttonTexts = { "LUNAR", "神野", "天野", "松本", "長澤", "宇都宮", "ヴィ", "相沢", "平井", "伊藤" };

            for (int i = 0; i < 10; i++)
            {
                TestButton testButton = new TestButton(this, i, (i % 5) * 100, (i / 5) * 100, 100, 100);
                testButton.Text = buttonTexts[i];
                //testButton.Click += (sender, e) => SwapText((TestButton)sender);
                Controls.Add(testButton);
            }

            _testLabel = new TestLabel("らべるです。", 10, 300, 100, 500);
            Controls.Add(_testLabel);

            _textBox = new TestTextBox("てきすとぼっくすです。", 110, 300, 500, 100);
            Controls.Add(_textBox);

            //Label label = new label();
            //label.Location = new Point(30,400);
            //label.Text = "ラベルです";

            //Controls.Add(label);
        }
        private void SwapText(TestButton button) 
        { 
            string tempText = button.Text;

            button.Text = _textBox.Text;

            _textBox.Text = tempText;

            LabelTextUpdate(button.Text);
        
        }
        public void LabelTextUpdate(string str)
        {
            _testLabel.TextUpdate(str);
        }

        public string ButtonLabelReplacement(string str) 
        { 
            string s = _textBox.TextReplacement(str);

            return s;
        
        }

    }

    }



