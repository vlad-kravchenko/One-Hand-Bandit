namespace One_Hand_Bandit
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dvig1 = new System.Windows.Forms.Timer(this.components);
            this.dvig2 = new System.Windows.Forms.Timer(this.components);
            this.dvig3 = new System.Windows.Forms.Timer(this.components);
            this.stop1 = new System.Windows.Forms.Timer(this.components);
            this.stop2 = new System.Windows.Forms.Timer(this.components);
            this.stop3 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(53, 69);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(178, 61);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Старт!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("Arial", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 89);
            this.label1.TabIndex = 1;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkOrange;
            this.label2.Font = new System.Drawing.Font("Arial", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 89);
            this.label2.TabIndex = 2;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkOrange;
            this.label3.Font = new System.Drawing.Font("Arial", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 89);
            this.label3.TabIndex = 3;
            this.label3.Text = "0";
            // 
            // dvig1
            // 
            this.dvig1.Interval = 10;
            this.dvig1.Tick += new System.EventHandler(this.dvig1_Tick);
            // 
            // dvig2
            // 
            this.dvig2.Interval = 10;
            this.dvig2.Tick += new System.EventHandler(this.dvig2_Tick);
            // 
            // dvig3
            // 
            this.dvig3.Interval = 10;
            this.dvig3.Tick += new System.EventHandler(this.dvig3_Tick);
            // 
            // stop1
            // 
            this.stop1.Interval = 1000;
            this.stop1.Tick += new System.EventHandler(this.stop1_Tick);
            // 
            // stop2
            // 
            this.stop2.Interval = 2000;
            this.stop2.Tick += new System.EventHandler(this.stop2_Tick);
            // 
            // stop3
            // 
            this.stop3.Interval = 3000;
            this.stop3.Tick += new System.EventHandler(this.stop3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(284, 313);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Бандит";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer dvig1;
        private System.Windows.Forms.Timer dvig2;
        private System.Windows.Forms.Timer dvig3;
        private System.Windows.Forms.Timer stop1;
        private System.Windows.Forms.Timer stop2;
        private System.Windows.Forms.Timer stop3;
    }
}

