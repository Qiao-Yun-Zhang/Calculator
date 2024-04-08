using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //全域變數
        float firstNumber, secondNumber; //firstNumber 儲存第一個數字，secondNumber 儲存第二個數字
        int operators = -1; //記錄選擇哪一種運算符號？0:加、1:減、2:乘、3:除、-1:重新設定

        //增加數字函式
        private void Add_Number(string _number)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = ""; //這個簡單的判斷式，會預先檢查輸入文字框是不是只有一個「0」？是的話，就先清除掉裡面的數字內容
            }
            txtNumber.Text = txtNumber.Text + _number;
        }

        //選擇四則運算函式
        private void Select_Operator(int _operator)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text); //將輸入文字框轉換成浮點數，存入第一個數字的全域變數
            txtNumber.Text = "0"; //重新將輸入文字框重新設定為0
            operators = _operator; //選擇「四則運算」號
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            Add_Number("1"); //只需要呼叫Add_Number函式，並且設定參數為數字1
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            Add_Number("2");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            Add_Number("3");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            Add_Number("4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            Add_Number("5");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            Add_Number("6");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            Add_Number("7");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            Add_Number("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            Add_Number("9");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            Add_Number("0");
        }

        //按下選擇「加」按鍵
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Select_Operator(0);
        }

        //按下選擇「減」按鍵
        private void btnMinus_Click(object sender, EventArgs e)
        {
            Select_Operator(1);
        }

        //按下選擇「乘」按鍵
        private void btnPlus_Click(object sender, EventArgs e)
        {
            Select_Operator(2);
        }

        //按下選擇「除」按鍵
        private void btnDivide_Click(object sender, EventArgs e)
        {
            Select_Operator(3);
        }

        //按下選擇「等於」按鍵
        private void btnEqual_Click(object sender, EventArgs e)
        {
            float finalResults = 0f; //宣告最後計算結果變數，區域變數
            secondNumber = Convert.ToSingle(txtNumber.Text); //將輸入文字框轉換成浮點數，存入第二個數字的全域變數

            //依照四則運算符號的選擇，進行加減乘除
            switch (operators)
            {
                case 0:
                    finalResults = firstNumber + secondNumber;
                    break;
                case 1:
                    finalResults = firstNumber - secondNumber;
                    break;
                case 2:
                    finalResults = firstNumber * secondNumber;
                    break;
                case 3:
                    finalResults = firstNumber / secondNumber;
                    break;
            }

            txtNumber.Text = string.Format("{0:0.##########}", finalResults); //在輸入文字框中，顯示最後計算結果，並且轉換成格式化的字串內容

            //重置所有全域變數
            firstNumber = 0f;
            secondNumber = 0f;
            operators = -1;
        }

        //按下選擇「小數點」按鍵
        private void btnDot_Click(object sender, EventArgs e)
        {
            //確認輸入文字框中完全沒有小數點
            if (txtNumber.Text.IndexOf(".") == -1)
            {
                txtNumber.Text = txtNumber.Text + ".";
            }
        }

        //按下選擇「清除」按鍵
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "0";
            firstNumber = 0f;
            secondNumber = 0f;
            operators = -1;
        }
    }
}