namespace Roteiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            Planner = new Button();
            Relatorios = new Button();
            Planilha = new Button();
            Projetinhos = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatAppearance.BorderColor = Color.Red;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(757, 57);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 1;
            panel1.MouseMove += panell_MouseDown;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.FlatAppearance.BorderColor = Color.Red;
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(665, 60);
            button4.Name = "button4";
            button4.Size = new Size(40, 40);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.FlatAppearance.BorderColor = Color.Red;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(711, 60);
            button3.Name = "button3";
            button3.Size = new Size(40, 40);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(177, 25);
            label1.TabIndex = 1;
            label1.Text = "PROJETO 2000";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Firebrick;
            panel2.Controls.Add(Planner);
            panel2.Controls.Add(Relatorios);
            panel2.Controls.Add(Planilha);
            panel2.Controls.Add(Projetinhos);
            panel2.Location = new Point(0, 99);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 352);
            panel2.TabIndex = 2;
            // 
            // Planner
            // 
            Planner.BackColor = Color.Transparent;
            Planner.FlatAppearance.BorderColor = Color.Red;
            Planner.FlatAppearance.BorderSize = 0;
            Planner.FlatAppearance.MouseDownBackColor = Color.White;
            Planner.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            Planner.FlatStyle = FlatStyle.Flat;
            Planner.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Planner.ForeColor = Color.Black;
            Planner.Image = Properties.Resources.icons8_planejador_32;
            Planner.ImageAlign = ContentAlignment.MiddleLeft;
            Planner.Location = new Point(5, 139);
            Planner.Name = "Planner";
            Planner.Size = new Size(184, 38);
            Planner.TabIndex = 3;
            Planner.Text = "Planner";
            Planner.UseVisualStyleBackColor = false;
            Planner.Click += Planner_Click;
            // 
            // Relatorios
            // 
            Relatorios.BackColor = Color.Transparent;
            Relatorios.FlatAppearance.BorderColor = Color.Red;
            Relatorios.FlatAppearance.BorderSize = 0;
            Relatorios.FlatAppearance.MouseDownBackColor = Color.White;
            Relatorios.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            Relatorios.FlatStyle = FlatStyle.Flat;
            Relatorios.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Relatorios.ForeColor = Color.Black;
            Relatorios.Image = Properties.Resources.icons8_relatório_32;
            Relatorios.ImageAlign = ContentAlignment.MiddleLeft;
            Relatorios.Location = new Point(5, 95);
            Relatorios.Name = "Relatorios";
            Relatorios.Size = new Size(184, 38);
            Relatorios.TabIndex = 2;
            Relatorios.Text = "Relatórios";
            Relatorios.UseVisualStyleBackColor = false;
            Relatorios.Click += Relatorios_Click;
            // 
            // Planilha
            // 
            Planilha.BackColor = Color.Transparent;
            Planilha.FlatAppearance.BorderColor = Color.Red;
            Planilha.FlatAppearance.BorderSize = 0;
            Planilha.FlatAppearance.MouseDownBackColor = Color.White;
            Planilha.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            Planilha.FlatStyle = FlatStyle.Flat;
            Planilha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Planilha.ForeColor = Color.Black;
            Planilha.Image = Properties.Resources.icons8_ms_excel_32;
            Planilha.ImageAlign = ContentAlignment.MiddleLeft;
            Planilha.Location = new Point(3, 51);
            Planilha.Name = "Planilha";
            Planilha.Size = new Size(184, 38);
            Planilha.TabIndex = 1;
            Planilha.Text = "Planilhas";
            Planilha.UseVisualStyleBackColor = false;
            Planilha.Click += Planilha_Click;
            // 
            // Projetinhos
            // 
            Projetinhos.BackColor = Color.Transparent;
            Projetinhos.FlatAppearance.BorderColor = Color.Red;
            Projetinhos.FlatAppearance.BorderSize = 0;
            Projetinhos.FlatAppearance.MouseDownBackColor = Color.White;
            Projetinhos.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            Projetinhos.FlatStyle = FlatStyle.Flat;
            Projetinhos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Projetinhos.ForeColor = Color.Black;
            Projetinhos.Image = (Image)resources.GetObject("Projetinhos.Image");
            Projetinhos.ImageAlign = ContentAlignment.MiddleLeft;
            Projetinhos.Location = new Point(3, 7);
            Projetinhos.Name = "Projetinhos";
            Projetinhos.Size = new Size(184, 38);
            Projetinhos.TabIndex = 0;
            Projetinhos.Text = "Projetinhos";
            Projetinhos.UseVisualStyleBackColor = false;
            Projetinhos.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.InactiveCaption;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button Projetinhos;
        private Button button3;
        private Button button4;
        private Button Planner;
        private Button Relatorios;
        private Button Planilha;
    }
}
