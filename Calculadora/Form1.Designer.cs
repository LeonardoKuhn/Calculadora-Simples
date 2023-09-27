namespace Calculadora
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btnEnter.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            contextMenuStrip1 = new ContextMenuStrip(components);
            lblOperacao = new TextBox();
            txtResultado = new Label();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnSum = new Button();
            btnCE = new Button();
            btnC = new Button();
            btnSub = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnEnter = new Button();
            btnMul = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnDiv = new Button();
            btnPonto = new Button();
            btn0 = new Button();
            txtValor1 = new Label();
            txtOperador = new Label();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(contextMenuStrip1, "contextMenuStrip1");
            // 
            // lblOperacao
            // 
            lblOperacao.BackColor = SystemColors.ButtonHighlight;
            lblOperacao.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(lblOperacao, "lblOperacao");
            lblOperacao.ForeColor = Color.Transparent;
            lblOperacao.Name = "lblOperacao";
            lblOperacao.ReadOnly = true;
            // 
            // txtResultado
            // 
            txtResultado.BackColor = Color.White;
            resources.ApplyResources(txtResultado, "txtResultado");
            txtResultado.Name = "txtResultado";
            // 
            // btn7
            // 
            resources.ApplyResources(btn7, "btn7");
            btn7.Name = "btn7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            resources.ApplyResources(btn8, "btn8");
            btn8.Name = "btn8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            resources.ApplyResources(btn9, "btn9");
            btn9.Name = "btn9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnSum
            // 
            resources.ApplyResources(btnSum, "btnSum");
            btnSum.Name = "btnSum";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.Click += btnSum_Click;
            // 
            // btnCE
            // 
            resources.ApplyResources(btnCE, "btnCE");
            btnCE.Name = "btnCE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += btnCE_Click;
            // 
            // btnC
            // 
            resources.ApplyResources(btnC, "btnC");
            btnC.Name = "btnC";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnSub
            // 
            resources.ApplyResources(btnSub, "btnSub");
            btnSub.Name = "btnSub";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btn6
            // 
            resources.ApplyResources(btn6, "btn6");
            btn6.Name = "btn6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            resources.ApplyResources(btn5, "btn5");
            btn5.Name = "btn5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            resources.ApplyResources(btn4, "btn4");
            btn4.Name = "btn4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btnEnter
            // 
            resources.ApplyResources(btnEnter, "btnEnter");
            btnEnter.Name = "btnEnter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnMul
            // 
            resources.ApplyResources(btnMul, "btnMul");
            btnMul.Name = "btnMul";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnMul_Click;
            // 
            // btn3
            // 
            resources.ApplyResources(btn3, "btn3");
            btn3.Name = "btn3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            resources.ApplyResources(btn2, "btn2");
            btn2.Name = "btn2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            resources.ApplyResources(btn1, "btn1");
            btn1.Name = "btn1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btnDiv
            // 
            resources.ApplyResources(btnDiv, "btnDiv");
            btnDiv.Name = "btnDiv";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnPonto
            // 
            resources.ApplyResources(btnPonto, "btnPonto");
            btnPonto.Name = "btnPonto";
            btnPonto.UseVisualStyleBackColor = true;
            btnPonto.Click += btnPonto_Click;
            // 
            // btn0
            // 
            resources.ApplyResources(btn0, "btn0");
            btn0.Name = "btn0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // txtValor1
            // 
            txtValor1.BackColor = Color.White;
            resources.ApplyResources(txtValor1, "txtValor1");
            txtValor1.Name = "txtValor1";
            // 
            // txtOperador
            // 
            txtOperador.BackColor = Color.White;
            resources.ApplyResources(txtOperador, "txtOperador");
            txtOperador.ForeColor = Color.Black;
            txtOperador.Name = "txtOperador";
            // 
            // Form1
            // 
            AcceptButton = null;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnC;
            Controls.Add(btnDiv);
            Controls.Add(btnPonto);
            Controls.Add(btn0);
            Controls.Add(btnEnter);
            Controls.Add(btnMul);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnC);
            Controls.Add(btnSub);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnCE);
            Controls.Add(btnSum);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtResultado);
            Controls.Add(txtValor1);
            Controls.Add(txtOperador);
            Controls.Add(lblOperacao);
            KeyPreview = true;
            Name = "Form1";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TextBox lblOperacao;
        private Label txtResultado;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnSum;
        private Button btnCE;
        private Button btnC;
        private Button btnSub;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnEnter;
        private Button btnMul;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnDiv;
        private Button btnPonto;
        private Button btn0;
        private Label txtValor1;
        private Label txtOperador;
    }
}