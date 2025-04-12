namespace WinFormsApp2
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
            txtNombre = new TextBox();
            label1 = new Label();
            ButtGuardar = new Button();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            txtSeccion = new TextBox();
            txtCarnet = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(157, 77);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(156, 23);
            txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 80);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // ButtGuardar
            // 
            ButtGuardar.Location = new Point(60, 247);
            ButtGuardar.Name = "ButtGuardar";
            ButtGuardar.Size = new Size(100, 44);
            ButtGuardar.TabIndex = 2;
            ButtGuardar.Text = "Guardar";
            ButtGuardar.UseVisualStyleBackColor = true;
            ButtGuardar.Click += ButtGuardar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 133);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Carnet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 187);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(369, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(401, 187);
            dataGridView1.TabIndex = 5;
            // 
            // txtSeccion
            // 
            txtSeccion.Location = new Point(157, 187);
            txtSeccion.Name = "txtSeccion";
            txtSeccion.Size = new Size(156, 23);
            txtSeccion.TabIndex = 6;
            // 
            // txtCarnet
            // 
            txtCarnet.Location = new Point(157, 125);
            txtCarnet.Name = "txtCarnet";
            txtCarnet.Size = new Size(156, 23);
            txtCarnet.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCarnet);
            Controls.Add(txtSeccion);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ButtGuardar);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label label1;
        private Button ButtGuardar;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private TextBox txtSeccion;
        private TextBox txtCarnet;
    }
}
