
namespace EntitySample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnListGrade = new System.Windows.Forms.Button();
            this.BtnSaveStudent = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnFind = new System.Windows.Forms.Button();
            this.GrBoxStudents = new System.Windows.Forms.GroupBox();
            this.TxtStudentPhoto = new System.Windows.Forms.TextBox();
            this.TxtStudentId = new System.Windows.Forms.TextBox();
            this.TxtStudentName = new System.Windows.Forms.TextBox();
            this.TxtStudentSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GrBoxLessons = new System.Windows.Forms.GroupBox();
            this.TxtLessonId = new System.Windows.Forms.TextBox();
            this.TxtLessonName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GrBoxGrades = new System.Windows.Forms.GroupBox();
            this.BtnUpdateExGrade = new System.Windows.Forms.Button();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtGradeAverage = new System.Windows.Forms.TextBox();
            this.TxtExamGrade1 = new System.Windows.Forms.TextBox();
            this.TxtExamGrade2 = new System.Windows.Forms.TextBox();
            this.TxtExamGrade3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnStudentsList = new System.Windows.Forms.Button();
            this.BtnLessonsList = new System.Windows.Forms.Button();
            this.BtnProcedure = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.BtnDone = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GrBoxStudents.SuspendLayout();
            this.GrBoxLessons.SuspendLayout();
            this.GrBoxGrades.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 216);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnListGrade
            // 
            this.BtnListGrade.Location = new System.Drawing.Point(9, 397);
            this.BtnListGrade.Name = "BtnListGrade";
            this.BtnListGrade.Size = new System.Drawing.Size(118, 23);
            this.BtnListGrade.TabIndex = 1;
            this.BtnListGrade.Text = "GRADE LIST";
            this.BtnListGrade.UseVisualStyleBackColor = true;
            this.BtnListGrade.Click += new System.EventHandler(this.BtnListGrade_Click);
            // 
            // BtnSaveStudent
            // 
            this.BtnSaveStudent.Location = new System.Drawing.Point(9, 224);
            this.BtnSaveStudent.Name = "BtnSaveStudent";
            this.BtnSaveStudent.Size = new System.Drawing.Size(118, 23);
            this.BtnSaveStudent.TabIndex = 2;
            this.BtnSaveStudent.Text = "SAVE STUDENT";
            this.BtnSaveStudent.UseVisualStyleBackColor = true;
            this.BtnSaveStudent.Click += new System.EventHandler(this.BtnSaveStudent_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(9, 252);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(118, 23);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "DELETE";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(9, 281);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(118, 23);
            this.BtnUpdate.TabIndex = 4;
            this.BtnUpdate.Text = "UPDATE";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnFind
            // 
            this.BtnFind.Location = new System.Drawing.Point(9, 310);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(118, 23);
            this.BtnFind.TabIndex = 5;
            this.BtnFind.Text = "FIND";
            this.BtnFind.UseVisualStyleBackColor = true;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // GrBoxStudents
            // 
            this.GrBoxStudents.Controls.Add(this.TxtStudentPhoto);
            this.GrBoxStudents.Controls.Add(this.TxtStudentId);
            this.GrBoxStudents.Controls.Add(this.TxtStudentName);
            this.GrBoxStudents.Controls.Add(this.TxtStudentSurname);
            this.GrBoxStudents.Controls.Add(this.label4);
            this.GrBoxStudents.Controls.Add(this.label3);
            this.GrBoxStudents.Controls.Add(this.label2);
            this.GrBoxStudents.Controls.Add(this.label1);
            this.GrBoxStudents.Location = new System.Drawing.Point(147, 230);
            this.GrBoxStudents.Name = "GrBoxStudents";
            this.GrBoxStudents.Size = new System.Drawing.Size(232, 136);
            this.GrBoxStudents.TabIndex = 6;
            this.GrBoxStudents.TabStop = false;
            this.GrBoxStudents.Text = "Student";
            // 
            // TxtStudentPhoto
            // 
            this.TxtStudentPhoto.Location = new System.Drawing.Point(112, 102);
            this.TxtStudentPhoto.Name = "TxtStudentPhoto";
            this.TxtStudentPhoto.Size = new System.Drawing.Size(100, 20);
            this.TxtStudentPhoto.TabIndex = 23;
            // 
            // TxtStudentId
            // 
            this.TxtStudentId.Location = new System.Drawing.Point(112, 15);
            this.TxtStudentId.Name = "TxtStudentId";
            this.TxtStudentId.Size = new System.Drawing.Size(100, 20);
            this.TxtStudentId.TabIndex = 22;
            // 
            // TxtStudentName
            // 
            this.TxtStudentName.Location = new System.Drawing.Point(112, 44);
            this.TxtStudentName.Name = "TxtStudentName";
            this.TxtStudentName.Size = new System.Drawing.Size(100, 20);
            this.TxtStudentName.TabIndex = 21;
            this.TxtStudentName.TextChanged += new System.EventHandler(this.TxtStudentName_TextChanged);
            // 
            // TxtStudentSurname
            // 
            this.TxtStudentSurname.Location = new System.Drawing.Point(112, 73);
            this.TxtStudentSurname.Name = "TxtStudentSurname";
            this.TxtStudentSurname.Size = new System.Drawing.Size(100, 20);
            this.TxtStudentSurname.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "PHOTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "SURNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID";
            // 
            // GrBoxLessons
            // 
            this.GrBoxLessons.Controls.Add(this.TxtLessonId);
            this.GrBoxLessons.Controls.Add(this.TxtLessonName);
            this.GrBoxLessons.Controls.Add(this.label7);
            this.GrBoxLessons.Controls.Add(this.label8);
            this.GrBoxLessons.Location = new System.Drawing.Point(147, 372);
            this.GrBoxLessons.Name = "GrBoxLessons";
            this.GrBoxLessons.Size = new System.Drawing.Size(232, 136);
            this.GrBoxLessons.TabIndex = 24;
            this.GrBoxLessons.TabStop = false;
            this.GrBoxLessons.Text = "Lessons";
            // 
            // TxtLessonId
            // 
            this.TxtLessonId.Location = new System.Drawing.Point(112, 15);
            this.TxtLessonId.Name = "TxtLessonId";
            this.TxtLessonId.Size = new System.Drawing.Size(100, 20);
            this.TxtLessonId.TabIndex = 22;
            // 
            // TxtLessonName
            // 
            this.TxtLessonName.Location = new System.Drawing.Point(112, 44);
            this.TxtLessonName.Name = "TxtLessonName";
            this.TxtLessonName.Size = new System.Drawing.Size(100, 20);
            this.TxtLessonName.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "NAME";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "ID";
            // 
            // GrBoxGrades
            // 
            this.GrBoxGrades.Controls.Add(this.BtnUpdateExGrade);
            this.GrBoxGrades.Controls.Add(this.BtnCalculate);
            this.GrBoxGrades.Controls.Add(this.TxtResult);
            this.GrBoxGrades.Controls.Add(this.label5);
            this.GrBoxGrades.Controls.Add(this.TxtGradeAverage);
            this.GrBoxGrades.Controls.Add(this.TxtExamGrade1);
            this.GrBoxGrades.Controls.Add(this.TxtExamGrade2);
            this.GrBoxGrades.Controls.Add(this.TxtExamGrade3);
            this.GrBoxGrades.Controls.Add(this.label9);
            this.GrBoxGrades.Controls.Add(this.label10);
            this.GrBoxGrades.Controls.Add(this.label11);
            this.GrBoxGrades.Controls.Add(this.label12);
            this.GrBoxGrades.Location = new System.Drawing.Point(449, 230);
            this.GrBoxGrades.Name = "GrBoxGrades";
            this.GrBoxGrades.Size = new System.Drawing.Size(237, 243);
            this.GrBoxGrades.TabIndex = 25;
            this.GrBoxGrades.TabStop = false;
            this.GrBoxGrades.Text = "Grades";
            // 
            // BtnUpdateExGrade
            // 
            this.BtnUpdateExGrade.Location = new System.Drawing.Point(77, 188);
            this.BtnUpdateExGrade.Name = "BtnUpdateExGrade";
            this.BtnUpdateExGrade.Size = new System.Drawing.Size(135, 23);
            this.BtnUpdateExGrade.TabIndex = 29;
            this.BtnUpdateExGrade.Text = "UPDATE EX. GRADE";
            this.BtnUpdateExGrade.UseVisualStyleBackColor = true;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(112, 155);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(100, 23);
            this.BtnCalculate.TabIndex = 28;
            this.BtnCalculate.Text = "CALCULATE";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(112, 128);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(100, 20);
            this.TxtResult.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "RESULT";
            // 
            // TxtGradeAverage
            // 
            this.TxtGradeAverage.Location = new System.Drawing.Point(112, 102);
            this.TxtGradeAverage.Name = "TxtGradeAverage";
            this.TxtGradeAverage.Size = new System.Drawing.Size(100, 20);
            this.TxtGradeAverage.TabIndex = 23;
            // 
            // TxtExamGrade1
            // 
            this.TxtExamGrade1.Location = new System.Drawing.Point(112, 15);
            this.TxtExamGrade1.Name = "TxtExamGrade1";
            this.TxtExamGrade1.Size = new System.Drawing.Size(100, 20);
            this.TxtExamGrade1.TabIndex = 22;
            // 
            // TxtExamGrade2
            // 
            this.TxtExamGrade2.Location = new System.Drawing.Point(112, 44);
            this.TxtExamGrade2.Name = "TxtExamGrade2";
            this.TxtExamGrade2.Size = new System.Drawing.Size(100, 20);
            this.TxtExamGrade2.TabIndex = 21;
            // 
            // TxtExamGrade3
            // 
            this.TxtExamGrade3.Location = new System.Drawing.Point(112, 73);
            this.TxtExamGrade3.Name = "TxtExamGrade3";
            this.TxtExamGrade3.Size = new System.Drawing.Size(100, 20);
            this.TxtExamGrade3.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "GRADE AVERAGE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "EXAM 3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(60, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "EXAM 2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(60, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "EXAM 1";
            // 
            // BtnStudentsList
            // 
            this.BtnStudentsList.Location = new System.Drawing.Point(9, 339);
            this.BtnStudentsList.Name = "BtnStudentsList";
            this.BtnStudentsList.Size = new System.Drawing.Size(118, 23);
            this.BtnStudentsList.TabIndex = 26;
            this.BtnStudentsList.Text = "STUDENTS LIST";
            this.BtnStudentsList.UseVisualStyleBackColor = true;
            this.BtnStudentsList.Click += new System.EventHandler(this.BtnStudentsList_Click);
            // 
            // BtnLessonsList
            // 
            this.BtnLessonsList.Location = new System.Drawing.Point(9, 368);
            this.BtnLessonsList.Name = "BtnLessonsList";
            this.BtnLessonsList.Size = new System.Drawing.Size(118, 23);
            this.BtnLessonsList.TabIndex = 27;
            this.BtnLessonsList.Text = "LESSONS LIST";
            this.BtnLessonsList.UseVisualStyleBackColor = true;
            this.BtnLessonsList.Click += new System.EventHandler(this.BtnLessonsList_Click);
            // 
            // BtnProcedure
            // 
            this.BtnProcedure.Location = new System.Drawing.Point(9, 426);
            this.BtnProcedure.Name = "BtnProcedure";
            this.BtnProcedure.Size = new System.Drawing.Size(118, 23);
            this.BtnProcedure.TabIndex = 28;
            this.BtnProcedure.Text = "PROCEDURES";
            this.BtnProcedure.UseVisualStyleBackColor = true;
            this.BtnProcedure.Click += new System.EventHandler(this.BtnProcedure_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(787, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 17);
            this.radioButton1.TabIndex = 29;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "List to Name (A-Z)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // BtnDone
            // 
            this.BtnDone.Location = new System.Drawing.Point(796, 426);
            this.BtnDone.Name = "BtnDone";
            this.BtnDone.Size = new System.Drawing.Size(75, 23);
            this.BtnDone.TabIndex = 30;
            this.BtnDone.Text = "Done";
            this.BtnDone.UseVisualStyleBackColor = true;
            this.BtnDone.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(787, 55);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 17);
            this.radioButton2.TabIndex = 31;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "List to Name (Z-A)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(787, 91);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(53, 17);
            this.radioButton3.TabIndex = 32;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "First 3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(787, 130);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(71, 17);
            this.radioButton4.TabIndex = 33;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Find to ID";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(787, 166);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(115, 17);
            this.radioButton5.TabIndex = 34;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Names Start with A";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(787, 201);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(98, 17);
            this.radioButton6.TabIndex = 35;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Students Count";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(787, 230);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(119, 17);
            this.radioButton7.TabIndex = 36;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Exam 1 Total Grade";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(787, 258);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(135, 17);
            this.radioButton8.TabIndex = 37;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Exam 1 Average Grade";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(787, 287);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(98, 17);
            this.radioButton9.TabIndex = 38;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Passed Exam 1";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(787, 316);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(135, 17);
            this.radioButton10.TabIndex = 39;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Passed Exam 1(Way 2)";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 480);
            this.Controls.Add(this.radioButton10);
            this.Controls.Add(this.radioButton9);
            this.Controls.Add(this.radioButton8);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.BtnDone);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.BtnProcedure);
            this.Controls.Add(this.BtnLessonsList);
            this.Controls.Add(this.BtnStudentsList);
            this.Controls.Add(this.GrBoxGrades);
            this.Controls.Add(this.GrBoxLessons);
            this.Controls.Add(this.GrBoxStudents);
            this.Controls.Add(this.BtnFind);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSaveStudent);
            this.Controls.Add(this.BtnListGrade);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GrBoxStudents.ResumeLayout(false);
            this.GrBoxStudents.PerformLayout();
            this.GrBoxLessons.ResumeLayout(false);
            this.GrBoxLessons.PerformLayout();
            this.GrBoxGrades.ResumeLayout(false);
            this.GrBoxGrades.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnListGrade;
        private System.Windows.Forms.Button BtnSaveStudent;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.GroupBox GrBoxStudents;
        private System.Windows.Forms.TextBox TxtStudentPhoto;
        private System.Windows.Forms.TextBox TxtStudentId;
        private System.Windows.Forms.TextBox TxtStudentName;
        private System.Windows.Forms.TextBox TxtStudentSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GrBoxLessons;
        private System.Windows.Forms.TextBox TxtLessonId;
        private System.Windows.Forms.TextBox TxtLessonName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox GrBoxGrades;
        private System.Windows.Forms.TextBox TxtGradeAverage;
        private System.Windows.Forms.TextBox TxtExamGrade1;
        private System.Windows.Forms.TextBox TxtExamGrade2;
        private System.Windows.Forms.TextBox TxtExamGrade3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnStudentsList;
        private System.Windows.Forms.Button BtnLessonsList;
        private System.Windows.Forms.Button BtnUpdateExGrade;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnProcedure;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button BtnDone;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
    }
}

