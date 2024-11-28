namespace LR6
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
            dataGridView1 = new DataGridView();
            btnSaveToBinary = new Button();
            btnSaveToText = new Button();
            btnLoadFromBinary = new Button();
            btnLoadFromText = new Button();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(258, 174);
            dataGridView1.TabIndex = 0;
            // 
            // btnSaveToBinary
            // 
            btnSaveToBinary.Location = new Point(370, 84);
            btnSaveToBinary.Name = "btnSaveToBinary";
            btnSaveToBinary.Size = new Size(121, 23);
            btnSaveToBinary.TabIndex = 1;
            btnSaveToBinary.Text = "Save to Binary";
            btnSaveToBinary.UseVisualStyleBackColor = true;
            btnSaveToBinary.Click += btnSaveToBinary_Click;
            // 
            // btnSaveToText
            // 
            btnSaveToText.Location = new Point(370, 121);
            btnSaveToText.Name = "btnSaveToText";
            btnSaveToText.Size = new Size(121, 23);
            btnSaveToText.TabIndex = 2;
            btnSaveToText.Text = "Save to Text";
            btnSaveToText.UseVisualStyleBackColor = true;
            btnSaveToText.Click += btnSaveToText_Click;
            // 
            // btnLoadFromBinary
            // 
            btnLoadFromBinary.Location = new Point(370, 161);
            btnLoadFromBinary.Name = "btnLoadFromBinary";
            btnLoadFromBinary.Size = new Size(121, 23);
            btnLoadFromBinary.TabIndex = 3;
            btnLoadFromBinary.Text = "Load from Binary";
            btnLoadFromBinary.UseVisualStyleBackColor = true;
            btnLoadFromBinary.Click += btnLoadFromBinary_Click;
            // 
            // btnLoadFromText
            // 
            btnLoadFromText.Location = new Point(370, 201);
            btnLoadFromText.Name = "btnLoadFromText";
            btnLoadFromText.Size = new Size(121, 23);
            btnLoadFromText.TabIndex = 4;
            btnLoadFromText.Text = "Load from Text";
            btnLoadFromText.UseVisualStyleBackColor = true;
            btnLoadFromText.Click += btnLoadFromText_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoadFromText);
            Controls.Add(btnLoadFromBinary);
            Controls.Add(btnSaveToText);
            Controls.Add(btnSaveToBinary);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnSaveToBinary;
        private Button btnSaveToText;
        private Button btnLoadFromBinary;
        private Button btnLoadFromText;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}
