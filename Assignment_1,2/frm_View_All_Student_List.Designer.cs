
namespace _01_Assignment
{
    partial class frm_View_All_Student_List
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
            this.lbl_View_All_Student_List = new System.Windows.Forms.Label();
            this.studentDetailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this._VRAssignment_dboDataSet2 = new _01_Assignment._VRAssignment_dboDataSet2();
            this.studentDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._VRAssignment_dboDataSet1 = new _01_Assignment._VRAssignment_dboDataSet1();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.btn_Add_New_Student = new System.Windows.Forms.Button();
            this.btn_Search_Student = new System.Windows.Forms.Button();
            this._VRAssignment_dboDataSet = new _01_Assignment._VRAssignment_dboDataSet();
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_DetailsTableAdapter = new _01_Assignment._VRAssignment_dboDataSet1TableAdapters.Student_DetailsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDetailsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this._VSRAssignment_dboDataSet = new _01_Assignment._VSRAssignment_dboDataSet();
            this.student_DetailsTableAdapter1 = new _01_Assignment._VSRAssignment_dboDataSetTableAdapters.Student_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._VRAssignment_dboDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._VRAssignment_dboDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._VRAssignment_dboDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._VSRAssignment_dboDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_View_All_Student_List
            // 
            this.lbl_View_All_Student_List.AutoSize = true;
            this.lbl_View_All_Student_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_View_All_Student_List.Font = new System.Drawing.Font("Century", 40.2F);
            this.lbl_View_All_Student_List.ForeColor = System.Drawing.Color.SlateBlue;
            this.lbl_View_All_Student_List.Location = new System.Drawing.Point(254, 43);
            this.lbl_View_All_Student_List.Name = "lbl_View_All_Student_List";
            this.lbl_View_All_Student_List.Size = new System.Drawing.Size(715, 82);
            this.lbl_View_All_Student_List.TabIndex = 0;
            this.lbl_View_All_Student_List.Text = "View All Student List";
            // 
            // studentDetailsBindingSource2
            // 
            this.studentDetailsBindingSource2.DataMember = "Student_Details";
            this.studentDetailsBindingSource2.DataSource = this._VRAssignment_dboDataSet2;
            // 
            // _VRAssignment_dboDataSet2
            // 
            this._VRAssignment_dboDataSet2.DataSetName = "_VRAssignment_dboDataSet2";
            this._VRAssignment_dboDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDetailsBindingSource1
            // 
            this.studentDetailsBindingSource1.DataMember = "Student_Details";
            this.studentDetailsBindingSource1.DataSource = this._VRAssignment_dboDataSet1;
            // 
            // _VRAssignment_dboDataSet1
            // 
            this._VRAssignment_dboDataSet1.DataSetName = "_VRAssignment_dboDataSet1";
            this._VRAssignment_dboDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Username.Font = new System.Drawing.Font("Sitka Banner", 24F);
            this.lbl_Username.ForeColor = System.Drawing.Color.Red;
            this.lbl_Username.Location = new System.Drawing.Point(7, 0);
            this.lbl_Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(179, 58);
            this.lbl_Username.TabIndex = 95;
            this.lbl_Username.Text = "Username";
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.White;
            this.btn_Log_Out.Font = new System.Drawing.Font("Sitka Banner", 24F);
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Red;
            this.btn_Log_Out.Location = new System.Drawing.Point(1060, 0);
            this.btn_Log_Out.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(171, 71);
            this.btn_Log_Out.TabIndex = 3;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // btn_Add_New_Student
            // 
            this.btn_Add_New_Student.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Add_New_Student.Font = new System.Drawing.Font("Sitka Banner", 24F);
            this.btn_Add_New_Student.ForeColor = System.Drawing.Color.Red;
            this.btn_Add_New_Student.Location = new System.Drawing.Point(133, 785);
            this.btn_Add_New_Student.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add_New_Student.Name = "btn_Add_New_Student";
            this.btn_Add_New_Student.Size = new System.Drawing.Size(349, 76);
            this.btn_Add_New_Student.TabIndex = 1;
            this.btn_Add_New_Student.Text = "Add New Student";
            this.btn_Add_New_Student.UseVisualStyleBackColor = false;
            this.btn_Add_New_Student.Click += new System.EventHandler(this.btn_Add_New_Student_Click);
            // 
            // btn_Search_Student
            // 
            this.btn_Search_Student.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Search_Student.Font = new System.Drawing.Font("Sitka Banner", 24F);
            this.btn_Search_Student.ForeColor = System.Drawing.Color.Red;
            this.btn_Search_Student.Location = new System.Drawing.Point(751, 785);
            this.btn_Search_Student.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Search_Student.Name = "btn_Search_Student";
            this.btn_Search_Student.Size = new System.Drawing.Size(324, 76);
            this.btn_Search_Student.TabIndex = 2;
            this.btn_Search_Student.Text = "Search Student";
            this.btn_Search_Student.UseVisualStyleBackColor = false;
            this.btn_Search_Student.Click += new System.EventHandler(this.btn_Search_Student_Click);
            // 
            // _VRAssignment_dboDataSet
            // 
            this._VRAssignment_dboDataSet.DataSetName = "_VRAssignment_dboDataSet";
            this._VRAssignment_dboDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDetailsBindingSource
            // 
            this.studentDetailsBindingSource.DataMember = "Student_Details";
            this.studentDetailsBindingSource.DataSource = this._VRAssignment_dboDataSet;
            // 
            // student_DetailsTableAdapter
            // 
            this.student_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mobNODataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentDetailsBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1220, 567);
            this.dataGridView1.TabIndex = 99;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            this.rollNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobNODataGridViewTextBoxColumn
            // 
            this.mobNODataGridViewTextBoxColumn.DataPropertyName = "Mob_NO";
            this.mobNODataGridViewTextBoxColumn.HeaderText = "Mob_NO";
            this.mobNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mobNODataGridViewTextBoxColumn.Name = "mobNODataGridViewTextBoxColumn";
            this.mobNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentDetailsBindingSource3
            // 
            this.studentDetailsBindingSource3.DataMember = "Student_Details";
            this.studentDetailsBindingSource3.DataSource = this._VSRAssignment_dboDataSet;
            // 
            // _VSRAssignment_dboDataSet
            // 
            this._VSRAssignment_dboDataSet.DataSetName = "_VSRAssignment_dboDataSet";
            this._VSRAssignment_dboDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_DetailsTableAdapter1
            // 
            this.student_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // frm_View_All_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 905);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Search_Student);
            this.Controls.Add(this.btn_Add_New_Student);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_View_All_Student_List);
            this.Name = "frm_View_All_Student_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Student List";
            this.Load += new System.EventHandler(this.frm_View_All_Student_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._VRAssignment_dboDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._VRAssignment_dboDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._VRAssignment_dboDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._VSRAssignment_dboDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_All_Student_List;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Button btn_Add_New_Student;
        private System.Windows.Forms.Button btn_Search_Student;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private _VRAssignment_dboDataSet _VRAssignment_dboDataSet;
        private _VRAssignment_dboDataSet1 _VRAssignment_dboDataSet1;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource1;
        private _VRAssignment_dboDataSet1TableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource2;
        private _VRAssignment_dboDataSet2 _VRAssignment_dboDataSet2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _VSRAssignment_dboDataSet _VSRAssignment_dboDataSet;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource3;
        private _VSRAssignment_dboDataSetTableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
    }
}