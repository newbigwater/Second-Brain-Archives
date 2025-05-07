- Index
    
    01. Console 출력
    
    01) Project 생성
    
    02) Code & Exe
    
    (01) Code
    
    (02) Exe
    
    (03) Mission 01
    
    (04) Mission 02
    
    02. Form 출력
    
    01) Form Reference를 참조(Include)한다.
    
    02) Winform 화면 작성
    
    03) Class와 Object, Instance…
    
    (01) 용어 설명
    
    (02) 들여다 보기
    
    04) 텍스트 출력하기
    
    (01) Code 작성
    
    05) 이미지 출력하기
    
    (01) 출력하고자 하는 이미지를 다운로드하여 실행 폴더에 넣습니다.
    
    (02) Code 작성
    
    06) Mission 03
    
    Mission Complete
    
    Mission 01.
    
    Mission 03.
    

---

# 01. Console 출력

## 01) Project 생성

- Project Name : Lesson03

![Untitled.png](00.%20attachments/Untitled.png)

- 프로젝트 생성 후 .csproj 파일 수정
    - 수정 방법은 Lesson02를 참고 하세요.

```JavaScript
<OutputPath>..\build\$(Platform)$(Configuration)\</OutputPath>
<IntermediateOutputPath>..\output\$(Platform)$(Configuration)\$(AssemblyName)</IntermediateOutputPath>
```

- 새로 생성된 프로젝트를 솔루션의 시작 프로젝트로 설정

![Untitled 1.png](00.%20attachments/Untitled%201.png)

## 02) Code & Exe

### (01) Code

```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03 //Lesson03 Project Basic Namespace
{
    class Program
    {
        static void Main(string[] args) // Main() Method의 시작 부분
        {/* Main() Method Scope 시작
            Main() Method Block */

            // 화면에 문자를 출력한다.
            System.Console.WriteLine("[Case 01]");
            System.Console.Write("Hello ~ ");
            System.Console.Write("C# World!");

            System.Console.WriteLine("[Case 02]");
            System.Console.Write("Hello ~ ");
            System.Console.WriteLine("C# World!");

        }// Main() Method Scpe 종료
    }
}
```

### (02) Exe

![Untitled 2.png](00.%20attachments/Untitled%202.png)

### (03) Mission 01

- 출력 결과를 아래와 같이 출력하세요.
    
    ![Untitled 3.png](00.%20attachments/Untitled%203.png)
    

### (04) Mission 02

- Escape sequence
    
    - ￦* 처럼 코드의 안에서 특수한 문자를 사용하는 경우가 있습니다.  
        C#에서 ￦ 기호를 나타내고 싶을 때는 또 하나의 ￦ 기호를 붙여서 ￦￦로 나타내야 합니다.  
        
    - 특수한 문자는 ￦ + 문자를 좋바해 1개의 문자를 나타냅니다.  
        이것을 Escape sequence라고 합니다.  
        
    - 아래 Escape sequence 코드화 하여 사용해 보세요.
    
    |   |   |
    |---|---|
    |Escape sequence|Mean|
    |\a|경고음|
    |\b|백 스페이스|
    |\t|수평 탭|
    |\v|수직 탭|
    |\n|줄바꿈|
    |\f|폼피드|
    |\r|복귀|
    |\’|‘|
    |\”|“|
    |\\|\|
    |\0|null|
    

---

# 02. Form 출력

## 01) Form Reference를 참조(Include)한다.

- WinForm을 띄우기 위해서는 「System」과 「System.Windows.Forms」 Reference가 필요하며 해당 Reference를 개발 환경의 프로젝트에 추가해야 한다.
    - 아래 Lesson03 Console Project의 개발 환경을 보면 「System」은 추가되어 있으니,  
        「System.Windows.Forms」만 추가하자.  
        

![Untitled 4.png](00.%20attachments/Untitled%204.png)

![Untitled 5.png](00.%20attachments/Untitled%205.png)

![Untitled 6.png](00.%20attachments/Untitled%206.png)

![Untitled 7.png](00.%20attachments/Untitled%207.png)

## 02) Winform 화면 작성

```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // System.Windows.Forms.Form 객체를 생성하기 위한 namespace 사용하겠다고 알림

namespace Lesson03 //Lesson03 Project Basic Namespace
{
    class Program
    {
        static void Main(string[] args) // Main() Method의 시작 부분
        {// Main() Method Scope 시작

            // 화면에 문자를 출력한다.
            System.Console.WriteLine("[Case 01]");
            System.Console.Write("Hello ~ ");
            System.Console.Write("C# World!");
            System.Console.WriteLine();

            System.Console.WriteLine("[Case 02]");
            System.Console.Write("Hello ~ ");
            System.Console.WriteLine("C# World!");

            // WinformMain() Method 호출, Caller, 호출자
            WinformMain();

        }// Main() Method Scpe 종료

        // WinformMain() Method, Callee, 호출 당하는 자
        static void WinformMain()
        {
            // form을 생성한다.
            Form form = new Form();

            // form의 Form Title을 설정한다.
            form.Text = "Hello~ C# World!";

            // form 실행
            Application.Run(form);
        }
    }
}
```

- 실행 화면

![Untitled 8.png](00.%20attachments/Untitled%208.png)

## 03) Class와 Object, Instance…

### (01) 용어 설명

