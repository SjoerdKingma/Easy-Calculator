namespace EasyCalculator
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
            this.radioPlus = new System.Windows.Forms.RadioButton();
            this.radioDivide = new System.Windows.Forms.RadioButton();
            this.radioMultiply = new System.Windows.Forms.RadioButton();
            this.radioMinus = new System.Windows.Forms.RadioButton();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.checkRememberInput = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // radioPlus
            // 
            this.radioPlus.AutoSize = true;
            this.radioPlus.Checked = true;
            this.radioPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPlus.Location = new System.Drawing.Point(12, 10);
            this.radioPlus.Name = "radioPlus";
            this.radioPlus.Size = new System.Drawing.Size(57, 24);
            this.radioPlus.TabIndex = 0;
            this.radioPlus.TabStop = true;
            this.radioPlus.Text = "Plus";
            this.radioPlus.UseVisualStyleBackColor = true;
            // 
            // radioDivide
            // 
            this.radioDivide.AutoSize = true;
            this.radioDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDivide.Location = new System.Drawing.Point(232, 10);
            this.radioDivide.Name = "radioDivide";
            this.radioDivide.Size = new System.Drawing.Size(70, 24);
            this.radioDivide.TabIndex = 1;
            this.radioDivide.Text = "Divide";
            this.radioDivide.UseVisualStyleBackColor = true;
            // 
            // radioMultiply
            // 
            this.radioMultiply.AutoSize = true;
            this.radioMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMultiply.Location = new System.Drawing.Point(147, 10);
            this.radioMultiply.Name = "radioMultiply";
            this.radioMultiply.Size = new System.Drawing.Size(79, 24);
            this.radioMultiply.TabIndex = 2;
            this.radioMultiply.Text = "Multiply";
            this.radioMultiply.UseVisualStyleBackColor = true;
            // 
            // radioMinus
            // 
            this.radioMinus.AutoSize = true;
            this.radioMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMinus.Location = new System.Drawing.Point(72, 10);
            this.radioMinus.Name = "radioMinus";
            this.radioMinus.Size = new System.Drawing.Size(69, 24);
            this.radioMinus.TabIndex = 3;
            this.radioMinus.Text = "Minus";
            this.radioMinus.UseVisualStyleBackColor = true;
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(12, 43);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(290, 31);
            this.txtInput.TabIndex = 0;
            this.txtInput.Enter += new System.EventHandler(this.txtInput_Enter);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(12, 80);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(95, 35);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(12, 255);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(290, 31);
            this.txtOutput.TabIndex = 7;
            this.txtOutput.Click += new System.EventHandler(this.txtOutput_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 147);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(290, 102);
            this.txtLog.TabIndex = 8;
            this.txtLog.Text = "";
            // 
            // btnUndo
            // 
            this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.Location = new System.Drawing.Point(219, 80);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(83, 35);
            this.btnUndo.TabIndex = 9;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(125, 80);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 35);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(323, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // checkRememberInput
            // 
            this.checkRememberInput.AutoSize = true;
            this.checkRememberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRememberInput.Location = new System.Drawing.Point(15, 121);
            this.checkRememberInput.Name = "checkRememberInput";
            this.checkRememberInput.Size = new System.Drawing.Size(126, 20);
            this.checkRememberInput.TabIndex = 12;
            this.checkRememberInput.Text = "Remember input";
            this.checkRememberInput.UseVisualStyleBackColor = true;
            this.checkRememberInput.CheckedChanged += new System.EventHandler(this.checkRememberInput_CheckedChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 301);
            this.Controls.Add(this.checkRememberInput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.radioMinus);
            this.Controls.Add(this.radioMultiply);
            this.Controls.Add(this.radioDivide);
            this.Controls.Add(this.radioPlus);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Easy Calculator";
            this.Enter += new System.EventHandler(this.Form1_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioPlus;
        private System.Windows.Forms.RadioButton radioDivide;
        private System.Windows.Forms.RadioButton radioMultiply;
        private System.Windows.Forms.RadioButton radioMinus;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.CheckBox checkRememberInput;
    }
}

