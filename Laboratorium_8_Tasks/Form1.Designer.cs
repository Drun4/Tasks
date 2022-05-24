
namespace Laboratorium_8_Tasks
{
    partial class Form1
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
            this.txt_From = new System.Windows.Forms.TextBox();
            this.txt_NumOfThreads = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_StartOne = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.txt_To = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Answer = new System.Windows.Forms.TextBox();
            this.btn_StartMany = new System.Windows.Forms.Button();
            this.rtxt_ThreadStreamer = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txt_From
            // 
            this.txt_From.Location = new System.Drawing.Point(28, 39);
            this.txt_From.Margin = new System.Windows.Forms.Padding(4);
            this.txt_From.Name = "txt_From";
            this.txt_From.Size = new System.Drawing.Size(132, 22);
            this.txt_From.TabIndex = 0;
            // 
            // txt_NumOfThreads
            // 
            this.txt_NumOfThreads.Location = new System.Drawing.Point(361, 39);
            this.txt_NumOfThreads.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NumOfThreads.Name = "txt_NumOfThreads";
            this.txt_NumOfThreads.Size = new System.Drawing.Size(188, 22);
            this.txt_NumOfThreads.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of threads";
            // 
            // btn_StartOne
            // 
            this.btn_StartOne.Location = new System.Drawing.Point(361, 147);
            this.btn_StartOne.Name = "btn_StartOne";
            this.btn_StartOne.Size = new System.Drawing.Size(91, 27);
            this.btn_StartOne.TabIndex = 5;
            this.btn_StartOne.Text = "Start One";
            this.btn_StartOne.UseVisualStyleBackColor = true;
            this.btn_StartOne.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(361, 209);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(188, 27);
            this.btn_Clear.TabIndex = 6;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // txt_To
            // 
            this.txt_To.Location = new System.Drawing.Point(193, 39);
            this.txt_To.Margin = new System.Windows.Forms.Padding(4);
            this.txt_To.Name = "txt_To";
            this.txt_To.Size = new System.Drawing.Size(132, 22);
            this.txt_To.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Answer:";
            // 
            // txt_Answer
            // 
            this.txt_Answer.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Answer.Location = new System.Drawing.Point(419, 94);
            this.txt_Answer.Name = "txt_Answer";
            this.txt_Answer.Size = new System.Drawing.Size(130, 22);
            this.txt_Answer.TabIndex = 12;
            // 
            // btn_StartMany
            // 
            this.btn_StartMany.Location = new System.Drawing.Point(458, 147);
            this.btn_StartMany.Name = "btn_StartMany";
            this.btn_StartMany.Size = new System.Drawing.Size(91, 27);
            this.btn_StartMany.TabIndex = 13;
            this.btn_StartMany.Text = "Start Many";
            this.btn_StartMany.UseVisualStyleBackColor = true;
            this.btn_StartMany.Click += new System.EventHandler(this.btn_StartMany_Click);
            // 
            // rtxt_ThreadStreamer
            // 
            this.rtxt_ThreadStreamer.Location = new System.Drawing.Point(28, 85);
            this.rtxt_ThreadStreamer.Name = "rtxt_ThreadStreamer";
            this.rtxt_ThreadStreamer.Size = new System.Drawing.Size(297, 151);
            this.rtxt_ThreadStreamer.TabIndex = 14;
            this.rtxt_ThreadStreamer.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 248);
            this.Controls.Add(this.rtxt_ThreadStreamer);
            this.Controls.Add(this.btn_StartMany);
            this.Controls.Add(this.txt_Answer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_To);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_StartOne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_NumOfThreads);
            this.Controls.Add(this.txt_From);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tasks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_From;
        private System.Windows.Forms.TextBox txt_NumOfThreads;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_StartOne;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.TextBox txt_To;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Answer;
        private System.Windows.Forms.Button btn_StartMany;
        private System.Windows.Forms.RichTextBox rtxt_ThreadStreamer;
    }
}

