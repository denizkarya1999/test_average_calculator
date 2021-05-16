namespace Test_Average
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
            this.test1PromptLabel = new System.Windows.Forms.Label();
            this.test2PromptLabel = new System.Windows.Forms.Label();
            this.test3PromptLabel = new System.Windows.Forms.Label();
            this.AverageLabel = new System.Windows.Forms.Label();
            this.calculateaveregebutton = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.average_label = new System.Windows.Forms.Label();
            this.test1TextBox = new System.Windows.Forms.TextBox();
            this.Test2textBox = new System.Windows.Forms.TextBox();
            this.Test3textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // test1PromptLabel
            // 
            this.test1PromptLabel.AutoSize = true;
            this.test1PromptLabel.Location = new System.Drawing.Point(57, 20);
            this.test1PromptLabel.Name = "test1PromptLabel";
            this.test1PromptLabel.Size = new System.Drawing.Size(40, 13);
            this.test1PromptLabel.TabIndex = 0;
            this.test1PromptLabel.Text = "Test 1:";
            // 
            // test2PromptLabel
            // 
            this.test2PromptLabel.AutoSize = true;
            this.test2PromptLabel.Location = new System.Drawing.Point(57, 49);
            this.test2PromptLabel.Name = "test2PromptLabel";
            this.test2PromptLabel.Size = new System.Drawing.Size(40, 13);
            this.test2PromptLabel.TabIndex = 1;
            this.test2PromptLabel.Text = "Test 2:";
            // 
            // test3PromptLabel
            // 
            this.test3PromptLabel.AutoSize = true;
            this.test3PromptLabel.Location = new System.Drawing.Point(57, 74);
            this.test3PromptLabel.Name = "test3PromptLabel";
            this.test3PromptLabel.Size = new System.Drawing.Size(40, 13);
            this.test3PromptLabel.TabIndex = 2;
            this.test3PromptLabel.Text = "Test 3:";
            // 
            // AverageLabel
            // 
            this.AverageLabel.AutoSize = true;
            this.AverageLabel.Location = new System.Drawing.Point(25, 118);
            this.AverageLabel.Name = "AverageLabel";
            this.AverageLabel.Size = new System.Drawing.Size(105, 13);
            this.AverageLabel.TabIndex = 3;
            this.AverageLabel.Text = "Average Test Score:";
            // 
            // calculateaveregebutton
            // 
            this.calculateaveregebutton.Location = new System.Drawing.Point(19, 155);
            this.calculateaveregebutton.Name = "calculateaveregebutton";
            this.calculateaveregebutton.Size = new System.Drawing.Size(75, 41);
            this.calculateaveregebutton.TabIndex = 4;
            this.calculateaveregebutton.Text = "Calculate Average";
            this.calculateaveregebutton.UseVisualStyleBackColor = true;
            this.calculateaveregebutton.Click += new System.EventHandler(this.calculateaveregebutton_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(111, 155);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(75, 41);
            this.clear_button.TabIndex = 5;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(201, 155);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 41);
            this.exit_button.TabIndex = 6;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // average_label
            // 
            this.average_label.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.average_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.average_label.Location = new System.Drawing.Point(136, 108);
            this.average_label.Name = "average_label";
            this.average_label.Size = new System.Drawing.Size(140, 23);
            this.average_label.TabIndex = 7;
            // 
            // test1TextBox
            // 
            this.test1TextBox.Location = new System.Drawing.Point(114, 17);
            this.test1TextBox.Name = "test1TextBox";
            this.test1TextBox.Size = new System.Drawing.Size(100, 20);
            this.test1TextBox.TabIndex = 8;
            // 
            // Test2textBox
            // 
            this.Test2textBox.Location = new System.Drawing.Point(114, 46);
            this.Test2textBox.Name = "Test2textBox";
            this.Test2textBox.Size = new System.Drawing.Size(100, 20);
            this.Test2textBox.TabIndex = 9;
            // 
            // Test3textBox
            // 
            this.Test3textBox.Location = new System.Drawing.Point(114, 72);
            this.Test3textBox.Name = "Test3textBox";
            this.Test3textBox.Size = new System.Drawing.Size(100, 20);
            this.Test3textBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 220);
            this.Controls.Add(this.Test3textBox);
            this.Controls.Add(this.Test2textBox);
            this.Controls.Add(this.test1TextBox);
            this.Controls.Add(this.average_label);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.calculateaveregebutton);
            this.Controls.Add(this.AverageLabel);
            this.Controls.Add(this.test3PromptLabel);
            this.Controls.Add(this.test2PromptLabel);
            this.Controls.Add(this.test1PromptLabel);
            this.Name = "Form1";
            this.Text = "Test Average";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label test1PromptLabel;
        private System.Windows.Forms.Label test2PromptLabel;
        private System.Windows.Forms.Label test3PromptLabel;
        private System.Windows.Forms.Label AverageLabel;
        private System.Windows.Forms.Button calculateaveregebutton;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label average_label;
        private System.Windows.Forms.TextBox test1TextBox;
        private System.Windows.Forms.TextBox Test2textBox;
        private System.Windows.Forms.TextBox Test3textBox;
    }
}

