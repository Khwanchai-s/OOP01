using Microsoft.VisualBasic;

namespace OOP01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //firstclass f = new firstclass();
            //f.devname = "Khwanchai Suksaen";
            //string msg = f.devname + Environment.NewLine
            //            + f.devstart;
            //MessageBox.Show(msg);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employees em = new Employees();
            //set ค่าให้ property ของ obj ชื่อ em
            em.ID = 1;
            em.Name = "Khwanchai";
            em.Salary = 20.0;
            em.Email = "khwanchai.su@udru.ac.th";
            //Get ค่าใน Property ของ obj ชื่อ em ออกมาแสดงผล
            string msg = em.ID.ToString() + Environment.NewLine
                       + em.Name + Environment.NewLine
                       + em.Salary.ToString("#,#00.00") + Environment.NewLine
                       + em.Email;
            MessageBox.Show(msg);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            firstclass f = new firstclass();
            MessageBox.Show(f.ID + Environment.NewLine + f.FullName);

            firstclass f2 = new firstclass(2, "ชื่อทดสอบ นามสกุลรันได้;");
            MessageBox.Show(f2.ID + Environment.NewLine + f2.FullName);
        }

        private void button4_Click(object sender, EventArgs e)
        {//ปุ่มสามเหลี่ยม

            DrawChar d = new DrawChar();   //เรียกใช้ Class ใช้ค่าเริ่มต้น
            textBox1.Text = d.Triangle();
        }

        private void button5_Click(object sender, EventArgs e)
        {//ปุ่มสี่เหลี่ยม
            DrawChar d = new DrawChar(9, "A");   //เรียกใช้คลาส ใช้ค่าที่กำหนดเข้าไป
            textBox1.Text = d.Square();
        }
    }
}