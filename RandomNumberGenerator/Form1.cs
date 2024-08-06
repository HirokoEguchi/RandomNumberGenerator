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
        private Button button1;

        private Bitmap image1;
        private Bitmap image2;
        private Bitmap image3;
        private Bitmap image4;
        private Bitmap image5;
        private Bitmap image6;

        private Point image1Position;
        private Point image2Position;
        private Point image3Position;


        //Formの初期化
        public Form1()
        {
            InitializeComponent();

            image1 = new Bitmap("saikoro_1.png");
            image2 = new Bitmap("saikoro_2.png");
            image3 = new Bitmap("saikoro_3.png");
            image4 = new Bitmap("saikoro_4.png");
            image5 = new Bitmap("saikoro_5.png");
            image6 = new Bitmap("saikoro_6.png");

            // 初期位置の設定
            image1Position = new Point(50, 70);
            image2Position = new Point(150, 70);
            image3Position = new Point(250, 70);

            // ダブルバッファリングを有効にする
            this.DoubleBuffered = true;

            //Randomオブジェクトを初期化
            random = new Random();




            //Labelをコードで生成
            /*
            label1 = new Label
            {
                Location = new Point(100, 50),
                Size = new Size(100, 20),
                Name = "label1",
                Text = "Number"
            };

            //Labelをフォームに追加
            this.Controls.Add(label1);
            */





            //Buttonをコードで生成
            button1 = new Button
            {
                Location = new Point(150, 200),
                Size = new Size(75, 23),
                Name = "button1",
                Text = "Generate"
            };

            //Buttonのイベントハンドラを追加
            button1.Click += button1_Click;

            //Buttonをフォームに追加
            this.Controls.Add(button1);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            // 画像の描画
            if (image1 != null)
            {
                g.DrawImage(image1, new Rectangle(image1Position.X, image1Position.Y, 60, 60));
            }

            if (image2 != null)
            {
                g.DrawImage(image2, new Rectangle(image2Position.X, image2Position.Y, 60, 60));
            }

            if (image3 != null)
            {
                g.DrawImage(image3, new Rectangle(image3Position.X, image3Position.Y, 60, 60));
            }

        }



        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        private void button1_Click(object sender, EventArgs e)
        {
            // ランダムな数字を生成する

            // ランダムに要素番号を選択
            int randomIndex = random.Next(numbers.Count); // 0からnumbers.Count - 1までのランダムな整数を生成

            // ランダムに選ばれた要素を表示
            int selectedNumber = numbers[randomIndex];
        }
    }


}
