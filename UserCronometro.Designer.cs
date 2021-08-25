
namespace PrincipalPomodoro
{
    partial class UserCronometro
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
            this.lblTempo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnIniCronometro = new Guna.UI2.WinForms.Guna2Button();
            this.btnDimiCrono = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinutosCrono = new Guna.UI2.WinForms.Guna2Button();
            this.btnSegundosCrono = new Guna.UI2.WinForms.Guna2Button();
            this.panelBack = new System.Windows.Forms.Panel();
            this.btnAumentCrono = new Guna.UI2.WinForms.Guna2Button();
            this.lblTempoCrono = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timerCronometro = new System.Windows.Forms.Timer(this.components);
            this.panelBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTempo
            // 
            this.lblTempo.BackColor = System.Drawing.Color.Transparent;
            this.lblTempo.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.ForeColor = System.Drawing.Color.White;
            this.lblTempo.Location = new System.Drawing.Point(22, 36);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(249, 130);
            this.lblTempo.TabIndex = 3;
            this.lblTempo.Text = "00:00";
            // 
            // btnIniCronometro
            // 
            this.btnIniCronometro.BorderRadius = 5;
            this.btnIniCronometro.CheckedState.Parent = this.btnIniCronometro;
            this.btnIniCronometro.CustomImages.Parent = this.btnIniCronometro;
            this.btnIniCronometro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIniCronometro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIniCronometro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIniCronometro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIniCronometro.DisabledState.Parent = this.btnIniCronometro;
            this.btnIniCronometro.FillColor = System.Drawing.Color.White;
            this.btnIniCronometro.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniCronometro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(82)))), ((int)(((byte)(77)))));
            this.btnIniCronometro.HoverState.Parent = this.btnIniCronometro;
            this.btnIniCronometro.Location = new System.Drawing.Point(61, 182);
            this.btnIniCronometro.Name = "btnIniCronometro";
            this.btnIniCronometro.ShadowDecoration.Parent = this.btnIniCronometro;
            this.btnIniCronometro.Size = new System.Drawing.Size(180, 45);
            this.btnIniCronometro.TabIndex = 5;
            this.btnIniCronometro.Text = "INICIAR";
            this.btnIniCronometro.Click += new System.EventHandler(this.btnIniCronometro_Click);
            // 
            // btnDimiCrono
            // 
            this.btnDimiCrono.BorderRadius = 13;
            this.btnDimiCrono.CheckedState.Parent = this.btnDimiCrono;
            this.btnDimiCrono.CustomImages.Parent = this.btnDimiCrono;
            this.btnDimiCrono.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDimiCrono.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDimiCrono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDimiCrono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDimiCrono.DisabledState.Parent = this.btnDimiCrono;
            this.btnDimiCrono.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(82)))), ((int)(((byte)(77)))));
            this.btnDimiCrono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDimiCrono.ForeColor = System.Drawing.Color.White;
            this.btnDimiCrono.HoverState.Parent = this.btnDimiCrono;
            this.btnDimiCrono.Location = new System.Drawing.Point(290, 131);
            this.btnDimiCrono.Name = "btnDimiCrono";
            this.btnDimiCrono.ShadowDecoration.Parent = this.btnDimiCrono;
            this.btnDimiCrono.Size = new System.Drawing.Size(55, 45);
            this.btnDimiCrono.TabIndex = 8;
            this.btnDimiCrono.Text = "v";
            this.btnDimiCrono.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnMinutosCrono
            // 
            this.btnMinutosCrono.BackColor = System.Drawing.Color.Transparent;
            this.btnMinutosCrono.CheckedState.Parent = this.btnMinutosCrono;
            this.btnMinutosCrono.CustomImages.Parent = this.btnMinutosCrono;
            this.btnMinutosCrono.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinutosCrono.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinutosCrono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinutosCrono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinutosCrono.DisabledState.Parent = this.btnMinutosCrono;
            this.btnMinutosCrono.FillColor = System.Drawing.Color.Transparent;
            this.btnMinutosCrono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnMinutosCrono.ForeColor = System.Drawing.Color.White;
            this.btnMinutosCrono.HoverState.Parent = this.btnMinutosCrono;
            this.btnMinutosCrono.Location = new System.Drawing.Point(41, 3);
            this.btnMinutosCrono.Name = "btnMinutosCrono";
            this.btnMinutosCrono.ShadowDecoration.Parent = this.btnMinutosCrono;
            this.btnMinutosCrono.Size = new System.Drawing.Size(113, 30);
            this.btnMinutosCrono.TabIndex = 10;
            this.btnMinutosCrono.Text = "Minutos";
            this.btnMinutosCrono.Click += new System.EventHandler(this.btnMinutosCrono_Click);
            // 
            // btnSegundosCrono
            // 
            this.btnSegundosCrono.BackColor = System.Drawing.Color.Transparent;
            this.btnSegundosCrono.CheckedState.Parent = this.btnSegundosCrono;
            this.btnSegundosCrono.CustomImages.Parent = this.btnSegundosCrono;
            this.btnSegundosCrono.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSegundosCrono.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSegundosCrono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSegundosCrono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSegundosCrono.DisabledState.Parent = this.btnSegundosCrono;
            this.btnSegundosCrono.FillColor = System.Drawing.Color.Transparent;
            this.btnSegundosCrono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSegundosCrono.ForeColor = System.Drawing.Color.White;
            this.btnSegundosCrono.HoverState.Parent = this.btnSegundosCrono;
            this.btnSegundosCrono.Location = new System.Drawing.Point(181, 3);
            this.btnSegundosCrono.Name = "btnSegundosCrono";
            this.btnSegundosCrono.ShadowDecoration.Parent = this.btnSegundosCrono;
            this.btnSegundosCrono.Size = new System.Drawing.Size(113, 30);
            this.btnSegundosCrono.TabIndex = 11;
            this.btnSegundosCrono.Text = "Segundos";
            this.btnSegundosCrono.Click += new System.EventHandler(this.btnSegundosCrono_Click);
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(100)))), ((int)(((byte)(95)))));
            this.panelBack.Controls.Add(this.btnAumentCrono);
            this.panelBack.Controls.Add(this.lblTempoCrono);
            this.panelBack.Controls.Add(this.btnSegundosCrono);
            this.panelBack.Controls.Add(this.btnMinutosCrono);
            this.panelBack.Controls.Add(this.btnDimiCrono);
            this.panelBack.Controls.Add(this.btnIniCronometro);
            this.panelBack.Location = new System.Drawing.Point(102, 133);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(366, 273);
            this.panelBack.TabIndex = 2;
            // 
            // btnAumentCrono
            // 
            this.btnAumentCrono.BorderRadius = 13;
            this.btnAumentCrono.CheckedState.Parent = this.btnAumentCrono;
            this.btnAumentCrono.CustomImages.Parent = this.btnAumentCrono;
            this.btnAumentCrono.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAumentCrono.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAumentCrono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAumentCrono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAumentCrono.DisabledState.Parent = this.btnAumentCrono;
            this.btnAumentCrono.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(82)))), ((int)(((byte)(77)))));
            this.btnAumentCrono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAumentCrono.ForeColor = System.Drawing.Color.White;
            this.btnAumentCrono.HoverState.Parent = this.btnAumentCrono;
            this.btnAumentCrono.Location = new System.Drawing.Point(290, 68);
            this.btnAumentCrono.Name = "btnAumentCrono";
            this.btnAumentCrono.ShadowDecoration.Parent = this.btnAumentCrono;
            this.btnAumentCrono.Size = new System.Drawing.Size(55, 45);
            this.btnAumentCrono.TabIndex = 13;
            this.btnAumentCrono.Text = "^";
            this.btnAumentCrono.Click += new System.EventHandler(this.btnAumentCrono_Click);
            // 
            // lblTempoCrono
            // 
            this.lblTempoCrono.BackColor = System.Drawing.Color.Transparent;
            this.lblTempoCrono.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoCrono.ForeColor = System.Drawing.Color.White;
            this.lblTempoCrono.Location = new System.Drawing.Point(35, 46);
            this.lblTempoCrono.Name = "lblTempoCrono";
            this.lblTempoCrono.Size = new System.Drawing.Size(249, 130);
            this.lblTempoCrono.TabIndex = 12;
            this.lblTempoCrono.Text = "00:00";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(143, 36);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(276, 67);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "Cronometro";
            // 
            // timerCronometro
            // 
            this.timerCronometro.Interval = 1000;
            this.timerCronometro.Tick += new System.EventHandler(this.timerCronometro_Tick);
            // 
            // UserCronometro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(82)))), ((int)(((byte)(77)))));
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.panelBack);
            this.Name = "UserCronometro";
            this.Size = new System.Drawing.Size(556, 450);
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTempo;
        private Guna.UI2.WinForms.Guna2Button btnIniCronometro;
        private Guna.UI2.WinForms.Guna2Button btnDimiCrono;
        private Guna.UI2.WinForms.Guna2Button btnMinutosCrono;
        private Guna.UI2.WinForms.Guna2Button btnSegundosCrono;
        private System.Windows.Forms.Panel panelBack;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTempoCrono;
        private System.Windows.Forms.Timer timerCronometro;
        private Guna.UI2.WinForms.Guna2Button btnAumentCrono;
    }
}
