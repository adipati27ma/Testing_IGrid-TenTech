namespace Testing_IGrid_TenTech
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
            this.iGrid1DefaultCellStyle = new TenTec.Windows.iGridLib.iGCellStyle(true);
            this.iGrid1DefaultColHdrStyle = new TenTec.Windows.iGridLib.iGColHdrStyle(true);
            this.iGrid1 = new TenTec.Windows.iGridLib.iGrid();
            ((System.ComponentModel.ISupportInitialize)(this.iGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // iGrid1
            // 
            this.iGrid1.DefaultAutoGroupRow.Height = 21;
            this.iGrid1.DefaultCol.CellStyle = this.iGrid1DefaultCellStyle;
            this.iGrid1.DefaultCol.ColHdrStyle = this.iGrid1DefaultColHdrStyle;
            this.iGrid1.DefaultRow.Height = 21;
            this.iGrid1.DefaultRow.NormalCellHeight = 21;
            this.iGrid1.Location = new System.Drawing.Point(12, 12);
            this.iGrid1.Name = "iGrid1";
            this.iGrid1.Size = new System.Drawing.Size(1082, 703);
            this.iGrid1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 727);
            this.Controls.Add(this.iGrid1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.iGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TenTec.Windows.iGridLib.iGCellStyle iGrid1DefaultCellStyle;
        private TenTec.Windows.iGridLib.iGColHdrStyle iGrid1DefaultColHdrStyle;
        private TenTec.Windows.iGridLib.iGrid iGrid1;
    }
}