- Class : Object를 정의하고 만들어 내기 위한 설계도 혹은 틀을 말한다.
- Object : Class에 선언된 모양 그대로 생성된 실체를 말한다.  
    ‘Class의 Instance’라고 한다.  
    
- Instance : Class를 통해서 구현해야할 Object가 실제로 구현된 구체적인 실체를 말한다.

> [!important]  
> 붕어빵 장사꾼이 붕어빵 제작 기구를 통해 슈크림 붕어빵, 단팥 붕어빵을 만들 때.붕어빵을 만드는 기구를 우리는 Class라고하고, 기구를 통해 만들어지는 붕어빵을 Object,각 각 만들어낸 슈크림 붕어빵과 단팥 붕어빵을 Instance라고 한다.  

### (02) 들여다 보기

```C#
// Form Class 를 사용하여 form 이라는 Form 객체 정의한다.
Form form = null;

// 정의된 form 객체를 Instance 화 한다.
// 또는 Form Class 객체를 생성한다.
form = new Form();

// 생성된 form instance 의 Form Title 을 설정한다.
form.Text = "Hello~ C# World!";

// 생성된 form 객체를 지정하여 실행한다.
Application.Run(form);
```

## 04) 텍스트 출력하기

> 생성된 폼에 Label Control를 추가하여 텍스트를 출력해보자.

### (01) Code 작성

- Color Structure를 사용하기 위해서는 「System.Drawing」 Reference를 참조 추가 한다.

```C#
using System.Drawing;

static void WinformMain()
{
    Form form = new Form();

    form.Text = "Hello~ C# World!";

    Label lb = new Label();
    lb.Width = 150;
    lb.Text = "C# Label Control";
    lb.ForeColor = Color.SeaGreen;

		// label Control을 Form 객체를 참조하도록 Parent Property에 Form 객체을 연동한다.
    lb.Parent = form;

    Application.Run(form);
}
```

- 출력 화면
    
    ![Untitled 9.png](00.%20attachments/Untitled%209.png)
    

## 05) 이미지 출력하기

> 생성된 폼에 Picturebox Control를 추가하여 이미지를 띄어보자.

### (01) 출력하고자 하는 이미지를 다운로드하여 실행 폴더에 넣습니다.

> 01.01) 항목을 확인하면 출력 경로를 확인 할 수 있습니다.

### (02) Code 작성

- Picturebox는 System.Drawing namespace에 존재 함으로 해당 네임스페이스를 추가합니다.

```C#
using System.Drawing;
static void WinformMain()
{
    Form form = new Form();

    form.Text = "Hello~ C# World!";

    PictureBox pic = new PictureBox();
    pic.Load("D:\\workspace\\Painting C#\\Lesson\\build\\AnyCPUDebug\\img.png");
		pic.SizeMode = PictureBoxSizeMode.AutoSize;
    pic.Parent = form;

    Application.Run(form);
}
```

- 출력 화면
    
    ![Untitled 10.png](00.%20attachments/Untitled%2010.png)
    

## 06) Mission 03

- Label Control과 Picturebox Control를 합쳐보자.
    - Parent 속성 활용을 하면 된다.

![Untitled 11.png](00.%20attachments/Untitled%2011.png)

---

# Mission Complete

## Mission 01.

- Description
    - 아래와 같이 해당 문제를 해결하기 위한 방안은 여러 방식이 있다.
        - Code 작성은 어떤 것이 맞고 틀리고는 없으며, 다만 Best practice(모범 사례)가 있을 뿐이다.

```C#
// case 01
System.Console.WriteLine("[Case 01]");
System.Console.Write("Hello ~ ");
System.Console.Write("C# World!");
System.Console.WriteLine();

System.Console.WriteLine("[Case 02]");
System.Console.Write("Hello ~ ");
System.Console.WriteLine("C# World!");

// Case 02
System.Console.WriteLine("[Case 01]");
System.Console.Write("Hello ~ ");
System.Console.Write("C# World!\n");

System.Console.WriteLine("[Case 02]");
System.Console.Write("Hello ~ ");
System.Console.WriteLine("C# World!");
```

## Mission 03.

- Description
    - Label Control 객체의 Parent 속성을

```C#
PictureBox pic = new PictureBox();
pic.Load("D:\\workspace\\Painting C#\\Lesson\\build\\AnyCPUDebug\\img.png");
pic.SizeMode = PictureBoxSizeMode.AutoSize;
pic.Parent = form;

Label lb = new Label();
lb.Width = 150;
lb.Text = "C# Label Control";
lb.ForeColor = Color.CornflowerBlue;
lb.BackColor = Color.Transparent;
lb.Parent = pic;
```

> [!important]  
> 그럼 Label Control의 Parent Property 내부는 어떻게 구성되었을까?  

- 아래 코드는 「[System.Windows](http://System.Windows).Forms」 namespace 안의 Control class의 ‘Parent’ Property의 code이다.
    
    - Parent Property에 Form 객체를 대입하면, 해당 Property는 내부적으로 ParentInternal Property에 넘겨 받은 Form 객체를 대입한다.
    - ParentInternal Property는 넘겨받은 Form 객체의 조건을 확인 한 후, 조건 만족 시  
        Form 객체의 Controls Property을 받아와 해당 집합 객체에 본인 객체(Label Control)을 추가 함으로써 계층구조를 완성한다.  
        
    
    ![Untitled 12.png](00.%20attachments/Untitled%2012.png)