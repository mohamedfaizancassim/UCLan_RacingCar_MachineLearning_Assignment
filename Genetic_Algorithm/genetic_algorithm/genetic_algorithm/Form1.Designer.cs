namespace genetic_algorithm
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
            this.txtParticleView = new System.Windows.Forms.TextBox();
            this.cmdPopulateTxt = new System.Windows.Forms.Button();
            this.cmdEvaluvate = new System.Windows.Forms.Button();
            this.txtGrading = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numGenerations = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDecodedResult = new System.Windows.Forms.TextBox();
            this.cmdVisualise = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdReset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfParticles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGenerations)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "No of Particles";
            // 
            // numNumberOfParticles
            // 
            this.numNumberOfParticles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNumberOfParticles.Location = new System.Drawing.Point(157, 8);
            this.numNumberOfParticles.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numNumberOfParticles.Name = "numNumberOfParticles";
            this.numNumberOfParticles.Size = new System.Drawing.Size(73, 26);
            this.numNumberOfParticles.TabIndex = 1;
            // 
            // cmdSpawn
            // 
            this.cmdSpawn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSpawn.Location = new System.Drawing.Point(309, 6);
            this.cmdSpawn.Name = "cmdSpawn";
            this.cmdSpawn.Size = new System.Drawing.Size(69, 31);
            this.cmdSpawn.TabIndex = 2;
            this.cmdSpawn.Text = "Spawn";
            this.cmdSpawn.UseVisualStyleBackColor = true;
            this.cmdSpawn.Click += new System.EventHandler(this.cmdSpawn_Click);
            // 
            // txtParticleView
            // 
            this.txtParticleView.Location = new System.Drawing.Point(6, 17);
            this.txtParticleView.Multiline = true;
            this.txtParticleView.Name = "txtParticleView";
            this.txtParticleView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtParticleView.Size = new System.Drawing.Size(374, 153);
            this.txtParticleView.TabIndex = 3;
            // 
            // cmdPopulateTxt
            // 
            this.cmdPopulateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPopulateTxt.Location = new System.Drawing.Point(385, 6);
            this.cmdPopulateTxt.Name = "cmdPopulateTxt";
            this.cmdPopulateTxt.Size = new System.Drawing.Size(75, 31);
            this.cmdPopulateTxt.TabIndex = 4;
            this.cmdPopulateTxt.Text = "Populate";
            this.cmdPopulateTxt.UseVisualStyleBackColor = true;
            this.cmdPopulateTxt.Click += new System.EventHandler(this.cmdPopulateTxt_Click);
            // 
            // cmdEvaluvate
            // 
            this.cmdEvaluvate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEvaluvate.Location = new System.Drawing.Point(309, 43);
            this.cmdEvaluvate.Name = "cmdEvaluvate";
            this.cmdEvaluvate.Size = new System.Drawing.Size(151, 33);
            this.cmdEvaluvate.TabIndex = 5;
            this.cmdEvaluvate.Text = "Evaluvate";
            this.cmdEvaluvate.UseVisualStyleBackColor = true;
            this.cmdEvaluvate.Click += new System.EventHandler(this.cmdEvaluvate_Click);
            // 
            // txtGrading
            // 
            this.txtGrading.Location = new System.Drawing.Point(386, 17);
            this.txtGrading.Multiline = true;
            this.txtGrading.Name = "txtGrading";
            this.txtGrading.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGrading.Size = new System.Drawing.Size(385, 153);
            this.txtGrading.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "No of Generations";
            // 
            // numGenerations
            // 
            this.numGenerations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numGenerations.Location = new System.Drawing.Point(157, 38);
            this.numGenerations.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numGenerations.Name = "numGenerations";
            this.numGenerations.Size = new System.Drawing.Size(73, 26);
            this.numGenerations.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDecodedResult);
            this.groupBox1.Controls.Add(this.cmdVisualise);
            this.groupBox1.Location = new System.Drawing.Point(24, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 271);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recomendation";
            // 
            // txtDecodedResult
            // 
            this.txtDecodedResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecodedResult.Location = new System.Drawing.Point(6, 27);
            this.txtDecodedResult.Multiline = true;
            this.txtDecodedResult.Name = "txtDecodedResult";
            this.txtDecodedResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDecodedResult.Size = new System.Drawing.Size(627, 238);
            this.txtDecodedResult.TabIndex = 1;
            // 
            // cmdVisualise
            // 
            this.cmdVisualise.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVisualise.Location = new System.Drawing.Point(670, 19);
            this.cmdVisualise.Name = "cmdVisualise";
            this.cmdVisualise.Size = new System.Drawing.Size(102, 28);
            this.cmdVisualise.TabIndex = 0;
            this.cmdVisualise.Text = "Visualise";
            this.cmdVisualise.UseVisualStyleBackColor = true;
            this.cmdVisualise.Click += new System.EventHandler(this.cmdVisualise_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(623, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 10;
            // 
            // cmdReset
            // 
            this.cmdReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReset.Location = new System.Drawing.Point(651, 8);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(151, 33);
            this.cmdReset.TabIndex = 11;
            this.cmdReset.Text = "RESET";
            this.cmdReset.UseVisualStyleBackColor = true;
            this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtParticleView);
            this.groupBox2.Controls.Add(this.txtGrading);
            this.groupBox2.Location = new System.Drawing.Point(24, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(778, 176);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Raw Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 632);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmdReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numGenerations);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdEvaluvate);
            this.Controls.Add(this.cmdPopulateTxt);
            this.Controls.Add(this.cmdSpawn);
            this.Controls.Add(this.numNumberOfParticles);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Genetic Algorithm by Faizansoft Research";
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfParticles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGenerations)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numNumberOfParticles;
        private System.Windows.Forms.Button cmdSpawn;
        private System.Windows.Forms.TextBox txtParticleView;
        private System.Windows.Forms.Button cmdPopulateTxt;
        private System.Windows.Forms.Button cmdEvaluvate;
        private System.Windows.Forms.TextBox txtGrading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numGenerations;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdVisualise;
        private System.Windows.Forms.TextBox txtDecodedResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdReset;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

