namespace WindowsFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tituloT = new System.Windows.Forms.TextBox();
            this.descripcionT = new System.Windows.Forms.TextBox();
            this.agregar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.cargar = new System.Windows.Forms.Button();
            this.marcarTarea = new System.Windows.Forms.Button();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustesDeInterfazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarColorDeFondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarTamañoDeFuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Tareas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titulo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(360, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción:";
            // 
            // tituloT
            // 
            this.tituloT.BackColor = System.Drawing.Color.Azure;
            this.tituloT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tituloT.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloT.Location = new System.Drawing.Point(79, 90);
            this.tituloT.Name = "tituloT";
            this.tituloT.Size = new System.Drawing.Size(275, 28);
            this.tituloT.TabIndex = 3;
            // 
            // descripcionT
            // 
            this.descripcionT.BackColor = System.Drawing.Color.Azure;
            this.descripcionT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descripcionT.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionT.Location = new System.Drawing.Point(482, 90);
            this.descripcionT.Name = "descripcionT";
            this.descripcionT.Size = new System.Drawing.Size(333, 28);
            this.descripcionT.TabIndex = 4;
            // 
            // agregar
            // 
            this.agregar.BackColor = System.Drawing.Color.Azure;
            this.agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar.Location = new System.Drawing.Point(44, 413);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(131, 53);
            this.agregar.TabIndex = 6;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = false;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.Color.Azure;
            this.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar.Location = new System.Drawing.Point(195, 413);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(131, 53);
            this.eliminar.TabIndex = 7;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = false;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.Azure;
            this.guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.Location = new System.Drawing.Point(345, 413);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(131, 53);
            this.guardar.TabIndex = 8;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // cargar
            // 
            this.cargar.BackColor = System.Drawing.Color.Azure;
            this.cargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cargar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargar.Location = new System.Drawing.Point(504, 413);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(131, 53);
            this.cargar.TabIndex = 9;
            this.cargar.Text = "Cargar";
            this.cargar.UseVisualStyleBackColor = false;
            this.cargar.Click += new System.EventHandler(this.cargar_Click);
            // 
            // marcarTarea
            // 
            this.marcarTarea.BackColor = System.Drawing.Color.Azure;
            this.marcarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.marcarTarea.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcarTarea.Location = new System.Drawing.Point(655, 413);
            this.marcarTarea.Name = "marcarTarea";
            this.marcarTarea.Size = new System.Drawing.Size(131, 53);
            this.marcarTarea.TabIndex = 10;
            this.marcarTarea.Text = "Marcar tarea como realizada";
            this.marcarTarea.UseVisualStyleBackColor = false;
            this.marcarTarea.Click += new System.EventHandler(this.marcarTarea_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.configuraciónToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajustesDeInterfazToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuraciónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("configuraciónToolStripMenuItem.Image")));
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(34, 24);
            this.configuraciónToolStripMenuItem.Tag = "";
            this.configuraciónToolStripMenuItem.ToolTipText = "Configuración";
            // 
            // ajustesDeInterfazToolStripMenuItem
            // 
            this.ajustesDeInterfazToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.ajustesDeInterfazToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ajustesDeInterfazToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarColorDeFondoToolStripMenuItem,
            this.cambiarTamañoDeFuenteToolStripMenuItem});
            this.ajustesDeInterfazToolStripMenuItem.Name = "ajustesDeInterfazToolStripMenuItem";
            this.ajustesDeInterfazToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ajustesDeInterfazToolStripMenuItem.Tag = "";
            this.ajustesDeInterfazToolStripMenuItem.Text = "Ajustes de interfaz";
            this.ajustesDeInterfazToolStripMenuItem.ToolTipText = "ajustes";
            // 
            // cambiarColorDeFondoToolStripMenuItem
            // 
            this.cambiarColorDeFondoToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.cambiarColorDeFondoToolStripMenuItem.Name = "cambiarColorDeFondoToolStripMenuItem";
            this.cambiarColorDeFondoToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.cambiarColorDeFondoToolStripMenuItem.Text = "Cambiar color de fondo";
            this.cambiarColorDeFondoToolStripMenuItem.Click += new System.EventHandler(this.cambiarColorDeFondoToolStripMenuItem_Click);
            // 
            // cambiarTamañoDeFuenteToolStripMenuItem
            // 
            this.cambiarTamañoDeFuenteToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.cambiarTamañoDeFuenteToolStripMenuItem.Name = "cambiarTamañoDeFuenteToolStripMenuItem";
            this.cambiarTamañoDeFuenteToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.cambiarTamañoDeFuenteToolStripMenuItem.Text = "Cambiar tamaño de fuente";
            this.cambiarTamañoDeFuenteToolStripMenuItem.Click += new System.EventHandler(this.cambiarTamañoDeFuenteToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(838, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Azure;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(18, 138);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(799, 260);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(838, 483);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.marcarTarea);
            this.Controls.Add(this.cargar);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.descripcionT);
            this.Controls.Add(this.tituloT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskList";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tituloT;
        private System.Windows.Forms.TextBox descripcionT;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button cargar;
        private System.Windows.Forms.Button marcarTarea;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajustesDeInterfazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarColorDeFondoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarTamañoDeFuenteToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListView listView1;
    }
}

