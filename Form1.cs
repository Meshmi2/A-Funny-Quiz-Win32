using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Win32
{
    public partial class QUIZ : Form
    {
        public QUIZ()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Displays the MessageBox.
            const string message = "Quit Program?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            // Close The Program
            if (result == DialogResult.Yes)
            {
                // Closes the parent form.
                this.Close();
            } 
            // cancel the closure of the form.
            // If the no button was pressed ...
            if (result == DialogResult.No)
            {
                // cancel the closure of the form
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //

            // Please Replace The Question
            const string q1 = ("Are you Human?");
            const string q2 = ("Is the CPU part of a computer?");
            const string q3 = ("is the middle finger an offense?");
            const string q4 = ("was a German inventing the phone?");
            const string q5 = ("Is it true that Leonardo da vinci designed the mose?");
            const string q6 = ("Is it true that 1 + 1 equals 2?");
            const string q7 = ("do we live on a geoid?");
            const string q8 = ("America is made up of 13 states?");
            const string q9 = ("the united kingdom uses the euro?");
            const string q10 = ("Did Steve Jobs ever work for Apple?");
            //Define Point

            int startpoint = 0;

            //Start The Quiz...
            
            //Question..1
            const string message = q1;
            const string caption = "Question 1";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            _ = checkBox1.Checked = true;
            if (result == DialogResult.Yes)
            {
                label13.Visible = true;
                label12.Text = Convert.ToString(++(startpoint));

            }
            else if (result == DialogResult.No)
            {
                label12.Text = Convert.ToString(--(startpoint));
            }
            
            //Question..2
            const string message2 = q2;
            const string caption2 = "Question 2";
            var result2 = MessageBox.Show(message2, caption2,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            _ = checkBox2.Checked = true;
            if (result2 == DialogResult.Yes)
            {
                label14.Visible = true;
                label12.Text = Convert.ToString(++(startpoint));

            }
            else if (result2 == DialogResult.No)
            {
                label12.Text = Convert.ToString(--(startpoint));
            }
            //Question..3
            const string message3 = q3;
            const string caption3 = "Question 3";
            var result3 = MessageBox.Show(message3, caption3,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            _ = checkBox3.Checked = true;
            if (result3 == DialogResult.Yes)
            {
                label15.Visible = true;
                label12.Text = Convert.ToString(++(startpoint));

            }
            else if (result3 == DialogResult.No)
            {
                label12.Text = Convert.ToString(--(startpoint));
            }
            //Question..4
            const string message4 = q4;
            const string caption4 = "Question 4";
            var result4 = MessageBox.Show(message4, caption4,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            _ = checkBox4.Checked = true;
            if (result4 == DialogResult.Yes)
            {
                label12.Text = Convert.ToString(--(startpoint));
            }
            else if (result4 == DialogResult.No)
            {
                label16.Visible = true;
                label12.Text = Convert.ToString(++(startpoint));
            }
            //Question..5
            const string message5 = q5;
            const string caption5 = "Question 5";
            var result5 = MessageBox.Show(message5, caption5,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            _ = checkBox5.Checked = true;
            if (result5 == DialogResult.Yes)
            {
                label12.Text = Convert.ToString(--(startpoint));
            }
            else if (result5 == DialogResult.No)
            {
                label17.Visible = true;
                label12.Text = Convert.ToString(++(startpoint));

            }
            //Question..6

            const string message6 = q6;
            const string caption6 = "Question 6";
            var result6 = MessageBox.Show(message6, caption6,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            _ = checkBox6.Checked = true;
            if (result6 == DialogResult.Yes)
            {
                label18.Visible = true;
                label12.Text = Convert.ToString(++(startpoint));

            }
            else if (result6 == DialogResult.No)
            {
                label12.Text = Convert.ToString(--(startpoint));
            }
            //Question..7

            const string message7 = q7;
            const string caption7 = "Question 7";
            var result7 = MessageBox.Show(message7, caption7,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            _ = checkBox7.Checked = true;
            if (result7 == DialogResult.Yes)
            {
                label19.Visible = true;
                label12.Text = Convert.ToString(++(startpoint));
            }
            else if (result7 == DialogResult.No)
            {
                label12.Text = Convert.ToString(--(startpoint));
            }
            //Question..8

            const string message8 = q8;
            const string caption8 = "Question 8";
            var result8 = MessageBox.Show(message8, caption8,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            _ = checkBox8.Checked = true;
            if (result8 == DialogResult.Yes)
            {
                label12.Text = Convert.ToString(--(startpoint));
            }
            else if (result8 == DialogResult.No)
            {
                label20.Visible = true;
                label12.Text = Convert.ToString(++(startpoint));

            }
            //Question..9

            const string message9 = q9;
            const string caption9 = "Question 9";
            var result9 = MessageBox.Show(message9, caption9,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            _ = checkBox9.Checked = true;
            if (result9 == DialogResult.Yes)
            {
                label12.Text = Convert.ToString(--(startpoint));
            }
            else if (result9 == DialogResult.No)
            {
                label21.Visible = true;
                label12.Text = Convert.ToString(++(startpoint));
            }
            //Question..10

            const string message10 = q10;
            const string caption10 = "Question 10";
            var result10 = MessageBox.Show(message10, caption10,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            _ = checkBox10.Checked = true;
            if (result10 == DialogResult.Yes)
            {
                label22.Visible = true;
                label12.Text = Convert.ToString(++(startpoint));
            }
            else if (result10 == DialogResult.No)
            {
                label12.Text = Convert.ToString(--(startpoint));
            }

            const string message11 = "Done :)";
            const string caption11 = "Done";
            var result11 = MessageBox.Show(message11, caption11);
        }
    }
}
