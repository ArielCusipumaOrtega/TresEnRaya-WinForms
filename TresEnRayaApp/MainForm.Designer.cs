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
            lblSubtitulo = new Label();
            lblTresEnRaya = new Label();
            pnlTurno = new Panel();
            lblTurno = new Label();
            tlpTablero = new TableLayoutPanel();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            pnlMarcador = new Panel();
            lblScoreO = new Label();
            lblEmpates = new Label();
            lblScoreX = new Label();
            pnlModo = new Panel();
            rbContraIA = new RadioButton();
            rbVsJugador = new RadioButton();
            pnlAcciones = new Panel();
            btnSalir = new Button();
            btnReiniciarMarcador = new Button();
            btnNuevaPartida = new Button();
            pnlSuperior.SuspendLayout();
            pnlTurno.SuspendLayout();
            tlpTablero.SuspendLayout();
            pnlMarcador.SuspendLayout();
            pnlModo.SuspendLayout();
            pnlAcciones.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.FromArgb(30, 41, 59);
            pnlSuperior.Controls.Add(lblSubtitulo);
            pnlSuperior.Controls.Add(lblTresEnRaya);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(450, 70);
            pnlSuperior.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Segoe UI", 8.5F);
            lblSubtitulo.ForeColor = Color.FromArgb(148, 163, 184);
            lblSubtitulo.Location = new Point(0, 42);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(450, 18);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Minimax AI Engine • .NET 10";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTresEnRaya
            // 
            lblTresEnRaya.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTresEnRaya.ForeColor = Color.FromArgb(248, 250, 252);
            lblTresEnRaya.Location = new Point(0, 10);
            lblTresEnRaya.Name = "lblTresEnRaya";
            lblTresEnRaya.Size = new Size(450, 32);
            lblTresEnRaya.TabIndex = 0;
            lblTresEnRaya.Text = "🎮  T R E S   E N   R A Y A";
            lblTresEnRaya.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTurno
            // 
            pnlTurno.BackColor = Color.FromArgb(30, 41, 59);
            pnlTurno.Controls.Add(lblTurno);
            pnlTurno.Location = new Point(35, 84);
            pnlTurno.Name = "pnlTurno";
            pnlTurno.Size = new Size(380, 42);
            pnlTurno.TabIndex = 1;
            // 
            // lblTurno
            // 
            lblTurno.Dock = DockStyle.Fill;
            lblTurno.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTurno.ForeColor = Color.FromArgb(56, 189, 248);
            lblTurno.Location = new Point(0, 0);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(380, 42);
            lblTurno.TabIndex = 0;
            lblTurno.Text = "Turno: Jugador X";
            lblTurno.TextAlign = ContentAlignment.MiddleCenter;
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
            tlpTablero.Location = new Point(69, 138);
            tlpTablero.Name = "tlpTablero";
            tlpTablero.RowCount = 3;
            tlpTablero.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpTablero.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpTablero.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpTablero.Size = new Size(312, 312);
            tlpTablero.TabIndex = 2;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(30, 41, 59);
            btn1.Cursor = Cursors.Hand;
            btn1.Dock = DockStyle.Fill;
            btn1.FlatAppearance.BorderColor = Color.FromArgb(51, 65, 85);
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            btn1.ForeColor = Color.FromArgb(248, 250, 252);
            btn1.Location = new Point(4, 4);
            btn1.Margin = new Padding(4);
            btn1.Name = "btn1";
            btn1.Size = new Size(96, 96);
            btn1.TabIndex = 0;
            btn1.Tag = "0";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += BotonTablero_click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(30, 41, 59);
            btn2.Cursor = Cursors.Hand;
            btn2.Dock = DockStyle.Fill;
            btn2.FlatAppearance.BorderColor = Color.FromArgb(51, 65, 85);
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            btn2.ForeColor = Color.FromArgb(248, 250, 252);
            btn2.Location = new Point(108, 4);
            btn2.Margin = new Padding(4);
            btn2.Name = "btn2";
            btn2.Size = new Size(96, 96);
            btn2.TabIndex = 1;
            btn2.Tag = "1";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += BotonTablero_click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(30, 41, 59);
            btn3.Cursor = Cursors.Hand;
            btn3.Dock = DockStyle.Fill;
            btn3.FlatAppearance.BorderColor = Color.FromArgb(51, 65, 85);
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            btn3.ForeColor = Color.FromArgb(248, 250, 252);
            btn3.Location = new Point(212, 4);
            btn3.Margin = new Padding(4);
            btn3.Name = "btn3";
            btn3.Size = new Size(96, 96);
            btn3.TabIndex = 2;
            btn3.Tag = "2";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += BotonTablero_click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(30, 41, 59);
            btn4.Cursor = Cursors.Hand;
            btn4.Dock = DockStyle.Fill;
            btn4.FlatAppearance.BorderColor = Color.FromArgb(51, 65, 85);
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            btn4.ForeColor = Color.FromArgb(248, 250, 252);
            btn4.Location = new Point(4, 108);
            btn4.Margin = new Padding(4);
            btn4.Name = "btn4";
            btn4.Size = new Size(96, 96);
            btn4.TabIndex = 3;
            btn4.Tag = "3";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += BotonTablero_click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(30, 41, 59);
            btn5.Cursor = Cursors.Hand;
            btn5.Dock = DockStyle.Fill;
            btn5.FlatAppearance.BorderColor = Color.FromArgb(51, 65, 85);
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            btn5.ForeColor = Color.FromArgb(248, 250, 252);
            btn5.Location = new Point(108, 108);
            btn5.Margin = new Padding(4);
            btn5.Name = "btn5";
            btn5.Size = new Size(96, 96);
            btn5.TabIndex = 4;
            btn5.Tag = "4";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += BotonTablero_click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(30, 41, 59);
            btn6.Cursor = Cursors.Hand;
            btn6.Dock = DockStyle.Fill;
            btn6.FlatAppearance.BorderColor = Color.FromArgb(51, 65, 85);
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            btn6.ForeColor = Color.FromArgb(248, 250, 252);
            btn6.Location = new Point(212, 108);
            btn6.Margin = new Padding(4);
            btn6.Name = "btn6";
            btn6.Size = new Size(96, 96);
            btn6.TabIndex = 5;
            btn6.Tag = "5";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += BotonTablero_click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(30, 41, 59);
            btn7.Cursor = Cursors.Hand;
            btn7.Dock = DockStyle.Fill;
            btn7.FlatAppearance.BorderColor = Color.FromArgb(51, 65, 85);
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            btn7.ForeColor = Color.FromArgb(248, 250, 252);
            btn7.Location = new Point(4, 212);
            btn7.Margin = new Padding(4);
            btn7.Name = "btn7";
            btn7.Size = new Size(96, 96);
            btn7.TabIndex = 6;
            btn7.Tag = "6";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += BotonTablero_click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(30, 41, 59);
            btn8.Cursor = Cursors.Hand;
            btn8.Dock = DockStyle.Fill;
            btn8.FlatAppearance.BorderColor = Color.FromArgb(51, 65, 85);
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            btn8.ForeColor = Color.FromArgb(248, 250, 252);
            btn8.Location = new Point(108, 212);
            btn8.Margin = new Padding(4);
            btn8.Name = "btn8";
            btn8.Size = new Size(96, 96);
            btn8.TabIndex = 7;
            btn8.Tag = "7";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += BotonTablero_click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(30, 41, 59);
            btn9.Cursor = Cursors.Hand;
            btn9.Dock = DockStyle.Fill;
            btn9.FlatAppearance.BorderColor = Color.FromArgb(51, 65, 85);
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            btn9.ForeColor = Color.FromArgb(248, 250, 252);
            btn9.Location = new Point(212, 212);
            btn9.Margin = new Padding(4);
            btn9.Name = "btn9";
            btn9.Size = new Size(96, 96);
            btn9.TabIndex = 8;
            btn9.Tag = "8";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += BotonTablero_click;
            // 
            // pnlMarcador
            // 
            pnlMarcador.BackColor = Color.FromArgb(30, 41, 59);
            pnlMarcador.Controls.Add(lblScoreO);
            pnlMarcador.Controls.Add(lblEmpates);
            pnlMarcador.Controls.Add(lblScoreX);
            pnlMarcador.Location = new Point(35, 462);
            pnlMarcador.Name = "pnlMarcador";
            pnlMarcador.Size = new Size(380, 42);
            pnlMarcador.TabIndex = 3;
            // 
            // lblScoreO
            // 
            lblScoreO.BackColor = Color.FromArgb(15, 23, 42);
            lblScoreO.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblScoreO.ForeColor = Color.FromArgb(244, 63, 94);
            lblScoreO.Location = new Point(255, 6);
            lblScoreO.Name = "lblScoreO";
            lblScoreO.Size = new Size(115, 30);
            lblScoreO.TabIndex = 2;
            lblScoreO.Text = "Jugador O: 0";
            lblScoreO.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmpates
            // 
            lblEmpates.BackColor = Color.FromArgb(15, 23, 42);
            lblEmpates.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblEmpates.ForeColor = Color.FromArgb(148, 163, 184);
            lblEmpates.Location = new Point(133, 6);
            lblEmpates.Name = "lblEmpates";
            lblEmpates.Size = new Size(114, 30);
            lblEmpates.TabIndex = 1;
            lblEmpates.Text = "Empates: 0";
            lblEmpates.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblScoreX
            // 
            lblScoreX.BackColor = Color.FromArgb(15, 23, 42);
            lblScoreX.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblScoreX.ForeColor = Color.FromArgb(56, 189, 248);
            lblScoreX.Location = new Point(10, 6);
            lblScoreX.Name = "lblScoreX";
            lblScoreX.Size = new Size(115, 30);
            lblScoreX.TabIndex = 0;
            lblScoreX.Text = "Jugador X: 0";
            lblScoreX.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlModo
            // 
            pnlModo.BackColor = Color.FromArgb(30, 41, 59);
            pnlModo.Controls.Add(rbContraIA);
            pnlModo.Controls.Add(rbVsJugador);
            pnlModo.Location = new Point(35, 514);
            pnlModo.Name = "pnlModo";
            pnlModo.Size = new Size(380, 36);
            pnlModo.TabIndex = 4;
            // 
            // rbContraIA
            // 
            rbContraIA.AutoSize = true;
            rbContraIA.Checked = true;
            rbContraIA.Cursor = Cursors.Hand;
            rbContraIA.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            rbContraIA.ForeColor = Color.FromArgb(226, 232, 240);
            rbContraIA.Location = new Point(45, 8);
            rbContraIA.Name = "rbContraIA";
            rbContraIA.Size = new Size(106, 21);
            rbContraIA.TabIndex = 0;
            rbContraIA.TabStop = true;
            rbContraIA.Text = "🤖 Contra IA";
            rbContraIA.UseVisualStyleBackColor = true;
            rbContraIA.CheckedChanged += ModoJuego_CheckedChanged;
            // 
            // rbVsJugador
            // 
            rbVsJugador.AutoSize = true;
            rbVsJugador.Cursor = Cursors.Hand;
            rbVsJugador.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            rbVsJugador.ForeColor = Color.FromArgb(226, 232, 240);
            rbVsJugador.Location = new Point(215, 8);
            rbVsJugador.Name = "rbVsJugador";
            rbVsJugador.Size = new Size(122, 21);
            rbVsJugador.TabIndex = 1;
            rbVsJugador.Text = "👥 2 Jugadores";
            rbVsJugador.UseVisualStyleBackColor = true;
            rbVsJugador.CheckedChanged += ModoJuego_CheckedChanged;
            // 
            // pnlAcciones
            // 
            pnlAcciones.BackColor = Color.Transparent;
            pnlAcciones.Controls.Add(btnSalir);
            pnlAcciones.Controls.Add(btnReiniciarMarcador);
            pnlAcciones.Controls.Add(btnNuevaPartida);
            pnlAcciones.Location = new Point(35, 560);
            pnlAcciones.Name = "pnlAcciones";
            pnlAcciones.Size = new Size(380, 44);
            pnlAcciones.TabIndex = 5;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(153, 27, 27);
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(254, 202, 202);
            btnSalir.Location = new Point(305, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 40);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "✖ Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnReiniciarMarcador
            // 
            btnReiniciarMarcador.BackColor = Color.FromArgb(51, 65, 85);
            btnReiniciarMarcador.Cursor = Cursors.Hand;
            btnReiniciarMarcador.FlatAppearance.BorderSize = 0;
            btnReiniciarMarcador.FlatStyle = FlatStyle.Flat;
            btnReiniciarMarcador.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnReiniciarMarcador.ForeColor = Color.FromArgb(241, 245, 249);
            btnReiniciarMarcador.Location = new Point(140, 2);
            btnReiniciarMarcador.Name = "btnReiniciarMarcador";
            btnReiniciarMarcador.Size = new Size(155, 40);
            btnReiniciarMarcador.TabIndex = 1;
            btnReiniciarMarcador.Text = "⏱ Reiniciar Marcador";
            btnReiniciarMarcador.UseVisualStyleBackColor = false;
            btnReiniciarMarcador.Click += btnReiniciarMarcador_Click;
            // 
            // btnNuevaPartida
            // 
            btnNuevaPartida.BackColor = Color.FromArgb(2, 132, 199);
            btnNuevaPartida.Cursor = Cursors.Hand;
            btnNuevaPartida.FlatAppearance.BorderSize = 0;
            btnNuevaPartida.FlatStyle = FlatStyle.Flat;
            btnNuevaPartida.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNuevaPartida.ForeColor = Color.White;
            btnNuevaPartida.Location = new Point(0, 2);
            btnNuevaPartida.Name = "btnNuevaPartida";
            btnNuevaPartida.Size = new Size(130, 40);
            btnNuevaPartida.TabIndex = 0;
            btnNuevaPartida.Text = "🔄 Nueva Partida";
            btnNuevaPartida.UseVisualStyleBackColor = false;
            btnNuevaPartida.Click += btnNuevaPartida_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(450, 630);
            Controls.Add(pnlAcciones);
            Controls.Add(pnlModo);
            Controls.Add(pnlMarcador);
            Controls.Add(tlpTablero);
            Controls.Add(pnlTurno);
            Controls.Add(pnlSuperior);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tres en Raya - Minimax AI";
            pnlSuperior.ResumeLayout(false);
            pnlTurno.ResumeLayout(false);
            tlpTablero.ResumeLayout(false);
            pnlMarcador.ResumeLayout(false);
            pnlModo.ResumeLayout(false);
            pnlModo.PerformLayout();
            pnlAcciones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSuperior;
        private Label lblSubtitulo;
        private Label lblTresEnRaya;
        private Panel pnlTurno;
        private Label lblTurno;
        private TableLayoutPanel tlpTablero;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Panel pnlMarcador;
        private Label lblScoreX;
        private Label lblEmpates;
        private Label lblScoreO;
        private Panel pnlModo;
        private RadioButton rbContraIA;
        private RadioButton rbVsJugador;
        private Panel pnlAcciones;
        private Button btnNuevaPartida;
        private Button btnReiniciarMarcador;
        private Button btnSalir;
    }
}
