using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz {
    public partial class MathQuiz : Form {
        Random random = new Random();

        int addend1;
        int addend2;

        int minusend1;
        int minusend2;

        int multiend1;
        int multiend2;

        int divideend1;
        int divideend2;

        int timeleft;

        public MathQuiz() {
            InitializeComponent();
        }

        //퀴즈 시작 함. 랜덤으로 수를 정하기!
        public void StartTheQuiz() {
            timeLabel.BackColor = Color.White;

            // 더하기 문제 랜덤값 구하기. 0에서 50까지의 랜덤값이 나올 수 있음
            addend1 = random.Next(51);
            addend2 = random.Next(51);

            //랜덤값 표시하기
            plusleftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            // 더하기 값 초기화
            sum.Value = 0;


            //빼기
            minusend1 = random.Next(1, 101);
            minusend2 = random.Next(1, minusend1);
            minusleftLabel.Text = minusend1.ToString();
            minusRightLabel.Text = minusend2.ToString();
            minus.Value = 0;

            //곱하기
            multiend1 = random.Next(2, 11);
            multiend2 = random.Next(2, 11);
            multileftLabel.Text = multiend1.ToString();
            multiRightLabel.Text = multiend2.ToString();
            multi.Value = 0;

            //나누기
            divideend2 = random.Next(2, 11);
            divideend1 = random.Next(2, 11) * divideend2;
            divideleftLabel.Text = divideend1.ToString();
            divideRightLabel.Text = divideend2.ToString();
            divide.Value = 0;

            // 타이머 시작!!
            timeleft = 30;
            timeLabel.Text = "30 초";
            timer1.Start();
        }

        private bool CheckTheAnswer() {
            if((addend1+addend2 == sum.Value)&&
                (minusend1-minusend2 == minus.Value)&&
                (multiend1*multiend2 == multi.Value)&&
                (divideend1/divideend2 == divide.Value)) {
                return true;
            } else {
                return false;
            }
        }

        private void startBT_Click(object sender, EventArgs e) {
            StartTheQuiz();
            startBT.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (CheckTheAnswer()) {
                timer1.Stop();
                MessageBox.Show("시간 안에 다 풀었습니다! 축하합니다!!!");
                startBT.Enabled = true;
            } else if (timeleft > 0) {
                timeleft = timeleft - 1;
                timeLabel.Text = timeleft + "초";
            } else {
                timer1.Stop();
                timeLabel.Text = "시간 초과!!";
                MessageBox.Show("시간안에 계산 못하였습니다.");
                sum.Value = addend1 + addend2;
                minus.Value = minusend1 - minusend2;
                multi.Value = multiend1 * multiend2;
                divide.Value = divideend1 / divideend2;
                startBT.Enabled = true;
            }

            if(timeleft == 5) {
                timeLabel.BackColor = Color.Red;
            }
        }

        // object sender는 즉 엔터를 눌렀을 때 포커스되어진 NumbericUpDown을 가르킨다.
        private void answer_Enter(object sender, EventArgs e) {
            NumericUpDown answerBox= sender as NumericUpDown;
            if (answerBox != null) {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0,lengthOfAnswer);
            }
        }
    }

}
