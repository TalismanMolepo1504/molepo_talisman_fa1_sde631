namespace ProgrammingLanguages
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            label1 = new Label();
            listBox2 = new ListBox();
            textBox1 = new TextBox();
            addBtn = new Button();
            removeBtn = new Button();
            removeMessage = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.ForeColor = Color.Transparent;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(70, 38);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(675, 379);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(271, 90);
            label1.Name = "label1";
            label1.Size = new Size(245, 20);
            label1.TabIndex = 1;
            label1.Text = "My Favourite Programming Languages";
            // 
            // listBox2
            // 
            listBox2.ForeColor = Color.Transparent;
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(142, 113);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(559, 169);
            listBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.ForeColor = SystemColors.ControlDarkDark;
            textBox1.Location = new Point(145, 303);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(556, 25);
            textBox1.TabIndex = 3;
            textBox1.Text = "Enter Programming Language";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // addBtn
            // 
            addBtn.BackColor = SystemColors.HotTrack;
            addBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBtn.ForeColor = Color.White;
            addBtn.Location = new Point(145, 334);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(120, 37);
            addBtn.TabIndex = 4;
            addBtn.Text = "Add Language";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // removeBtn
            // 
            removeBtn.BackColor = Color.Red;
            removeBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            removeBtn.ForeColor = Color.White;
            removeBtn.Location = new Point(271, 334);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(110, 37);
            removeBtn.TabIndex = 5;
            removeBtn.Text = "Remove";
            removeBtn.UseVisualStyleBackColor = false;
            removeBtn.Click += removeBtn_Click;
            // 
            // removeMessage
            // 
            removeMessage.AutoSize = true;
            removeMessage.Location = new Point(151, 384);
            removeMessage.Name = "removeMessage";
            removeMessage.Size = new Size(0, 15);
            removeMessage.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(removeMessage);
            Controls.Add(removeBtn);
            Controls.Add(addBtn);
            Controls.Add(textBox1);
            Controls.Add(listBox2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Favourite Programming Languages";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private ListBox listBox2;
        private TextBox textBox1;
        private Button addBtn;
        private Button removeBtn;
        private Label removeMessage;
    }
}
