namespace Project
{
    partial class Orderfood
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button18 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(202, 79);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "ค้นหารายการอาหาร";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(14, 111);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(399, 175);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "อาหาร";
            this.columnHeader1.Width = 238;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "จำนวน";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ราคา";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 80;
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.White;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(14, 322);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(400, 175);
            this.listView2.TabIndex = 7;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "เครื่องดื่ม";
            this.columnHeader4.Width = 238;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "จำนวน";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ราคา";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 80;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(273, 296);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(140, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(15, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "รวม 0 รายการ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(274, 505);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(140, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(15, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "รวม 0 รายการ";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 535);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 40);
            this.button4.TabIndex = 10;
            this.button4.Text = "จำนวน";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(98, 535);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 40);
            this.button5.TabIndex = 10;
            this.button5.Text = "ย้ายรายการ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(178, 535);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 40);
            this.button6.TabIndex = 10;
            this.button6.Text = "ปรับปรุง";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(258, 535);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 40);
            this.button7.TabIndex = 10;
            this.button7.Text = "ห่อกลับ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(338, 535);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 40);
            this.button8.TabIndex = 10;
            this.button8.Text = "ลบ";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(18, 600);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(126, 40);
            this.button9.TabIndex = 10;
            this.button9.Text = "ชำระ";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(150, 600);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(264, 40);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "0";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Location = new System.Drawing.Point(420, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 81);
            this.panel1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(622, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "ถัดไป >>>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(502, 14);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(108, 52);
            this.button14.TabIndex = 0;
            this.button14.Text = "หอย";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(381, 13);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(108, 52);
            this.button13.TabIndex = 0;
            this.button13.Text = "ปู";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(261, 13);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(108, 52);
            this.button12.TabIndex = 0;
            this.button12.Text = "ปลา";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(141, 13);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(108, 52);
            this.button11.TabIndex = 0;
            this.button11.Text = "กุ้ง";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(21, 13);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(108, 52);
            this.button10.TabIndex = 0;
            this.button10.Text = "แนะนำ";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button19);
            this.flowLayoutPanel1.Controls.Add(this.button20);
            this.flowLayoutPanel1.Controls.Add(this.button21);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 11);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(727, 341);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(3, 3);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(138, 50);
            this.button19.TabIndex = 0;
            this.button19.Text = "ข้าวกะเพรา";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Visible = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(147, 3);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(138, 50);
            this.button20.TabIndex = 0;
            this.button20.Text = "ข้าวผัด";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Visible = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(291, 3);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(138, 50);
            this.button21.TabIndex = 0;
            this.button21.Text = "น้ำแข็ง";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Visible = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button17);
            this.panel2.Controls.Add(this.button16);
            this.panel2.Controls.Add(this.button15);
            this.panel2.Location = new System.Drawing.Point(420, 535);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(752, 105);
            this.panel2.TabIndex = 14;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(492, 55);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(116, 35);
            this.button17.TabIndex = 0;
            this.button17.Text = "ยกเลิกการขาย";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(614, 55);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(116, 35);
            this.button16.TabIndex = 0;
            this.button16.Text = "บันทึก";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(614, 14);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(116, 35);
            this.button15.TabIndex = 0;
            this.button15.Text = "พิมพ์ใบเรียกเก็บเงิน";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1030, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "00:00:00";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Location = new System.Drawing.Point(419, 169);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(753, 360);
            this.panel3.TabIndex = 16;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(280, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "จำนวนลูกค้า :  ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button18);
            this.panel4.Controls.Add(this.button22);
            this.panel4.Controls.Add(this.button23);
            this.panel4.Controls.Add(this.button24);
            this.panel4.Controls.Add(this.button25);
            this.panel4.Controls.Add(this.button26);
            this.panel4.Location = new System.Drawing.Point(420, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(752, 81);
            this.panel4.TabIndex = 12;
            this.panel4.Visible = false;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(622, 13);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(108, 52);
            this.button18.TabIndex = 0;
            this.button18.Text = "ถัดไป >>>";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(502, 14);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(108, 52);
            this.button22.TabIndex = 0;
            this.button22.Text = "ผัด";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(381, 13);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(108, 52);
            this.button23.TabIndex = 0;
            this.button23.Text = "ตำ / ยำ";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(261, 13);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(108, 52);
            this.button24.TabIndex = 0;
            this.button24.Text = "ต้ม";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(141, 13);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(108, 52);
            this.button25.TabIndex = 0;
            this.button25.Text = "ปลาหมึก";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(21, 13);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(108, 52);
            this.button26.TabIndex = 0;
            this.button26.Text = "<< ย้อนกลับ";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button29);
            this.panel5.Controls.Add(this.button30);
            this.panel5.Controls.Add(this.button31);
            this.panel5.Controls.Add(this.button32);
            this.panel5.Location = new System.Drawing.Point(420, 79);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(752, 81);
            this.panel5.TabIndex = 12;
            this.panel5.Visible = false;
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(381, 13);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(108, 52);
            this.button29.TabIndex = 0;
            this.button29.Text = "เครื่องดื่ม";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(261, 13);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(108, 52);
            this.button30.TabIndex = 0;
            this.button30.Text = "อาหารจานด่วน";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(141, 13);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(108, 52);
            this.button31.TabIndex = 0;
            this.button31.Text = "ทอด / กินเล่น";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(21, 13);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(108, 52);
            this.button32.TabIndex = 0;
            this.button32.Text = "<< ย้อนกลับ";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Project.Properties.Resources._6bf64ac2_e2d4_44a4_a594_81f0dd793ad2;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(15, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 61);
            this.button2.TabIndex = 5;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1184, 661);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Orderfood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Orderfood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "สั่งรายการอาหาร";
            this.Load += new System.EventHandler(this.Orderfood_Load);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Timer timer2;
    }
}