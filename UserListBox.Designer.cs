
namespace PrincipalPomodoro
{
    partial class UserListBox
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAddTask = new Guna.UI2.WinForms.Guna2Button();
            this.clbTasks = new System.Windows.Forms.CheckedListBox();
            this.txtTask = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRemoveTask = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(183, 39);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(167, 67);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "Tarefas";
            // 
            // btnAddTask
            // 
            this.btnAddTask.BorderRadius = 10;
            this.btnAddTask.CheckedState.Parent = this.btnAddTask;
            this.btnAddTask.CustomImages.Parent = this.btnAddTask;
            this.btnAddTask.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTask.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddTask.DisabledState.Parent = this.btnAddTask;
            this.btnAddTask.FillColor = System.Drawing.Color.White;
            this.btnAddTask.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(82)))), ((int)(((byte)(77)))));
            this.btnAddTask.HoverState.Parent = this.btnAddTask;
            this.btnAddTask.Location = new System.Drawing.Point(118, 353);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.ShadowDecoration.Parent = this.btnAddTask;
            this.btnAddTask.Size = new System.Drawing.Size(150, 45);
            this.btnAddTask.TabIndex = 5;
            this.btnAddTask.Text = "Adicionar";
            this.btnAddTask.Click += new System.EventHandler(this.btnTesti_Click);
            // 
            // clbTasks
            // 
            this.clbTasks.FormattingEnabled = true;
            this.clbTasks.Location = new System.Drawing.Point(84, 136);
            this.clbTasks.Name = "clbTasks";
            this.clbTasks.Size = new System.Drawing.Size(374, 169);
            this.clbTasks.TabIndex = 6;
            this.clbTasks.SelectedIndexChanged += new System.EventHandler(this.clbTasks_SelectedIndexChanged);
            // 
            // txtTask
            // 
            this.txtTask.BorderRadius = 5;
            this.txtTask.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTask.DefaultText = "Tarefa...";
            this.txtTask.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTask.DisabledState.Parent = this.txtTask;
            this.txtTask.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTask.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTask.FocusedState.Parent = this.txtTask;
            this.txtTask.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTask.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTask.HoverState.Parent = this.txtTask;
            this.txtTask.Location = new System.Drawing.Point(100, 311);
            this.txtTask.Name = "txtTask";
            this.txtTask.PasswordChar = '\0';
            this.txtTask.PlaceholderText = "";
            this.txtTask.SelectedText = "";
            this.txtTask.ShadowDecoration.Parent = this.txtTask;
            this.txtTask.Size = new System.Drawing.Size(345, 36);
            this.txtTask.TabIndex = 8;
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.BorderRadius = 10;
            this.btnRemoveTask.CheckedState.Parent = this.btnRemoveTask;
            this.btnRemoveTask.CustomImages.Parent = this.btnRemoveTask;
            this.btnRemoveTask.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveTask.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemoveTask.DisabledState.Parent = this.btnRemoveTask;
            this.btnRemoveTask.FillColor = System.Drawing.Color.White;
            this.btnRemoveTask.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(82)))), ((int)(((byte)(77)))));
            this.btnRemoveTask.HoverState.Parent = this.btnRemoveTask;
            this.btnRemoveTask.Location = new System.Drawing.Point(284, 353);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.ShadowDecoration.Parent = this.btnRemoveTask;
            this.btnRemoveTask.Size = new System.Drawing.Size(150, 45);
            this.btnRemoveTask.TabIndex = 9;
            this.btnRemoveTask.Text = "Remover";
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);
            // 
            // UserListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(82)))), ((int)(((byte)(77)))));
            this.Controls.Add(this.btnRemoveTask);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.clbTasks);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "UserListBox";
            this.Size = new System.Drawing.Size(556, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnAddTask;
        private System.Windows.Forms.CheckedListBox clbTasks;
        private Guna.UI2.WinForms.Guna2TextBox txtTask;
        private Guna.UI2.WinForms.Guna2Button btnRemoveTask;
    }
}
