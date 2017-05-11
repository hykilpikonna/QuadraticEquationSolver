namespace QuadraticEquationSolver
{
    partial class QuadraticSolver
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.Output1 = new System.Windows.Forms.TextBox();
            this.Output2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(12, 80);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(380, 23);
            this.Calculate.TabIndex = 3;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Output1
            // 
            this.Output1.Location = new System.Drawing.Point(12, 132);
            this.Output1.Name = "Output1";
            this.Output1.ReadOnly = true;
            this.Output1.Size = new System.Drawing.Size(380, 20);
            this.Output1.TabIndex = 4;
            // 
            // Output2
            // 
            this.Output2.Location = new System.Drawing.Point(12, 180);
            this.Output2.Name = "Output2";
            this.Output2.ReadOnly = true;
            this.Output2.Size = new System.Drawing.Size(380, 20);
            this.Output2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Output2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "X² +";
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(12, 54);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(110, 20);
            this.a.TabIndex = 5;
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(160, 54);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(101, 20);
            this.b.TabIndex = 5;
            this.b.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "X +";
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(296, 54);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(96, 20);
            this.c.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(377, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Quadratic Equation Solver  By: Hykilpikonna";
            // 
            // QuadraticSolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 219);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.Output2);
            this.Controls.Add(this.Output1);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuadraticSolver";
            this.ShowIcon = false;
            this.Text = "Quadratic Equation Solver  By: Hykilpikonna";
            this.Load += new System.EventHandler(this.QuadraticSolver_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.QuadraticSolver_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.QuadraticSolver_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.QuadraticSolver_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox Output1;
        private System.Windows.Forms.TextBox Output2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox c;
        private System.Windows.Forms.Label label6;
    }
}

