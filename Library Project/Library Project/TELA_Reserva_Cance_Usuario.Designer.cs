namespace Library_Project
{
    partial class TELA_Reserva_Cance_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TELA_Reserva_Cance_Usuario));
            panel1 = new Panel();
            BNT_Voltar_pag_reserva = new Button();
            panel2 = new Panel();
            BNT_Voltar_catalogo_3 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(BNT_Voltar_pag_reserva);
            panel1.Location = new Point(128, 667);
            panel1.Name = "panel1";
            panel1.Size = new Size(572, 134);
            panel1.TabIndex = 0;
            // 
            // BNT_Voltar_pag_reserva
            // 
            BNT_Voltar_pag_reserva.FlatStyle = FlatStyle.Popup;
            BNT_Voltar_pag_reserva.Location = new Point(-25, -12);
            BNT_Voltar_pag_reserva.Name = "BNT_Voltar_pag_reserva";
            BNT_Voltar_pag_reserva.Size = new Size(625, 180);
            BNT_Voltar_pag_reserva.TabIndex = 3;
            BNT_Voltar_pag_reserva.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(BNT_Voltar_catalogo_3);
            panel2.Location = new Point(793, 751);
            panel2.Name = "panel2";
            panel2.Size = new Size(572, 54);
            panel2.TabIndex = 1;
            // 
            // BNT_Voltar_catalogo_3
            // 
            BNT_Voltar_catalogo_3.FlatStyle = FlatStyle.Popup;
            BNT_Voltar_catalogo_3.Location = new Point(-13, -21);
            BNT_Voltar_catalogo_3.Name = "BNT_Voltar_catalogo_3";
            BNT_Voltar_catalogo_3.Size = new Size(594, 105);
            BNT_Voltar_catalogo_3.TabIndex = 2;
            BNT_Voltar_catalogo_3.UseVisualStyleBackColor = true;
            // 
            // TELA_Reserva_Cance_Usuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1515, 775);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TELA_Reserva_Cance_Usuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TELA_Reserva_Cance_Usuario";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BNT_Voltar_pag_reserva;
        private Panel panel2;
        private Button BNT_Voltar_catalogo_3;
    }
}