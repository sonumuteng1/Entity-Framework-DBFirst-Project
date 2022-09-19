using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitySample
{
    public partial class Form1 : Form
    {

        DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnLessonsList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBLDERSLER.ToList();

            // if i don't want to see all columns of a database table, i can make that. 
            dataGridView1.Columns[2].Visible = false;
        }

        private void BtnStudentsList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBLOGRENCI.ToList();
            //if i dont want to see all columns which at the table exists. For ex 3 and 4
            // This is a way to make that.
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;

        }

        private void BtnListGrade_Click(object sender, EventArgs e)
        {
            //I dont want to see all columns which at the table exists. I can select the datas which i want to see
            // This is a way to make that.
            var query = from item in db.TBLNOTLAR
                        select new { 
                            //item.NOTID, 
                            item.TBLOGRENCI.AD,
                            item.TBLOGRENCI.SOYAD,
                            item.TBLDERSLER.DERSAD, 
                            item.SINAV1, 
                            item.SINAV2, 
                            item.SINAV3, 
                            item.ORTALAMA, 
                            item.DURUM 
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void BtnSaveStudent_Click(object sender, EventArgs e)
        {
            //to add a new student 
            TBLOGRENCI tblOgrenci = new TBLOGRENCI();
            tblOgrenci.AD = TxtStudentName.Text;
            tblOgrenci.SOYAD = TxtStudentSurname.Text;
            db.TBLOGRENCI.Add(tblOgrenci);
            db.SaveChanges();
            MessageBox.Show("You've added the student to the list");

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //To delete a student.
            int id = Convert.ToInt32(TxtStudentId.Text);
            var studenttodelete = db.TBLOGRENCI.Find(id);
            db.TBLOGRENCI.Remove(studenttodelete);
            db.SaveChanges();
            MessageBox.Show("You have deleted the student");

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtStudentId.Text);
            var student = db.TBLOGRENCI.Find(id);
            student.AD = TxtStudentName.Text;
            student.SOYAD = TxtStudentSurname.Text;
            student.FOTOGRAF = TxtStudentPhoto.Text;
            db.SaveChanges();
            MessageBox.Show("The Info of student has been updatet");

        }

        private void BtnProcedure_Click(object sender, EventArgs e)
        {
            //filling a table with a procedure
            dataGridView1.DataSource = db.NOTLIST().ToList();
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBLOGRENCI.Where(x => x.AD == TxtStudentName.Text | x.SOYAD==TxtStudentSurname.Text).ToList();
        }

        private void TxtStudentName_TextChanged(object sender, EventArgs e)
        {
            //Search something in db with lambda expressions
            string searchThis = TxtStudentName.Text;
            var results = from item in db.TBLOGRENCI
                          where item.AD.Contains(searchThis)
                          select item;
            dataGridView1.DataSource = results.ToList();

        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                List<TBLOGRENCI> liste1= db.TBLOGRENCI.OrderBy(x => x.AD).ToList();
                dataGridView1.DataSource = liste1;
            }
            if (radioButton2.Checked==true)
            {
                List<TBLOGRENCI> liste2=db.TBLOGRENCI.OrderByDescending(x => x.AD).ToList();
                dataGridView1.DataSource = liste2;
            }
            if (radioButton3.Checked==true)
            {
                List<TBLOGRENCI> liste3 = db.TBLOGRENCI.OrderBy(x => x.AD).Take(3).ToList();
                dataGridView1.DataSource = liste3;
            }
            if (radioButton4.Checked==true&&TxtStudentId.Text!=null)
            {
                int id = Convert.ToInt32(TxtStudentId.Text);
                var student = db.TBLOGRENCI.Where(x=>x.ID==id).ToList();
                dataGridView1.DataSource = student;
            }
            if (radioButton5.Checked==true)
            {
                var list5 = db.TBLOGRENCI.Where(x => x.AD.StartsWith("A")).ToList();
                dataGridView1.DataSource = list5;
            }
            if (radioButton6.Checked==true)
            {
                int totalStudentCount = db.TBLOGRENCI.Count();
                MessageBox.Show(totalStudentCount.ToString(),"Count of Students");
            }
            if (radioButton7.Checked==true)
            {
                int totalGradeExam1 = Convert.ToInt32(db.TBLNOTLAR.Sum(x => x.SINAV1));
                MessageBox.Show(totalGradeExam1.ToString(), "Totalgrade of Exam1");
            }
            if (radioButton8.Checked==true)
            {
                int averageGradeExam1 = Convert.ToInt32(db.TBLNOTLAR.Average(x => x.SINAV1));
                MessageBox.Show(averageGradeExam1.ToString(), "Totalgrade of Exam1");
            }
            if (radioButton9.Checked==true)
            {
                int averageGradeExam1 = Convert.ToInt32(db.TBLNOTLAR.Average(x => x.SINAV1));
                List<TBLNOTLAR> list9 = db.TBLNOTLAR.Where(x => x.SINAV1 > averageGradeExam1).ToList();
                //dataGridView1.DataSource = list9;

                var query = from item in list9
                            select new {item.TBLOGRENCI.AD,
                            item.TBLOGRENCI.SOYAD,
                            item.TBLDERSLER.DERSAD};
                dataGridView1.DataSource = query.OrderBy(x=>x.AD).ToList();
                 
            }
            if (radioButton10.Checked==true)
            {
                var query2 = from item1 in db.TBLNOTLAR
                             join item2 in db.TBLOGRENCI
                             on item1.OGR equals item2.ID
                             join item3 in db.TBLDERSLER
                             on item1.DERS equals item3.DERSID
                             select new
                             {
                                 student = item2.AD,
                                 lesson=item3.DERSAD,
                                 exam1 = item1.SINAV1,
                                 exam2 = item1.SINAV2
                             };
                dataGridView1.DataSource = query2.OrderBy(x=>x.student).ToList();

            }
        }
    }
}
