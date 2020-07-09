namespace CarReportSystem {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbRecoder = new System.Windows.Forms.ComboBox();
            this.cbCarName = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.rbToyota = new System.Windows.Forms.RadioButton();
            this.rbNissan = new System.Windows.Forms.RadioButton();
            this.rbHonda = new System.Windows.Forms.RadioButton();
            this.rbSubaru = new System.Windows.Forms.RadioButton();
            this.rbGaisya = new System.Windows.Forms.RadioButton();
            this.rbSonota = new System.Windows.Forms.RadioButton();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.dgvCarReportData = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.pbCarImage = new System.Windows.Forms.PictureBox();
            this.btImageOpen = new System.Windows.Forms.Button();
            this.btImageClear = new System.Windows.Forms.Button();
            this.btDataAdd = new System.Windows.Forms.Button();
            this.btDataClear = new System.Windows.Forms.Button();
            this.btDataFix = new System.Windows.Forms.Button();
            this.btEnd = new System.Windows.Forms.Button();
            this.btDataOpen = new System.Windows.Forms.Button();
            this.btDataSave = new System.Windows.Forms.Button();
            this.gbMaker = new System.Windows.Forms.GroupBox();
            this.ofdOpenData = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveData = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarReportData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarImage)).BeginInit();
            this.gbMaker.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "記録者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "メーカー：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "車名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "レポート：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "記事一覧：";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(113, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 19);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // cbRecoder
            // 
            this.cbRecoder.FormattingEnabled = true;
            this.cbRecoder.Location = new System.Drawing.Point(113, 51);
            this.cbRecoder.Name = "cbRecoder";
            this.cbRecoder.Size = new System.Drawing.Size(272, 20);
            this.cbRecoder.TabIndex = 2;
            // 
            // cbCarName
            // 
            this.cbCarName.FormattingEnabled = true;
            this.cbCarName.Location = new System.Drawing.Point(113, 117);
            this.cbCarName.Name = "cbCarName";
            this.cbCarName.Size = new System.Drawing.Size(272, 20);
            this.cbCarName.TabIndex = 2;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(113, 19);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(218, 19);
            this.dtpDate.TabIndex = 1;
            // 
            // rbToyota
            // 
            this.rbToyota.AutoSize = true;
            this.rbToyota.Checked = true;
            this.rbToyota.Location = new System.Drawing.Point(6, 8);
            this.rbToyota.Name = "rbToyota";
            this.rbToyota.Size = new System.Drawing.Size(47, 16);
            this.rbToyota.TabIndex = 3;
            this.rbToyota.TabStop = true;
            this.rbToyota.Text = "トヨタ";
            this.rbToyota.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            this.rbNissan.AutoSize = true;
            this.rbNissan.Location = new System.Drawing.Point(58, 8);
            this.rbNissan.Name = "rbNissan";
            this.rbNissan.Size = new System.Drawing.Size(47, 16);
            this.rbNissan.TabIndex = 3;
            this.rbNissan.Text = "日産";
            this.rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            this.rbHonda.AutoSize = true;
            this.rbHonda.Location = new System.Drawing.Point(110, 8);
            this.rbHonda.Name = "rbHonda";
            this.rbHonda.Size = new System.Drawing.Size(51, 16);
            this.rbHonda.TabIndex = 3;
            this.rbHonda.Text = "ホンダ";
            this.rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            this.rbSubaru.AutoSize = true;
            this.rbSubaru.Location = new System.Drawing.Point(166, 8);
            this.rbSubaru.Name = "rbSubaru";
            this.rbSubaru.Size = new System.Drawing.Size(52, 16);
            this.rbSubaru.TabIndex = 3;
            this.rbSubaru.Text = "スバル";
            this.rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbGaisya
            // 
            this.rbGaisya.AutoSize = true;
            this.rbGaisya.Location = new System.Drawing.Point(223, 8);
            this.rbGaisya.Name = "rbGaisya";
            this.rbGaisya.Size = new System.Drawing.Size(47, 16);
            this.rbGaisya.TabIndex = 3;
            this.rbGaisya.Text = "外車";
            this.rbGaisya.UseVisualStyleBackColor = true;
            // 
            // rbSonota
            // 
            this.rbSonota.AutoSize = true;
            this.rbSonota.Location = new System.Drawing.Point(275, 8);
            this.rbSonota.Name = "rbSonota";
            this.rbSonota.Size = new System.Drawing.Size(54, 16);
            this.rbSonota.TabIndex = 3;
            this.rbSonota.Text = "その他";
            this.rbSonota.UseVisualStyleBackColor = true;
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(113, 158);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(333, 106);
            this.tbReport.TabIndex = 4;
            // 
            // dgvCarReportData
            // 
            this.dgvCarReportData.AllowUserToAddRows = false;
            this.dgvCarReportData.AllowUserToDeleteRows = false;
            this.dgvCarReportData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvCarReportData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarReportData.Location = new System.Drawing.Point(113, 270);
            this.dgvCarReportData.MultiSelect = false;
            this.dgvCarReportData.Name = "dgvCarReportData";
            this.dgvCarReportData.ReadOnly = true;
            this.dgvCarReportData.RowTemplate.Height = 21;
            this.dgvCarReportData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarReportData.Size = new System.Drawing.Size(632, 142);
            this.dgvCarReportData.TabIndex = 5;
            this.dgvCarReportData.Click += new System.EventHandler(this.dgvCarReportData_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(472, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "画像：";
            // 
            // pbCarImage
            // 
            this.pbCarImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCarImage.Location = new System.Drawing.Point(474, 56);
            this.pbCarImage.Name = "pbCarImage";
            this.pbCarImage.Size = new System.Drawing.Size(271, 176);
            this.pbCarImage.TabIndex = 6;
            this.pbCarImage.TabStop = false;
            // 
            // btImageOpen
            // 
            this.btImageOpen.Location = new System.Drawing.Point(589, 27);
            this.btImageOpen.Name = "btImageOpen";
            this.btImageOpen.Size = new System.Drawing.Size(75, 23);
            this.btImageOpen.TabIndex = 7;
            this.btImageOpen.Text = "開く";
            this.btImageOpen.UseVisualStyleBackColor = true;
            this.btImageOpen.Click += new System.EventHandler(this.btImageOpen_Click);
            // 
            // btImageClear
            // 
            this.btImageClear.Location = new System.Drawing.Point(670, 27);
            this.btImageClear.Name = "btImageClear";
            this.btImageClear.Size = new System.Drawing.Size(75, 23);
            this.btImageClear.TabIndex = 7;
            this.btImageClear.Text = "削除";
            this.btImageClear.UseVisualStyleBackColor = true;
            this.btImageClear.Click += new System.EventHandler(this.btImageClear_Click);
            // 
            // btDataAdd
            // 
            this.btDataAdd.Location = new System.Drawing.Point(474, 238);
            this.btDataAdd.Name = "btDataAdd";
            this.btDataAdd.Size = new System.Drawing.Size(75, 23);
            this.btDataAdd.TabIndex = 7;
            this.btDataAdd.Text = "追加";
            this.btDataAdd.UseVisualStyleBackColor = true;
            this.btDataAdd.Click += new System.EventHandler(this.btDataAdd_Click);
            // 
            // btDataClear
            // 
            this.btDataClear.Enabled = false;
            this.btDataClear.Location = new System.Drawing.Point(670, 238);
            this.btDataClear.Name = "btDataClear";
            this.btDataClear.Size = new System.Drawing.Size(75, 23);
            this.btDataClear.TabIndex = 7;
            this.btDataClear.Text = "削除";
            this.btDataClear.UseVisualStyleBackColor = true;
            this.btDataClear.Click += new System.EventHandler(this.btDataClear_Click);
            // 
            // btDataFix
            // 
            this.btDataFix.Enabled = false;
            this.btDataFix.Location = new System.Drawing.Point(572, 238);
            this.btDataFix.Name = "btDataFix";
            this.btDataFix.Size = new System.Drawing.Size(75, 23);
            this.btDataFix.TabIndex = 7;
            this.btDataFix.Text = "修正";
            this.btDataFix.UseVisualStyleBackColor = true;
            this.btDataFix.Click += new System.EventHandler(this.btDataFix_Click);
            // 
            // btEnd
            // 
            this.btEnd.Location = new System.Drawing.Point(638, 418);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(107, 23);
            this.btEnd.TabIndex = 7;
            this.btEnd.Text = "終了";
            this.btEnd.UseVisualStyleBackColor = true;
            this.btEnd.Click += new System.EventHandler(this.btEnd_Click);
            // 
            // btDataOpen
            // 
            this.btDataOpen.Location = new System.Drawing.Point(38, 298);
            this.btDataOpen.Name = "btDataOpen";
            this.btDataOpen.Size = new System.Drawing.Size(69, 34);
            this.btDataOpen.TabIndex = 7;
            this.btDataOpen.Text = "開く";
            this.btDataOpen.UseVisualStyleBackColor = true;
            this.btDataOpen.Click += new System.EventHandler(this.btDataOpen_Click);
            // 
            // btDataSave
            // 
            this.btDataSave.Location = new System.Drawing.Point(39, 338);
            this.btDataSave.Name = "btDataSave";
            this.btDataSave.Size = new System.Drawing.Size(69, 34);
            this.btDataSave.TabIndex = 7;
            this.btDataSave.Text = "保存";
            this.btDataSave.UseVisualStyleBackColor = true;
            this.btDataSave.Click += new System.EventHandler(this.btDataSave_Click);
            // 
            // gbMaker
            // 
            this.gbMaker.Controls.Add(this.rbToyota);
            this.gbMaker.Controls.Add(this.rbNissan);
            this.gbMaker.Controls.Add(this.rbHonda);
            this.gbMaker.Controls.Add(this.rbSubaru);
            this.gbMaker.Controls.Add(this.rbGaisya);
            this.gbMaker.Controls.Add(this.rbSonota);
            this.gbMaker.Location = new System.Drawing.Point(113, 82);
            this.gbMaker.Name = "gbMaker";
            this.gbMaker.Size = new System.Drawing.Size(333, 29);
            this.gbMaker.TabIndex = 8;
            this.gbMaker.TabStop = false;
            // 
            // ofdOpenData
            // 
            this.ofdOpenData.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbMaker);
            this.Controls.Add(this.btImageClear);
            this.Controls.Add(this.btDataFix);
            this.Controls.Add(this.btDataSave);
            this.Controls.Add(this.btDataOpen);
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.btDataClear);
            this.Controls.Add(this.btDataAdd);
            this.Controls.Add(this.btImageOpen);
            this.Controls.Add(this.pbCarImage);
            this.Controls.Add(this.dgvCarReportData);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.cbCarName);
            this.Controls.Add(this.cbRecoder);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "試乗レポート管理システム";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarReportData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarImage)).EndInit();
            this.gbMaker.ResumeLayout(false);
            this.gbMaker.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbRecoder;
        private System.Windows.Forms.ComboBox cbCarName;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.RadioButton rbToyota;
        private System.Windows.Forms.RadioButton rbNissan;
        private System.Windows.Forms.RadioButton rbHonda;
        private System.Windows.Forms.RadioButton rbSubaru;
        private System.Windows.Forms.RadioButton rbGaisya;
        private System.Windows.Forms.RadioButton rbSonota;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.DataGridView dgvCarReportData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbCarImage;
        private System.Windows.Forms.Button btImageOpen;
        private System.Windows.Forms.Button btImageClear;
        private System.Windows.Forms.Button btDataAdd;
        private System.Windows.Forms.Button btDataClear;
        private System.Windows.Forms.Button btDataFix;
        private System.Windows.Forms.Button btEnd;
        private System.Windows.Forms.Button btDataOpen;
        private System.Windows.Forms.Button btDataSave;
        private System.Windows.Forms.GroupBox gbMaker;
        private System.Windows.Forms.OpenFileDialog ofdOpenData;
        private System.Windows.Forms.SaveFileDialog sfdSaveData;
    }
}

