namespace Library_Project
{
    partial class INFO_Livro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INFO_Livro));
            BNT_Voltar_ao_inicio = new Button();
            BNT_Reservar = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel3 = new Panel();
            button1 = new Button();
            panel4 = new Panel();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // BNT_Voltar_ao_inicio
            // 
            BNT_Voltar_ao_inicio.BackColor = Color.Transparent;
            BNT_Voltar_ao_inicio.BackgroundImageLayout = ImageLayout.Stretch;
            BNT_Voltar_ao_inicio.FlatStyle = FlatStyle.Popup;
            BNT_Voltar_ao_inicio.ForeColor = Color.FromArgb(9, 90, 162);
            BNT_Voltar_ao_inicio.Location = new Point(-66, -29);
            BNT_Voltar_ao_inicio.Name = "BNT_Voltar_ao_inicio";
            BNT_Voltar_ao_inicio.Size = new Size(792, 108);
            BNT_Voltar_ao_inicio.TabIndex = 0;
            BNT_Voltar_ao_inicio.UseVisualStyleBackColor = false;
            BNT_Voltar_ao_inicio.Click += BNT_Voltar_ao_inicio_Click;
            // 
            // BNT_Reservar
            // 
            BNT_Reservar.BackColor = Color.Transparent;
            BNT_Reservar.BackgroundImageLayout = ImageLayout.Stretch;
            BNT_Reservar.FlatStyle = FlatStyle.Popup;
            BNT_Reservar.ForeColor = Color.FromArgb(9, 90, 162);
            BNT_Reservar.Location = new Point(-23, -13);
            BNT_Reservar.Name = "BNT_Reservar";
            BNT_Reservar.Size = new Size(660, 53);
            BNT_Reservar.TabIndex = 1;
            BNT_Reservar.UseVisualStyleBackColor = false;
            BNT_Reservar.Click += BNT_Reservar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(BNT_Voltar_ao_inicio);
            panel1.Location = new Point(655, 825);
            panel1.Name = "panel1";
            panel1.Size = new Size(726, 37);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Location = new Point(679, 765);
            panel2.Name = "panel2";
            panel2.Size = new Size(674, 42);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Source Code Pro", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(142, 51);
            label1.TabIndex = 4;
            label1.Text = "label1";
            label1.Click += label1_Click_1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Location = new Point(674, 314);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(637, 304);
            flowLayoutPanel1.TabIndex = 5;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Source Code Pro", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 207, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(255, 91);
            label2.TabIndex = 6;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.Transparent;
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Location = new Point(674, 72);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(753, 109);
            flowLayoutPanel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(BNT_Reservar);
            panel3.Location = new Point(697, 637);
            panel3.Name = "panel3";
            panel3.Size = new Size(614, 35);
            panel3.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.FromArgb(9, 90, 162);
            button1.Location = new Point(-11, -5);
            button1.Name = "button1";
            button1.Size = new Size(671, 68);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(button1);
            panel4.Location = new Point(674, 683);
            panel4.Name = "panel4";
            panel4.Size = new Size(658, 48);
            panel4.TabIndex = 9;
            // 
            // INFO_Livro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1500, 758);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "INFO_Livro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button BNT_Voltar_ao_inicio;
        private Button BNT_Reservar;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel3;
        private Button button1;
        private Panel panel4;
    }
}
