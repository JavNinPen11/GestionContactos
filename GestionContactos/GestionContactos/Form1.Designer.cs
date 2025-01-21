namespace GestionContactos
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
            btnAñadirContacto = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAñadirContacto);
            groupBox1.Location = new Point(40, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 341);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
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
    }
}
