namespace Blind_dating.Web_forms
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.blinddatingDataSet = new Blind_dating.Web_forms.blinddatingDataSet();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityTableAdapter = new Blind_dating.Web_forms.blinddatingDataSetTableAdapters.CityTableAdapter();
            this.tableAdapterManager = new Blind_dating.Web_forms.blinddatingDataSetTableAdapters.TableAdapterManager();
            this.btnShowRequest = new System.Windows.Forms.Button();
            this.btnShowQeustions = new System.Windows.Forms.Button();
            this.btnShowCities = new System.Windows.Forms.Button();
            this.btnShowDates = new System.Windows.Forms.Button();
            this.blinddatingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveChanging = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.blinddatingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blinddatingDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // blinddatingDataSet
            // 
            this.blinddatingDataSet.DataSetName = "blinddatingDataSet";
            this.blinddatingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "City";
            this.cityBindingSource.DataSource = this.blinddatingDataSet;
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CityTableAdapter = this.cityTableAdapter;
            this.tableAdapterManager.DateStatusTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Blind_dating.Web_forms.blinddatingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnShowRequest
            // 
            this.btnShowRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowRequest.Location = new System.Drawing.Point(8, 31);
            this.btnShowRequest.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowRequest.Name = "btnShowRequest";
            this.btnShowRequest.Size = new System.Drawing.Size(192, 36);
            this.btnShowRequest.TabIndex = 0;
            this.btnShowRequest.Text = "Requests";
            this.btnShowRequest.UseVisualStyleBackColor = true;
            // 
            // btnShowQeustions
            // 
            this.btnShowQeustions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowQeustions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowQeustions.Location = new System.Drawing.Point(8, 75);
            this.btnShowQeustions.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowQeustions.Name = "btnShowQeustions";
            this.btnShowQeustions.Size = new System.Drawing.Size(192, 36);
            this.btnShowQeustions.TabIndex = 1;
            this.btnShowQeustions.Text = "Questions";
            this.btnShowQeustions.UseVisualStyleBackColor = true;
            // 
            // btnShowCities
            // 
            this.btnShowCities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowCities.Location = new System.Drawing.Point(8, 117);
            this.btnShowCities.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowCities.Name = "btnShowCities";
            this.btnShowCities.Size = new System.Drawing.Size(192, 36);
            this.btnShowCities.TabIndex = 2;
            this.btnShowCities.Text = "Cities";
            this.btnShowCities.UseVisualStyleBackColor = true;
            this.btnShowCities.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btnShowDates
            // 
            this.btnShowDates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowDates.Location = new System.Drawing.Point(8, 160);
            this.btnShowDates.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowDates.Name = "btnShowDates";
            this.btnShowDates.Size = new System.Drawing.Size(192, 36);
            this.btnShowDates.TabIndex = 3;
            this.btnShowDates.Text = "Types of date";
            this.btnShowDates.UseVisualStyleBackColor = true;
            // 
            // blinddatingDataSetBindingSource
            // 
            this.blinddatingDataSetBindingSource.DataSource = this.blinddatingDataSet;
            this.blinddatingDataSetBindingSource.Position = 0;
            // 
            // cityBindingSource1
            // 
            this.cityBindingSource1.DataMember = "City";
            this.cityBindingSource1.DataSource = this.blinddatingDataSetBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(887, 524);
            this.dataGridView1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.btnShowQeustions);
            this.groupBox1.Controls.Add(this.btnShowDates);
            this.groupBox1.Controls.Add(this.btnShowRequest);
            this.groupBox1.Controls.Add(this.btnShowCities);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(931, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(208, 214);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose table";
            // 
            // saveChanging
            // 
            this.saveChanging.BackColor = System.Drawing.SystemColors.ControlText;
            this.saveChanging.FlatAppearance.BorderSize = 3;
            this.saveChanging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveChanging.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveChanging.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveChanging.Location = new System.Drawing.Point(931, 263);
            this.saveChanging.Margin = new System.Windows.Forms.Padding(4);
            this.saveChanging.Name = "saveChanging";
            this.saveChanging.Size = new System.Drawing.Size(208, 42);
            this.saveChanging.TabIndex = 6;
            this.saveChanging.Text = "Save";
            this.saveChanging.UseVisualStyleBackColor = false;
            this.saveChanging.Click += new System.EventHandler(this.SaveChanging_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1173, 554);
            this.Controls.Add(this.saveChanging);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.blinddatingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blinddatingDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private blinddatingDataSet blinddatingDataSet;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private blinddatingDataSetTableAdapters.CityTableAdapter cityTableAdapter;
        private blinddatingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnShowRequest;
        private System.Windows.Forms.Button btnShowQeustions;
        private System.Windows.Forms.Button btnShowCities;
        private System.Windows.Forms.Button btnShowDates;
        private System.Windows.Forms.BindingSource blinddatingDataSetBindingSource;
        private System.Windows.Forms.BindingSource cityBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveChanging;
    }
}