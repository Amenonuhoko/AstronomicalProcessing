namespace AstronomicalProcessing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnBinarySearch = new System.Windows.Forms.Button();
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.btnMidExtreme = new System.Windows.Forms.Button();
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.btnMode = new System.Windows.Forms.Button();
            this.btnRange = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAverage = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(246, 484);
            this.listBox1.TabIndex = 0;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(286, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 33);
            this.textBox1.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(286, 186);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 42);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "Edit";
            this.toolTip1.SetToolTip(this.btnEdit, "Edits the entry to the value in the textbox");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnBinarySearch
            // 
            this.btnBinarySearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBinarySearch.Location = new System.Drawing.Point(356, 12);
            this.btnBinarySearch.Name = "btnBinarySearch";
            this.btnBinarySearch.Size = new System.Drawing.Size(214, 42);
            this.btnBinarySearch.TabIndex = 5;
            this.btnBinarySearch.Text = "Binary Search";
            this.toolTip1.SetToolTip(this.btnBinarySearch, "Performs a binary search");
            this.btnBinarySearch.UseVisualStyleBackColor = true;
            this.btnBinarySearch.Click += new System.EventHandler(this.btnBinarySearch_Click);
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBubbleSort.Location = new System.Drawing.Point(526, 186);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(107, 42);
            this.btnBubbleSort.TabIndex = 6;
            this.btnBubbleSort.Text = "Sort";
            this.toolTip1.SetToolTip(this.btnBubbleSort, "Sorts the list");
            this.btnBubbleSort.UseVisualStyleBackColor = true;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // btnMidExtreme
            // 
            this.btnMidExtreme.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMidExtreme.Location = new System.Drawing.Point(394, 295);
            this.btnMidExtreme.Name = "btnMidExtreme";
            this.btnMidExtreme.Size = new System.Drawing.Size(137, 42);
            this.btnMidExtreme.TabIndex = 8;
            this.btnMidExtreme.TabStop = false;
            this.btnMidExtreme.Text = "Mid-Extreme";
            this.toolTip1.SetToolTip(this.btnMidExtreme, "Sum of the smallest value and the largest value divided by 2");
            this.btnMidExtreme.UseVisualStyleBackColor = true;
            this.btnMidExtreme.Click += new System.EventHandler(this.btnMidExtreme_Click);
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Enabled = false;
            this.textBoxDisplay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDisplay.Location = new System.Drawing.Point(286, 243);
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(347, 33);
            this.textBoxDisplay.TabIndex = 9;
            // 
            // btnMode
            // 
            this.btnMode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMode.Location = new System.Drawing.Point(394, 343);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(137, 42);
            this.btnMode.TabIndex = 10;
            this.btnMode.TabStop = false;
            this.btnMode.Text = "Mode";
            this.toolTip1.SetToolTip(this.btnMode, "Find the number that appears most frequentlyendif");
            this.btnMode.UseVisualStyleBackColor = true;
            // 
            // btnRange
            // 
            this.btnRange.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRange.Location = new System.Drawing.Point(394, 439);
            this.btnRange.Name = "btnRange";
            this.btnRange.Size = new System.Drawing.Size(137, 42);
            this.btnRange.TabIndex = 11;
            this.btnRange.TabStop = false;
            this.btnRange.Text = "Range";
            this.toolTip1.SetToolTip(this.btnRange, "Find the difference between the largest and smallest values");
            this.btnRange.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(356, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 42);
            this.button1.TabIndex = 12;
            this.button1.TabStop = false;
            this.button1.Text = "Sequential Search";
            this.toolTip1.SetToolTip(this.button1, "Performs a sequential search");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAverage
            // 
            this.btnAverage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAverage.Location = new System.Drawing.Point(394, 391);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(137, 42);
            this.btnAverage.TabIndex = 13;
            this.btnAverage.TabStop = false;
            this.btnAverage.Text = "Average";
            this.toolTip1.SetToolTip(this.btnAverage, "Find the average");
            this.btnAverage.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(663, 25);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 503);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRange);
            this.Controls.Add(this.btnMode);
            this.Controls.Add(this.textBoxDisplay);
            this.Controls.Add(this.btnMidExtreme);
            this.Controls.Add(this.btnBubbleSort);
            this.Controls.Add(this.btnBinarySearch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private TextBox textBox1;
        private Button btnEdit;
        private Button btnBinarySearch;
        private Button btnBubbleSort;
        private Button btnMidExtreme;
        private TextBox textBoxDisplay;
        private Button btnMode;
        private Button btnRange;
        private Button button1;
        private ToolTip toolTip1;
        private Button btnAverage;
        private ToolStrip toolStrip1;
    }
}