using Project_1_SimpleCalculetor.Logical.ProgramsFormsLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Project_1_SimpleCalculetor.Forms.ProgramsForms
{
    public partial class Form_Library : Form
    {
        private Form CurrentForm;
        public Form_Library(Form getProgramSele_Form)
        {
            InitializeComponent();
             CurrentForm = getProgramSele_Form;



        }
        Logic_Library NewFormLib = new Logic_Library();

        private void Form_Library_Load(object sender, EventArgs e)
        {

            
            PictureBox f = new PictureBox();
            f.Click += pictureBox1_Click;
            f.Width = 75;
            f.Height = 110;
            f.BackColor = Color.Black;

            int x = 12;
            int y = 12;
            f.Location = new Point(x, y);

            panel1.Controls.Add(f);
            f.BringToFront();

            PictureBox f1= new PictureBox();
            f1.Click += pictureBox1_Click;
            f1.Width = 75;
            f1.Height = 110;
            f1.BackColor = Color.Black;

            int x1 = x + 75 + 10;
            int y1 = 12;
            f1.Location = new Point(x1, y1);

            panel1.Controls.Add(f1);
            f1.BringToFront();



            PictureBox f2 = new PictureBox();
            f2.Click += pictureBox1_Click;
            f2.Width = 75;
            f2.Height = 110;
            f2.BackColor = Color.Black;

            int x2 = x1  + 75 + 10;
            int y2 = 12;
            f2.Location = new Point(x2, y2);

            panel1.Controls.Add(f2);
            f2.BringToFront();




            PictureBox f3 = new PictureBox();
            f3.Click += pictureBox1_Click;
            f3.Width = 75;
            f3.Height = 110;
            f3.BackColor = Color.Black;

            int x3 = x2 + 75 + 10;
            int y3 = 12;
            f3.Location = new Point(x3, y3);

            panel1.Controls.Add(f3);
            f3.BringToFront();


            PictureBox f4 = new PictureBox();
            f4.Click += pictureBox1_Click;
            f4.Width = 75;
            f4.Height = 110;
            f4.BackColor = Color.Black;

            int x4 = x3 + 75 + 10;
            int y4 = 12;
            f4.Location = new Point(x4, y4);

            panel1.Controls.Add(f4);
            f4.BringToFront();




            PictureBox f5 = new PictureBox();
            f5.Click += pictureBox1_Click;
            f5.Width = 75;
            f5.Height = 110;
            f5.BackColor = Color.Black;

            int x5 = x4 + 75 + 10;
            int y5 = 12;
            f5  .Location = new Point(x5, y5);

            panel1.Controls.Add(f5);
            f5.BringToFront();





            PictureBox f6 = new PictureBox();
            f6.Click += pictureBox1_Click;
            f6.Width = 75;
            f6.Height = 110;
            f6.BackColor = Color.Black;

            int x6 = x5 + 75 + 10;
            int y6 = 12;
            f6.Location = new Point(x6, y6);

            panel1.Controls.Add(f6);    
            f6.BringToFront();



            PictureBox f7 = new PictureBox();
            f7.Click += pictureBox1_Click;
            f7.Width = 75;
            f7.Height = 110;
            f7.BackColor = Color.Black;

            int x7 = x;
            int y7 = y + 10 + 110;
                f7.Location = new Point(x7, y7);

            panel1.Controls.Add(f7);
            f7.BringToFront();


            PictureBox f8 = new PictureBox();
            f8.Click += pictureBox1_Click;
            f8.Width = 75;
            f8.Height = 110;
            f8.BackColor = Color.Black;

            int x8 = x7;
            int y8 = y7 + 10 + 110;
            f8.Location = new Point(x8, y8);

            panel1.Controls.Add(f8);
            f8.BringToFront();





            PictureBox f9 = new PictureBox();
            f9.Click += pictureBox1_Click;
            f9.Width = 75;
            f9.Height = 110;
            f9.BackColor = Color.Black;

            int x9 = x8;
            int y9 = y8 + 10 + 110;
            f9.Location = new Point(x9, y9);

            panel1.Controls.Add(f9);
            f9.BringToFront();


        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //string url = "https://m.media-amazon.com/images/I/71AgBFCTE4L._SY425_.jpg";

            //var request = WebRequest.Create(url);
            //using (var response = request.GetResponse())
            //using (var stream = response.GetResponseStream())
            //{
            //    pictureBox1.Image = Bitmap.FromStream(stream);
            //}
            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


        }

    
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo{FileName =
            //    "https/Go_TO_BookPage", 
            //    UseShellExecute = true});

          

        }
    }
}
