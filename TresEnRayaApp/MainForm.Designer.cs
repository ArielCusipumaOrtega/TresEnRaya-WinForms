namespace TresEnRayaApp
{
    partial class MainForm
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
            pnlSuperior = new Panel();
            lblTresEnRaya = new Label();
            lblTurno = new Label();
            pnlMarcador = new Panel();
            lblEmpates = new Label();
            lblScoreO = new Label();
            lblScoreX = new Label();
            pnlAcciones = new Panel();
            btnSalir = new Button();
            btnReiniciarMarcador = new Button();
            btnNuevaPartida = new Button();
            tlpTablero = new TableLayoutPanel();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            pnlSuperior.SuspendLayout();
            pnlMarcador.SuspendLayout();
            pnlAcciones.SuspendLayout();
            tlpTablero.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.FromArgb(233, 236, 239);
            pnlSuperior.Controls.Add(lblTresEnRaya);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(424, 60);
            pnlSuperior.TabIndex = 0;
            // 
            // lblTresEnRaya
            // 
            lblTresEnRaya.AutoSize = true;
            lblTresEnRaya.BackColor = Color.FromArgb(192, 255, 192);
            lblTresEnRaya.Font = new Font("Segoe UI", 22.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTresEnRaya.ForeColor = SystemColors.MenuHighlight;
            lblTresEnRaya.Location = new Point(121, 9);
            lblTresEnRaya.Name = "lblTresEnRaya";
            lblTresEnRaya.Size = new Size(193, 41);
            lblTresEnRaya.TabIndex = 0;
            lblTresEnRaya.Text = "Tres en Raya";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTurno.ForeColor = Color.FromArgb(15, 76, 129);
            lblTurno.Location = new Point(68, 61);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(167, 25);
            lblTurno.TabIndex = 0;
            lblTurno.Text = "Turno: Jugador X";
            lblTurno.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlMarcador
            // 
            pnlMarcador.Controls.Add(lblEmpates);
            pnlMarcador.Controls.Add(lblScoreO);
            pnlMarcador.Controls.Add(lblScoreX);
            pnlMarcador.Location = new Point(45, 395);
            pnlMarcador.Name = "pnlMarcador";
            pnlMarcador.Size = new Size(350, 45);
            pnlMarcador.TabIndex = 2;
            // 
            // lblEmpates
            // 
            lblEmpates.AutoSize = true;
            lblEmpates.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmpates.ForeColor = Color.FromArgb(73, 80, 87);
            lblEmpates.Location = new Point(238, 12);
            lblEmpates.Name = "lblEmpates";
            lblEmpates.Size = new Size(81, 19);
            lblEmpates.TabIndex = 2;
            lblEmpates.Text = "Empates: 0";
            // 
            // lblScoreO
            // 
            lblScoreO.AutoSize = true;
            lblScoreO.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblScoreO.ForeColor = Color.FromArgb(193, 18, 31);
            lblScoreO.Location = new Point(120, 11);
            lblScoreO.Name = "lblScoreO";
            lblScoreO.Size = new Size(95, 19);
            lblScoreO.TabIndex = 1;
            lblScoreO.Text = "Jugador O: 0";
            // 
            // lblScoreX
            // 
            lblScoreX.AutoSize = true;
            lblScoreX.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblScoreX.ForeColor = Color.FromArgb(27, 73, 101);
            lblScoreX.Location = new Point(2, 11);
            lblScoreX.Name = "lblScoreX";
            lblScoreX.Size = new Size(93, 19);
            lblScoreX.TabIndex = 0;
            lblScoreX.Text = "Jugador X: 0";
            // 
            // pnlAcciones
            // 
            pnlAcciones.Controls.Add(btnSalir);
            pnlAcciones.Controls.Add(btnReiniciarMarcador);
            pnlAcciones.Controls.Add(btnNuevaPartida);
            pnlAcciones.Location = new Point(45, 455);
            pnlAcciones.Name = "pnlAcciones";
            pnlAcciones.Size = new Size(350, 60);
            pnlAcciones.TabIndex = 3;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Tomato;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = SystemColors.InactiveBorder;
            btnSalir.Location = new Point(275, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(70, 38);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnReiniciarMarcador
            // 
            btnReiniciarMarcador.BackColor = Color.MediumSpringGreen;
            btnReiniciarMarcador.Cursor = Cursors.Hand;
            btnReiniciarMarcador.FlatStyle = FlatStyle.Flat;
            btnReiniciarMarcador.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReiniciarMarcador.ForeColor = SystemColors.MenuText;
            btnReiniciarMarcador.Location = new Point(139, 3);
            btnReiniciarMarcador.Name = "btnReiniciarMarcador";
            btnReiniciarMarcador.Size = new Size(130, 38);
            btnReiniciarMarcador.TabIndex = 1;
            btnReiniciarMarcador.Text = "Reiniciar Marcador";
            btnReiniciarMarcador.UseVisualStyleBackColor = false;
            btnReiniciarMarcador.Click += btnReiniciarMarcador_Click;
            // 
            // btnNuevaPartida
            // 
            btnNuevaPartida.BackColor = Color.MediumSpringGreen;
            btnNuevaPartida.Cursor = Cursors.Hand;
            btnNuevaPartida.FlatStyle = FlatStyle.Flat;
            btnNuevaPartida.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNuevaPartida.ForeColor = SystemColors.MenuText;
            btnNuevaPartida.Location = new Point(3, 3);
            btnNuevaPartida.Name = "btnNuevaPartida";
            btnNuevaPartida.Size = new Size(130, 38);
            btnNuevaPartida.TabIndex = 0;
            btnNuevaPartida.Text = "Nueva Partida";
            btnNuevaPartida.UseVisualStyleBackColor = false;
            btnNuevaPartida.Click += btnNuevaPartida_Click;
            // 
            // tlpTablero
            // 
            tlpTablero.ColumnCount = 3;
            tlpTablero.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpTablero.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpTablero.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpTablero.Controls.Add(btn9, 2, 2);
            tlpTablero.Controls.Add(btn8, 1, 2);
            tlpTablero.Controls.Add(btn7, 0, 2);
            tlpTablero.Controls.Add(btn6, 2, 1);
            tlpTablero.Controls.Add(btn5, 1, 1);
            tlpTablero.Controls.Add(btn4, 0, 1);
            tlpTablero.Controls.Add(btn3, 2, 0);
            tlpTablero.Controls.Add(btn2, 1, 0);
            tlpTablero.Controls.Add(btn1, 0, 0);
            tlpTablero.Location = new Point(68, 89);
            tlpTablero.Name = "tlpTablero";
            tlpTablero.RowCount = 3;
            tlpTablero.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpTablero.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpTablero.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpTablero.Size = new Size(300, 300);
            tlpTablero.TabIndex = 4;
            // 
            // btn9
            // 
            btn9.Cursor = Cursors.Hand;
            btn9.Dock = DockStyle.Fill;
            btn9.FlatAppearance.BorderColor = Color.FromArgb(206, 212, 218);
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            btn9.Location = new Point(204, 204);
            btn9.Margin = new Padding(4);
            btn9.Name = "btn9";
            btn9.Size = new Size(92, 92);
            btn9.TabIndex = 8;
            btn9.Tag = "8";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += BotonTablero_click;
            // 
            // btn8
            // 
            btn8.Cursor = Cursors.Hand;
            btn8.Dock = DockStyle.Fill;
            btn8.FlatAppearance.BorderColor = Color.FromArgb(206, 212, 218);
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            btn8.Location = new Point(104, 204);
            btn8.Margin = new Padding(4);
            btn8.Name = "btn8";
            btn8.Size = new Size(92, 92);
            btn8.TabIndex = 7;
            btn8.Tag = "7";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += BotonTablero_click;
            // 
            // btn7
            // 
            btn7.Cursor = Cursors.Hand;
            btn7.Dock = DockStyle.Fill;
            btn7.FlatAppearance.BorderColor = Color.FromArgb(206, 212, 218);
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            btn7.Location = new Point(4, 204);
            btn7.Margin = new Padding(4);
            btn7.Name = "btn7";
            btn7.Size = new Size(92, 92);
            btn7.TabIndex = 6;
            btn7.Tag = "6";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += BotonTablero_click;
            // 
            // btn6
            // 
            btn6.Cursor = Cursors.Hand;
            btn6.Dock = DockStyle.Fill;
            btn6.FlatAppearance.BorderColor = Color.FromArgb(206, 212, 218);
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            btn6.Location = new Point(204, 104);
            btn6.Margin = new Padding(4);
            btn6.Name = "btn6";
            btn6.Size = new Size(92, 92);
            btn6.TabIndex = 5;
            btn6.Tag = "5";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += BotonTablero_click;
            // 
            // btn5
            // 
            btn5.Cursor = Cursors.Hand;
            btn5.Dock = DockStyle.Fill;
            btn5.FlatAppearance.BorderColor = Color.FromArgb(206, 212, 218);
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            btn5.Location = new Point(104, 104);
            btn5.Margin = new Padding(4);
            btn5.Name = "btn5";
            btn5.Size = new Size(92, 92);
            btn5.TabIndex = 4;
            btn5.Tag = "4";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += BotonTablero_click;
            // 
            // btn4
            // 
            btn4.Cursor = Cursors.Hand;
            btn4.Dock = DockStyle.Fill;
            btn4.FlatAppearance.BorderColor = Color.FromArgb(206, 212, 218);
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            btn4.Location = new Point(4, 104);
            btn4.Margin = new Padding(4);
            btn4.Name = "btn4";
            btn4.Size = new Size(92, 92);
            btn4.TabIndex = 3;
            btn4.Tag = "3";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += BotonTablero_click;
            // 
            // btn3
            // 
            btn3.Cursor = Cursors.Hand;
            btn3.Dock = DockStyle.Fill;
            btn3.FlatAppearance.BorderColor = Color.FromArgb(206, 212, 218);
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            btn3.Location = new Point(204, 4);
            btn3.Margin = new Padding(4);
            btn3.Name = "btn3";
            btn3.Size = new Size(92, 92);
            btn3.TabIndex = 2;
            btn3.Tag = "2";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += BotonTablero_click;
            // 
            // btn2
            // 
            btn2.Cursor = Cursors.Hand;
            btn2.Dock = DockStyle.Fill;
            btn2.FlatAppearance.BorderColor = Color.FromArgb(206, 212, 218);
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            btn2.Location = new Point(104, 4);
            btn2.Margin = new Padding(4);
            btn2.Name = "btn2";
            btn2.Size = new Size(92, 92);
            btn2.TabIndex = 1;
            btn2.Tag = "1";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += BotonTablero_click;
            // 
            // btn1
            // 
            btn1.Cursor = Cursors.Hand;
            btn1.Dock = DockStyle.Fill;
            btn1.FlatAppearance.BorderColor = Color.FromArgb(206, 212, 218);
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            btn1.Location = new Point(4, 4);
            btn1.Margin = new Padding(4);
            btn1.Name = "btn1";
            btn1.Size = new Size(92, 92);
            btn1.TabIndex = 0;
            btn1.Tag = "0";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += BotonTablero_click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 512);
            Controls.Add(lblTurno);
            Controls.Add(tlpTablero);
            Controls.Add(pnlAcciones);
            Controls.Add(pnlMarcador);
            Controls.Add(pnlSuperior);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Juego Tres en Raya";
            pnlSuperior.ResumeLayout(false);
            pnlSuperior.PerformLayout();
            pnlMarcador.ResumeLayout(false);
            pnlMarcador.PerformLayout();
            pnlAcciones.ResumeLayout(false);
            tlpTablero.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSuperior;
        private Panel pnlMarcador;
        private Panel pnlAcciones;
        private Label lblTurno;
        private TableLayoutPanel tlpTablero;
        private Button btn1;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Label lblScoreO;
        private Label lblScoreX;
        private Label lblEmpates;
        private Button btnNuevaPartida;
        private Button btnReiniciarMarcador;
        private Button btnSalir;
        private Label lblTresEnRaya;
    }
}
