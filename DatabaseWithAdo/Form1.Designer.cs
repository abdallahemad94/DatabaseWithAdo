namespace DatabaseWithAdo
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
            this.TablesComboBox = new System.Windows.Forms.ComboBox();
            this.TablesLabel = new System.Windows.Forms.Label();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.FilterByComboBox = new System.Windows.Forms.ComboBox();
            this.FilterByLabel = new System.Windows.Forms.Label();
            this.FilterIDBox = new System.Windows.Forms.TextBox();
            this.FilterIDLabel = new System.Windows.Forms.Label();
            this.ViewButton = new System.Windows.Forms.Button();
            this.ValueError = new System.Windows.Forms.ErrorProvider(this.components);
            this.InsertIDBox = new System.Windows.Forms.TextBox();
            this.InsertNameBox = new System.Windows.Forms.TextBox();
            this.InsertCourseDescBox = new System.Windows.Forms.TextBox();
            this.InsertCourseInstBox = new System.Windows.Forms.TextBox();
            this.InsertIDLabel = new System.Windows.Forms.Label();
            this.InsertNamelabel = new System.Windows.Forms.Label();
            this.InsertCourseDescLabel = new System.Windows.Forms.Label();
            this.InsertCourseInstLabel = new System.Windows.Forms.Label();
            this.InsertButton = new System.Windows.Forms.Button();
            this.DeleteIDBox = new System.Windows.Forms.TextBox();
            this.DeleteIDLable = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueError)).BeginInit();
            this.SuspendLayout();
            // 
            // TablesComboBox
            // 
            this.TablesComboBox.FormattingEnabled = true;
            this.TablesComboBox.Location = new System.Drawing.Point(67, 9);
            this.TablesComboBox.Name = "TablesComboBox";
            this.TablesComboBox.Size = new System.Drawing.Size(135, 21);
            this.TablesComboBox.TabIndex = 1;
            this.TablesComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTableList_SelectedIndexChanged);
            // 
            // TablesLabel
            // 
            this.TablesLabel.AutoSize = true;
            this.TablesLabel.Location = new System.Drawing.Point(0, 12);
            this.TablesLabel.Name = "TablesLabel";
            this.TablesLabel.Size = new System.Drawing.Size(40, 13);
            this.TablesLabel.TabIndex = 0;
            this.TablesLabel.Text = "Table: ";
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AllowUserToResizeRows = false;
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGridView.GridColor = System.Drawing.Color.Gold;
            this.DataGridView.Location = new System.Drawing.Point(309, 12);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.ShowEditingIcon = false;
            this.DataGridView.Size = new System.Drawing.Size(513, 437);
            this.DataGridView.TabIndex = 3;
            // 
            // FilterByComboBox
            // 
            this.FilterByComboBox.FormattingEnabled = true;
            this.FilterByComboBox.Items.AddRange(new object[] {
            "None",
            "Student",
            "Course",
            "Instructor"});
            this.FilterByComboBox.Location = new System.Drawing.Point(67, 36);
            this.FilterByComboBox.Name = "FilterByComboBox";
            this.FilterByComboBox.Size = new System.Drawing.Size(121, 21);
            this.FilterByComboBox.TabIndex = 2;
            this.FilterByComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterByComboBox_SelectedIndexChanged);
            // 
            // FilterByLabel
            // 
            this.FilterByLabel.AutoSize = true;
            this.FilterByLabel.Location = new System.Drawing.Point(0, 39);
            this.FilterByLabel.Name = "FilterByLabel";
            this.FilterByLabel.Size = new System.Drawing.Size(47, 13);
            this.FilterByLabel.TabIndex = 0;
            this.FilterByLabel.Text = "Filter By:";
            // 
            // FilterIDBox
            // 
            this.FilterIDBox.Location = new System.Drawing.Point(67, 63);
            this.FilterIDBox.Name = "FilterIDBox";
            this.FilterIDBox.Size = new System.Drawing.Size(100, 20);
            this.FilterIDBox.TabIndex = 3;
            this.FilterIDBox.Visible = false;
            // 
            // FilterIDLabel
            // 
            this.FilterIDLabel.AutoSize = true;
            this.FilterIDLabel.Location = new System.Drawing.Point(0, 66);
            this.FilterIDLabel.Name = "FilterIDLabel";
            this.FilterIDLabel.Size = new System.Drawing.Size(44, 13);
            this.FilterIDLabel.TabIndex = 0;
            this.FilterIDLabel.Text = "IDLabel";
            this.FilterIDLabel.Visible = false;
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(228, 89);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(75, 23);
            this.ViewButton.TabIndex = 4;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Visible = false;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // ValueError
            // 
            this.ValueError.ContainerControl = this;
            // 
            // InsertIDBox
            // 
            this.InsertIDBox.Location = new System.Drawing.Point(116, 131);
            this.InsertIDBox.Name = "InsertIDBox";
            this.InsertIDBox.Size = new System.Drawing.Size(100, 20);
            this.InsertIDBox.TabIndex = 5;
            this.InsertIDBox.Visible = false;
            // 
            // InsertNameBox
            // 
            this.InsertNameBox.Location = new System.Drawing.Point(116, 157);
            this.InsertNameBox.Name = "InsertNameBox";
            this.InsertNameBox.Size = new System.Drawing.Size(100, 20);
            this.InsertNameBox.TabIndex = 6;
            this.InsertNameBox.Visible = false;
            // 
            // InsertCourseDescBox
            // 
            this.InsertCourseDescBox.Location = new System.Drawing.Point(116, 183);
            this.InsertCourseDescBox.Name = "InsertCourseDescBox";
            this.InsertCourseDescBox.Size = new System.Drawing.Size(100, 20);
            this.InsertCourseDescBox.TabIndex = 7;
            this.InsertCourseDescBox.Visible = false;
            // 
            // InsertCourseInstBox
            // 
            this.InsertCourseInstBox.AccessibleDescription = "";
            this.InsertCourseInstBox.AccessibleName = "";
            this.InsertCourseInstBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InsertCourseInstBox.Location = new System.Drawing.Point(116, 209);
            this.InsertCourseInstBox.Name = "InsertCourseInstBox";
            this.InsertCourseInstBox.Size = new System.Drawing.Size(100, 20);
            this.InsertCourseInstBox.TabIndex = 8;
            this.InsertCourseInstBox.Visible = false;
            // 
            // InsertIDLabel
            // 
            this.InsertIDLabel.AutoSize = true;
            this.InsertIDLabel.Location = new System.Drawing.Point(0, 134);
            this.InsertIDLabel.Name = "InsertIDLabel";
            this.InsertIDLabel.Size = new System.Drawing.Size(44, 13);
            this.InsertIDLabel.TabIndex = 0;
            this.InsertIDLabel.Text = "InsertID";
            this.InsertIDLabel.Visible = false;
            // 
            // InsertNamelabel
            // 
            this.InsertNamelabel.AutoSize = true;
            this.InsertNamelabel.Location = new System.Drawing.Point(0, 160);
            this.InsertNamelabel.Name = "InsertNamelabel";
            this.InsertNamelabel.Size = new System.Drawing.Size(61, 13);
            this.InsertNamelabel.TabIndex = 0;
            this.InsertNamelabel.Text = "InsertName";
            this.InsertNamelabel.Visible = false;
            // 
            // InsertCourseDescLabel
            // 
            this.InsertCourseDescLabel.AutoSize = true;
            this.InsertCourseDescLabel.Location = new System.Drawing.Point(0, 186);
            this.InsertCourseDescLabel.Name = "InsertCourseDescLabel";
            this.InsertCourseDescLabel.Size = new System.Drawing.Size(99, 13);
            this.InsertCourseDescLabel.TabIndex = 0;
            this.InsertCourseDescLabel.Text = "Course Description:";
            this.InsertCourseDescLabel.Visible = false;
            // 
            // InsertCourseInstLabel
            // 
            this.InsertCourseInstLabel.AutoSize = true;
            this.InsertCourseInstLabel.Location = new System.Drawing.Point(0, 212);
            this.InsertCourseInstLabel.Name = "InsertCourseInstLabel";
            this.InsertCourseInstLabel.Size = new System.Drawing.Size(104, 13);
            this.InsertCourseInstLabel.TabIndex = 0;
            this.InsertCourseInstLabel.Text = "Course Instructor ID:";
            this.InsertCourseInstLabel.Visible = false;
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(228, 235);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(75, 23);
            this.InsertButton.TabIndex = 9;
            this.InsertButton.Text = "Add Item";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Visible = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // DeleteIDBox
            // 
            this.DeleteIDBox.Location = new System.Drawing.Point(81, 303);
            this.DeleteIDBox.Name = "DeleteIDBox";
            this.DeleteIDBox.Size = new System.Drawing.Size(100, 20);
            this.DeleteIDBox.TabIndex = 10;
            // 
            // DeleteIDLable
            // 
            this.DeleteIDLable.AutoSize = true;
            this.DeleteIDLable.Location = new System.Drawing.Point(0, 306);
            this.DeleteIDLable.Name = "DeleteIDLable";
            this.DeleteIDLable.Size = new System.Drawing.Size(18, 13);
            this.DeleteIDLable.TabIndex = 11;
            this.DeleteIDLable.Text = "ID";
            this.DeleteIDLable.Visible = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(228, 329);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "Delete Item";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Visible = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.DeleteIDLable);
            this.Controls.Add(this.DeleteIDBox);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.InsertCourseInstLabel);
            this.Controls.Add(this.InsertCourseDescLabel);
            this.Controls.Add(this.InsertNamelabel);
            this.Controls.Add(this.InsertIDLabel);
            this.Controls.Add(this.InsertCourseInstBox);
            this.Controls.Add(this.InsertCourseDescBox);
            this.Controls.Add(this.InsertNameBox);
            this.Controls.Add(this.InsertIDBox);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.FilterIDLabel);
            this.Controls.Add(this.FilterIDBox);
            this.Controls.Add(this.FilterByLabel);
            this.Controls.Add(this.FilterByComboBox);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.TablesLabel);
            this.Controls.Add(this.TablesComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox TablesComboBox;
        private System.Windows.Forms.Label TablesLabel;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.ComboBox FilterByComboBox;
        private System.Windows.Forms.Label FilterByLabel;
        private System.Windows.Forms.TextBox FilterIDBox;
        private System.Windows.Forms.Label FilterIDLabel;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.ErrorProvider ValueError;
        private System.Windows.Forms.Label InsertCourseInstLabel;
        private System.Windows.Forms.Label InsertCourseDescLabel;
        private System.Windows.Forms.Label InsertNamelabel;
        private System.Windows.Forms.Label InsertIDLabel;
        private System.Windows.Forms.TextBox InsertCourseInstBox;
        private System.Windows.Forms.TextBox InsertCourseDescBox;
        private System.Windows.Forms.TextBox InsertNameBox;
        private System.Windows.Forms.TextBox InsertIDBox;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Label DeleteIDLable;
        private System.Windows.Forms.TextBox DeleteIDBox;
        private System.Windows.Forms.Button DeleteButton;
    }
}

