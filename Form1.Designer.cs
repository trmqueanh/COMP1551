namespace StringProcessingApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtShift;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnInitialize;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Button btnDecode; 
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnInputCode;
        private System.Windows.Forms.Button btnOutputCode;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.Button btnReset;

        private void InitializeComponent()
        {
            txtInput = new TextBox();
            txtShift = new TextBox();
            txtResult = new TextBox();
            btnInitialize = new Button();
            btnEncode = new Button();
            btnDecode = new Button();
            btnPrint = new Button();
            btnInputCode = new Button();
            btnOutputCode = new Button();
            btnSort = new Button();
            btnHash = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(12, 20);
            txtInput.Name = "txtInput";
            txtInput.PlaceholderText = "Enter uppercase letters (max 40)";
            txtInput.Size = new Size(363, 23);
            txtInput.TabIndex = 0;
            // 
            // txtShift
            // 
            txtShift.Location = new Point(398, 20);
            txtShift.Name = "txtShift";
            txtShift.PlaceholderText = "N (-25 to 25)";
            txtShift.Size = new Size(84, 23);
            txtShift.TabIndex = 1;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(12, 196);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(816, 23);
            txtResult.TabIndex = 2;
            // 
            // btnInitialize
            // 
            btnInitialize.Location = new Point(522, 20);
            btnInitialize.Name = "btnInitialize";
            btnInitialize.Size = new Size(88, 23);
            btnInitialize.TabIndex = 3;
            btnInitialize.Text = "Initialize";
            btnInitialize.Click += btnInitialize_Click;
            // 
            // btnEncode
            // 
            btnEncode.Location = new Point(12, 105);
            btnEncode.Name = "btnEncode";
            btnEncode.Size = new Size(86, 28);
            btnEncode.TabIndex = 4;
            btnEncode.Text = "Encode";
            btnEncode.Click += btnEncode_Click;
            // 
            // btnDecode
            // 
            btnDecode.Location = new Point(112, 105);
            btnDecode.Name = "btnDecode";
            btnDecode.Size = new Size(86, 28);
            btnDecode.TabIndex = 5;
            btnDecode.Text = "Decode";
            btnDecode.Click += btnDecode_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(219, 105);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 28);
            btnPrint.TabIndex = 6;
            btnPrint.Text = "Print";
            btnPrint.Click += btnPrint_Click;
            // 
            // btnInputCode
            // 
            btnInputCode.Location = new Point(324, 105);
            btnInputCode.Name = "btnInputCode";
            btnInputCode.Size = new Size(75, 28);
            btnInputCode.TabIndex = 7;
            btnInputCode.Text = "Input ASCII";
            btnInputCode.Click += btnInputCode_Click;
            // 
            // btnOutputCode
            // 
            btnOutputCode.Location = new Point(426, 105);
            btnOutputCode.Name = "btnOutputCode";
            btnOutputCode.Size = new Size(94, 28);
            btnOutputCode.TabIndex = 8;
            btnOutputCode.Text = "Output ASCII";
            btnOutputCode.Click += btnOutputCode_Click;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(550, 105);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(75, 28);
            btnSort.TabIndex = 9;
            btnSort.Text = "Sort";
            btnSort.Click += btnSort_Click;
            // 
            // btnHash
            // 
            btnHash.Location = new Point(661, 105);
            btnHash.Name = "btnHash";
            btnHash.Size = new Size(75, 28);
            btnHash.TabIndex = 10;
            btnHash.Text = "Hash";
            btnHash.Click += btnHash_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(633, 20);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(843, 339);
            Controls.Add(txtInput);
            Controls.Add(txtShift);
            Controls.Add(txtResult);
            Controls.Add(btnInitialize);
            Controls.Add(btnEncode);
            Controls.Add(btnDecode);
            Controls.Add(btnPrint);
            Controls.Add(btnInputCode);
            Controls.Add(btnOutputCode);
            Controls.Add(btnSort);
            Controls.Add(btnHash);
            Controls.Add(btnReset);
            Name = "Form1";
            Text = "String Processing App";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
