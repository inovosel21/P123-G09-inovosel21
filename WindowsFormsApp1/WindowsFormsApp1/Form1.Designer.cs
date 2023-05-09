namespace WindowsFormsApp1 {
    partial class FormEvaluation {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.txtEvaluationDate = new System.Windows.Forms.TextBox();
            this.txtMinForSignature = new System.Windows.Forms.TextBox();
            this.txtMinForGrade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtActivityDescription = new System.Windows.Forms.TextBox();
            this.numPoints = new System.Windows.Forms.NumericUpDown();
            this.cboActivities = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Location = new System.Drawing.Point(324, 374);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 49);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnCancel.Location = new System.Drawing.Point(476, 374);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(146, 49);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(162, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ocjenjivač:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(319, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datum evaluacije:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label3.Location = new System.Drawing.Point(520, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bodovi:";
            // 
            // txtTeacher
            // 
            this.txtTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtTeacher.Location = new System.Drawing.Point(167, 326);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.Size = new System.Drawing.Size(151, 31);
            this.txtTeacher.TabIndex = 5;
            // 
            // txtEvaluationDate
            // 
            this.txtEvaluationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtEvaluationDate.Location = new System.Drawing.Point(324, 326);
            this.txtEvaluationDate.Name = "txtEvaluationDate";
            this.txtEvaluationDate.Size = new System.Drawing.Size(178, 31);
            this.txtEvaluationDate.TabIndex = 6;
            // 
            // txtMinForSignature
            // 
            this.txtMinForSignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtMinForSignature.Location = new System.Drawing.Point(295, 33);
            this.txtMinForSignature.Name = "txtMinForSignature";
            this.txtMinForSignature.Size = new System.Drawing.Size(155, 31);
            this.txtMinForSignature.TabIndex = 7;
            // 
            // txtMinForGrade
            // 
            this.txtMinForGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtMinForGrade.Location = new System.Drawing.Point(476, 32);
            this.txtMinForGrade.Name = "txtMinForGrade";
            this.txtMinForGrade.Size = new System.Drawing.Size(161, 31);
            this.txtMinForGrade.TabIndex = 8;
            this.txtMinForGrade.TextChanged += new System.EventHandler(this.txtMinForGrade_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label4.Location = new System.Drawing.Point(290, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Uvjet za potpis:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label5.Location = new System.Drawing.Point(471, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Uvjet za ocjenu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label6.Location = new System.Drawing.Point(18, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Aktivnost:";
            // 
            // txtActivityDescription
            // 
            this.txtActivityDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtActivityDescription.Location = new System.Drawing.Point(23, 83);
            this.txtActivityDescription.Multiline = true;
            this.txtActivityDescription.Name = "txtActivityDescription";
            this.txtActivityDescription.Size = new System.Drawing.Size(599, 194);
            this.txtActivityDescription.TabIndex = 12;
            // 
            // numPoints
            // 
            this.numPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.numPoints.Location = new System.Drawing.Point(525, 326);
            this.numPoints.Name = "numPoints";
            this.numPoints.Size = new System.Drawing.Size(79, 31);
            this.numPoints.TabIndex = 13;
            // 
            // cboActivities
            // 
            this.cboActivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.cboActivities.FormattingEnabled = true;
            this.cboActivities.Location = new System.Drawing.Point(23, 32);
            this.cboActivities.Name = "cboActivities";
            this.cboActivities.Size = new System.Drawing.Size(257, 33);
            this.cboActivities.TabIndex = 14;
            // 
            // FormEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 453);
            this.Controls.Add(this.cboActivities);
            this.Controls.Add(this.numPoints);
            this.Controls.Add(this.txtActivityDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMinForGrade);
            this.Controls.Add(this.txtMinForSignature);
            this.Controls.Add(this.txtEvaluationDate);
            this.Controls.Add(this.txtTeacher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "FormEvaluation";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.TextBox txtEvaluationDate;
        private System.Windows.Forms.TextBox txtMinForSignature;
        private System.Windows.Forms.TextBox txtMinForGrade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtActivityDescription;
        private System.Windows.Forms.NumericUpDown numPoints;
        private System.Windows.Forms.ComboBox cboActivities;
    }
}

