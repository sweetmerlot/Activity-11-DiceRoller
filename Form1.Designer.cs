
namespace Activity11_Dice
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
            this.button1 = new System.Windows.Forms.Button();
            this.rollButton = new System.Windows.Forms.Button();
            this.dice1 = new System.Windows.Forms.Label();
            this.dice2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.diceGroupBox = new System.Windows.Forms.GroupBox();
            this.diceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 429);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(403, 429);
            this.rollButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(213, 60);
            this.rollButton.TabIndex = 1;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // dice1
            // 
            this.dice1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dice1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dice1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dice1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dice1.Location = new System.Drawing.Point(61, 72);
            this.dice1.Name = "dice1";
            this.dice1.Size = new System.Drawing.Size(133, 119);
            this.dice1.TabIndex = 2;
            this.dice1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dice1.Visible = false;
            // 
            // dice2
            // 
            this.dice2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dice2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dice2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dice2.Location = new System.Drawing.Point(352, 72);
            this.dice2.Name = "dice2";
            this.dice2.Size = new System.Drawing.Size(133, 119);
            this.dice2.TabIndex = 4;
            this.dice2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dice2.Visible = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(83, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(647, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "How many rolls will it take to roll snake eyes?";
            // 
            // diceGroupBox
            // 
            this.diceGroupBox.Controls.Add(this.dice2);
            this.diceGroupBox.Controls.Add(this.dice1);
            this.diceGroupBox.Location = new System.Drawing.Point(83, 117);
            this.diceGroupBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.diceGroupBox.Name = "diceGroupBox";
            this.diceGroupBox.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.diceGroupBox.Size = new System.Drawing.Size(533, 238);
            this.diceGroupBox.TabIndex = 6;
            this.diceGroupBox.TabStop = false;
            this.diceGroupBox.Text = "Click Generate to Create Dice";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.diceGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Dice Roller";
            this.diceGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Label dice1;
        private System.Windows.Forms.Label dice2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox diceGroupBox;
    }
}

