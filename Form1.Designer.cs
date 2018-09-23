namespace Calculator
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
            this.TableGrid = new System.Windows.Forms.TableLayoutPanel();
            this.Num0 = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.Num7 = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.Num6 = new System.Windows.Forms.Button();
            this.Num8 = new System.Windows.Forms.Button();
            this.Num9 = new System.Windows.Forms.Button();
            this.Multi = new System.Windows.Forms.Button();
            this.Num4 = new System.Windows.Forms.Button();
            this.Num5 = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.Button();
            this.Num2 = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Num3 = new System.Windows.Forms.Button();
            this.Equasion = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.Label();
            this.Comma = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TableGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableGrid
            // 
            this.TableGrid.ColumnCount = 4;
            this.TableGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableGrid.Controls.Add(this.Num0, 1, 5);
            this.TableGrid.Controls.Add(this.Div, 3, 5);
            this.TableGrid.Controls.Add(this.Num7, 0, 4);
            this.TableGrid.Controls.Add(this.Sub, 3, 3);
            this.TableGrid.Controls.Add(this.Num6, 2, 3);
            this.TableGrid.Controls.Add(this.Num8, 1, 4);
            this.TableGrid.Controls.Add(this.Num9, 2, 4);
            this.TableGrid.Controls.Add(this.Multi, 3, 4);
            this.TableGrid.Controls.Add(this.Num4, 0, 3);
            this.TableGrid.Controls.Add(this.Num5, 1, 3);
            this.TableGrid.Controls.Add(this.Num1, 0, 2);
            this.TableGrid.Controls.Add(this.Num2, 1, 2);
            this.TableGrid.Controls.Add(this.Add, 3, 2);
            this.TableGrid.Controls.Add(this.Num3, 2, 2);
            this.TableGrid.Controls.Add(this.Equasion, 0, 0);
            this.TableGrid.Controls.Add(this.Answer, 0, 1);
            this.TableGrid.Controls.Add(this.Comma, 0, 5);
            this.TableGrid.Controls.Add(this.Equal, 2, 5);
            this.TableGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableGrid.Location = new System.Drawing.Point(0, 0);
            this.TableGrid.Margin = new System.Windows.Forms.Padding(0);
            this.TableGrid.Name = "TableGrid";
            this.TableGrid.RowCount = 6;
            this.TableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.TableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.TableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableGrid.Size = new System.Drawing.Size(362, 450);
            this.TableGrid.TabIndex = 0;
            // 
            // Num0
            // 
            this.Num0.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num0.Location = new System.Drawing.Point(93, 379);
            this.Num0.Name = "Num0";
            this.Num0.Size = new System.Drawing.Size(84, 68);
            this.Num0.TabIndex = 1;
            this.Num0.Text = "0";
            this.Num0.UseVisualStyleBackColor = true;
            this.Num0.GotFocus += new System.EventHandler(this.Num0_Click);
            // 
            // Div
            // 
            this.Div.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Div.Location = new System.Drawing.Point(273, 379);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(84, 68);
            this.Div.TabIndex = 3;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.GotFocus += new System.EventHandler(this.Div_Click);
            // 
            // Num7
            // 
            this.Num7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num7.Location = new System.Drawing.Point(3, 305);
            this.Num7.Name = "Num7";
            this.Num7.Size = new System.Drawing.Size(84, 68);
            this.Num7.TabIndex = 4;
            this.Num7.Text = "7";
            this.Num7.UseVisualStyleBackColor = true;
            this.Num7.GotFocus += new System.EventHandler(this.Num7_Click);
            // 
            // Sub
            // 
            this.Sub.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sub.Location = new System.Drawing.Point(273, 231);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(84, 68);
            this.Sub.TabIndex = 11;
            this.Sub.Text = "-";
            this.Sub.UseVisualStyleBackColor = true;
            this.Sub.GotFocus += new System.EventHandler(this.Sub_Click);
            // 
            // Num6
            // 
            this.Num6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num6.Location = new System.Drawing.Point(183, 231);
            this.Num6.Name = "Num6";
            this.Num6.Size = new System.Drawing.Size(84, 68);
            this.Num6.TabIndex = 10;
            this.Num6.Text = "6";
            this.Num6.UseVisualStyleBackColor = true;
            this.Num6.GotFocus += new System.EventHandler(this.Num6_Click);
            // 
            // Num8
            // 
            this.Num8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num8.Location = new System.Drawing.Point(93, 305);
            this.Num8.Name = "Num8";
            this.Num8.Size = new System.Drawing.Size(84, 68);
            this.Num8.TabIndex = 5;
            this.Num8.Text = "8";
            this.Num8.UseVisualStyleBackColor = true;
            this.Num8.GotFocus += new System.EventHandler(this.Num8_Click);
            // 
            // Num9
            // 
            this.Num9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num9.Location = new System.Drawing.Point(183, 305);
            this.Num9.Name = "Num9";
            this.Num9.Size = new System.Drawing.Size(84, 68);
            this.Num9.TabIndex = 6;
            this.Num9.Text = "9";
            this.Num9.UseVisualStyleBackColor = true;
            this.Num9.GotFocus += new System.EventHandler(this.Num9_Click);
            // 
            // Multi
            // 
            this.Multi.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multi.Location = new System.Drawing.Point(273, 305);
            this.Multi.Name = "Multi";
            this.Multi.Size = new System.Drawing.Size(84, 68);
            this.Multi.TabIndex = 7;
            this.Multi.Text = "*";
            this.Multi.UseVisualStyleBackColor = true;
            this.Multi.GotFocus += new System.EventHandler(this.Multi_Click);
            // 
            // Num4
            // 
            this.Num4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num4.Location = new System.Drawing.Point(3, 231);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(84, 68);
            this.Num4.TabIndex = 8;
            this.Num4.Text = "4";
            this.Num4.UseVisualStyleBackColor = true;
            this.Num4.GotFocus += new System.EventHandler(this.Num4_Click);
            // 
            // Num5
            // 
            this.Num5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num5.Location = new System.Drawing.Point(93, 231);
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(84, 68);
            this.Num5.TabIndex = 9;
            this.Num5.Text = "5";
            this.Num5.UseVisualStyleBackColor = true;
            this.Num5.GotFocus += new System.EventHandler(this.Num5_Click);
            // 
            // Num1
            // 
            this.Num1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num1.Location = new System.Drawing.Point(3, 157);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(84, 68);
            this.Num1.TabIndex = 12;
            this.Num1.Text = "1";
            this.Num1.UseVisualStyleBackColor = true;
            this.Num1.GotFocus += new System.EventHandler(this.Num1_Click);
            // 
            // Num2
            // 
            this.Num2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num2.Location = new System.Drawing.Point(93, 157);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(84, 68);
            this.Num2.TabIndex = 13;
            this.Num2.Text = "2";
            this.Num2.UseVisualStyleBackColor = true;
            this.Num2.GotFocus += new System.EventHandler(this.Num2_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(273, 157);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(84, 68);
            this.Add.TabIndex = 15;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.GotFocus += new System.EventHandler(this.Add_Click);
            // 
            // Num3
            // 
            this.Num3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num3.Location = new System.Drawing.Point(183, 157);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(84, 68);
            this.Num3.TabIndex = 14;
            this.Num3.Text = "3";
            this.Num3.UseVisualStyleBackColor = true;
            this.Num3.GotFocus += new System.EventHandler(this.Num3_Click);
            // 
            // Equasion
            // 
            this.Equasion.AutoSize = true;
            this.TableGrid.SetColumnSpan(this.Equasion, 4);
            this.Equasion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Equasion.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equasion.Location = new System.Drawing.Point(3, 0);
            this.Equasion.Name = "Equasion";
            this.Equasion.Size = new System.Drawing.Size(356, 53);
            this.Equasion.TabIndex = 16;
            this.Equasion.Text = "0";
            this.Equasion.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.TableGrid.SetColumnSpan(this.Answer, 4);
            this.Answer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Answer.Font = new System.Drawing.Font("Century Gothic", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer.Location = new System.Drawing.Point(3, 53);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(356, 101);
            this.Answer.TabIndex = 17;
            this.Answer.Text = "0";
            this.Answer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Comma
            // 
            this.Comma.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comma.Location = new System.Drawing.Point(3, 379);
            this.Comma.Name = "Comma";
            this.Comma.Size = new System.Drawing.Size(84, 68);
            this.Comma.TabIndex = 2;
            this.Comma.Text = ".";
            this.Comma.UseVisualStyleBackColor = true;
            this.Comma.GotFocus += new System.EventHandler(this.Comma_Click);
            // 
            // Equal
            // 
            this.Equal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equal.Location = new System.Drawing.Point(183, 379);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(84, 68);
            this.Equal.TabIndex = 0;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 450);
            this.Controls.Add(this.TableGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TableGrid.ResumeLayout(false);
            this.TableGrid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableGrid;
        private System.Windows.Forms.Button Comma;
        private System.Windows.Forms.Button Num0;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button Num7;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.Button Num6;
        private System.Windows.Forms.Button Num8;
        private System.Windows.Forms.Button Num9;
        private System.Windows.Forms.Button Multi;
        private System.Windows.Forms.Button Num4;
        private System.Windows.Forms.Button Num5;
        private System.Windows.Forms.Button Num1;
        private System.Windows.Forms.Button Num2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Num3;
        private System.Windows.Forms.Label Equasion;
        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.Timer timer1;
    }
}

