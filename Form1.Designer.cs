
namespace PrincipalPomodoro
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLado = new System.Windows.Forms.Panel();
            this.btnTask = new Guna.UI2.WinForms.Guna2Button();
            this.btnCronometro = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.tTempo = new System.Windows.Forms.Timer(this.components);
            this.userCronometro1 = new PrincipalPomodoro.UserCronometro();
            this.userHome1 = new PrincipalPomodoro.UserHome();
            this.userListBox1 = new PrincipalPomodoro.UserListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.guna2HtmlLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panelLado);
            this.panel1.Controls.Add(this.btnTask);
            this.panel1.Controls.Add(this.btnCronometro);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(22, 81);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(158, 23);
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.Text = "Iago Antunes Ferreira";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panelLado
            // 
            this.panelLado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(82)))), ((int)(((byte)(77)))));
            this.panelLado.Location = new System.Drawing.Point(0, 139);
            this.panelLado.Name = "panelLado";
            this.panelLado.Size = new System.Drawing.Size(11, 45);
            this.panelLado.TabIndex = 3;
            // 
            // btnTask
            // 
            this.btnTask.CheckedState.Parent = this.btnTask;
            this.btnTask.CustomImages.Parent = this.btnTask;
            this.btnTask.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTask.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTask.DisabledState.Parent = this.btnTask;
            this.btnTask.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnTask.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTask.ForeColor = System.Drawing.Color.White;
            this.btnTask.HoverState.Parent = this.btnTask;
            this.btnTask.Location = new System.Drawing.Point(-3, 241);
            this.btnTask.Name = "btnTask";
            this.btnTask.ShadowDecoration.Parent = this.btnTask;
            this.btnTask.Size = new System.Drawing.Size(200, 45);
            this.btnTask.TabIndex = 2;
            this.btnTask.Text = "Tarefas";
            this.btnTask.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // btnCronometro
            // 
            this.btnCronometro.CheckedState.Parent = this.btnCronometro;
            this.btnCronometro.CustomImages.Parent = this.btnCronometro;
            this.btnCronometro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCronometro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCronometro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCronometro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCronometro.DisabledState.Parent = this.btnCronometro;
            this.btnCronometro.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnCronometro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCronometro.ForeColor = System.Drawing.Color.White;
            this.btnCronometro.HoverState.Parent = this.btnCronometro;
            this.btnCronometro.Location = new System.Drawing.Point(0, 190);
            this.btnCronometro.Name = "btnCronometro";
            this.btnCronometro.ShadowDecoration.Parent = this.btnCronometro;
            this.btnCronometro.Size = new System.Drawing.Size(197, 45);
            this.btnCronometro.TabIndex = 1;
            this.btnCronometro.Text = "Cronometro";
            this.btnCronometro.Click += new System.EventHandler(this.btnCronometro_Click);
            // 
            // btnHome
            // 
            this.btnHome.CheckedState.Parent = this.btnHome;
            this.btnHome.CustomImages.Parent = this.btnHome;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.DisabledState.Parent = this.btnHome;
            this.btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.Location = new System.Drawing.Point(0, 139);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(197, 45);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // userCronometro1
            // 
            this.userCronometro1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(82)))), ((int)(((byte)(77)))));
            this.userCronometro1.Location = new System.Drawing.Point(196, 0);
            this.userCronometro1.Name = "userCronometro1";
            this.userCronometro1.Size = new System.Drawing.Size(573, 489);
            this.userCronometro1.TabIndex = 2;
            // 
            // userHome1
            // 
            this.userHome1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(82)))), ((int)(((byte)(77)))));
            this.userHome1.Location = new System.Drawing.Point(196, 0);
            this.userHome1.Name = "userHome1";
            this.userHome1.Size = new System.Drawing.Size(573, 489);
            this.userHome1.TabIndex = 1;
            // 
            // userListBox1
            // 
            this.userListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(82)))), ((int)(((byte)(77)))));
            this.userListBox1.Location = new System.Drawing.Point(196, 0);
            this.userListBox1.Name = "userListBox1";
            this.userListBox1.Size = new System.Drawing.Size(562, 450);
            this.userListBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(82)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.userListBox1);
            this.Controls.Add(this.userCronometro1);
            this.Controls.Add(this.userHome1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLado;
        private Guna.UI2.WinForms.Guna2Button btnTask;
        private Guna.UI2.WinForms.Guna2Button btnCronometro;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private System.Windows.Forms.Timer tTempo;
        private UserHome userHome1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private UserCronometro userCronometro1;
        private UserListBox userListBox1;
    }
}

