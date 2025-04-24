- Index
    
    01. Main
    
    01) Source Code
    
    02) Description
    
    02. .Net Framework
    
    01) Common Language Runtime; CLR (공용 언어 런타임)
    
    (01) CLR 이란?
    
    (02) 특징
    
    (03) 역할
    
    02) Base Class Library; BCL (기본 클래스 라이브러리)
    
    03) Common Type System; CTS (공용 형식 시스템)
    
    04) Common Language Specification; CLS (공용 언어 사양)
    
    02. Build 과정
    

---

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 02. .Net Framework이란/attachments/Untitled.png|Untitled.png](00.%20attachments/Untitled.png)

# 01. Main

## 01) Source Code

```C#
using System;
using static System.Console;

namespace Lesson01.Console
{
	class Program
	{
		// 프로그램의 진입점(Entry Point)
		// [한정자;Modifier][반환 형식][함수명][매개 변수]
		static void Main(string[] args)
		{
			if(args.Length == 0)
			{
				Console.WriteLine("사용법 : HelloWorld(.exe) <이름>");
				return;
			}

			WriteLine("Hello, {0}!", args[0]);
		}
	}
}
```

## 02) Description

- using System;
    - 컴파일러에게 ‘System’ name space안에 있는 클래스를 사용하겠다고 알림
    - using : C# Keyword
    - System : C# 코드가 기본적으로 필요로하는 클래스들을 담고 있는 Name Space
    - ; : 컴파일러에게 문장의 끝을 알리는 기호
- using static System.Console;
    - 출력의 대표적인 Write(), WriteLine(), Read(), ReadLine() 정적 메소드를 포함한 Class
    - using static
        - 어떤 데이터 형식(Ex-Class)의 정적 멤버를 데이터 형식의 이름을 명시하지 않고 참조하겠다고 선언하는 기능
- namespace Lesson01.Console { … }
    - namespace
        - 특성이나 하는 일이 비슷한 클래스, 구조체, 인터페이스, 대리자, 열거 형식 등을 하나의 이름 아래 묶는 일을 한다.
        - .NET Framework Library에 수 많은 클래스가 있어도 혼동을 느끼지 않고 사용할 수 있는 비결은 이렇게 각 용도/분야별로 정리되어 있는 네임스페이스로 인해서다.

---

# 02. .Net Framework

> [!info] .NET 용어  
> .  
> [https://learn.microsoft.com/ko-kr/dotnet/standard/glossary](https://learn.microsoft.com/ko-kr/dotnet/standard/glossary)  

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 02. .Net Framework이란/attachments/Untitled 1.png|Untitled 1.png](00.%20attachments/Untitled%201.png)

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 02. .Net Framework이란/attachments/Untitled 2.png|Untitled 2.png](00.%20attachments/Untitled%202.png)

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 02. .Net Framework이란/attachments/Untitled 3.png|Untitled 3.png](00.%20attachments/Untitled%203.png)

## 01) Common Language Runtime; CLR (공용 언어 런타임)

### (01) CLR 이란?

- native code(C/C++)로 작성되어 있는 프로그램들은 운영체제가 직접 실행할 수 있지만, C# 컴파일러가 만들어낸 실행 파일은 H/W가 이해할 수 없는 코드로 구성되어 있기 때문에 실행 할 수 없다.
    - native code는 OS에 의해 컴퓨터 기계어로 동작하는 코드로 직접 컴파일되는 코드를 의미하며, 다른 이름으로는 unmanaged code라고도 한다.
    - managed code는 native code와 반대로 인터프리터를 통해 실행되는 코드를 의미하며, 인터프리터로는 Java의 VM과 C#의 CLR이 있다.

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 02. .Net Framework이란/attachments/Untitled 4.png|Untitled 4.png](00.%20attachments/Untitled%204.png)

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 02. .Net Framework이란/attachments/Untitled 5.png|Untitled 5.png](00.%20attachments/Untitled%205.png)

  

### (02) 특징

- C#으로 생성된 프로그램의 실행 환경
- 중간 언어(Intermediate Language; IL)를 통한 다중 언어 지원

### (03) 역할

