namespace CRUD
{
    partial class NoteTakingApplication
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
            title_txtBox = new TextBox();
            description_txtBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            notesDGV = new DataGridView();
            createButton = new Button();
            readButton = new Button();
            saveButton = new Button();
            deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)notesDGV).BeginInit();
            SuspendLayout();
            // 
            // title_txtBox
            // 
            title_txtBox.Location = new Point(12, 50);
            title_txtBox.Name = "title_txtBox";
            title_txtBox.Size = new Size(276, 23);
            title_txtBox.TabIndex = 0;
            // 
            // description_txtBox
            // 
            description_txtBox.Location = new Point(12, 123);
            description_txtBox.Multiline = true;
            description_txtBox.Name = "description_txtBox";
            description_txtBox.Size = new Size(276, 303);
            description_txtBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(42, 21);
            label1.TabIndex = 2;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 3;
            label2.Text = "Description";
            // 
            // notesDGV
            // 
            notesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            notesDGV.BackgroundColor = Color.White;
            notesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            notesDGV.Location = new Point(310, 50);
            notesDGV.Name = "notesDGV";
            notesDGV.RowTemplate.Height = 25;
            notesDGV.Size = new Size(478, 257);
            notesDGV.TabIndex = 4;
            notesDGV.CellDoubleClick += notesDGV_CellDoubleClick;
            // 
            // createButton
            // 
            createButton.Location = new Point(390, 313);
            createButton.Name = "createButton";
            createButton.Size = new Size(100, 43);
            createButton.TabIndex = 5;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // readButton
            // 
            readButton.Location = new Point(568, 313);
            readButton.Name = "readButton";
            readButton.Size = new Size(100, 43);
            readButton.TabIndex = 6;
            readButton.Text = "Read";
            readButton.UseVisualStyleBackColor = true;
            readButton.Click += readButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(390, 387);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(100, 39);
            saveButton.TabIndex = 7;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(568, 387);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(100, 39);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // NoteTakingApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteButton);
            Controls.Add(saveButton);
            Controls.Add(readButton);
            Controls.Add(createButton);
            Controls.Add(notesDGV);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(description_txtBox);
            Controls.Add(title_txtBox);
            Name = "NoteTakingApplication";
            Text = "Notes";
            Load += NoteTakingApplication_Load;
            ((System.ComponentModel.ISupportInitialize)notesDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox title_txtBox;
        private TextBox description_txtBox;
        private Label label1;
        private Label label2;
        private DataGridView notesDGV;
        private Button createButton;
        private Button readButton;
        private Button saveButton;
        private Button deleteButton;
    }
}