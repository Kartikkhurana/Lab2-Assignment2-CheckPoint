namespace SharpAutoCenter
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BasePrice = new System.Windows.Forms.TextBox();
            this.AdditionalOptions = new System.Windows.Forms.TextBox();
            this.SubTotal = new System.Windows.Forms.TextBox();
            this.SalesTax = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.TradeInAllowance = new System.Windows.Forms.TextBox();
            this.AmountDue = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Computernavigation = new System.Windows.Forms.CheckBox();
            this.Leatherinterior = new System.Windows.Forms.CheckBox();
            this.Stereosystem = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Customizeddetailing = new System.Windows.Forms.RadioButton();
            this.Pearlized = new System.Windows.Forms.RadioButton();
            this.Standard = new System.Windows.Forms.RadioButton();
            this.Calculate = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Additional Options:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SubTotal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "SalesTax(13%):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Trade-in Allowance:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Amount Due:";
            // 
            // BasePrice
            // 
            this.BasePrice.Location = new System.Drawing.Point(147, 34);
            this.BasePrice.Name = "BasePrice";
            this.BasePrice.Size = new System.Drawing.Size(100, 20);
            this.BasePrice.TabIndex = 7;
            // 
            // AdditionalOptions
            // 
            this.AdditionalOptions.Location = new System.Drawing.Point(147, 72);
            this.AdditionalOptions.Name = "AdditionalOptions";
            this.AdditionalOptions.ReadOnly = true;
            this.AdditionalOptions.Size = new System.Drawing.Size(100, 20);
            this.AdditionalOptions.TabIndex = 8;
            // 
            // SubTotal
            // 
            this.SubTotal.Location = new System.Drawing.Point(147, 98);
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Size = new System.Drawing.Size(100, 20);
            this.SubTotal.TabIndex = 9;
            // 
            // SalesTax
            // 
            this.SalesTax.Location = new System.Drawing.Point(147, 130);
            this.SalesTax.Name = "SalesTax";
            this.SalesTax.ReadOnly = true;
            this.SalesTax.Size = new System.Drawing.Size(100, 20);
            this.SalesTax.TabIndex = 10;
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(147, 159);
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Size = new System.Drawing.Size(100, 20);
            this.Total.TabIndex = 11;
            // 
            // TradeInAllowance
            // 
            this.TradeInAllowance.Location = new System.Drawing.Point(147, 193);
            this.TradeInAllowance.Name = "TradeInAllowance";
            this.TradeInAllowance.Size = new System.Drawing.Size(100, 20);
            this.TradeInAllowance.TabIndex = 12;
            this.TradeInAllowance.Text = "0";
            this.TradeInAllowance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AmountDue
            // 
            this.AmountDue.Location = new System.Drawing.Point(147, 223);
            this.AmountDue.Name = "AmountDue";
            this.AmountDue.ReadOnly = true;
            this.AmountDue.Size = new System.Drawing.Size(100, 20);
            this.AmountDue.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(469, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F1)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.calculateToolStripMenuItem.Text = "Calculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fontToolStripMenuItem.Text = "Font...";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.colorToolStripMenuItem.Text = "Color...";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Computernavigation);
            this.groupBox1.Controls.Add(this.Leatherinterior);
            this.groupBox1.Controls.Add(this.Stereosystem);
            this.groupBox1.Location = new System.Drawing.Point(306, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 127);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Additional Items";
            // 
            // Computernavigation
            // 
            this.Computernavigation.AutoSize = true;
            this.Computernavigation.Location = new System.Drawing.Point(15, 92);
            this.Computernavigation.Name = "Computernavigation";
            this.Computernavigation.Size = new System.Drawing.Size(125, 17);
            this.Computernavigation.TabIndex = 2;
            this.Computernavigation.Text = "Computer Navigation";
            this.Computernavigation.UseVisualStyleBackColor = true;
            // 
            // Leatherinterior
            // 
            this.Leatherinterior.AutoSize = true;
            this.Leatherinterior.Location = new System.Drawing.Point(15, 51);
            this.Leatherinterior.Name = "Leatherinterior";
            this.Leatherinterior.Size = new System.Drawing.Size(97, 17);
            this.Leatherinterior.TabIndex = 1;
            this.Leatherinterior.Text = "Leather Interior";
            this.Leatherinterior.UseVisualStyleBackColor = true;
            // 
            // Stereosystem
            // 
            this.Stereosystem.AutoSize = true;
            this.Stereosystem.Location = new System.Drawing.Point(15, 28);
            this.Stereosystem.Name = "Stereosystem";
            this.Stereosystem.Size = new System.Drawing.Size(94, 17);
            this.Stereosystem.TabIndex = 0;
            this.Stereosystem.Text = "Stereo System";
            this.Stereosystem.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Customizeddetailing);
            this.groupBox2.Controls.Add(this.Pearlized);
            this.groupBox2.Controls.Add(this.Standard);
            this.groupBox2.Location = new System.Drawing.Point(306, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 127);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exterior Finsih";
            // 
            // Customizeddetailing
            // 
            this.Customizeddetailing.AutoSize = true;
            this.Customizeddetailing.Location = new System.Drawing.Point(15, 103);
            this.Customizeddetailing.Name = "Customizeddetailing";
            this.Customizeddetailing.Size = new System.Drawing.Size(123, 17);
            this.Customizeddetailing.TabIndex = 2;
            this.Customizeddetailing.Text = "Customized Detailing";
            this.Customizeddetailing.UseVisualStyleBackColor = true;
            // 
            // Pearlized
            // 
            this.Pearlized.AutoSize = true;
            this.Pearlized.Location = new System.Drawing.Point(15, 62);
            this.Pearlized.Name = "Pearlized";
            this.Pearlized.Size = new System.Drawing.Size(68, 17);
            this.Pearlized.TabIndex = 1;
            this.Pearlized.Text = "Pearlized";
            this.Pearlized.UseVisualStyleBackColor = true;
            // 
            // Standard
            // 
            this.Standard.AutoSize = true;
            this.Standard.Checked = true;
            this.Standard.Location = new System.Drawing.Point(15, 30);
            this.Standard.Name = "Standard";
            this.Standard.Size = new System.Drawing.Size(68, 17);
            this.Standard.TabIndex = 0;
            this.Standard.TabStop = true;
            this.Standard.Text = "Standard";
            this.Standard.UseVisualStyleBackColor = true;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(12, 319);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 35);
            this.Calculate.TabIndex = 8;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(195, 319);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 35);
            this.Clear.TabIndex = 17;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.button2_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(391, 319);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 40);
            this.Exit.TabIndex = 18;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 389);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AmountDue);
            this.Controls.Add(this.TradeInAllowance);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.SalesTax);
            this.Controls.Add(this.SubTotal);
            this.Controls.Add(this.AdditionalOptions);
            this.Controls.Add(this.BasePrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = " Auto Center";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BasePrice;
        private System.Windows.Forms.TextBox AdditionalOptions;
        private System.Windows.Forms.TextBox SubTotal;
        private System.Windows.Forms.TextBox SalesTax;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.TextBox TradeInAllowance;
        private System.Windows.Forms.TextBox AmountDue;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Computernavigation;
        private System.Windows.Forms.CheckBox Leatherinterior;
        private System.Windows.Forms.CheckBox Stereosystem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Customizeddetailing;
        private System.Windows.Forms.RadioButton Pearlized;
        private System.Windows.Forms.RadioButton Standard;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
    }
}

