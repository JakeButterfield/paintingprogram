namespace Windows_Form_Demo
{
    partial class WindowsDemoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowsDemoForm));
            this.label_title = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DecoratingChoiceButton = new System.Windows.Forms.RadioButton();
            this.PaintingChoiceButton = new System.Windows.Forms.RadioButton();
            this.Input_BasePrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Input_WallAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Input_WallLength = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Input_WallHeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.Input_TotalPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(13, 13);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(385, 30);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Painting and Decorating Quote Form";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DecoratingChoiceButton);
            this.groupBox1.Controls.Add(this.PaintingChoiceButton);
            this.groupBox1.Location = new System.Drawing.Point(18, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 67);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose an option";
            // 
            // DecoratingChoiceButton
            // 
            this.DecoratingChoiceButton.AutoSize = true;
            this.DecoratingChoiceButton.Location = new System.Drawing.Point(124, 28);
            this.DecoratingChoiceButton.Name = "DecoratingChoiceButton";
            this.DecoratingChoiceButton.Size = new System.Drawing.Size(77, 17);
            this.DecoratingChoiceButton.TabIndex = 1;
            this.DecoratingChoiceButton.TabStop = true;
            this.DecoratingChoiceButton.Text = "Decoration";
            this.DecoratingChoiceButton.UseVisualStyleBackColor = true;
            this.DecoratingChoiceButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // PaintingChoiceButton
            // 
            this.PaintingChoiceButton.AutoSize = true;
            this.PaintingChoiceButton.Location = new System.Drawing.Point(21, 28);
            this.PaintingChoiceButton.Name = "PaintingChoiceButton";
            this.PaintingChoiceButton.Size = new System.Drawing.Size(63, 17);
            this.PaintingChoiceButton.TabIndex = 0;
            this.PaintingChoiceButton.TabStop = true;
            this.PaintingChoiceButton.Text = "Painting";
            this.PaintingChoiceButton.UseVisualStyleBackColor = true;
            this.PaintingChoiceButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Input_BasePrice
            // 
            this.Input_BasePrice.Location = new System.Drawing.Point(181, 399);
            this.Input_BasePrice.Name = "Input_BasePrice";
            this.Input_BasePrice.ReadOnly = true;
            this.Input_BasePrice.Size = new System.Drawing.Size(100, 20);
            this.Input_BasePrice.TabIndex = 2;
            this.Input_BasePrice.TextChanged += new System.EventHandler(this.Input_BasePrice_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Base Price";
            // 
            // Input_WallAmount
            // 
            this.Input_WallAmount.Location = new System.Drawing.Point(19, 241);
            this.Input_WallAmount.Name = "Input_WallAmount";
            this.Input_WallAmount.Size = new System.Drawing.Size(156, 20);
            this.Input_WallAmount.TabIndex = 4;
            this.Input_WallAmount.TextChanged += new System.EventHandler(this.Input_WallAmount_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "How many walls need painting?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Average length of each wall (metres):";
            // 
            // Input_WallLength
            // 
            this.Input_WallLength.Location = new System.Drawing.Point(19, 290);
            this.Input_WallLength.Name = "Input_WallLength";
            this.Input_WallLength.Size = new System.Drawing.Size(156, 20);
            this.Input_WallLength.TabIndex = 7;
            this.Input_WallLength.TextChanged += new System.EventHandler(this.Input_WallLength_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Average height of each wall (metres):";
            // 
            // Input_WallHeight
            // 
            this.Input_WallHeight.Location = new System.Drawing.Point(19, 341);
            this.Input_WallHeight.Name = "Input_WallHeight";
            this.Input_WallHeight.Size = new System.Drawing.Size(156, 20);
            this.Input_WallHeight.TabIndex = 9;
            this.Input_WallHeight.TextChanged += new System.EventHandler(this.Input_WallHeight_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Painting:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Location = new System.Drawing.Point(22, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 51);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paint Choice";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(189, 20);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(92, 17);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.Text = "Premium (£30)";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(98, 20);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(83, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.Text = "Glossy (£20)";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 20);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Normal (£10)";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total Price";
            // 
            // Input_TotalPrice
            // 
            this.Input_TotalPrice.Location = new System.Drawing.Point(290, 399);
            this.Input_TotalPrice.Name = "Input_TotalPrice";
            this.Input_TotalPrice.ReadOnly = true;
            this.Input_TotalPrice.Size = new System.Drawing.Size(100, 20);
            this.Input_TotalPrice.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 46);
            this.button1.TabIndex = 14;
            this.button1.Text = "Calculate Total";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton6);
            this.groupBox3.Location = new System.Drawing.Point(22, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(207, 51);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Have you bought your own wallpaper?";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(98, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(93, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "No (£30 each)";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Checked = true;
            this.radioButton6.Location = new System.Drawing.Point(7, 20);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(73, 17);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Yes (Free)";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(209, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // WindowsDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 437);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Input_TotalPrice);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Input_WallHeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Input_WallLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Input_WallAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Input_BasePrice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WindowsDemoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painting & Decorating Quote Form";
            this.Load += new System.EventHandler(this.WindowsDemoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton DecoratingChoiceButton;
        private System.Windows.Forms.RadioButton PaintingChoiceButton;
        private System.Windows.Forms.TextBox Input_BasePrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Input_WallAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Input_WallLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Input_WallHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Input_TotalPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

