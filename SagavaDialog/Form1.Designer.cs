
namespace SagavaDialog
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
            this.input = new System.Windows.Forms.TextBox();
            this.say = new System.Windows.Forms.Button();
            this.dialog = new System.Windows.Forms.ListBox();
            this.clearChat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(22, 209);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(402, 23);
            this.input.TabIndex = 0;
            this.input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_KeyDown);
            // 
            // say
            // 
            this.say.Location = new System.Drawing.Point(430, 200);
            this.say.Name = "say";
            this.say.Size = new System.Drawing.Size(124, 39);
            this.say.TabIndex = 1;
            this.say.Text = "Сказать";
            this.say.UseVisualStyleBackColor = true;
            this.say.Click += new System.EventHandler(this.say_Click);
            // 
            // dialog
            // 
            this.dialog.FormattingEnabled = true;
            this.dialog.ItemHeight = 15;
            this.dialog.Location = new System.Drawing.Point(22, 25);
            this.dialog.Name = "dialog";
            this.dialog.Size = new System.Drawing.Size(663, 169);
            this.dialog.TabIndex = 2;
            // 
            // clearChat
            // 
            this.clearChat.Location = new System.Drawing.Point(564, 200);
            this.clearChat.Name = "clearChat";
            this.clearChat.Size = new System.Drawing.Size(121, 38);
            this.clearChat.TabIndex = 3;
            this.clearChat.Text = "Очистить";
            this.clearChat.UseVisualStyleBackColor = true;
            this.clearChat.Click += new System.EventHandler(this.clearChat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 261);
            this.Controls.Add(this.clearChat);
            this.Controls.Add(this.dialog);
            this.Controls.Add(this.say);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "Сагава Чат";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button say;
        private System.Windows.Forms.ListBox dialog;
        private System.Windows.Forms.Button clearChat;
    }
}

