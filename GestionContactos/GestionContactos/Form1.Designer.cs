﻿namespace GestionContactos
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
            groupBox1 = new GroupBox();
            btnModificarContacto = new Button();
            btnBorrarContacto = new Button();
            btnAñadirContacto = new Button();
            btnMostrarContactos = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnMostrarContactos);
            groupBox1.Controls.Add(btnModificarContacto);
            groupBox1.Controls.Add(btnBorrarContacto);
            groupBox1.Controls.Add(btnAñadirContacto);
            groupBox1.Location = new Point(40, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 341);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnModificarContacto
            // 
            btnModificarContacto.Location = new Point(6, 157);
            btnModificarContacto.Name = "btnModificarContacto";
            btnModificarContacto.Size = new Size(238, 35);
            btnModificarContacto.TabIndex = 1;
            btnModificarContacto.Text = "Modificar contacto";
            btnModificarContacto.UseVisualStyleBackColor = true;
            btnModificarContacto.Click += btnModificarContacto_Click;
            // 
            // btnBorrarContacto
            // 
            btnBorrarContacto.Location = new Point(6, 101);
            btnBorrarContacto.Name = "btnBorrarContacto";
            btnBorrarContacto.Size = new Size(238, 39);
            btnBorrarContacto.TabIndex = 2;
            btnBorrarContacto.Text = "Borrar contacto";
            btnBorrarContacto.UseVisualStyleBackColor = true;
            btnBorrarContacto.Click += btnBorrarContacto_Click;
            // 
            // btnAñadirContacto
            // 
            btnAñadirContacto.Location = new Point(6, 40);
            btnAñadirContacto.Name = "btnAñadirContacto";
            btnAñadirContacto.Size = new Size(238, 36);
            btnAñadirContacto.TabIndex = 1;
            btnAñadirContacto.Text = "Añadir Contacto";
            btnAñadirContacto.UseVisualStyleBackColor = true;
            btnAñadirContacto.Click += btnAñadirContacto_Click;
            // 
            // btnMostrarContactos
            // 
            btnMostrarContactos.Location = new Point(6, 208);
            btnMostrarContactos.Name = "btnMostrarContactos";
            btnMostrarContactos.Size = new Size(238, 32);
            btnMostrarContactos.TabIndex = 3;
            btnMostrarContactos.Text = "Mostrar contactos";
            btnMostrarContactos.UseVisualStyleBackColor = true;
            btnMostrarContactos.Click += btnMostrarContactos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAñadirContacto;
        private Button btnBorrarContacto;
        private Button btnModificarContacto;
        private Button btnMostrarContactos;
    }
}
