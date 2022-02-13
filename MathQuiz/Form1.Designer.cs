namespace MathQuiz {
    partial class MathQuiz {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plusleftLabel = new System.Windows.Forms.Label();
            this.plusLabel = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.minus = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.minusleftLabel = new System.Windows.Forms.Label();
            this.multi = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.multiRightLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.multileftLabel = new System.Windows.Forms.Label();
            this.divide = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.divideRightLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.divideleftLabel = new System.Windows.Forms.Label();
            this.startBT = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divide)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeLabel.Location = new System.Drawing.Point(268, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(200, 30);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("함초롬돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(164, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "남은 시간";
            // 
            // plusleftLabel
            // 
            this.plusleftLabel.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.plusleftLabel.Location = new System.Drawing.Point(50, 75);
            this.plusleftLabel.Name = "plusleftLabel";
            this.plusleftLabel.Size = new System.Drawing.Size(60, 50);
            this.plusleftLabel.TabIndex = 2;
            this.plusleftLabel.Text = "?";
            this.plusleftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusLabel
            // 
            this.plusLabel.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.plusLabel.Location = new System.Drawing.Point(116, 75);
            this.plusLabel.Name = "plusLabel";
            this.plusLabel.Size = new System.Drawing.Size(60, 50);
            this.plusLabel.TabIndex = 3;
            this.plusLabel.Text = "+";
            this.plusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.plusRightLabel.Location = new System.Drawing.Point(182, 75);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.plusRightLabel.TabIndex = 4;
            this.plusRightLabel.Text = "?";
            this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(248, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 50);
            this.label4.TabIndex = 5;
            this.label4.Text = "=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sum.Location = new System.Drawing.Point(314, 86);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(100, 35);
            this.sum.TabIndex = 1;
            this.sum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sum.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.minus.Location = new System.Drawing.Point(314, 141);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(100, 35);
            this.minus.TabIndex = 2;
            this.minus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minus.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(248, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 50);
            this.label2.TabIndex = 10;
            this.label2.Text = "=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            this.minusRightLabel.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.minusRightLabel.Location = new System.Drawing.Point(182, 130);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.minusRightLabel.TabIndex = 9;
            this.minusRightLabel.Text = "?";
            this.minusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(116, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 50);
            this.label5.TabIndex = 8;
            this.label5.Text = "-";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusleftLabel
            // 
            this.minusleftLabel.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.minusleftLabel.Location = new System.Drawing.Point(50, 130);
            this.minusleftLabel.Name = "minusleftLabel";
            this.minusleftLabel.Size = new System.Drawing.Size(60, 50);
            this.minusleftLabel.TabIndex = 7;
            this.minusleftLabel.Text = "?";
            this.minusleftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multi
            // 
            this.multi.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.multi.Location = new System.Drawing.Point(314, 191);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(100, 35);
            this.multi.TabIndex = 3;
            this.multi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.multi.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(248, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 50);
            this.label7.TabIndex = 15;
            this.label7.Text = "=";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multiRightLabel
            // 
            this.multiRightLabel.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.multiRightLabel.Location = new System.Drawing.Point(182, 180);
            this.multiRightLabel.Name = "multiRightLabel";
            this.multiRightLabel.Size = new System.Drawing.Size(60, 50);
            this.multiRightLabel.TabIndex = 14;
            this.multiRightLabel.Text = "?";
            this.multiRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(116, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 50);
            this.label9.TabIndex = 13;
            this.label9.Text = "×";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multileftLabel
            // 
            this.multileftLabel.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.multileftLabel.Location = new System.Drawing.Point(50, 180);
            this.multileftLabel.Name = "multileftLabel";
            this.multileftLabel.Size = new System.Drawing.Size(60, 50);
            this.multileftLabel.TabIndex = 12;
            this.multileftLabel.Text = "?";
            this.multileftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.divide.Location = new System.Drawing.Point(314, 242);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(100, 35);
            this.divide.TabIndex = 4;
            this.divide.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.divide.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(248, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 50);
            this.label11.TabIndex = 20;
            this.label11.Text = "=";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divideRightLabel
            // 
            this.divideRightLabel.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.divideRightLabel.Location = new System.Drawing.Point(182, 231);
            this.divideRightLabel.Name = "divideRightLabel";
            this.divideRightLabel.Size = new System.Drawing.Size(60, 50);
            this.divideRightLabel.TabIndex = 19;
            this.divideRightLabel.Text = "?";
            this.divideRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(116, 231);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 50);
            this.label13.TabIndex = 18;
            this.label13.Text = "÷";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divideleftLabel
            // 
            this.divideleftLabel.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.divideleftLabel.Location = new System.Drawing.Point(50, 231);
            this.divideleftLabel.Name = "divideleftLabel";
            this.divideleftLabel.Size = new System.Drawing.Size(60, 50);
            this.divideleftLabel.TabIndex = 17;
            this.divideleftLabel.Text = "?";
            this.divideleftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startBT
            // 
            this.startBT.AutoSize = true;
            this.startBT.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.startBT.Location = new System.Drawing.Point(120, 307);
            this.startBT.Name = "startBT";
            this.startBT.Size = new System.Drawing.Size(229, 38);
            this.startBT.TabIndex = 0;
            this.startBT.Text = "퀴즈 시작";
            this.startBT.UseVisualStyleBackColor = true;
            this.startBT.Click += new System.EventHandler(this.startBT_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MathQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 357);
            this.Controls.Add(this.startBT);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.divideRightLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.divideleftLabel);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.multiRightLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.multileftLabel);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minusRightLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.minusleftLabel);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.plusLabel);
            this.Controls.Add(this.plusleftLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MathQuiz";
            this.Text = "MathQuiz";
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label plusleftLabel;
        private System.Windows.Forms.Label plusLabel;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.NumericUpDown minus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label minusleftLabel;
        private System.Windows.Forms.NumericUpDown multi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label multiRightLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label multileftLabel;
        private System.Windows.Forms.NumericUpDown divide;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label divideRightLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label divideleftLabel;
        private System.Windows.Forms.Button startBT;
        private System.Windows.Forms.Timer timer1;
    }
}

