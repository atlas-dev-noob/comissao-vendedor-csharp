namespace Comissão_do_vendedor
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
            txtvendedor = new TextBox();
            txtpeca = new TextBox();
            txtpreco = new TextBox();
            txtqtd = new TextBox();
            btncalcular = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblresultadofinal = new Label();
            SuspendLayout();
            // 
            // txtvendedor
            // 
            txtvendedor.Location = new Point(66, 417);
            txtvendedor.Name = "txtvendedor";
            txtvendedor.Size = new Size(125, 27);
            txtvendedor.TabIndex = 0;
            txtvendedor.TextChanged += textBox1_TextChanged;
            // 
            // txtpeca
            // 
            txtpeca.Location = new Point(236, 417);
            txtpeca.Name = "txtpeca";
            txtpeca.Size = new Size(125, 27);
            txtpeca.TabIndex = 1;
            // 
            // txtpreco
            // 
            txtpreco.Location = new Point(395, 417);
            txtpreco.Name = "txtpreco";
            txtpreco.Size = new Size(125, 27);
            txtpreco.TabIndex = 2;
            // 
            // txtqtd
            // 
            txtqtd.Location = new Point(554, 417);
            txtqtd.Name = "txtqtd";
            txtqtd.Size = new Size(125, 27);
            txtqtd.TabIndex = 3;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(320, 474);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(110, 48);
            btncalcular.TabIndex = 4;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 394);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 5;
            label1.Text = "Vendedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 394);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 6;
            label2.Text = "Código da peça";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(379, 394);
            label3.Name = "label3";
            label3.Size = new Size(158, 20);
            label3.TabIndex = 7;
            label3.Text = "Preço unitário da peça";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(543, 394);
            label4.Name = "label4";
            label4.Size = new Size(145, 20);
            label4.TabIndex = 8;
            label4.Text = "Quantidade Vendida";
            // 
            // lblresultadofinal
            // 
            lblresultadofinal.AutoSize = true;
            lblresultadofinal.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblresultadofinal.Location = new Point(91, 64);
            lblresultadofinal.Name = "lblresultadofinal";
            lblresultadofinal.Size = new Size(0, 39);
            lblresultadofinal.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(lblresultadofinal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btncalcular);
            Controls.Add(txtqtd);
            Controls.Add(txtpreco);
            Controls.Add(txtpeca);
            Controls.Add(txtvendedor);
            Name = "Form1";
            Text = "Calcular comissão";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtvendedor;
        private TextBox txtpeca;
        private TextBox txtpreco;
        private TextBox txtqtd;
        private Button btncalcular;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblresultadofinal;
    }
}
