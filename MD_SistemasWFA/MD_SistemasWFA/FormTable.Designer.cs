namespace MD_SistemasWFA
{
    partial class FormTable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbl_Tables = new MetroFramework.Controls.MetroGrid();
            this.col_Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Caracteristica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Search = new MetroFramework.Controls.MetroTextBox();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.btn_Cancel = new MetroFramework.Controls.MetroTile();
            this.btn_Ok = new MetroFramework.Controls.MetroTile();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Tables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.pnl_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbl_Tables
            // 
            this.tbl_Tables.AllowUserToResizeRows = false;
            this.tbl_Tables.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbl_Tables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbl_Tables.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tbl_Tables.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbl_Tables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tbl_Tables.ColumnHeadersHeight = 40;
            this.tbl_Tables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tbl_Tables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Numero,
            this.col_Cantidad,
            this.col_Estado,
            this.col_Caracteristica});
            this.tbl_Tables.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbl_Tables.DefaultCellStyle = dataGridViewCellStyle5;
            this.tbl_Tables.EnableHeadersVisualStyles = false;
            this.tbl_Tables.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbl_Tables.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbl_Tables.Location = new System.Drawing.Point(24, 96);
            this.tbl_Tables.Name = "tbl_Tables";
            this.tbl_Tables.ReadOnly = true;
            this.tbl_Tables.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbl_Tables.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tbl_Tables.RowHeadersWidth = 70;
            this.tbl_Tables.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tbl_Tables.RowTemplate.Height = 100;
            this.tbl_Tables.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbl_Tables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbl_Tables.Size = new System.Drawing.Size(753, 390);
            this.tbl_Tables.TabIndex = 0;
            this.tbl_Tables.UseCustomForeColor = true;
            this.tbl_Tables.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_Tables_CellClick);
            this.tbl_Tables.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_Tables_CellDoubleClick);
            // 
            // col_Numero
            // 
            this.col_Numero.HeaderText = "N°";
            this.col_Numero.Name = "col_Numero";
            this.col_Numero.ReadOnly = true;
            // 
            // col_Cantidad
            // 
            this.col_Cantidad.HeaderText = "Cantidad";
            this.col_Cantidad.Name = "col_Cantidad";
            this.col_Cantidad.ReadOnly = true;
            // 
            // col_Estado
            // 
            this.col_Estado.HeaderText = "Estado";
            this.col_Estado.Name = "col_Estado";
            this.col_Estado.ReadOnly = true;
            this.col_Estado.Width = 150;
            // 
            // col_Caracteristica
            // 
            this.col_Caracteristica.HeaderText = "Característica";
            this.col_Caracteristica.Name = "col_Caracteristica";
            this.col_Caracteristica.ReadOnly = true;
            this.col_Caracteristica.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_Caracteristica.Width = 200;
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_Search.CustomButton.Image = null;
            this.txt_Search.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.txt_Search.CustomButton.Name = "";
            this.txt_Search.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Search.CustomButton.TabIndex = 1;
            this.txt_Search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Search.CustomButton.UseSelectable = true;
            this.txt_Search.CustomButton.Visible = false;
            this.txt_Search.Lines = new string[0];
            this.txt_Search.Location = new System.Drawing.Point(23, 63);
            this.txt_Search.MaxLength = 32767;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PromptText = "Search . . .";
            this.txt_Search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Search.SelectedText = "";
            this.txt_Search.SelectionLength = 0;
            this.txt_Search.SelectionStart = 0;
            this.txt_Search.ShortcutsEnabled = true;
            this.txt_Search.ShowClearButton = true;
            this.txt_Search.Size = new System.Drawing.Size(221, 23);
            this.txt_Search.TabIndex = 1;
            this.txt_Search.UseSelectable = true;
            this.txt_Search.WaterMark = "Search . . .";
            this.txt_Search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Search_KeyPress);
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.Controls.Add(this.btn_Cancel);
            this.pnl_Bottom.Controls.Add(this.btn_Ok);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(20, 536);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(760, 44);
            this.pnl_Bottom.TabIndex = 12;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.ActiveControl = null;
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(637, 3);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(120, 38);
            this.btn_Cancel.Style = MetroFramework.MetroColorStyle.Red;
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_Cancel.UseSelectable = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Ok
            // 
            this.btn_Ok.ActiveControl = null;
            this.btn_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Ok.Location = new System.Drawing.Point(511, 3);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(120, 38);
            this.btn_Ok.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_Ok.TabIndex = 9;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Ok.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_Ok.UseSelectable = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(449, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.tbl_Tables);
            this.Name = "FormTable";
            this.Text = "FormTable";
            this.Load += new System.EventHandler(this.FormTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Tables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.pnl_Bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid tbl_Tables;
        private MetroFramework.Controls.MetroTextBox txt_Search;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Caracteristica;
        private System.Windows.Forms.Panel pnl_Bottom;
        private MetroFramework.Controls.MetroTile btn_Cancel;
        private MetroFramework.Controls.MetroTile btn_Ok;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}