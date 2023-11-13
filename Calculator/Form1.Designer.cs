namespace Calculator
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
            this.txtBoxResult = new System.Windows.Forms.TextBox();
            this.btnBackslash = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnCube = new System.Windows.Forms.Button();
            this.btnFact = new System.Windows.Forms.Button();
            this.btnSquar = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnCosh = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnSqrtGeneral = new System.Windows.Forms.Button();
            this.btnPercentage = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnSinh = new System.Windows.Forms.Button();
            this.btnHex = new System.Windows.Forms.Button();
            this.btnTanh = new System.Windows.Forms.Button();
            this.btnBin = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxResult
            // 
            this.txtBoxResult.Font = new System.Drawing.Font("Raleway ExtraBold", 24F, System.Drawing.FontStyle.Bold);
            this.txtBoxResult.Location = new System.Drawing.Point(12, 47);
            this.txtBoxResult.Multiline = true;
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.Size = new System.Drawing.Size(1176, 60);
            this.txtBoxResult.TabIndex = 0;
            this.txtBoxResult.Text = "0";
            this.txtBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBoxResult.TextChanged += new System.EventHandler(this.ResultHandler);
            // 
            // btnBackslash
            // 
            this.btnBackslash.Font = new System.Drawing.Font("Wingdings", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnBackslash.Location = new System.Drawing.Point(12, 123);
            this.btnBackslash.Name = "btnBackslash";
            this.btnBackslash.Size = new System.Drawing.Size(140, 68);
            this.btnBackslash.TabIndex = 1;
            this.btnBackslash.Text = "";
            this.btnBackslash.UseVisualStyleBackColor = true;
            this.btnBackslash.Click += new System.EventHandler(this.btnBackslash_Click);
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.Font = new System.Drawing.Font("Raleway ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btnPlusMinus.Location = new System.Drawing.Point(450, 123);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(140, 68);
            this.btnPlusMinus.TabIndex = 2;
            this.btnPlusMinus.Text = "±";
            this.btnPlusMinus.UseVisualStyleBackColor = true;
            this.btnPlusMinus.Click += new System.EventHandler(this.btnPlusMinus_Click);
            // 
            // btnCE
            // 
            this.btnCE.Font = new System.Drawing.Font("Raleway ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btnCE.Location = new System.Drawing.Point(158, 123);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(140, 68);
            this.btnCE.TabIndex = 3;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Raleway ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btnC.Location = new System.Drawing.Point(304, 123);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(140, 68);
            this.btnC.TabIndex = 4;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Raleway ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btn9.Location = new System.Drawing.Point(303, 197);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(140, 68);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.EnterNs);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Raleway ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btn8.Location = new System.Drawing.Point(157, 197);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(140, 68);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.EnterNs);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Raleway ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(450, 197);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 68);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BasicOps);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Raleway ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btn7.Location = new System.Drawing.Point(11, 197);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(140, 68);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.EnterNs);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Raleway ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btn4.Location = new System.Drawing.Point(303, 271);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(140, 68);
            this.btn4.TabIndex = 12;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.EnterNs);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Raleway ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btn5.Location = new System.Drawing.Point(157, 271);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(140, 68);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.EnterNs);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Raleway ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btnSubtract.Location = new System.Drawing.Point(450, 271);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(140, 68);
            this.btnSubtract.TabIndex = 10;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.BasicOps);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Raleway ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btn6.Location = new System.Drawing.Point(11, 271);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(140, 68);
            this.btn6.TabIndex = 9;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.EnterNs);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Raleway ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btn1.Location = new System.Drawing.Point(303, 345);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(140, 68);
            this.btn1.TabIndex = 16;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.EnterNs);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Raleway ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btn2.Location = new System.Drawing.Point(157, 345);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(140, 68);
            this.btn2.TabIndex = 15;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.EnterNs);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Raleway ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btnMultiply.Location = new System.Drawing.Point(450, 345);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(140, 68);
            this.btnMultiply.TabIndex = 14;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.BasicOps);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Raleway ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btn3.Location = new System.Drawing.Point(11, 345);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(140, 68);
            this.btn3.TabIndex = 13;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.EnterNs);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Raleway ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btnEqual.Location = new System.Drawing.Point(304, 419);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(140, 68);
            this.btnEqual.TabIndex = 20;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Raleway ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btn0.Location = new System.Drawing.Point(157, 419);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(140, 68);
            this.btn0.TabIndex = 19;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.EnterNs);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Raleway ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btnDivide.Location = new System.Drawing.Point(450, 419);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(140, 68);
            this.btnDivide.TabIndex = 18;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.BasicOps);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Font = new System.Drawing.Font("Raleway ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btnDecimal.Location = new System.Drawing.Point(11, 419);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(140, 68);
            this.btnDecimal.TabIndex = 17;
            this.btnDecimal.Text = ",";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.EnterNs);
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Raleway ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btnLog.Location = new System.Drawing.Point(902, 123);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(140, 68);
            this.btnLog.TabIndex = 24;
            this.btnLog.Text = "log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnE
            // 
            this.btnE.Font = new System.Drawing.Font("Raleway ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btnE.Location = new System.Drawing.Point(756, 123);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(140, 68);
            this.btnE.TabIndex = 23;
            this.btnE.Text = "e";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnLn
            // 
            this.btnLn.Font = new System.Drawing.Font("Raleway ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btnLn.Location = new System.Drawing.Point(1048, 123);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(140, 68);
            this.btnLn.TabIndex = 22;
            this.btnLn.Text = "ln";
            this.btnLn.UseVisualStyleBackColor = true;
            this.btnLn.Click += new System.EventHandler(this.btnLn_Click);
            // 
            // btnPi
            // 
            this.btnPi.Font = new System.Drawing.Font("Centaur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPi.Location = new System.Drawing.Point(610, 123);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(140, 68);
            this.btnPi.TabIndex = 21;
            this.btnPi.Text = "π";
            this.btnPi.UseVisualStyleBackColor = true;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // btnExp
            // 
            this.btnExp.Font = new System.Drawing.Font("Raleway ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btnExp.Location = new System.Drawing.Point(902, 197);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(140, 68);
            this.btnExp.TabIndex = 28;
            this.btnExp.Text = "x^y";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.BasicOps);
            // 
            // btnCube
            // 
            this.btnCube.Font = new System.Drawing.Font("Raleway ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btnCube.Location = new System.Drawing.Point(756, 197);
            this.btnCube.Name = "btnCube";
            this.btnCube.Size = new System.Drawing.Size(140, 68);
            this.btnCube.TabIndex = 27;
            this.btnCube.Text = "x³";
            this.btnCube.UseVisualStyleBackColor = true;
            this.btnCube.Click += new System.EventHandler(this.preDefExps);
            // 
            // btnFact
            // 
            this.btnFact.Font = new System.Drawing.Font("Raleway ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btnFact.Location = new System.Drawing.Point(1048, 197);
            this.btnFact.Name = "btnFact";
            this.btnFact.Size = new System.Drawing.Size(140, 68);
            this.btnFact.TabIndex = 26;
            this.btnFact.Text = "x!";
            this.btnFact.UseVisualStyleBackColor = true;
            this.btnFact.Click += new System.EventHandler(this.btnFact_Click);
            // 
            // btnSquar
            // 
            this.btnSquar.Font = new System.Drawing.Font("Raleway ExtraBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquar.Location = new System.Drawing.Point(610, 197);
            this.btnSquar.Name = "btnSquar";
            this.btnSquar.Size = new System.Drawing.Size(140, 68);
            this.btnSquar.TabIndex = 25;
            this.btnSquar.Text = "x²";
            this.btnSquar.UseVisualStyleBackColor = true;
            this.btnSquar.Click += new System.EventHandler(this.preDefExps);
            // 
            // btnTan
            // 
            this.btnTan.Font = new System.Drawing.Font("Raleway ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btnTan.Location = new System.Drawing.Point(902, 345);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(140, 68);
            this.btnTan.TabIndex = 36;
            this.btnTan.Text = "tan(x)";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.btnTrig);
            // 
            // btnCos
            // 
            this.btnCos.Font = new System.Drawing.Font("Raleway ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btnCos.Location = new System.Drawing.Point(756, 345);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(140, 68);
            this.btnCos.TabIndex = 35;
            this.btnCos.Text = "cos(x)";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnTrig);
            // 
            // btnCosh
            // 
            this.btnCosh.Font = new System.Drawing.Font("Raleway ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btnCosh.Location = new System.Drawing.Point(756, 420);
            this.btnCosh.Name = "btnCosh";
            this.btnCosh.Size = new System.Drawing.Size(140, 68);
            this.btnCosh.TabIndex = 34;
            this.btnCosh.Text = "cosh(x)";
            this.btnCosh.UseVisualStyleBackColor = true;
            this.btnCosh.Click += new System.EventHandler(this.btnTrig);
            // 
            // btnSin
            // 
            this.btnSin.Font = new System.Drawing.Font("Raleway ExtraBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSin.Location = new System.Drawing.Point(610, 345);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(140, 68);
            this.btnSin.TabIndex = 33;
            this.btnSin.Text = "sin(x)";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btnTrig);
            // 
            // btnMod
            // 
            this.btnMod.Font = new System.Drawing.Font("Raleway ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btnMod.Location = new System.Drawing.Point(902, 271);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(140, 68);
            this.btnMod.TabIndex = 32;
            this.btnMod.Text = "mod";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.BasicOps);
            // 
            // btnSqrtGeneral
            // 
            this.btnSqrtGeneral.Font = new System.Drawing.Font("Raleway ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btnSqrtGeneral.Location = new System.Drawing.Point(756, 271);
            this.btnSqrtGeneral.Name = "btnSqrtGeneral";
            this.btnSqrtGeneral.Size = new System.Drawing.Size(140, 68);
            this.btnSqrtGeneral.TabIndex = 31;
            this.btnSqrtGeneral.Text = "sqrt";
            this.btnSqrtGeneral.UseVisualStyleBackColor = true;
            this.btnSqrtGeneral.Click += new System.EventHandler(this.BasicOps);
            // 
            // btnPercentage
            // 
            this.btnPercentage.Font = new System.Drawing.Font("Raleway ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btnPercentage.Location = new System.Drawing.Point(1048, 271);
            this.btnPercentage.Name = "btnPercentage";
            this.btnPercentage.Size = new System.Drawing.Size(140, 68);
            this.btnPercentage.TabIndex = 30;
            this.btnPercentage.Text = "%";
            this.btnPercentage.UseVisualStyleBackColor = true;
            this.btnPercentage.Click += new System.EventHandler(this.btnPercentage_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Font = new System.Drawing.Font("Raleway ExtraBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrt.Location = new System.Drawing.Point(610, 271);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(140, 68);
            this.btnSqrt.TabIndex = 29;
            this.btnSqrt.Text = "√x";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.preDefExps);
            // 
            // btnSinh
            // 
            this.btnSinh.Font = new System.Drawing.Font("Raleway ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btnSinh.Location = new System.Drawing.Point(610, 419);
            this.btnSinh.Name = "btnSinh";
            this.btnSinh.Size = new System.Drawing.Size(140, 68);
            this.btnSinh.TabIndex = 40;
            this.btnSinh.Text = "sinh(x)";
            this.btnSinh.UseVisualStyleBackColor = true;
            this.btnSinh.Click += new System.EventHandler(this.btnTrig);
            // 
            // btnHex
            // 
            this.btnHex.Font = new System.Drawing.Font("Raleway ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btnHex.Location = new System.Drawing.Point(1048, 419);
            this.btnHex.Name = "btnHex";
            this.btnHex.Size = new System.Drawing.Size(140, 68);
            this.btnHex.TabIndex = 39;
            this.btnHex.Text = "hex";
            this.btnHex.UseVisualStyleBackColor = true;
            this.btnHex.Click += new System.EventHandler(this.btnHex_Click);
            // 
            // btnTanh
            // 
            this.btnTanh.Font = new System.Drawing.Font("Raleway ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btnTanh.Location = new System.Drawing.Point(902, 419);
            this.btnTanh.Name = "btnTanh";
            this.btnTanh.Size = new System.Drawing.Size(140, 68);
            this.btnTanh.TabIndex = 38;
            this.btnTanh.Text = "tanh(x)";
            this.btnTanh.UseVisualStyleBackColor = true;
            this.btnTanh.Click += new System.EventHandler(this.btnTrig);
            // 
            // btnBin
            // 
            this.btnBin.Font = new System.Drawing.Font("Raleway ExtraBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBin.Location = new System.Drawing.Point(1048, 345);
            this.btnBin.Name = "btnBin";
            this.btnBin.Size = new System.Drawing.Size(140, 68);
            this.btnBin.TabIndex = 37;
            this.btnBin.Text = "bin";
            this.btnBin.UseVisualStyleBackColor = true;
            this.btnBin.Click += new System.EventHandler(this.btnBin_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Assistant ExtraBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.Location = new System.Drawing.Point(12, 9);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 30);
            this.labelError.TabIndex = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 500);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.btnSinh);
            this.Controls.Add(this.btnHex);
            this.Controls.Add(this.btnTanh);
            this.Controls.Add(this.btnBin);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnCosh);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnSqrtGeneral);
            this.Controls.Add(this.btnPercentage);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.btnCube);
            this.Controls.Add(this.btnFact);
            this.Controls.Add(this.btnSquar);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnLn);
            this.Controls.Add(this.btnPi);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.btnBackslash);
            this.Controls.Add(this.txtBoxResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxResult;
        private System.Windows.Forms.Button btnBackslash;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnLn;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnCube;
        private System.Windows.Forms.Button btnFact;
        private System.Windows.Forms.Button btnSquar;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnCosh;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnSqrtGeneral;
        private System.Windows.Forms.Button btnPercentage;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnSinh;
        private System.Windows.Forms.Button btnHex;
        private System.Windows.Forms.Button btnTanh;
        private System.Windows.Forms.Button btnBin;
        private System.Windows.Forms.Label labelError;
    }
}

