namespace Project
{
    partial class UserControl4
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl4));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "card.png");
            // 
            // button22
            // 
            this.button22.Image = global::Project.Properties.Resources.ea26acc1_3a49_4aed_892b_50bba75403b6;
            this.button22.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button22.Location = new System.Drawing.Point(350, 23);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(132, 98);
            this.button22.TabIndex = 1;
            this.button22.Text = "ทะเบียนพนักงาน";
            this.button22.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button21
            // 
            this.button21.Image = global::Project.Properties.Resources.b542c83e_87b1_4a57_b6a5_1f508fa4aac0;
            this.button21.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button21.Location = new System.Drawing.Point(189, 23);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(132, 98);
            this.button21.TabIndex = 2;
            this.button21.Text = "รายงาน";
            this.button21.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button20
            // 
            this.button20.Image = global::Project.Properties.Resources._810c2e72_00b2_4292_9c1c_a8a7fca76225;
            this.button20.Location = new System.Drawing.Point(37, 23);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(132, 98);
            this.button20.TabIndex = 3;
            this.button20.Text = "ข้อมูลรายการอาหาร";
            this.button20.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // UserControl4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Name = "UserControl4";
            this.Size = new System.Drawing.Size(731, 206);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button20;
    }
}
