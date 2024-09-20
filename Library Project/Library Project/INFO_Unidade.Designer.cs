namespace Library_Project
{
    partial class INFO_Unidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INFO_Unidade));
            BNT_Confirmar_Unidade = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label3 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label4 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // BNT_Confirmar_Unidade
            // 
            BNT_Confirmar_Unidade.BackColor = Color.Transparent;
            BNT_Confirmar_Unidade.BackgroundImageLayout = ImageLayout.Stretch;
            BNT_Confirmar_Unidade.FlatStyle = FlatStyle.Popup;
            BNT_Confirmar_Unidade.ForeColor = Color.FromArgb(9, 90, 162);
            BNT_Confirmar_Unidade.Location = new Point(-36, -15);
            BNT_Confirmar_Unidade.Name = "BNT_Confirmar_Unidade";
            BNT_Confirmar_Unidade.Size = new Size(792, 108);
            BNT_Confirmar_Unidade.TabIndex = 1;
            BNT_Confirmar_Unidade.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(BNT_Confirmar_Unidade);
            panel1.Location = new Point(820, 742);
            panel1.Name = "panel1";
            panel1.Size = new Size(605, 60);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Source Code Pro", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(185, 67);
            label1.TabIndex = 3;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Source Code Pro", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(135, 80);
            label2.Name = "label2";
            label2.Size = new Size(0, 121);
            label2.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Location = new Point(821, 71);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(704, 88);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Source Code Pro", 25.8000011F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(255, 207, 0);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(185, 67);
            label3.TabIndex = 10;
            label3.Text = "label3";
            label3.Click += label3_Click_1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.Transparent;
            flowLayoutPanel2.Controls.Add(label3);
            flowLayoutPanel2.Location = new Point(141, 71);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(632, 121);
            flowLayoutPanel2.TabIndex = 4;
            flowLayoutPanel2.Paint += flowLayoutPanel2_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Source Code Pro", 19.8000011F);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(142, 51);
            label4.TabIndex = 10;
            label4.Text = "label4";
            label4.Click += label4_Click;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoScroll = true;
            flowLayoutPanel3.BackColor = Color.Transparent;
            flowLayoutPanel3.Controls.Add(label4);
            flowLayoutPanel3.Location = new Point(824, 334);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(577, 257);
            flowLayoutPanel3.TabIndex = 11;
            // 
            // INFO_Unidade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1478, 707);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "INFO_Unidade";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += INFO_Unidade_Load;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BNT_Confirmar_Unidade;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel3;
    }
}