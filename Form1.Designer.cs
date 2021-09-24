namespace U2A1IDEISAC
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonConsultas = new System.Windows.Forms.Button();
            this.panelSubMenuPacientes = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonPacientes = new System.Windows.Forms.Button();
            this.panelSubMenuMedicos = new System.Windows.Forms.Panel();
            this.buttonModificarMedicos = new System.Windows.Forms.Button();
            this.buttonBajasMedicos = new System.Windows.Forms.Button();
            this.buttonAltasMedicos = new System.Windows.Forms.Button();
            this.buttonMedicos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelSubMenuPacientes.SuspendLayout();
            this.panelSubMenuMedicos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(207)))), ((int)(((byte)(201)))));
            this.panelMenu.Controls.Add(this.buttonConsultas);
            this.panelMenu.Controls.Add(this.panelSubMenuPacientes);
            this.panelMenu.Controls.Add(this.buttonPacientes);
            this.panelMenu.Controls.Add(this.panelSubMenuMedicos);
            this.panelMenu.Controls.Add(this.buttonMedicos);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 561);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonConsultas
            // 
            this.buttonConsultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(207)))), ((int)(((byte)(201)))));
            this.buttonConsultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonConsultas.FlatAppearance.BorderSize = 0;
            this.buttonConsultas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(167)))), ((int)(((byte)(161)))));
            this.buttonConsultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(181)))));
            this.buttonConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConsultas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultas.ForeColor = System.Drawing.Color.Black;
            this.buttonConsultas.Location = new System.Drawing.Point(0, 460);
            this.buttonConsultas.Name = "buttonConsultas";
            this.buttonConsultas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonConsultas.Size = new System.Drawing.Size(200, 45);
            this.buttonConsultas.TabIndex = 3;
            this.buttonConsultas.Text = "Consultas";
            this.buttonConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConsultas.UseVisualStyleBackColor = false;
            this.buttonConsultas.Click += new System.EventHandler(this.buttonConsultas_Click);
            // 
            // panelSubMenuPacientes
            // 
            this.panelSubMenuPacientes.Controls.Add(this.button3);
            this.panelSubMenuPacientes.Controls.Add(this.button2);
            this.panelSubMenuPacientes.Controls.Add(this.button1);
            this.panelSubMenuPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuPacientes.Location = new System.Drawing.Point(0, 325);
            this.panelSubMenuPacientes.Name = "panelSubMenuPacientes";
            this.panelSubMenuPacientes.Size = new System.Drawing.Size(200, 135);
            this.panelSubMenuPacientes.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DimGray;
            this.button3.Location = new System.Drawing.Point(0, 90);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(200, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = "Modificar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.Location = new System.Drawing.Point(0, 45);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(200, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Bajas";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(200, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Altas";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPacientes
            // 
            this.buttonPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(207)))), ((int)(((byte)(201)))));
            this.buttonPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPacientes.FlatAppearance.BorderSize = 0;
            this.buttonPacientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(167)))), ((int)(((byte)(161)))));
            this.buttonPacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(181)))));
            this.buttonPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPacientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPacientes.ForeColor = System.Drawing.Color.Black;
            this.buttonPacientes.Location = new System.Drawing.Point(0, 280);
            this.buttonPacientes.Name = "buttonPacientes";
            this.buttonPacientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonPacientes.Size = new System.Drawing.Size(200, 45);
            this.buttonPacientes.TabIndex = 2;
            this.buttonPacientes.Text = "Pacientes";
            this.buttonPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPacientes.UseVisualStyleBackColor = false;
            this.buttonPacientes.Click += new System.EventHandler(this.buttonPacientes_Click);
            // 
            // panelSubMenuMedicos
            // 
            this.panelSubMenuMedicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubMenuMedicos.Controls.Add(this.buttonModificarMedicos);
            this.panelSubMenuMedicos.Controls.Add(this.buttonBajasMedicos);
            this.panelSubMenuMedicos.Controls.Add(this.buttonAltasMedicos);
            this.panelSubMenuMedicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuMedicos.Location = new System.Drawing.Point(0, 145);
            this.panelSubMenuMedicos.Name = "panelSubMenuMedicos";
            this.panelSubMenuMedicos.Size = new System.Drawing.Size(200, 135);
            this.panelSubMenuMedicos.TabIndex = 1;
            // 
            // buttonModificarMedicos
            // 
            this.buttonModificarMedicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.buttonModificarMedicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonModificarMedicos.FlatAppearance.BorderSize = 0;
            this.buttonModificarMedicos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.buttonModificarMedicos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.buttonModificarMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificarMedicos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificarMedicos.ForeColor = System.Drawing.Color.DimGray;
            this.buttonModificarMedicos.Location = new System.Drawing.Point(0, 90);
            this.buttonModificarMedicos.Name = "buttonModificarMedicos";
            this.buttonModificarMedicos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonModificarMedicos.Size = new System.Drawing.Size(200, 45);
            this.buttonModificarMedicos.TabIndex = 2;
            this.buttonModificarMedicos.Text = "Modificar";
            this.buttonModificarMedicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModificarMedicos.UseVisualStyleBackColor = false;
            this.buttonModificarMedicos.Click += new System.EventHandler(this.buttonModificarMedicos_Click);
            // 
            // buttonBajasMedicos
            // 
            this.buttonBajasMedicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.buttonBajasMedicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBajasMedicos.FlatAppearance.BorderSize = 0;
            this.buttonBajasMedicos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.buttonBajasMedicos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.buttonBajasMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBajasMedicos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBajasMedicos.ForeColor = System.Drawing.Color.DimGray;
            this.buttonBajasMedicos.Location = new System.Drawing.Point(0, 45);
            this.buttonBajasMedicos.Name = "buttonBajasMedicos";
            this.buttonBajasMedicos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonBajasMedicos.Size = new System.Drawing.Size(200, 45);
            this.buttonBajasMedicos.TabIndex = 1;
            this.buttonBajasMedicos.Text = "Bajas";
            this.buttonBajasMedicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBajasMedicos.UseVisualStyleBackColor = false;
            this.buttonBajasMedicos.Click += new System.EventHandler(this.buttonBajasMedicos_Click);
            // 
            // buttonAltasMedicos
            // 
            this.buttonAltasMedicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.buttonAltasMedicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAltasMedicos.FlatAppearance.BorderSize = 0;
            this.buttonAltasMedicos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.buttonAltasMedicos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.buttonAltasMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAltasMedicos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAltasMedicos.ForeColor = System.Drawing.Color.DimGray;
            this.buttonAltasMedicos.Location = new System.Drawing.Point(0, 0);
            this.buttonAltasMedicos.Name = "buttonAltasMedicos";
            this.buttonAltasMedicos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonAltasMedicos.Size = new System.Drawing.Size(200, 45);
            this.buttonAltasMedicos.TabIndex = 0;
            this.buttonAltasMedicos.Text = "Altas";
            this.buttonAltasMedicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAltasMedicos.UseVisualStyleBackColor = false;
            this.buttonAltasMedicos.Click += new System.EventHandler(this.buttonAltasMedicos_Click);
            // 
            // buttonMedicos
            // 
            this.buttonMedicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(207)))), ((int)(((byte)(201)))));
            this.buttonMedicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMedicos.FlatAppearance.BorderSize = 0;
            this.buttonMedicos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(167)))), ((int)(((byte)(161)))));
            this.buttonMedicos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(181)))));
            this.buttonMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMedicos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMedicos.ForeColor = System.Drawing.Color.Black;
            this.buttonMedicos.Location = new System.Drawing.Point(0, 100);
            this.buttonMedicos.Name = "buttonMedicos";
            this.buttonMedicos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonMedicos.Size = new System.Drawing.Size(200, 45);
            this.buttonMedicos.TabIndex = 1;
            this.buttonMedicos.Text = "Médicos";
            this.buttonMedicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMedicos.UseVisualStyleBackColor = false;
            this.buttonMedicos.Click += new System.EventHandler(this.buttonMedicos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(110)))), ((int)(((byte)(144)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Complementaria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Actividad";
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(200, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(734, 561);
            this.panelChildForm.TabIndex = 1;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Paciente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelSubMenuPacientes.ResumeLayout(false);
            this.panelSubMenuMedicos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSubMenuMedicos;
        private System.Windows.Forms.Button buttonMedicos;
        private System.Windows.Forms.Button buttonModificarMedicos;
        private System.Windows.Forms.Button buttonBajasMedicos;
        private System.Windows.Forms.Button buttonAltasMedicos;
        private System.Windows.Forms.Button buttonPacientes;
        private System.Windows.Forms.Panel panelSubMenuPacientes;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonConsultas;
        private System.Windows.Forms.Panel panelChildForm;
    }
}

