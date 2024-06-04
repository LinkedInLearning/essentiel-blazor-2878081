using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;

namespace ExempleWebView
{
    partial class FrmMain
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
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            numDanger = new NumericUpDown();
            numAlerte = new NumericUpDown();
            cbEnCharge = new CheckBox();
            lblCharge = new Label();
            trackCharge = new TrackBar();
            blazorWebView = new BlazorWebView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDanger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAlerte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackCharge).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            splitContainer1.Panel1.Controls.Add(cbEnCharge);
            splitContainer1.Panel1.Controls.Add(lblCharge);
            splitContainer1.Panel1.Controls.Add(trackCharge);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(blazorWebView);
            splitContainer1.Size = new Size(530, 361);
            splitContainer1.SplitterDistance = 222;
            splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(numDanger, 0, 1);
            tableLayoutPanel1.Controls.Add(numAlerte, 1, 1);
            tableLayoutPanel1.Location = new Point(3, 92);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RightToLeft = RightToLeft.No;
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 44.4444427F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 55.5555573F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.Size = new Size(219, 54);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 24);
            label2.TabIndex = 6;
            label2.Text = "Seuil rouge";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(112, 0);
            label3.Name = "label3";
            label3.Size = new Size(104, 24);
            label3.TabIndex = 7;
            label3.Text = "Seuil orange";
            label3.TextAlign = ContentAlignment.BottomCenter;
            // 
            // numDanger
            // 
            numDanger.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numDanger.Location = new Point(3, 27);
            numDanger.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numDanger.Name = "numDanger";
            numDanger.Size = new Size(103, 23);
            numDanger.TabIndex = 0;
            numDanger.Value = new decimal(new int[] { 40, 0, 0, 0 });
            numDanger.ValueChanged += MajBatterie;
            // 
            // numAlerte
            // 
            numAlerte.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numAlerte.Location = new Point(112, 27);
            numAlerte.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            numAlerte.Name = "numAlerte";
            numAlerte.Size = new Size(104, 23);
            numAlerte.TabIndex = 0;
            numAlerte.Value = new decimal(new int[] { 70, 0, 0, 0 });
            numAlerte.ValueChanged += MajBatterie;
            // 
            // cbEnCharge
            // 
            cbEnCharge.AutoSize = true;
            cbEnCharge.Location = new Point(13, 57);
            cbEnCharge.Name = "cbEnCharge";
            cbEnCharge.Size = new Size(78, 19);
            cbEnCharge.TabIndex = 2;
            cbEnCharge.Text = "En charge";
            cbEnCharge.UseVisualStyleBackColor = true;
            cbEnCharge.CheckedChanged += MajBatterie;
            // 
            // lblCharge
            // 
            lblCharge.AutoSize = true;
            lblCharge.Location = new Point(12, 9);
            lblCharge.Name = "lblCharge";
            lblCharge.Size = new Size(76, 15);
            lblCharge.TabIndex = 1;
            lblCharge.Text = "Charge : 50%";
            // 
            // trackCharge
            // 
            trackCharge.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trackCharge.LargeChange = 10;
            trackCharge.Location = new Point(12, 27);
            trackCharge.Maximum = 100;
            trackCharge.Name = "trackCharge";
            trackCharge.Size = new Size(204, 45);
            trackCharge.SmallChange = 5;
            trackCharge.TabIndex = 3;
            trackCharge.Value = 50;
            trackCharge.Scroll += MajBatterie;
            // 
            // blazorWebView
            // 
            blazorWebView.Dock = DockStyle.Fill;
            blazorWebView.HostPage = "wwwroot/index.html";
            blazorWebView.Location = new Point(0, 0);
            blazorWebView.Name = "blazorWebView";
            blazorWebView.Size = new Size(304, 361);
            blazorWebView.StartPath = "/";
            blazorWebView.TabIndex = 0;
            blazorWebView.Text = "Chargement...";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 361);
            Controls.Add(splitContainer1);
            Name = "FrmMain";
            Text = "Testeur de batterie (Forms)";
            Load += FrmMain_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDanger).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAlerte).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackCharge).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label lblCharge;
        private NumericUpDown numDanger;
        private CheckBox cbEnCharge;
        private TableLayoutPanel tableLayoutPanel1;
        private TrackBar trackCharge;
        private Label label3;
        private Label label2;
        private NumericUpDown numAlerte;
        private Microsoft.AspNetCore.Components.WebView.WindowsForms.BlazorWebView blazorWebView;
    }
}
