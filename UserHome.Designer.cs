
namespace PrincipalPomodoro
{
    partial class UserHome
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelBack = new System.Windows.Forms.Panel();
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.lblTempo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnLong = new Guna.UI2.WinForms.Guna2Button();
            this.btnShort = new Guna.UI2.WinForms.Guna2Button();
            this.btnPomodoro = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(100)))), ((int)(((byte)(95)))));
            this.panelBack.Controls.Add(this.btnStart);
            this.panelBack.Controls.Add(this.lblTempo);
            this.panelBack.Controls.Add(this.btnLong);
            this.panelBack.Controls.Add(this.btnShort);
            this.panelBack.Controls.Add(this.btnPomodoro);
            this.panelBack.Location = new System.Drawing.Point(100, 131);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(366, 273);
            this.panelBack.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.BorderRadius = 5;
            this.btnStart.CheckedState.Parent = this.btnStart;
            this.btnStart.CustomImages.Parent = this.btnStart;
            this.btnStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStart.DisabledState.Parent = this.btnStart;
            this.btnStart.FillColor = System.Drawing.Color.White;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(82)))), ((int)(((byte)(77)))));
            this.btnStart.HoverState.Parent = this.btnStart;
            this.btnStart.Location = new System.Drawing.Point(94, 182);
            this.btnStart.Name = "btnStart";
            this.btnStart.ShadowDecoration.Parent = this.btnStart;
            this.btnStart.Size = new System.Drawing.Size(180, 45);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "INICIAR";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTempo
            // 
            this.lblTempo.BackColor = System.Drawing.Color.Transparent;
            this.lblTempo.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.ForeColor = System.Drawing.Color.White;
            this.lblTempo.Location = new System.Drawing.Point(53, 46);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(249, 130);
            this.lblTempo.TabIndex = 3;
            this.lblTempo.Text = "00:00";
            // 
            // btnLong
            // 
            this.btnLong.BackColor = System.Drawing.Color.Transparent;
            this.btnLong.CheckedState.Parent = this.btnLong;
            this.btnLong.CustomImages.Parent = this.btnLong;
            this.btnLong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLong.DisabledState.Parent = this.btnLong;
            this.btnLong.FillColor = System.Drawing.Color.Transparent;
            this.btnLong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLong.ForeColor = System.Drawing.Color.White;
            this.btnLong.HoverState.Parent = this.btnLong;
            this.btnLong.Location = new System.Drawing.Point(237, 3);
            this.btnLong.Name = "btnLong";
            this.btnLong.ShadowDecoration.Parent = this.btnLong;
            this.btnLong.Size = new System.Drawing.Size(126, 30);
            this.btnLong.TabIndex = 2;
            this.btnLong.Text = "Long";
            this.btnLong.Click += new System.EventHandler(this.btnLong_Click);
            // 
            // btnShort
            // 
            this.btnShort.BackColor = System.Drawing.Color.Transparent;
            this.btnShort.CheckedState.Parent = this.btnShort;
            this.btnShort.CustomImages.Parent = this.btnShort;
            this.btnShort.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShort.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShort.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShort.DisabledState.Parent = this.btnShort;
            this.btnShort.FillColor = System.Drawing.Color.Transparent;
            this.btnShort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShort.ForeColor = System.Drawing.Color.White;
            this.btnShort.HoverState.Parent = this.btnShort;
            this.btnShort.Location = new System.Drawing.Point(122, 3);
            this.btnShort.Name = "btnShort";
            this.btnShort.ShadowDecoration.Parent = this.btnShort;
            this.btnShort.Size = new System.Drawing.Size(113, 30);
            this.btnShort.TabIndex = 1;
            this.btnShort.Text = "Short";
            this.btnShort.Click += new System.EventHandler(this.btnShort_Click);
            // 
            // btnPomodoro
            // 
            this.btnPomodoro.BackColor = System.Drawing.Color.Transparent;
            this.btnPomodoro.CheckedState.Parent = this.btnPomodoro;
            this.btnPomodoro.CustomImages.Parent = this.btnPomodoro;
            this.btnPomodoro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPomodoro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPomodoro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPomodoro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPomodoro.DisabledState.Parent = this.btnPomodoro;
            this.btnPomodoro.FillColor = System.Drawing.Color.Transparent;
            this.btnPomodoro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPomodoro.ForeColor = System.Drawing.Color.White;
            this.btnPomodoro.HoverState.Parent = this.btnPomodoro;
            this.btnPomodoro.Location = new System.Drawing.Point(3, 3);
            this.btnPomodoro.Name = "btnPomodoro";
            this.btnPomodoro.ShadowDecoration.Parent = this.btnPomodoro;
            this.btnPomodoro.Size = new System.Drawing.Size(113, 30);
            this.btnPomodoro.TabIndex = 0;
            this.btnPomodoro.Text = "Pomodoro";
            this.btnPomodoro.Click += new System.EventHandler(this.btnPomodoro_Click);
            this.btnPomodoro.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPomodoro_MouseDown);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(161, 35);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(241, 67);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Pomodoro";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(82)))), ((int)(((byte)(77)))));
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.panelBack);
            this.Name = "UserHome";
            this.Size = new System.Drawing.Size(556, 450);
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBack;
        private Guna.UI2.WinForms.Guna2Button btnPomodoro;
        private Guna.UI2.WinForms.Guna2Button btnLong;
        private Guna.UI2.WinForms.Guna2Button btnShort;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnStart;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTempo;
        private System.Windows.Forms.Timer timer1;
    }
}
