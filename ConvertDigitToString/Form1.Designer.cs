namespace ConvertDigitToString
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
            label1 = new Label();
            txt_input = new TextBox();
            groupBox1 = new GroupBox();
            richText_output = new RichTextBox();
            BTN_Run = new Button();
            BTN_Reset = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 26);
            label1.Name = "label1";
            label1.Size = new Size(160, 19);
            label1.TabIndex = 0;
            label1.Text = "Nhập vào số nguyên N";
            // 
            // txt_input
            // 
            txt_input.Location = new Point(298, 26);
            txt_input.Name = "txt_input";
            txt_input.Size = new Size(100, 23);
            txt_input.TabIndex = 1;
            txt_input.KeyPress += txt_input_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richText_output);
            groupBox1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.Highlight;
            groupBox1.Location = new Point(22, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(376, 125);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kết quả đọc số";
            // 
            // richText_output
            // 
            richText_output.ForeColor = Color.Red;
            richText_output.Location = new Point(6, 22);
            richText_output.Name = "richText_output";
            richText_output.ReadOnly = true;
            richText_output.Size = new Size(364, 96);
            richText_output.TabIndex = 0;
            richText_output.Text = "";
            // 
            // BTN_Run
            // 
            BTN_Run.Location = new Point(169, 217);
            BTN_Run.Name = "BTN_Run";
            BTN_Run.Size = new Size(75, 23);
            BTN_Run.TabIndex = 3;
            BTN_Run.Text = "Thực hiện";
            BTN_Run.UseVisualStyleBackColor = true;
            BTN_Run.Click += BTN_Run_Click;
            // 
            // BTN_Reset
            // 
            BTN_Reset.Location = new Point(323, 217);
            BTN_Reset.Name = "BTN_Reset";
            BTN_Reset.Size = new Size(75, 23);
            BTN_Reset.TabIndex = 4;
            BTN_Reset.Text = "Xoá";
            BTN_Reset.UseVisualStyleBackColor = true;
            BTN_Reset.Click += BTN_Reset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 254);
            Controls.Add(BTN_Reset);
            Controls.Add(BTN_Run);
            Controls.Add(groupBox1);
            Controls.Add(txt_input);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_input;
        private GroupBox groupBox1;
        private RichTextBox richText_output;
        private Button BTN_Run;
        private Button BTN_Reset;
    }
}