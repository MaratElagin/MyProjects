
namespace CombinationCalculator
{
    partial class CombinationCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CombinationCalculator));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PermCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Perm = new System.Windows.Forms.Button();
            this.lbl_PermRes = new System.Windows.Forms.Label();
            this.lbl_AssigRes = new System.Windows.Forms.Label();
            this.btn_Assig = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_AssigNCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_ComprRes = new System.Windows.Forms.Label();
            this.btnCompr = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ComprNCount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_Perm = new System.Windows.Forms.CheckBox();
            this.cb_Assig = new System.Windows.Forms.CheckBox();
            this.cb_Compr = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_AssigMCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ComprMCount = new System.Windows.Forms.TextBox();
            this.lbl_retries = new System.Windows.Forms.Label();
            this.txt_retries = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("CricketLight", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(196)))), ((int)(((byte)(106)))));
            this.label1.Location = new System.Drawing.Point(24, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Перестановки P";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("CricketLight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(626, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 26);
            this.label2.TabIndex = 1;
            // 
            // txt_PermCount
            // 
            this.txt_PermCount.Font = new System.Drawing.Font("CricketLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_PermCount.Location = new System.Drawing.Point(372, 33);
            this.txt_PermCount.Name = "txt_PermCount";
            this.txt_PermCount.Size = new System.Drawing.Size(54, 30);
            this.txt_PermCount.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("CricketLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(254, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Введите n";
            // 
            // btn_Perm
            // 
            this.btn_Perm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(196)))), ((int)(((byte)(106)))));
            this.btn_Perm.Font = new System.Drawing.Font("CricketLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Perm.Location = new System.Drawing.Point(584, 29);
            this.btn_Perm.Name = "btn_Perm";
            this.btn_Perm.Size = new System.Drawing.Size(111, 37);
            this.btn_Perm.TabIndex = 5;
            this.btn_Perm.Text = "Рассчитать";
            this.btn_Perm.UseVisualStyleBackColor = false;
            this.btn_Perm.Click += new System.EventHandler(this.btn_Perm_Click);
            // 
            // lbl_PermRes
            // 
            this.lbl_PermRes.AutoSize = true;
            this.lbl_PermRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
            this.lbl_PermRes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_PermRes.ForeColor = System.Drawing.Color.White;
            this.lbl_PermRes.Location = new System.Drawing.Point(710, 39);
            this.lbl_PermRes.Name = "lbl_PermRes";
            this.lbl_PermRes.Size = new System.Drawing.Size(0, 24);
            this.lbl_PermRes.TabIndex = 6;
            // 
            // lbl_AssigRes
            // 
            this.lbl_AssigRes.AutoSize = true;
            this.lbl_AssigRes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_AssigRes.ForeColor = System.Drawing.Color.White;
            this.lbl_AssigRes.Location = new System.Drawing.Point(710, 227);
            this.lbl_AssigRes.Name = "lbl_AssigRes";
            this.lbl_AssigRes.Size = new System.Drawing.Size(0, 24);
            this.lbl_AssigRes.TabIndex = 12;
            // 
            // btn_Assig
            // 
            this.btn_Assig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(162)))), ((int)(((byte)(97)))));
            this.btn_Assig.Font = new System.Drawing.Font("CricketLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Assig.Location = new System.Drawing.Point(584, 214);
            this.btn_Assig.Name = "btn_Assig";
            this.btn_Assig.Size = new System.Drawing.Size(111, 37);
            this.btn_Assig.TabIndex = 11;
            this.btn_Assig.Text = "Рассчитать";
            this.btn_Assig.UseVisualStyleBackColor = false;
            this.btn_Assig.Click += new System.EventHandler(this.btn_Assig_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("CricketLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(254, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Введите n";
            // 
            // txt_AssigNCount
            // 
            this.txt_AssigNCount.Font = new System.Drawing.Font("CricketLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_AssigNCount.Location = new System.Drawing.Point(372, 200);
            this.txt_AssigNCount.Name = "txt_AssigNCount";
            this.txt_AssigNCount.Size = new System.Drawing.Size(55, 30);
            this.txt_AssigNCount.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("CricketLight", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(162)))), ((int)(((byte)(97)))));
            this.label6.Location = new System.Drawing.Point(24, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 26);
            this.label6.TabIndex = 7;
            this.label6.Text = "Размещения A";
            // 
            // lbl_ComprRes
            // 
            this.lbl_ComprRes.AutoSize = true;
            this.lbl_ComprRes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ComprRes.ForeColor = System.Drawing.Color.White;
            this.lbl_ComprRes.Location = new System.Drawing.Point(710, 427);
            this.lbl_ComprRes.Name = "lbl_ComprRes";
            this.lbl_ComprRes.Size = new System.Drawing.Size(0, 24);
            this.lbl_ComprRes.TabIndex = 18;
            // 
            // btnCompr
            // 
            this.btnCompr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(111)))), ((int)(((byte)(81)))));
            this.btnCompr.Font = new System.Drawing.Font("CricketLight", 9F);
            this.btnCompr.Location = new System.Drawing.Point(584, 414);
            this.btnCompr.Name = "btnCompr";
            this.btnCompr.Size = new System.Drawing.Size(111, 37);
            this.btnCompr.TabIndex = 17;
            this.btnCompr.Text = "Рассчитать";
            this.btnCompr.UseVisualStyleBackColor = false;
            this.btnCompr.Click += new System.EventHandler(this.btnCompr_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("CricketLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(254, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Введите n";
            // 
            // txt_ComprNCount
            // 
            this.txt_ComprNCount.Font = new System.Drawing.Font("CricketLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_ComprNCount.Location = new System.Drawing.Point(372, 401);
            this.txt_ComprNCount.Name = "txt_ComprNCount";
            this.txt_ComprNCount.Size = new System.Drawing.Size(54, 30);
            this.txt_ComprNCount.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("CricketLight", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(111)))), ((int)(((byte)(81)))));
            this.label9.Location = new System.Drawing.Point(24, 416);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 26);
            this.label9.TabIndex = 13;
            this.label9.Text = "Сочетания C";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 558);
            this.panel1.TabIndex = 19;
            // 
            // cb_Perm
            // 
            this.cb_Perm.AutoSize = true;
            this.cb_Perm.Location = new System.Drawing.Point(432, 42);
            this.cb_Perm.Name = "cb_Perm";
            this.cb_Perm.Size = new System.Drawing.Size(159, 21);
            this.cb_Perm.TabIndex = 21;
            this.cb_Perm.Text = "С повторениями";
            this.cb_Perm.UseVisualStyleBackColor = true;
            this.cb_Perm.CheckedChanged += new System.EventHandler(this.cb_Perm_CheckedChanged);
            // 
            // cb_Assig
            // 
            this.cb_Assig.AutoSize = true;
            this.cb_Assig.Location = new System.Drawing.Point(432, 226);
            this.cb_Assig.Name = "cb_Assig";
            this.cb_Assig.Size = new System.Drawing.Size(159, 21);
            this.cb_Assig.TabIndex = 22;
            this.cb_Assig.Text = "С повторениями";
            this.cb_Assig.UseVisualStyleBackColor = true;
            // 
            // cb_Compr
            // 
            this.cb_Compr.AutoSize = true;
            this.cb_Compr.Location = new System.Drawing.Point(432, 426);
            this.cb_Compr.Name = "cb_Compr";
            this.cb_Compr.Size = new System.Drawing.Size(159, 21);
            this.cb_Compr.TabIndex = 23;
            this.cb_Compr.Text = "С повторениями";
            this.cb_Compr.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("CricketLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(255, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Введите m";
            // 
            // txt_AssigMCount
            // 
            this.txt_AssigMCount.Font = new System.Drawing.Font("CricketLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_AssigMCount.Location = new System.Drawing.Point(373, 233);
            this.txt_AssigMCount.Name = "txt_AssigMCount";
            this.txt_AssigMCount.Size = new System.Drawing.Size(54, 30);
            this.txt_AssigMCount.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("CricketLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(254, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 23);
            this.label7.TabIndex = 27;
            this.label7.Text = "Введите m";
            // 
            // txt_ComprMCount
            // 
            this.txt_ComprMCount.Font = new System.Drawing.Font("CricketLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_ComprMCount.Location = new System.Drawing.Point(372, 435);
            this.txt_ComprMCount.Name = "txt_ComprMCount";
            this.txt_ComprMCount.Size = new System.Drawing.Size(54, 30);
            this.txt_ComprMCount.TabIndex = 26;
            // 
            // lbl_retries
            // 
            this.lbl_retries.AutoSize = true;
            this.lbl_retries.Font = new System.Drawing.Font("CricketLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_retries.Location = new System.Drawing.Point(255, 76);
            this.lbl_retries.Name = "lbl_retries";
            this.lbl_retries.Size = new System.Drawing.Size(183, 23);
            this.lbl_retries.TabIndex = 28;
            this.lbl_retries.Text = "Введите n1 n2... nk";
            this.lbl_retries.Visible = false;
            // 
            // txt_retries
            // 
            this.txt_retries.Font = new System.Drawing.Font("CricketLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_retries.Location = new System.Drawing.Point(472, 69);
            this.txt_retries.Name = "txt_retries";
            this.txt_retries.Size = new System.Drawing.Size(154, 30);
            this.txt_retries.TabIndex = 29;
            this.txt_retries.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(769, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 42);
            this.button1.TabIndex = 30;
            this.button1.Text = "Очистить всё";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CombinationCalculator
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
            this.ClientSize = new System.Drawing.Size(888, 558);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_retries);
            this.Controls.Add(this.lbl_retries);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_ComprMCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_AssigMCount);
            this.Controls.Add(this.cb_Compr);
            this.Controls.Add(this.cb_Assig);
            this.Controls.Add(this.cb_Perm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_ComprRes);
            this.Controls.Add(this.btnCompr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_ComprNCount);
            this.Controls.Add(this.lbl_AssigRes);
            this.Controls.Add(this.btn_Assig);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_AssigNCount);
            this.Controls.Add(this.lbl_PermRes);
            this.Controls.Add(this.btn_Perm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_PermCount);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Cricket", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(906, 605);
            this.MinimumSize = new System.Drawing.Size(906, 605);
            this.Name = "CombinationCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.CombinationCalculator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_PermCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Perm;
        private System.Windows.Forms.Label lbl_PermRes;
        private System.Windows.Forms.Label lbl_AssigRes;
        private System.Windows.Forms.Button btn_Assig;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_AssigNCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_ComprRes;
        private System.Windows.Forms.Button btnCompr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ComprNCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cb_Perm;
        private System.Windows.Forms.CheckBox cb_Assig;
        private System.Windows.Forms.CheckBox cb_Compr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_AssigMCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ComprMCount;
        private System.Windows.Forms.Label lbl_retries;
        private System.Windows.Forms.TextBox txt_retries;
        private System.Windows.Forms.Button button1;
    }
}

