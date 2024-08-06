using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberGenerator
{
    public partial class Form1 : Form
    {

        //フィールドとしてRandomオブジェクトを宣言
        private Random random;
        private Label label1;
        private Button button1;


        //Formの初期化
     public Form1()
        {
            InitializeComponent();

            //Randomオブジェクトを初期化
            random = new Random();

            //Labelをコードで生成
            label1 = new Label
            {
                Location = new Point(100, 50),
                Size = new Size(100, 20),
                Name = "label1",
                Text = "Number"
            };

            //Labelをフォームに追加
            this.Controls.Add(label1);

            //Buttonをコードで生成
            button1 = new Button
            {
                Location = new Point(100, 100),
                Size = new Size(75, 23),
                Name = "button1",
                Text = "Generate"
            };

            //Buttonのイベントハンドラを追加
            button1.Click += button1_Click;

            //Buttonをフォームに追加
            this.Controls.Add(button1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //ランダムな数字を生成する
            int randamNumber = random.Next(1, 101);

            //生成された数字をラベル人表示する
            label1.Text = randamNumber.ToString();
        }
    }

   
}
