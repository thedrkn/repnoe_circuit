using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepnoeProject

{ public partial class Form2 : Form
    {

    public int check1 = 0;
    public int check2 = 0;
    

    public string err_1 = "Ошибка: выбраны одинаковые точки";
        public string err_2 = "Соединение невозможно просчитать. Данный раздел находиться в разработке.";
    public double voltage= 0;
    public double resistance= 0;
        public double res_full = 0;


        public Form2()
        {
            InitializeComponent();
          
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void label21_Click(object sender, EventArgs e)
        {
                
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
    
        
                check1 = 1;
       
        
    }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check1 == 1)
            {
                if (check2 == 1)
                {
                    MessageBox.Show(err_1);
                }
                if (check2 == 2)
                {
                    MessageBox.Show(err_2);//а и b
                }
                if (check2 == 3) 
                {
                    res_full = (1 / ((1 / (2 * resistance)) + (1 / (2 * resistance)) + (1 / (2 * resistance))));
                    label26.Text = (String.Format("{0:f2}", ((voltage/2)/resistance))+"A");
                    label24.Text = (String.Format("{0:f2}", voltage) +"B");
                    label18.Text = (String.Format("{0:f2}", ((voltage * voltage) / (2 * resistance))) + "Вт");

                    label2.Text = (String.Format("{0:f2}", ((voltage / 2) / resistance))+"A");
                    label3.Text = (String.Format("{0:f2}", (voltage / 2))+"В");
                    label5.Text = (String.Format("{0:f2}", ((voltage * voltage) / (2 * resistance) / 2)) + "Вт");

                    label15.Text = (String.Format("{0:f2}", ((voltage / 2) / resistance))+"A");
                    label13.Text = (String.Format("{0:f2}", (voltage / 2)) + "В");
                    label10.Text = (String.Format("{0:f2}", ((voltage * voltage) / (2 * resistance) / 2)) + "Вт");

                    label32.Text = (String.Format("{0:f2}", ((voltage / 2) / resistance)) + "A");
                    label30.Text = (String.Format("{0:f2}", (voltage / 2)) + "В");
                    label28.Text = (String.Format("{0:f2}", ((voltage * voltage) / (2 * resistance) / 2)) + "Вт");

                    label38.Text = (String.Format("{0:f2}", ((voltage / 2) / resistance)) + "A");
                    label36.Text = (String.Format("{0:f2}", (voltage / 2)) + "В");
                    label34.Text = (String.Format("{0:f2}", ((voltage * voltage) / (2 * resistance) / 2)) + "Вт");

                    label44.Text = ("0A");
                    label42.Text = ("0B");
                    label40.Text = ("0Вт");

                    label68.Text = (String.Format("{0:f2}", (voltage/resistance)) + "A");
                    label66.Text = (String.Format("{0:f2}", (voltage*voltage)/res_full) + "Вт");
                    label64.Text = (String.Format("{0:f2}", res_full) + "Ом");



                }
                if (check2 == 4)
                {
                    MessageBox.Show(err_2); //a and d
                }

            }
            if (check1 == 2)
            {
                if (check2 == 2)
                {
                    MessageBox.Show(err_1);
                }
                if (check2 == 1)
                {
                    MessageBox.Show(err_2);//а и b
                }
                if (check2 == 3)
                {
                    MessageBox.Show(err_2);//b and c
                }
                if (check2 == 4)
                {
                    res_full = (1 / ((1 / (2 * resistance)) + (1 / (2 * resistance)) + (1 / (2 * resistance))));


                    label44.Text = ((String.Format("{0:f2}", ((voltage / 2) / resistance))) + ("A"));
                    label42.Text = (String.Format("{0:f2}", (voltage)) + "B");
                    label40.Text = (String.Format("{0:f2}", ((voltage * voltage) / (2 * resistance))) + "Вт");

                    label2.Text = (String.Format("{0:f2}", ((voltage / 2) / resistance)) + "A");
                    label3.Text = (String.Format("{0:f2}", (voltage / 2)) + "В");
                    label5.Text = (String.Format("{0:f2}", ((voltage * voltage) / (2 * resistance) / 2)) + "Вт");

                    label15.Text = (String.Format("{0:f2}", (((voltage / 2) / resistance))) + "A");
                    label13.Text = (String.Format("{0:f2}", (voltage / 2)) + "В");
                    label10.Text = (String.Format("{0:f2}", ((voltage * voltage) / (2 * resistance) / 2)) + "Вт");

                    label32.Text = (String.Format("{0:f2}", ((voltage / 2) / resistance)) + "A");
                    label30.Text = (String.Format("{0:f2}", (voltage / 2)) + "В");
                    label28.Text = (String.Format("{0:f2}", ((voltage * voltage) / (2 * resistance) / 2)) + "Вт");

                    label38.Text = (String.Format("{0:f2}", (voltage / 2 / resistance)) + "A");
                    label36.Text = (String.Format("{0:f2}", (voltage / 2)) + "В");
                    label34.Text = (String.Format("{0:f2}", ((voltage * voltage) / (2 * resistance) / 2)) + "Вт");

                    label26.Text = ("0A");
                    label24.Text = ("0B");
                    label18.Text = ("0Вт");

                    label68.Text = (String.Format("{0:f2}", (voltage / resistance)) + "A");
                    label66.Text = (String.Format("{0:f2}", (voltage * voltage) / res_full) + "Вт");
                    label64.Text = (String.Format("{0:f2}", res_full) + "Ом");
                }

            }
            if (check1 == 3)
            {
                if (check2 == 3)
                {
                    MessageBox.Show(err_1);
                }
                if (check2 == 2)
                {
                    MessageBox.Show(err_2);//c и b
                }
                if (check2 == 1)
                {
                    res_full = (1 / ((1 / (2 * resistance)) + (1 / (2 * resistance)) + (1 / (2 * resistance))));
                    label26.Text = (String.Format("{0:f2}", ((voltage / 2) / resistance)) + "A");
                    label24.Text = (String.Format("{0:f2}", voltage) + "B");
                    label18.Text = (String.Format("{0:f2}", ((voltage * voltage) / (2 * resistance))) + "Вт");

                    label2.Text = (String.Format("{0:f2}", ((voltage / 2) / resistance)) + "A");
                    label3.Text = (String.Format("{0:f2}", (voltage / 2)) + "В");
                    label5.Text = (String.Format("{0:f2}", ((voltage * voltage) / (2 * resistance) / 2)) + "Вт");

                    label15.Text = (String.Format("{0:f2}", ((voltage / 2) / resistance)) + "A");
                    label13.Text = (String.Format("{0:f2}", (voltage / 2)) + "В");
                    label10.Text = (String.Format("{0:f2}", ((voltage * voltage) / (2 * resistance) / 2)) + "Вт");

                    label32.Text = (String.Format("{0:f2}", ((voltage / 2) / resistance)) + "A");
                    label30.Text = (String.Format("{0:f2}", (voltage / 2)) + "В");
                    label28.Text = (String.Format("{0:f2}", ((voltage * voltage) / (2 * resistance) / 2)) + "Вт");

                    label38.Text = (String.Format("{0:f2}", ((voltage / 2) / resistance)) + "A");
                    label36.Text = (String.Format("{0:f2}", (voltage / 2)) + "В");
                    label34.Text = (String.Format("{0:f2}", ((voltage * voltage) / (2 * resistance) / 2)) + "Вт");

                    label44.Text = ("0A");
                    label42.Text = ("0B");
                    label40.Text = ("0Вт");

                    label68.Text = (String.Format("{0:f2}", (voltage / resistance)) + "A");
                    label66.Text = (String.Format("{0:f2}", (voltage * voltage) / res_full) + "Вт");
                    label64.Text = (String.Format("{0:f2}", res_full) + "Ом");

                }
                if (check2 == 4)
                {
                    MessageBox.Show(err_2);//c and d
                }

            }
            if (check1 == 4)
            {
                if (check2 == 4)
                {
                    MessageBox.Show(err_1);
                }
                if (check2 == 2)
                {
                    res_full = (1 / ((1 / (2 * resistance)) + (1 / (2 * resistance)) + (1 / (2 * resistance))));


                    label44.Text = ((String.Format("{0:f2}", ((voltage / 2) / resistance))) + ("A"));
                    label42.Text = (String.Format("{0:f2}", (voltage)) + "B");
                    label40.Text = (String.Format("{0:f2}", ((voltage * voltage) / (2 * resistance))) + "Вт");

                    label2.Text = (String.Format("{0:f2}", ((voltage / 2) / resistance)) + "A");
                    label3.Text = (String.Format("{0:f2}", (voltage / 2)) + "В");
                    label5.Text = (String.Format("{0:f2}", ((voltage * voltage) / (2 * resistance) / 2)) + "Вт");

                    label15.Text = (String.Format("{0:f2}", (((voltage / 2) / resistance))) + "A");
                    label13.Text = (String.Format("{0:f2}", (voltage / 2)) + "В");
                    label10.Text = (String.Format("{0:f2}", ((voltage * voltage) / (2 * resistance)) / 2) + "Вт");

                    label32.Text = (String.Format("{0:f2}", ((voltage / 2) / resistance)) + "A");
                    label30.Text = (String.Format("{0:f2}", (voltage / 2)) + "В");
                    label28.Text = (String.Format("{0:f2}", ((voltage * voltage) / (2 * resistance) / 2)) + "Вт");

                    label38.Text = (String.Format("{0:f2}", (voltage / 2 / resistance)) + "A");
                    label36.Text = (String.Format("{0:f2}", (voltage / 2)) + "В");
                    label34.Text = (String.Format("{0:f2}", ((voltage * voltage) / (2 * resistance) / 2)) + "Вт");

                    label26.Text = ("0A");
                    label24.Text = ("0B");
                    label18.Text = ("0Вт");

                    label68.Text = (String.Format("{0:f2}", (voltage / resistance)) + "A");
                    label66.Text = (String.Format("{0:f2}", (voltage * voltage) / res_full) + "Вт");
                    label64.Text = (String.Format("{0:f2}", res_full) + "Ом");
                }
                if (check2 == 3)
                {
                    MessageBox.Show(err_2);//d anld c
                }
                if (check2 == 1)
                {
                    MessageBox.Show(err_2);//a and d
                }

            }
        }



        private void label21_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "") { voltage = 0; }
            else
            {
                voltage = Convert.ToDouble(textBox7.Text);
            }
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        
            
        

            if (textBox1.Text == "") { resistance = 0; } else { resistance = Convert.ToDouble(textBox1.Text); }



        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            check2 = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            check1 = 2;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            check2 = 2;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            check1 = 3;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            check2 = 3;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            check1 = 4;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            check2 = 4;
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            check1 = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            check1 = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            check1 = 4;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            check2 = 1;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            check2 = 2;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            check2 = 3;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            check2 = 4;
        }

        private void label65_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label66_Click(object sender, EventArgs e)
        {

        }

        private void label67_Click(object sender, EventArgs e)
        {

        }

        private void label68_Click(object sender, EventArgs e)
        {

        }

        private void label69_Click(object sender, EventArgs e)
        {

        }

        private void label64_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
