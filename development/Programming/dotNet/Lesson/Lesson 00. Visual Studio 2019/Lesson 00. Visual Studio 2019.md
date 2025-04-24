- Index
    
    01. 환경 설정
    
    01) .Net Desktop 환경 구성
    
    02) Project 생성
    
    (01) Console (CLI 환경)
    
    (02) Winform (GUI 환경)
    
    (03) 구성
    
    03) Project Directory
    
    02. Solution Build
    
    01) Rebuild Solution
    
    02) Build Solution
    
    03) Clean Solution
    
    04) Rebuild Solution vs (Clean Solution + Build Solution)
    
    03. Debugging
    
    Step 01. Break point 설정
    
    Step 02. Debugging 모드로 실행한다.
    
    Step 03. Debugging
    
    04. Blank Solution - Lesson 생성
    

---

# 01. 환경 설정

## 01) .Net Desktop 환경 구성

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 00. Visual Studio 2019/attachments/Untitled.png|Untitled.png](00.%20attachments/Untitled.png)

## 02) Project 생성

> .Net Framework 환경과 .Net Core 환경은 다르다는 것을 명심한다.

### (01) Console (CLI 환경)

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 00. Visual Studio 2019/attachments/Untitled 1.png|Untitled 1.png](00.%20attachments/Untitled%201.png)

### (02) Winform (GUI 환경)

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 00. Visual Studio 2019/attachments/Untitled 2.png|Untitled 2.png](00.%20attachments/Untitled%202.png)

### (03) 구성

- 솔루션 및 프로젝트를 같은 디렉토리에 배치 선택!

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 00. Visual Studio 2019/attachments/Untitled 3.png|Untitled 3.png](00.%20attachments/Untitled%203.png)

## 03) Project Directory

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 00. Visual Studio 2019/attachments/Untitled 4.png|Untitled 4.png](00.%20attachments/Untitled%204.png)

- 기본적으로 프로젝트를 생성하면, 이미지와 같이 디렉토리가 구성된다.
    
    - bin : 산출물이 출력되는 위치
    - obj : 중간 산출물이 출력되는 위치
        - 중간 산출물은 build되는 과정에서 생성되는 데이터 파일들이다.
    - Properties : AssemblyInfo.cs 와 같은 파일들이 존재한다.
    - *.csproj : Project 파일, 빌드 설정 정보 등을 담고 있다.
    - *.sln : 솔루션 파일, Project 파일들을 관리하는 정보 등을 담고 있다.
    
      
    

- C# 컴파일 및 실행 과정
    
    ![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 00. Visual Studio 2019/attachments/Untitled 5.png|Untitled 5.png](00.%20attachments/Untitled%205.png)
    

---

# 02. Solution Build

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 00. Visual Studio 2019/attachments/Untitled 6.png|Untitled 6.png](00.%20attachments/Untitled%206.png)

## 01) Rebuild Solution

- 현재 수정된 부분과 수정되지 않는 부분을 모두 포함하여 새롭게 Build하여 산출물을 생성한다.

## 02) Build Solution

- 현재 수정된 부분을 포함하여 Build하여 산출물을 생성한다.

## 03) Clean Solution

- Build History를 제거한다.

## 04) Rebuild Solution vs (Clean Solution + Build Solution)

- 본인에 취향에 맞는 방식으로 빌드 하자.
    - 단 절대적으로 Build Solution만 진행하지 말자.

---

# 03. Debugging

> Visual Stuio를 사용하는 가장 큰 이유!  
> 버그나 오류 사항들을 찾는 방법이다.  

## Step 01. Break point 설정

