using System.Reflection.Emit;
using System.Windows.Forms;

namespace ScrapePokerTwistters
{
    partial class Home
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
            TreeNode treeNode5 = new TreeNode("Regions");
            TreeNode treeNode6 = new TreeNode("Board");
            TreeNode treeNode7 = new TreeNode("Images");
            TreeNode treeNode8 = new TreeNode("Fonts");
            twRegions = new TreeView();
            tbHeight = new TextBox();
            btnNew = new Button();
            btnPlusWidth = new Button();
            btnMinusWidth = new Button();
            btnPlusHeight = new Button();
            btnMinusHeight = new Button();
            btnUpRight = new Button();
            btnDownRight = new Button();
            btnDownLeft = new Button();
            btnUpLeft = new Button();
            btnUp = new Button();
            btnDown = new Button();
            btnLeft = new Button();
            btnRigth = new Button();
            lbXY = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            tbY = new TextBox();
            tbX = new TextBox();
            tbWidth = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // twRegions
            // 
            twRegions.Location = new Point(12, 48);
            twRegions.Name = "twRegions";
            treeNode5.Name = "Nodo0";
            treeNode5.NodeFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            treeNode5.Text = "Regions";
            treeNode6.Name = "Nodo1";
            treeNode6.NodeFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            treeNode6.Text = "Board";
            treeNode7.Name = "Nodo2";
            treeNode7.NodeFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            treeNode7.Text = "Images";
            treeNode8.Name = "Nodo3";
            treeNode8.NodeFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            treeNode8.Text = "Fonts";
            twRegions.Nodes.AddRange(new TreeNode[] { treeNode5, treeNode6, treeNode7, treeNode8 });
            twRegions.Size = new Size(159, 342);
            twRegions.TabIndex = 0;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(12, 19);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(48, 23);
            btnNew.TabIndex = 1;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnPlusWidth
            // 
            btnPlusWidth.Enabled = false;
            btnPlusWidth.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPlusWidth.ImageAlign = ContentAlignment.TopCenter;
            btnPlusWidth.Location = new Point(10, 69);
            btnPlusWidth.Name = "btnPlusWidth";
            btnPlusWidth.Size = new Size(25, 25);
            btnPlusWidth.TabIndex = 3;
            btnPlusWidth.Text = "+";
            btnPlusWidth.TextAlign = ContentAlignment.TopCenter;
            btnPlusWidth.UseVisualStyleBackColor = true;
            // 
            // btnMinusWidth
            // 
            btnMinusWidth.Enabled = false;
            btnMinusWidth.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMinusWidth.Location = new Point(34, 69);
            btnMinusWidth.Name = "btnMinusWidth";
            btnMinusWidth.Size = new Size(25, 25);
            btnMinusWidth.TabIndex = 4;
            btnMinusWidth.Text = "-";
            btnMinusWidth.UseVisualStyleBackColor = true;
            // 
            // btnPlusHeight
            // 
            btnPlusHeight.Enabled = false;
            btnPlusHeight.Location = new Point(73, 68);
            btnPlusHeight.Name = "btnPlusHeight";
            btnPlusHeight.Size = new Size(25, 25);
            btnPlusHeight.TabIndex = 5;
            btnPlusHeight.Text = "+";
            btnPlusHeight.TextAlign = ContentAlignment.MiddleRight;
            btnPlusHeight.UseVisualStyleBackColor = true;
            // 
            // btnMinusHeight
            // 
            btnMinusHeight.Enabled = false;
            btnMinusHeight.Location = new Point(97, 68);
            btnMinusHeight.Name = "btnMinusHeight";
            btnMinusHeight.Size = new Size(25, 25);
            btnMinusHeight.TabIndex = 6;
            btnMinusHeight.Text = "-";
            btnMinusHeight.TextAlign = ContentAlignment.TopCenter;
            btnMinusHeight.UseVisualStyleBackColor = true;
            // 
            // lbXY
            // 
            lbXY.AutoSize = true;
            lbXY.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lbXY.Location = new Point(130, 77);
            lbXY.Name = "lbXY";
            lbXY.Size = new Size(0, 13);
            lbXY.TabIndex = 8;
            // 
            // tbHeight
            // 
            tbHeight.Location = new Point(73, 42);
            tbHeight.Name = "tbHeight";
            tbHeight.Size = new Size(49, 23);
            tbHeight.TabIndex = 7;
            tbHeight.Text = "0";
            tbHeight.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 24);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 6;
            label2.Text = "Height";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 24);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Width";
            // 
            // tbWidth
            // 
            tbWidth.Location = new Point(10, 42);
            tbWidth.Name = "tbWidth";
            tbWidth.Size = new Size(49, 23);
            tbWidth.TabIndex = 0;
            tbWidth.Text = "0";
            tbWidth.TextAlign = HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbXY);
            groupBox1.Controls.Add(tbHeight);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbWidth);
            groupBox1.Controls.Add(btnPlusWidth);
            groupBox1.Controls.Add(btnMinusWidth);
            groupBox1.Controls.Add(btnPlusHeight);
            groupBox1.Controls.Add(btnMinusHeight);
            groupBox1.Location = new Point(177, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(203, 100);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rectangle";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(tbY);
            groupBox2.Controls.Add(tbX);
            groupBox2.Controls.Add(btnUpRight);
            groupBox2.Controls.Add(btnDownRight);
            groupBox2.Controls.Add(btnDownLeft);
            groupBox2.Controls.Add(btnUpLeft);
            groupBox2.Controls.Add(btnUp);
            groupBox2.Controls.Add(btnDown);
            groupBox2.Controls.Add(btnLeft);
            groupBox2.Controls.Add(btnRigth);
            groupBox2.Location = new Point(464, 9);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(107, 143);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nudge";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 96);
            label7.Name = "label7";
            label7.Size = new Size(14, 15);
            label7.TabIndex = 32;
            label7.Text = "Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 96);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 31;
            label3.Text = "X";
            // 
            // tbY
            // 
            tbY.Location = new Point(58, 114);
            tbY.Name = "tbY";
            tbY.Size = new Size(43, 23);
            tbY.TabIndex = 30;
            tbY.Text = "0";
            tbY.TextAlign = HorizontalAlignment.Right;
            // 
            // tbX
            // 
            tbX.Location = new Point(6, 114);
            tbX.Name = "tbX";
            tbX.Size = new Size(43, 23);
            tbX.TabIndex = 29;
            tbX.Text = "0";
            tbX.TextAlign = HorizontalAlignment.Right;
            // 
            // btnUpRight
            // 
            btnUpRight.Enabled = false;
            btnUpRight.Location = new Point(66, 20);
            btnUpRight.Name = "btnUpRight";
            btnUpRight.RightToLeft = RightToLeft.No;
            btnUpRight.Size = new Size(25, 25);
            btnUpRight.TabIndex = 28;
            btnUpRight.Text = "↗";
            btnUpRight.TextAlign = ContentAlignment.MiddleRight;
            btnUpRight.UseVisualStyleBackColor = true;
            // 
            // btnDownRight
            // 
            btnDownRight.Enabled = false;
            btnDownRight.Location = new Point(66, 68);
            btnDownRight.Name = "btnDownRight";
            btnDownRight.RightToLeft = RightToLeft.No;
            btnDownRight.Size = new Size(25, 25);
            btnDownRight.TabIndex = 27;
            btnDownRight.Text = "↘";
            btnDownRight.TextAlign = ContentAlignment.MiddleRight;
            btnDownRight.UseVisualStyleBackColor = true;
            // 
            // btnDownLeft
            // 
            btnDownLeft.Enabled = false;
            btnDownLeft.Location = new Point(18, 68);
            btnDownLeft.Name = "btnDownLeft";
            btnDownLeft.RightToLeft = RightToLeft.No;
            btnDownLeft.Size = new Size(25, 25);
            btnDownLeft.TabIndex = 26;
            btnDownLeft.Text = "↙";
            btnDownLeft.TextAlign = ContentAlignment.MiddleRight;
            btnDownLeft.UseVisualStyleBackColor = true;
            // 
            // btnUpLeft
            // 
            btnUpLeft.Enabled = false;
            btnUpLeft.Location = new Point(18, 20);
            btnUpLeft.Name = "btnUpLeft";
            btnUpLeft.RightToLeft = RightToLeft.No;
            btnUpLeft.Size = new Size(25, 25);
            btnUpLeft.TabIndex = 25;
            btnUpLeft.Text = "↖";
            btnUpLeft.TextAlign = ContentAlignment.MiddleRight;
            btnUpLeft.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            btnUp.Enabled = false;
            btnUp.Location = new Point(42, 20);
            btnUp.Name = "btnUp";
            btnUp.RightToLeft = RightToLeft.No;
            btnUp.Size = new Size(25, 25);
            btnUp.TabIndex = 24;
            btnUp.Text = "↑";
            btnUp.TextAlign = ContentAlignment.BottomCenter;
            btnUp.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            btnDown.Enabled = false;
            btnDown.Location = new Point(42, 68);
            btnDown.Name = "btnDown";
            btnDown.RightToLeft = RightToLeft.No;
            btnDown.Size = new Size(25, 25);
            btnDown.TabIndex = 23;
            btnDown.Text = "↓";
            btnDown.TextAlign = ContentAlignment.TopCenter;
            btnDown.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            btnLeft.Enabled = false;
            btnLeft.Location = new Point(18, 44);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(25, 25);
            btnLeft.TabIndex = 22;
            btnLeft.Text = "←";
            btnLeft.TextAlign = ContentAlignment.TopCenter;
            btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnRigth
            // 
            btnRigth.Enabled = false;
            btnRigth.Location = new Point(66, 44);
            btnRigth.Name = "btnRigth";
            btnRigth.Size = new Size(25, 25);
            btnRigth.TabIndex = 21;
            btnRigth.Text = "→";
            btnRigth.TextAlign = ContentAlignment.TopCenter;
            btnRigth.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 585);
            Controls.Add(btnNew);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(twRegions);
            Name = "Home";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TreeView twRegions;
        private TextBox tbHeight;
        private Button btnNew;
        private Button btnPlusWidth;
        private Button btnMinusWidth;
        private Button btnPlusHeight;
        private Button btnMinusHeight;
        private Button btnUpRight;
        private Button btnDownRight;
        private Button btnDownLeft;
        private Button btnUpLeft;
        private Button btnUp;
        private Button btnDown;
        private Button btnLeft;
        private Button btnRigth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private TextBox tbY;
        private TextBox tbX;
        private System.Windows.Forms.Label lbXY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private TextBox tbWidth;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
