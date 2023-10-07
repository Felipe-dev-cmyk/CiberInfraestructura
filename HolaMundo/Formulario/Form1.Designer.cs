namespace Formulario
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
            label1 = new Label();
            label2 = new Label();
            txtPassword1 = new TextBox();
            txtPassword2 = new TextBox();
            btnConfirm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 95);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 127);
            label2.Name = "label2";
            label2.Size = new Size(130, 15);
            label2.TabIndex = 1;
            label2.Text = "Confirma la contraseña";
            // 
            // txtPassword1
            // 
            txtPassword1.Location = new Point(254, 87);
            txtPassword1.Name = "txtPassword1";
            txtPassword1.Size = new Size(203, 23);
            txtPassword1.TabIndex = 2;
            // 
            // txtPassword2
            // 
            txtPassword2.Location = new Point(254, 119);
            txtPassword2.Name = "txtPassword2";
            txtPassword2.Size = new Size(203, 23);
            txtPassword2.TabIndex = 3;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(382, 162);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "Confirmar";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirm);
            Controls.Add(txtPassword2);
            Controls.Add(txtPassword1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPassword1;
        private TextBox txtPassword2;
        private Button btnConfirm;
    }
}