- 작성된 코드 중 문제 시작 지점에 break point를 설정 후 디버깅 모드로 실행한다.
    
    - 아래 이미지와 같이 좌측 부분을 클릭 하거나, F9를 눌러 설정한다.
        
        ![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 00. Visual Studio 2019/attachments/Untitled 7.png|Untitled 7.png](00.%20attachments/Untitled%207.png)
        
    - 설정한 Break point 목록을 확인은 아래와 같이 진행한다.
        
        ![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 00. Visual Studio 2019/attachments/Untitled 8.png|Untitled 8.png](00.%20attachments/Untitled%208.png)
        
        - 해당 메뉴를 선택하면 아래와 같이 Breakpoints 화면이 보인다.
        
        ![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 00. Visual Studio 2019/attachments/Untitled 9.png|Untitled 9.png](00.%20attachments/Untitled%209.png)
        
    
      
    

> Line 번호를 출력하고 싶으면 Tool → Option → Text Editor → C# → Line Numbers 선택!

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 00. Visual Studio 2019/attachments/Untitled 10.png|Untitled 10.png](00.%20attachments/Untitled%2010.png)

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 00. Visual Studio 2019/attachments/Untitled 11.png|Untitled 11.png](00.%20attachments/Untitled%2011.png)

---

## Step 02. Debugging 모드로 실행한다.

- Debug Menu에서 Start Debugging 모드로 실행한다.
    
    ![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 00. Visual Studio 2019/attachments/Untitled 12.png|Untitled 12.png](00.%20attachments/Untitled%2012.png)
    
    - 디버깅을 종료하고 싶을 땐 Shift + F5를 선택한다.
- Debugging Mode로 실행된 상태
    
    - 설정한 Break point에서 코드 진행이 멈춰있다.
    
    ![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 00. Visual Studio 2019/attachments/Untitled 13.png|Untitled 13.png](00.%20attachments/Untitled%2013.png)
    

---

## Step 03. Debugging

- Debugging Tool
    - Continue : 다음 Break point까지 진행한다.
    - Step over : 현재 호출 된 Scope에서 다음 실행 코드를 진행한다.
        - 만약 함수를 만나면 함수의 결과값만 반환 받는다.
    - Step Into : Step over와 비슷하지만 다른 점은 만약 함수를 만나면 내부에 접근 가능한 함수 일 경우 해당 함수 내부로 접근한다.

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 00. Visual Studio 2019/attachments/Untitled 14.png|Untitled 14.png](00.%20attachments/Untitled%2014.png)

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 00. Visual Studio 2019/attachments/Untitled 15.png|Untitled 15.png](00.%20attachments/Untitled%2015.png)

- Debugging Viewer
    
    ![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 00. Visual Studio 2019/attachments/Untitled 16.png|Untitled 16.png](00.%20attachments/Untitled%2016.png)
    
    ![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 00. Visual Studio 2019/attachments/Untitled 17.png|Untitled 17.png](00.%20attachments/Untitled%2017.png)
    
    - Call Stack : 프로세스 내 함수 호출 구조
        - 위 이미지와 같은 경우, Main 함수에서 func() 함수를 호출하여 func 함수 내부에서 Debuging 중인 함수 호출 구조가 보여 진다.
    - watch 1 : 현재 Scope 내에서 볼 수 있는 변수의 값을 보여준다.

---

# 04. Blank Solution - Lesson 생성

- Create a new project
    
    ![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 00. Visual Studio 2019/attachments/Untitled 18.png|Untitled 18.png](00.%20attachments/Untitled%2018.png)
    
- Blank solution
    
    ![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 00. Visual Studio 2019/attachments/Untitled 19.png|Untitled 19.png](00.%20attachments/Untitled%2019.png)
    
- Configuration

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 00. Visual Studio 2019/attachments/Untitled 20.png|Untitled 20.png](00.%20attachments/Untitled%2020.png)

- 생성된 빈 솔루션 및 디렉토리

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 00. Visual Studio 2019/attachments/Untitled 21.png|Untitled 21.png](00.%20attachments/Untitled%2021.png)

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 00. Visual Studio 2019/attachments/Untitled 22.png|Untitled 22.png](00.%20attachments/Untitled%2022.png)