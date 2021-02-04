
namespace MasterMindDemo
{
    partial class DemoFrm
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
            this.gbColor = new System.Windows.Forms.GroupBox();
            this.gbHistory = new System.Windows.Forms.GroupBox();
            this.gbGuess = new System.Windows.Forms.GroupBox();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnWhite = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.gbCurrentLine = new System.Windows.Forms.GroupBox();
            this.txtHistory = new System.Windows.Forms.TextBox();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.txtField = new System.Windows.Forms.TextBox();
            this.btnMain = new System.Windows.Forms.Button();
            this.txtCombination = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.gbColor.SuspendLayout();
            this.gbHistory.SuspendLayout();
            this.gbGuess.SuspendLayout();
            this.gbCurrentLine.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbColor
            // 
            this.gbColor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gbColor.Controls.Add(this.btnYellow);
            this.gbColor.Controls.Add(this.btnWhite);
            this.gbColor.Controls.Add(this.btnRed);
            this.gbColor.Controls.Add(this.btnGreen);
            this.gbColor.Controls.Add(this.btnBlue);
            this.gbColor.Controls.Add(this.btnBlack);
            this.gbColor.Location = new System.Drawing.Point(13, 425);
            this.gbColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbColor.Name = "gbColor";
            this.gbColor.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbColor.Size = new System.Drawing.Size(401, 77);
            this.gbColor.TabIndex = 0;
            this.gbColor.TabStop = false;
            this.gbColor.Text = "Select Color";
            // 
            // gbHistory
            // 
            this.gbHistory.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gbHistory.Controls.Add(this.txtHistory);
            this.gbHistory.Location = new System.Drawing.Point(13, 93);
            this.gbHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbHistory.Name = "gbHistory";
            this.gbHistory.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbHistory.Size = new System.Drawing.Size(401, 231);
            this.gbHistory.TabIndex = 1;
            this.gbHistory.TabStop = false;
            this.gbHistory.Text = "User History";
            // 
            // gbGuess
            // 
            this.gbGuess.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gbGuess.Controls.Add(this.btnShow);
            this.gbGuess.Controls.Add(this.txtCombination);
            this.gbGuess.Location = new System.Drawing.Point(13, 334);
            this.gbGuess.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbGuess.Name = "gbGuess";
            this.gbGuess.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbGuess.Size = new System.Drawing.Size(401, 81);
            this.gbGuess.TabIndex = 1;
            this.gbGuess.TabStop = false;
            this.gbGuess.Text = "Color Guess";
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            this.btnBlack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlack.Location = new System.Drawing.Point(7, 29);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(60, 40);
            this.btnBlack.TabIndex = 0;
            this.btnBlack.Tag = "0";
            this.btnBlack.UseVisualStyleBackColor = false;
            this.btnBlack.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlue.Location = new System.Drawing.Point(73, 29);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(60, 40);
            this.btnBlue.TabIndex = 1;
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Green;
            this.btnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGreen.Location = new System.Drawing.Point(139, 29);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(60, 40);
            this.btnGreen.TabIndex = 2;
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRed.Location = new System.Drawing.Point(205, 29);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(60, 40);
            this.btnRed.TabIndex = 3;
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnWhite
            // 
            this.btnWhite.BackColor = System.Drawing.Color.White;
            this.btnWhite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWhite.Location = new System.Drawing.Point(271, 29);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(60, 40);
            this.btnWhite.TabIndex = 4;
            this.btnWhite.UseVisualStyleBackColor = false;
            this.btnWhite.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYellow.Location = new System.Drawing.Point(337, 29);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(60, 40);
            this.btnYellow.TabIndex = 5;
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // gbCurrentLine
            // 
            this.gbCurrentLine.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gbCurrentLine.Controls.Add(this.btnMain);
            this.gbCurrentLine.Controls.Add(this.txtField);
            this.gbCurrentLine.Controls.Add(this.cmbPosition);
            this.gbCurrentLine.Location = new System.Drawing.Point(14, 14);
            this.gbCurrentLine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCurrentLine.Name = "gbCurrentLine";
            this.gbCurrentLine.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCurrentLine.Size = new System.Drawing.Size(401, 81);
            this.gbCurrentLine.TabIndex = 2;
            this.gbCurrentLine.TabStop = false;
            this.gbCurrentLine.Text = "Color Guess";
            // 
            // txtHistory
            // 
            this.txtHistory.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistory.Location = new System.Drawing.Point(7, 30);
            this.txtHistory.Multiline = true;
            this.txtHistory.Name = "txtHistory";
            this.txtHistory.ReadOnly = true;
            this.txtHistory.Size = new System.Drawing.Size(387, 193);
            this.txtHistory.TabIndex = 0;
            this.txtHistory.Text = "1. |Yellow|Yellow|Yellow|Yellow| -> |White|White|White|White|\r\n";
            // 
            // cmbPosition
            // 
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Items.AddRange(new object[] {
            "1er Position",
            "2nd Position",
            "3rd Position",
            "4th Position"});
            this.cmbPosition.Location = new System.Drawing.Point(7, 30);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(155, 29);
            this.cmbPosition.TabIndex = 0;
            this.cmbPosition.SelectedIndexChanged += new System.EventHandler(this.cmbPosition_SelectedIndexChanged);
            // 
            // txtField
            // 
            this.txtField.Enabled = false;
            this.txtField.Location = new System.Drawing.Point(168, 30);
            this.txtField.Name = "txtField";
            this.txtField.Size = new System.Drawing.Size(127, 29);
            this.txtField.TabIndex = 1;
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Location = new System.Drawing.Point(301, 30);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(92, 29);
            this.btnMain.TabIndex = 5;
            this.btnMain.Text = "Validate";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // txtCombination
            // 
            this.txtCombination.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCombination.Location = new System.Drawing.Point(7, 30);
            this.txtCombination.Name = "txtCombination";
            this.txtCombination.ReadOnly = true;
            this.txtCombination.Size = new System.Drawing.Size(289, 33);
            this.txtCombination.TabIndex = 1;
            this.txtCombination.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Location = new System.Drawing.Point(302, 32);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(92, 29);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // DemoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(428, 515);
            this.Controls.Add(this.gbCurrentLine);
            this.Controls.Add(this.gbGuess);
            this.Controls.Add(this.gbHistory);
            this.Controls.Add(this.gbColor);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DemoFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo MasterMind";
            this.gbColor.ResumeLayout(false);
            this.gbHistory.ResumeLayout(false);
            this.gbHistory.PerformLayout();
            this.gbGuess.ResumeLayout(false);
            this.gbGuess.PerformLayout();
            this.gbCurrentLine.ResumeLayout(false);
            this.gbCurrentLine.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbColor;
        private System.Windows.Forms.GroupBox gbHistory;
        private System.Windows.Forms.GroupBox gbGuess;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnWhite;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.TextBox txtHistory;
        private System.Windows.Forms.GroupBox gbCurrentLine;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.TextBox txtField;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.TextBox txtCombination;
        private System.Windows.Forms.Button btnShow;
    }
}