- 다중 언어 Platform 최적화 코드 생성
- 프로그램의 예외(오류) 발생 시 처리를 도와주는 기능
- 언어간의 상속 지원
- COM과의 상호 운영성 지원
- 자동 메모리 관리 (Garvage Collection; GC)
- App Domain(Logical Process)를 OS가 인식할 수 실제 바이너리 파일(*.exe, Physical Process)로 변환시켜준다.

## 02) Base Class Library; BCL (기본 클래스 라이브러리)

- 기본 클래스 라이브러리는 공통 중간 언어(CIL)를 포함한 모든 닷넷 프레임워크의 언어에서 사용가능한 표준 라이브러리다.
- MS가 발표한 공통 언어 규격을 따르며 Interface, class, 각 언어의 Run-time등을 제공한다.

## 03) Common Type System; CTS (공용 형식 시스템)

- '모든 데이터 형식과 런타임에 지원되는 프로그래밍 구조가 완전히 기술되어, 서로 어떠한 방식으로 상호작용하고 메타데이터에는 어떻게 나타나있는지 정의되어 있는 것’
- 간단히 각 언어마다 사용하는 키워드는 다르지만 mscor-lib.dll에서는 동일한 형식으로 받아들인다는 것입니다.
    - 예를 들면 C#에서 사용하는 int형의 경우 Visual Basic .NET은 Integer, C++에서는 int 또는 long으로 선언하지만 .NET에서는 System.Int32로 해석한다는 뜻입니다.

## 04) Common Language Specification; CLS (공용 언어 사양)

- '프로그램 언어가 호응할 수 있는 구조와 공용 형식들을 정의한 일련의 규약’
    - 외부로 노출되는 부분은 서로 공통된 형식을 사용해야 한다는 것

---

## 02. Build 과정

> (Editor) - C# Source code → (C# Compiler) - IL → (JIT Compiler) - Native code  
> → (OS) - Run  

- Build
    - 작성된 코드를 컴파일하고 링킹하는 과정
- Compile
    
    - Source Code를 기계어로 번역하는 작업
    - 컴파일을 시행하면 기계어로 번역된 파일이 새롭게 작성되며, 해당 파일을 오브젝트 파일(.obj)이라고 한다.
    
    ![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 02. .Net Framework이란/attachments/Untitled 6.png|Untitled 6.png](00.%20attachments/Untitled%206.png)
    
- Link
    - 여러 개의 오브젝트 파일을 연결하여 하나의 프로그램을 작성하는 작업

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 02. .Net Framework이란/attachments/Untitled 7.png|Untitled 7.png](00.%20attachments/Untitled%207.png)

- Code → CLI → CIL → CLR
    
    ![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 02. .Net Framework이란/attachments/Untitled 8.png|Untitled 8.png](00.%20attachments/Untitled%208.png)
    

- C# Compiler
    - Source Code → IL 생성
- Just In Time; JIT
    - 사용자가 IL(C#.Exe or C#.ClassLibrary(DLL))을 실행시키면 CLR이 IL Code를 읽어 들여 다시 H/W가 이해할 수 있는 native code로 컴파일 한 후 실행시키는데 이것을 JIT Compile이라고 한다.
    - JIT Compile
        - 실행에 필요한 코드를 실행할 때마다 실시간으로 컴파일해서 실행한다는 뜻이다.

> [!important]  
> 왜 두 번씩 컴파일하는 복잡한 과정을 거칠까?  

- C#이 동작하는 환경이자 엔진인 CLR은 C#뿐만 아니라 다른 언어도 지원하도록 설계됨
- 서로 다른 언어들이 만나기 위한 지점이 바로 IL이라는 중간 언어이고, 이 언어로 쓰여진 코드를 CLR이 다시 자신이 설치되어 있는 플랫폼에 최적화 시켜 컴파일한 후 실행하는 것이다.
- 장점
    - 플랫폼에 최적화된 코드를 생성하며, Linux or Windows와 같은 Platform에 독립적이다.
- 단점
    - 복잡한 과정을 통한 실행이 진행되기 때문에 컴파일 비용의 부담이 발생한다.

---