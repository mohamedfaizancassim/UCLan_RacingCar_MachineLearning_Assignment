namespace PSO
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
            this.label1 = new System.Windows.Forms.Label();
            this.numNumberOfParticles = new System.Windows.Forms.NumericUpDown();
            this.cmdSpawn = new System.Windows.Forms.Button();
            this.cmdRunPSO = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numInertia = new System.Windows.Forms.NumericUpDown();
            this.numC1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numC2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.numNoOfEpochs = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdReset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdVisualise = new System.Windows.Forms.Button();
            this.txtVisualise = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfParticles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInertia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numC2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNoOfEpochs)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Particles";
            // 
            // numNumberOfParticles
            // 
            this.numNumberOfParticles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNumberOfParticles.Location = new System.Drawing.Point(157, 9);
            this.numNumberOfParticles.Name = "numNumberOfParticles";
            this.numNumberOfParticles.Size = new System.Drawing.Size(120, 24);
            this.numNumberOfParticles.TabIndex = 1;
            this.numNumberOfParticles.ValueChanged += new System.EventHandler(this.numNumberOfParticles_ValueChanged);
            // 
            // cmdSpawn
            // 
            this.cmdSpawn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSpawn.Location = new System.Drawing.Point(616, 12);
            this.cmdSpawn.Name = "cmdSpawn";
            this.cmdSpawn.Size = new System.Drawing.Size(172, 34);
            this.cmdSpawn.TabIndex = 2;
            this.cmdSpawn.Text = "Spawn Particles";
            this.cmdSpawn.UseVisualStyleBackColor = true;
            this.cmdSpawn.Click += new System.EventHandler(this.cmdSpawn_Click);
            // 
            // cmdRunPSO
            // 
            this.cmdRunPSO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRunPSO.Location = new System.Drawing.Point(616, 52);
            this.cmdRunPSO.Name = "cmdRunPSO";
            this.cmdRunPSO.Size = new System.Drawing.Size(172, 34);
            this.cmdRunPSO.TabIndex = 3;
            this.cmdRunPSO.Text = "Run PSO";
            this.cmdRunPSO.UseVisualStyleBackColor = true;
            this.cmdRunPSO.Click += new System.EventHandler(this.cmdRunPSO_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Inertia";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // numInertia
            // 
            this.numInertia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numInertia.Location = new System.Drawing.Point(157, 81);
            this.numInertia.Name = "numInertia";
            this.numInertia.Size = new System.Drawing.Size(120, 24);
            this.numInertia.TabIndex = 5;
            // 
            // numC1
            // 
            this.numC1.DecimalPlaces = 2;
            this.numC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numC1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numC1.Location = new System.Drawing.Point(157, 111);
            this.numC1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numC1.Name = "numC1";
            this.numC1.Size = new System.Drawing.Size(120, 24);
            this.numC1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Learning Factor C1";
            // 
            // numC2
            // 
            this.numC2.DecimalPlaces = 2;
            this.numC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numC2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numC2.Location = new System.Drawing.Point(157, 141);
            this.numC2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numC2.Name = "numC2";
            this.numC2.Size = new System.Drawing.Size(120, 24);
            this.numC2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Learning Factor C2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Controls.Add(this.txtOriginal);
            this.groupBox1.Location = new System.Drawing.Point(9, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 218);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(393, 20);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(379, 192);
            this.txtResult.TabIndex = 1;
            // 
            // txtOriginal
            // 
            this.txtOriginal.Location = new System.Drawing.Point(7, 20);
            this.txtOriginal.Multiline = true;
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOriginal.Size = new System.Drawing.Size(367, 192);
            this.txtOriginal.TabIndex = 0;
            // 
            // numNoOfEpochs
            // 
            this.numNoOfEpochs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNoOfEpochs.Location = new System.Drawing.Point(157, 38);
            this.numNoOfEpochs.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numNoOfEpochs.Name = "numNoOfEpochs";
            this.numNoOfEpochs.Size = new System.Drawing.Size(120, 24);
            this.numNoOfEpochs.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Number of Epochs";
            // 
            // cmdReset
            // 
            this.cmdReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReset.Location = new System.Drawing.Point(616, 97);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(172, 34);
            this.cmdReset.TabIndex = 13;
            this.cmdReset.Text = "RESET";
            this.cmdReset.UseVisualStyleBackColor = true;
            this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdVisualise);
            this.groupBox2.Controls.Add(this.txtVisualise);
            this.groupBox2.Location = new System.Drawing.Point(11, 405);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 238);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recomendation";
            // 
            // cmdVisualise
            // 
            this.cmdVisualise.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVisualise.Location = new System.Drawing.Point(598, 19);
            this.cmdVisualise.Name = "cmdVisualise";
            this.cmdVisualise.Size = new System.Drawing.Size(172, 34);
            this.cmdVisualise.TabIndex = 14;
            this.cmdVisualise.Text = "Visualise";
            this.cmdVisualise.UseVisualStyleBackColor = true;
            this.cmdVisualise.Click += new System.EventHandler(this.cmdVisualise_Click);
            // 
            // txtVisualise
            // 
            this.txtVisualise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisualise.Location = new System.Drawing.Point(13, 32);
            this.txtVisualise.Multiline = true;
            this.txtVisualise.Name = "txtVisualise";
            this.txtVisualise.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVisualise.Size = new System.Drawing.Size(505, 191);
            this.txtVisualise.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 655);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmdReset);
            this.Controls.Add(this.numNoOfEpochs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numC2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numC1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numInertia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdRunPSO);
            this.Controls.Add(this.cmdSpawn);
            this.Controls.Add(this.numNumberOfParticles);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Particle Swarm Optimisation by Faizansoft Research";
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfParticles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInertia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numC2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNoOfEpochs)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numNumberOfParticles;
        private System.Windows.Forms.Button cmdSpawn;
        private System.Windows.Forms.Button cmdRunPSO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numInertia;
        private System.Windows.Forms.NumericUpDown numC1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numC2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.NumericUpDown numNoOfEpochs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdReset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdVisualise;
        private System.Windows.Forms.TextBox txtVisualise;
    }
}

