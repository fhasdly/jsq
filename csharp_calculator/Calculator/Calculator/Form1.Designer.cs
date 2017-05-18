namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rRadix16 = new System.Windows.Forms.RadioButton();
            this.rRadix10 = new System.Windows.Forms.RadioButton();
            this.rRadix8 = new System.Windows.Forms.RadioButton();
            this.rRadix2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonSign = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonF = new System.Windows.Forms.Button();
            this.buttonInt = new System.Windows.Forms.Button();
            this.buttonNot = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonAnd = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonXor = new System.Windows.Forms.Button();
            this.buttonOr = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttonRightMove = new System.Windows.Forms.Button();
            this.buttonLeftMove = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonEq = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonBs = new System.Windows.Forms.Button();
            this.buttonPI = new System.Windows.Forms.Button();
            this.buttonExp = new System.Windows.Forms.Button();
            this.buttonMC = new System.Windows.Forms.Button();
            this.buttonMR = new System.Windows.Forms.Button();
            this.buttonMS = new System.Windows.Forms.Button();
            this.buttonMAdd = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbInput.Location = new System.Drawing.Point(12, 12);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(327, 21);
            this.tbInput.TabIndex = 0;
            this.tbInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbInput.Click += new System.EventHandler(this.tbInput_Click);
            this.tbInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbInput_KeyDown);
            this.tbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rRadix16);
            this.groupBox1.Controls.Add(this.rRadix10);
            this.groupBox1.Controls.Add(this.rRadix8);
            this.groupBox1.Controls.Add(this.rRadix2);
            this.groupBox1.Location = new System.Drawing.Point(14, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 42);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // rRadix16
            // 
            this.rRadix16.AutoSize = true;
            this.rRadix16.Location = new System.Drawing.Point(216, 19);
            this.rRadix16.Name = "rRadix16";
            this.rRadix16.Size = new System.Drawing.Size(71, 16);
            this.rRadix16.TabIndex = 3;
            this.rRadix16.TabStop = true;
            this.rRadix16.Text = "十六进制";
            this.rRadix16.UseVisualStyleBackColor = true;
            this.rRadix16.Click += new System.EventHandler(this.rRadix16_Click);
            // 
            // rRadix10
            // 
            this.rRadix10.AutoSize = true;
            this.rRadix10.Checked = true;
            this.rRadix10.Location = new System.Drawing.Point(151, 19);
            this.rRadix10.Name = "rRadix10";
            this.rRadix10.Size = new System.Drawing.Size(59, 16);
            this.rRadix10.TabIndex = 2;
            this.rRadix10.TabStop = true;
            this.rRadix10.Text = "十进制";
            this.rRadix10.UseVisualStyleBackColor = true;
            this.rRadix10.Click += new System.EventHandler(this.rRadix10_Click);
            // 
            // rRadix8
            // 
            this.rRadix8.AutoSize = true;
            this.rRadix8.Location = new System.Drawing.Point(86, 19);
            this.rRadix8.Name = "rRadix8";
            this.rRadix8.Size = new System.Drawing.Size(59, 16);
            this.rRadix8.TabIndex = 1;
            this.rRadix8.TabStop = true;
            this.rRadix8.Text = "八进制";
            this.rRadix8.UseVisualStyleBackColor = true;
            this.rRadix8.Click += new System.EventHandler(this.rRadix8_Click);
            // 
            // rRadix2
            // 
            this.rRadix2.AutoSize = true;
            this.rRadix2.Location = new System.Drawing.Point(21, 19);
            this.rRadix2.Name = "rRadix2";
            this.rRadix2.Size = new System.Drawing.Size(59, 16);
            this.rRadix2.TabIndex = 0;
            this.rRadix2.TabStop = true;
            this.rRadix2.Text = "二进制";
            this.rRadix2.UseVisualStyleBackColor = true;
            this.rRadix2.Click += new System.EventHandler(this.rRadix2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(24, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(62, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(100, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(24, 122);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.Blue;
            this.button5.Location = new System.Drawing.Point(62, 122);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.Color.Blue;
            this.button6.Location = new System.Drawing.Point(100, 122);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(30, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.Color.Blue;
            this.button7.Location = new System.Drawing.Point(24, 93);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(30, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.ForeColor = System.Drawing.Color.Blue;
            this.button8.Location = new System.Drawing.Point(62, 93);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(30, 23);
            this.button8.TabIndex = 9;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.ForeColor = System.Drawing.Color.Blue;
            this.button9.Location = new System.Drawing.Point(100, 93);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(30, 23);
            this.button9.TabIndex = 10;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.ForeColor = System.Drawing.Color.Blue;
            this.button0.Location = new System.Drawing.Point(24, 180);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(30, 23);
            this.button0.TabIndex = 11;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.ForeColor = System.Drawing.Color.Blue;
            this.buttonDot.Location = new System.Drawing.Point(60, 180);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(30, 23);
            this.buttonDot.TabIndex = 12;
            this.buttonDot.Text = "·";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // buttonSign
            // 
            this.buttonSign.AccessibleDescription = "改变正负";
            this.buttonSign.ForeColor = System.Drawing.Color.Blue;
            this.buttonSign.Location = new System.Drawing.Point(100, 180);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(30, 23);
            this.buttonSign.TabIndex = 13;
            this.buttonSign.Tag = "";
            this.buttonSign.Text = "±";
            this.buttonSign.UseVisualStyleBackColor = true;
            this.buttonSign.Click += new System.EventHandler(this.buttonSign_Click);
            // 
            // buttonA
            // 
            this.buttonA.ForeColor = System.Drawing.Color.Blue;
            this.buttonA.Location = new System.Drawing.Point(24, 209);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(30, 23);
            this.buttonA.TabIndex = 14;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonB
            // 
            this.buttonB.ForeColor = System.Drawing.Color.Blue;
            this.buttonB.Location = new System.Drawing.Point(62, 209);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(30, 23);
            this.buttonB.TabIndex = 15;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // buttonC
            // 
            this.buttonC.ForeColor = System.Drawing.Color.Blue;
            this.buttonC.Location = new System.Drawing.Point(100, 209);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(30, 23);
            this.buttonC.TabIndex = 16;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonD
            // 
            this.buttonD.ForeColor = System.Drawing.Color.Blue;
            this.buttonD.Location = new System.Drawing.Point(24, 238);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(30, 23);
            this.buttonD.TabIndex = 17;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // buttonE
            // 
            this.buttonE.ForeColor = System.Drawing.Color.Blue;
            this.buttonE.Location = new System.Drawing.Point(64, 238);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(30, 23);
            this.buttonE.TabIndex = 18;
            this.buttonE.Text = "E";
            this.buttonE.UseVisualStyleBackColor = true;
            this.buttonE.Click += new System.EventHandler(this.buttonE_Click);
            // 
            // buttonF
            // 
            this.buttonF.ForeColor = System.Drawing.Color.Blue;
            this.buttonF.Location = new System.Drawing.Point(100, 238);
            this.buttonF.Name = "buttonF";
            this.buttonF.Size = new System.Drawing.Size(30, 23);
            this.buttonF.TabIndex = 19;
            this.buttonF.Text = "F";
            this.buttonF.UseVisualStyleBackColor = true;
            this.buttonF.Click += new System.EventHandler(this.buttonF_Click);
            // 
            // buttonInt
            // 
            this.buttonInt.AccessibleDescription = "取整";
            this.buttonInt.ForeColor = System.Drawing.Color.Red;
            this.buttonInt.Location = new System.Drawing.Point(230, 238);
            this.buttonInt.Name = "buttonInt";
            this.buttonInt.Size = new System.Drawing.Size(43, 23);
            this.buttonInt.TabIndex = 31;
            this.buttonInt.Text = "Int";
            this.buttonInt.UseVisualStyleBackColor = true;
            this.buttonInt.Click += new System.EventHandler(this.buttonInt_Click);
            // 
            // buttonNot
            // 
            this.buttonNot.AccessibleDescription = "取非.   未实现";
            this.buttonNot.ForeColor = System.Drawing.Color.Red;
            this.buttonNot.Location = new System.Drawing.Point(181, 238);
            this.buttonNot.Name = "buttonNot";
            this.buttonNot.Size = new System.Drawing.Size(43, 23);
            this.buttonNot.TabIndex = 30;
            this.buttonNot.Text = "Not";
            this.buttonNot.UseVisualStyleBackColor = true;
            this.buttonNot.Click += new System.EventHandler(this.buttonNot_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.ForeColor = System.Drawing.Color.Red;
            this.buttonAdd.Location = new System.Drawing.Point(145, 209);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(30, 23);
            this.buttonAdd.TabIndex = 29;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonAnd
            // 
            this.buttonAnd.ForeColor = System.Drawing.Color.Red;
            this.buttonAnd.Location = new System.Drawing.Point(230, 151);
            this.buttonAnd.Name = "buttonAnd";
            this.buttonAnd.Size = new System.Drawing.Size(43, 23);
            this.buttonAnd.TabIndex = 28;
            this.buttonAnd.Text = "And";
            this.buttonAnd.UseVisualStyleBackColor = true;
            this.buttonAnd.Click += new System.EventHandler(this.buttonAnd_Click);
            // 
            // buttonMod
            // 
            this.buttonMod.AccessibleDescription = "取模";
            this.buttonMod.ForeColor = System.Drawing.Color.Red;
            this.buttonMod.Location = new System.Drawing.Point(181, 151);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(43, 23);
            this.buttonMod.TabIndex = 27;
            this.buttonMod.Text = "Mod";
            this.buttonMod.UseVisualStyleBackColor = true;
            this.buttonMod.Click += new System.EventHandler(this.buttonMod_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.ForeColor = System.Drawing.Color.Red;
            this.buttonDiv.Location = new System.Drawing.Point(145, 122);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(30, 23);
            this.buttonDiv.TabIndex = 26;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // buttonXor
            // 
            this.buttonXor.ForeColor = System.Drawing.Color.Red;
            this.buttonXor.Location = new System.Drawing.Point(230, 180);
            this.buttonXor.Name = "buttonXor";
            this.buttonXor.Size = new System.Drawing.Size(43, 23);
            this.buttonXor.TabIndex = 25;
            this.buttonXor.Text = "Xor";
            this.buttonXor.UseVisualStyleBackColor = true;
            this.buttonXor.Click += new System.EventHandler(this.buttonXor_Click);
            // 
            // buttonOr
            // 
            this.buttonOr.ForeColor = System.Drawing.Color.Red;
            this.buttonOr.Location = new System.Drawing.Point(181, 180);
            this.buttonOr.Name = "buttonOr";
            this.buttonOr.Size = new System.Drawing.Size(43, 23);
            this.buttonOr.TabIndex = 24;
            this.buttonOr.Text = "Or";
            this.buttonOr.UseVisualStyleBackColor = true;
            this.buttonOr.Click += new System.EventHandler(this.buttonOr_Click);
            // 
            // buttonMul
            // 
            this.buttonMul.ForeColor = System.Drawing.Color.Red;
            this.buttonMul.Location = new System.Drawing.Point(145, 151);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(30, 23);
            this.buttonMul.TabIndex = 23;
            this.buttonMul.Text = "*";
            this.buttonMul.UseVisualStyleBackColor = true;
            this.buttonMul.Click += new System.EventHandler(this.buttonMul_Click);
            // 
            // buttonRightMove
            // 
            this.buttonRightMove.AccessibleDescription = "右移一位";
            this.buttonRightMove.ForeColor = System.Drawing.Color.Red;
            this.buttonRightMove.Location = new System.Drawing.Point(230, 209);
            this.buttonRightMove.Name = "buttonRightMove";
            this.buttonRightMove.Size = new System.Drawing.Size(43, 23);
            this.buttonRightMove.TabIndex = 22;
            this.buttonRightMove.Text = ">>";
            this.buttonRightMove.UseVisualStyleBackColor = true;
            this.buttonRightMove.Click += new System.EventHandler(this.buttonRightMove_Click);
            // 
            // buttonLeftMove
            // 
            this.buttonLeftMove.AccessibleDescription = "左移一位";
            this.buttonLeftMove.ForeColor = System.Drawing.Color.Red;
            this.buttonLeftMove.Location = new System.Drawing.Point(181, 209);
            this.buttonLeftMove.Name = "buttonLeftMove";
            this.buttonLeftMove.Size = new System.Drawing.Size(43, 23);
            this.buttonLeftMove.TabIndex = 21;
            this.buttonLeftMove.Text = "<<";
            this.buttonLeftMove.UseVisualStyleBackColor = true;
            this.buttonLeftMove.Click += new System.EventHandler(this.buttonLeftMove_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.ForeColor = System.Drawing.Color.Red;
            this.buttonSub.Location = new System.Drawing.Point(145, 180);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(30, 23);
            this.buttonSub.TabIndex = 20;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // buttonEq
            // 
            this.buttonEq.ForeColor = System.Drawing.Color.Red;
            this.buttonEq.Location = new System.Drawing.Point(145, 238);
            this.buttonEq.Name = "buttonEq";
            this.buttonEq.Size = new System.Drawing.Size(30, 23);
            this.buttonEq.TabIndex = 32;
            this.buttonEq.Text = "=";
            this.buttonEq.UseVisualStyleBackColor = true;
            this.buttonEq.Click += new System.EventHandler(this.buttonEq_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.AccessibleDescription = "清空所有数字";
            this.buttonClear.ForeColor = System.Drawing.Color.Red;
            this.buttonClear.Location = new System.Drawing.Point(145, 93);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(30, 23);
            this.buttonClear.TabIndex = 33;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonBs
            // 
            this.buttonBs.AccessibleDescription = "回删一个显示框中的符号";
            this.buttonBs.ForeColor = System.Drawing.Color.Red;
            this.buttonBs.Location = new System.Drawing.Point(181, 93);
            this.buttonBs.Name = "buttonBs";
            this.buttonBs.Size = new System.Drawing.Size(92, 23);
            this.buttonBs.TabIndex = 34;
            this.buttonBs.Text = "Backspace";
            this.buttonBs.UseVisualStyleBackColor = true;
            this.buttonBs.Click += new System.EventHandler(this.buttonBs_Click);
            // 
            // buttonPI
            // 
            this.buttonPI.AccessibleDescription = "显示出PI的值";
            this.buttonPI.ForeColor = System.Drawing.Color.Red;
            this.buttonPI.Location = new System.Drawing.Point(181, 122);
            this.buttonPI.Name = "buttonPI";
            this.buttonPI.Size = new System.Drawing.Size(43, 23);
            this.buttonPI.TabIndex = 35;
            this.buttonPI.Text = "PI";
            this.buttonPI.UseVisualStyleBackColor = true;
            this.buttonPI.Click += new System.EventHandler(this.buttonPI_Click);
            // 
            // buttonExp
            // 
            this.buttonExp.AccessibleDescription = "5 EXP 2,得到500";
            this.buttonExp.ForeColor = System.Drawing.Color.Red;
            this.buttonExp.Location = new System.Drawing.Point(230, 122);
            this.buttonExp.Name = "buttonExp";
            this.buttonExp.Size = new System.Drawing.Size(43, 23);
            this.buttonExp.TabIndex = 36;
            this.buttonExp.Text = "EXP";
            this.buttonExp.UseVisualStyleBackColor = true;
            this.buttonExp.Click += new System.EventHandler(this.buttonExp_Click);
            // 
            // buttonMC
            // 
            this.buttonMC.AccessibleDescription = "清除存储器中的数值";
            this.buttonMC.ForeColor = System.Drawing.Color.Red;
            this.buttonMC.Location = new System.Drawing.Point(287, 93);
            this.buttonMC.Name = "buttonMC";
            this.buttonMC.Size = new System.Drawing.Size(43, 23);
            this.buttonMC.TabIndex = 37;
            this.buttonMC.Text = "MC";
            this.buttonMC.UseVisualStyleBackColor = true;
            this.buttonMC.Click += new System.EventHandler(this.buttonMC_Click);
            // 
            // buttonMR
            // 
            this.buttonMR.AccessibleDescription = "将存于存储器中的数显示在计算器的显示框上";
            this.buttonMR.ForeColor = System.Drawing.Color.Red;
            this.buttonMR.Location = new System.Drawing.Point(287, 122);
            this.buttonMR.Name = "buttonMR";
            this.buttonMR.Size = new System.Drawing.Size(43, 23);
            this.buttonMR.TabIndex = 38;
            this.buttonMR.Text = "MR";
            this.buttonMR.UseVisualStyleBackColor = true;
            this.buttonMR.Click += new System.EventHandler(this.buttonMR_Click);
            // 
            // buttonMS
            // 
            this.buttonMS.AccessibleDescription = "将显示框的数值存于存储器中";
            this.buttonMS.ForeColor = System.Drawing.Color.Red;
            this.buttonMS.Location = new System.Drawing.Point(287, 151);
            this.buttonMS.Name = "buttonMS";
            this.buttonMS.Size = new System.Drawing.Size(43, 23);
            this.buttonMS.TabIndex = 39;
            this.buttonMS.Text = "MS";
            this.buttonMS.UseVisualStyleBackColor = true;
            this.buttonMS.Click += new System.EventHandler(this.buttonMS_Click);
            // 
            // buttonMAdd
            // 
            this.buttonMAdd.ForeColor = System.Drawing.Color.Red;
            this.buttonMAdd.Location = new System.Drawing.Point(287, 180);
            this.buttonMAdd.Name = "buttonMAdd";
            this.buttonMAdd.Size = new System.Drawing.Size(43, 23);
            this.buttonMAdd.TabIndex = 40;
            this.buttonMAdd.Text = "M+";
            this.buttonMAdd.UseVisualStyleBackColor = true;
            this.buttonMAdd.Click += new System.EventHandler(this.buttonMAdd_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.AccessibleDescription = "将显示框中的数据复制到粘贴版";
            this.buttonCopy.ForeColor = System.Drawing.Color.Red;
            this.buttonCopy.Location = new System.Drawing.Point(287, 209);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(43, 23);
            this.buttonCopy.TabIndex = 41;
            this.buttonCopy.Text = "copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.AccessibleDescription = "清空当前数字";
            this.buttonCE.ForeColor = System.Drawing.Color.Red;
            this.buttonCE.Location = new System.Drawing.Point(287, 238);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(43, 23);
            this.buttonCE.TabIndex = 42;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 43;
            this.label1.Text = "    ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 275);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonMAdd);
            this.Controls.Add(this.buttonMS);
            this.Controls.Add(this.buttonMR);
            this.Controls.Add(this.buttonMC);
            this.Controls.Add(this.buttonExp);
            this.Controls.Add(this.buttonPI);
            this.Controls.Add(this.buttonBs);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonEq);
            this.Controls.Add(this.buttonInt);
            this.Controls.Add(this.buttonNot);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonAnd);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonXor);
            this.Controls.Add(this.buttonOr);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttonRightMove);
            this.Controls.Add(this.buttonLeftMove);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonF);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.buttonSign);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "〖计算器〗";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rRadix16;
        private System.Windows.Forms.RadioButton rRadix10;
        private System.Windows.Forms.RadioButton rRadix8;
        private System.Windows.Forms.RadioButton rRadix2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonSign;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonF;
        private System.Windows.Forms.Button buttonInt;
        private System.Windows.Forms.Button buttonNot;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonAnd;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonXor;
        private System.Windows.Forms.Button buttonOr;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button buttonRightMove;
        private System.Windows.Forms.Button buttonLeftMove;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonEq;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonBs;
        private System.Windows.Forms.Button buttonPI;
        private System.Windows.Forms.Button buttonExp;
        private System.Windows.Forms.Button buttonMC;
        private System.Windows.Forms.Button buttonMR;
        private System.Windows.Forms.Button buttonMS;
        private System.Windows.Forms.Button buttonMAdd;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Label label1;
    }
}

