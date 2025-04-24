- Book Mark
    
    > [!info] [C#] GDI Point 위치  
    > 안녕하세요.  
    > [https://nowonbun.tistory.com/148](https://nowonbun.tistory.com/148)  
    

- 수학에서는 음수가 없는 좌표 기준 (0, 0)을 왼쪽 하단으로 계산합니다.
    - 그러나 윈도우에서는 왼쪽 상단이 기준으로 움직입니다.  
        물론 이 위치는 윈도우 전체에 해당이 됩니다.  
        - 즉 모니터 기준 가장 왼쪽, 상단 픽셀이 (0, 0)이 되겠습니다.

```C#
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GDI_POINT
{
    class Program : Form
    {
        static void Main(string[] args)
        {
            Application.Run(new Program());
        }

        public Program()
        {
            this.Load += new EventHandler(Program_Load);
        }

        public void Program_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }
    }
}
```

![[Notion/Information Technology/C/it.programming.c/Software Researching/GDI+/GDI Point 위치/attachments/Untitled.png|Untitled.png](00.%20attachments/Untitled.png)

```C#
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GDI_POINT
{
    class Program : Form
    {
        private float x, y, x_, y_;

        private Timer    tm;
        private Graphics g;
        private float    angle;

        private float width = 200;
        Color         color = Color.Red;

        static void Main(string[] args)
        {
            Application.Run(new Program());
        }

        public Program()
        {
            this.Size = new Size(500, 500);
            g = this.CreateGraphics();

            this.x = ClientRectangle.Width / 2;
            this.y = ClientRectangle.Height / 2;

            tm = new Timer();
            tm.Interval = 1;
            tm.Enabled = true;
            tm.Tick += new EventHandler(tm_Tick);

            this.Load += new EventHandler(Program_Load);
        }

        public void tm_Tick(object sender, EventArgs e)
        {
            if (angle == 360)
            {
                angle = 0;

                Random rand = new Random(DateTime.Now.Millisecond);
                switch (rand.Next(0, 3))
                {
                    case 0: color = Color.Red; break;
                    case 1: color = Color.Blue; break;
                    case 2: color = Color.Green; break;
                }
            }

            angle++;

            float radian = (float) (Math.PI / 180) * angle;
            this.x_ = x + (width * (float)Math.Sin(radian));
            this.y_ = y - (width * (float) Math.Cos(radian));

            g.DrawLine(new Pen(color), x, y, x_, y_);

        }

        public void Program_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }
    }
}
```