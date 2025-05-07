- Book Mark
    
    > [!info] [C#] GDI의 Graphic 객체 사용법과 더블 버퍼링 구현하는 방법  
    > 안녕하세요.  
    > [https://nowonbun.tistory.com/116](https://nowonbun.tistory.com/116)  
    

- Graphic Object
    - Form 함수인 This.CreateGraphics()
    - OnPaint에서 이벤트로 받는 방법
- OnPaint 방식
    - OnPaint에서 이벤트로 e.Graphics로 객체를 받은 후 처리
    - OnPaint에서 이벤트로 받은 Graphics 객체의 HashCode는 함수 호출 시 마다 다르다.
        - 즉, 상위에서 OnPaint 호출시 마다 CreateGraphics로 새로 생성하는 듯하다.

![Untitled.png](00.%20attachments/Untitled.png)

```C#
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GDI_POINT
{
    // 전광판 클래스
    class Billboard
    {
        // 폼에 그릴 위치와 크기 설정값
        private readonly Rectangle paintLocation;
        // 전광판에 나타낼 문구 설정
        private readonly string context;
        // 폰트 설정
        private readonly Font font = new Font(new FontFamily("Arial"), 15);
        // 타이핑 효과를 내기 위한 인덱스
        private int index = 1;
        // 생성자
        public Billboard(int index, string context)
        {
            // 초기 전광판 위치 설정
            this.paintLocation = new Rectangle(new Point(10, 10 + (index * 40)), new Size(250, 30));
            // 문구 설정
            this.context = context;
        }
        // 그리기
        public void Draw(Graphics g)
        {
            // 배경 클리어
            g.FillRectangle(Brushes.White, paintLocation);
            // 문구 그리기
            g.DrawString(context.Substring(0, index), font, Brushes.Black, paintLocation.Location);
            // 타이핑 효과 인덱스 조정
            index++;
            if (index >= context.Length)
            {
                index = 1;
            }
        }
    }
    // Form 클래스를 상속받는다.
    public class Program : Form
    {
        // 그래픽 객체 설정
        private readonly Graphics graphics;
        // 전광판 클래스
        private readonly Billboard bilboard1;
        private readonly Billboard bilboard2;
        // 생성자
        public Program()
        {
            // OnPaint 이벤트에 넣을 전광판
            bilboard1 = new Billboard(0, "This is OnPaint!!");
            // OnLoad 이벤트에 넣을 전광판
            bilboard2 = new Billboard(1, "This is Tick in OnLoad!!");
            // Graphic 객체 생성
            graphics = this.CreateGraphics();
            // 주소 값 확인하기
            Console.WriteLine("constructor - " + graphics.GetHashCode());
        }
        // OnLoad 이벤트
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // 타이머 생성
            var timer = new Timer();
            // 인터벌 0.1초
            timer.Interval = 100;
            timer.Tick += (_, __) =>
            {
                // 전광판 그리기 (생성자에서 생성한 Graphic 객체
                //bilboard2.Draw(graphics);
                // OnPaint를 호출하기
                this.Invalidate();
            };
            timer.Start();
        }
        // OnPaint 이벤트
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // 이벤트 파리미터에 Graphic이 있다.
            var g = e.Graphics;
            // 주소 값 확인하기
            Console.WriteLine("OnPaint - " + g.GetHashCode());
            // 전광판 그리기
            bilboard1.Draw(g);
        }
        // 싱글 스레드 어트리뷰트
        [STAThread]
        // 실행 함수
        static void Main(string[] args)
        {
            // 환경에 맞는 스타일 설정
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // 메시지 루프에 인스턴스를 생성한다.
            Application.Run(new Program());
        }
    }
}
```

- Form의 함수인 CreateGraphics()를 통해 받은 Graphics 객체
    - this.CreateGraphics()를 호출해서 Graphics 객체를 받은 후에 OnLoad 이벤트에 Tick을 만들어서 0.1 단위로 다시 그리는 액션을 만듬

![Untitled 1.png](00.%20attachments/Untitled%201.png)

```C#
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GDI_POINT
{
    // 전광판 클래스
    class Billboard
    {
        // 폼에 그릴 위치와 크기 설정값
        private readonly Rectangle paintLocation;
        // 전광판에 나타낼 문구 설정
        private readonly string context;
        // 폰트 설정
        private readonly Font font = new Font(new FontFamily("Arial"), 15);
        // 타이핑 효과를 내기 위한 인덱스
        private int index = 1;
        // 생성자
        public Billboard(int index, string context)
        {
            // 초기 전광판 위치 설정
            this.paintLocation = new Rectangle(new Point(10, 10 + (index * 40)), new Size(250, 30));
            // 문구 설정
            this.context = context;
        }
        // 그리기
        public void Draw(Graphics g)
        {
            // 배경 클리어
            g.FillRectangle(Brushes.White, paintLocation);
            // 문구 그리기
            g.DrawString(context.Substring(0, index), font, Brushes.Black, paintLocation.Location);
            // 타이핑 효과 인덱스 조정
            index++;
            if (index >= context.Length)
            {
                index = 1;
            }
        }
    }
    // Form 클래스를 상속받는다.
    public class Program : Form
    {
        // 그래픽 객체 설정
        private readonly Graphics graphics;
        // 전광판 클래스
        private readonly Billboard bilboard1;
        private readonly Billboard bilboard2;
        // 생성자
        public Program()
        {
            // OnPaint 이벤트에 넣을 전광판
            bilboard1 = new Billboard(0, "This is OnPaint!!");
            // OnLoad 이벤트에 넣을 전광판
            bilboard2 = new Billboard(1, "This is Tick in OnLoad!!");
            // Graphic 객체 생성
            graphics = this.CreateGraphics();
            // 주소 값 확인하기
            Console.WriteLine("constructor - " + graphics.GetHashCode());
        }
        // OnLoad 이벤트
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // 타이머 생성
            var timer = new Timer();
            // 인터벌 0.1초
            timer.Interval = 100;
            timer.Tick += (_, __) =>
            {
                // 전광판 그리기 (생성자에서 생성한 Graphic 객체
                bilboard2.Draw(graphics);
                // OnPaint를 호출하기
                //this.Invalidate();
            };
            timer.Start();
        }
        // OnPaint 이벤트
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // 이벤트 파리미터에 Graphic이 있다.
            var g = e.Graphics;
            // 주소 값 확인하기
            Console.WriteLine("OnPaint - " + g.GetHashCode());
            // 전광판 그리기
            bilboard1.Draw(g);
        }
        // 싱글 스레드 어트리뷰트
        [STAThread]
        // 실행 함수
        static void Main(string[] args)
        {
            // 환경에 맞는 스타일 설정
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // 메시지 루프에 인스턴스를 생성한다.
            Application.Run(new Program());
        }
    }
}
```

- 둘다 적용시 2번째 전광판이 보이지 않는다.

# 더블 버퍼링

여러가지 이미지를 합칠 때 각각에 객체에서 CreateGraphics를 호출해서 Form에 그리는 것이 아니고 Mameory DC, 즉 메모리 상의 Bitmap에 표현할 이미지를 모두 그리고 한 번에 화면에 그려내는 것이다.

위 소스를 보면 Onpaint를 호출하면 전광판 두 번째 이미지가 안 보이는 것을 확인할 수 있다.  
즉, 실제로 작업을 할 때에 어디서든 Graphics 객체를 가져올 수 있지만, 이벤트 메시지로 OnPaint가 호출이 되면 일부가 안보이거나 이상하게 보일 가능성이 큽니다.  

그것을 해결하기 위해서는 하나의 Image를 메모리에 만들어서 DC에 맞게 그려낸 다음에 한번에 OnPaint에서 그려내야 이미지가 짤리거나 깜빡이는 문제를 해결할 수 있다.