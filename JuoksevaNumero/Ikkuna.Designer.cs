namespace Tehtava11
{
    partial class Ikkuna
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
            textBoxNumber = new TextBox();
            buttonCancel = new Button();
            buttonOK = new Button();
            SuspendLayout();
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(258, 243);
            textBoxNumber.Margin = new Padding(7);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(403, 23);
            textBoxNumber.TabIndex = 17;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(735, 462);
            buttonCancel.Margin = new Padding(7);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(88, 27);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "&Stop";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonOK
            // 
            buttonOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.Location = new Point(830, 462);
            buttonOK.Margin = new Padding(7);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(88, 27);
            buttonOK.TabIndex = 4;
            buttonOK.Text = "&Start";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // Ikkuna
            // 
            AcceptButton = buttonOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(textBoxNumber);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Ikkuna";
            Text = "ikkuna";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}
