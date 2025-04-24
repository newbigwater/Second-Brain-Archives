- Index
    
    01. Lesson 01 Project 생성
    
    01) New Project
    
    (01) New Project 선택
    
    (02) Project 생성
    
    (03) 생성된 Solution Directory 구조
    
    02. Project Property File 수정
    

---

# 01. Lesson 01 Project 생성

## 01) New Project

### (01) New Project 선택

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 01. Project 생성 및 구성/attachments/Untitled.png|Untitled.png](00.%20attachments/Untitled.png)

### (02) Project 생성

- Console Project 생성

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 01. Project 생성 및 구성/attachments/Untitled 1.png|Untitled 1.png](00.%20attachments/Untitled%201.png)

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 01. Project 생성 및 구성/attachments/Untitled 2.png|Untitled 2.png](00.%20attachments/Untitled%202.png)

- Winform Project 생성

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 01. Project 생성 및 구성/attachments/Untitled 3.png|Untitled 3.png](00.%20attachments/Untitled%203.png)

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 01. Project 생성 및 구성/attachments/Untitled 4.png|Untitled 4.png](00.%20attachments/Untitled%204.png)

### (03) 생성된 Solution Directory 구조

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 01. Project 생성 및 구성/attachments/Untitled 5.png|Untitled 5.png](00.%20attachments/Untitled%205.png)

---

## 02. Project Property File 수정

> 현재와 같은 구성은 같은 솔루션에 묶에 프로젝트들의 산출물(Artifact!)들이 각각  
> 해당 프로젝트 폴더에 생성되는데, 이러면 산출물 관리가 힘드니 하나로 합치는  
> 작업이 필요하다.  

- *.csproj File을 Editor로 열어  
    산출물의 출력 경로인 ‘OutputPath’와  
    중간 산출물의 출력 경로인 ‘IntermediateOutputPath’를 아래와 같이 추가 및 수정하자.  
    
    ```JavaScript
    <OutputPath>..\build\$(Platform)$(Configuration)\</OutputPath>
    <IntermediateOutputPath>..\output\$(Platform)$(Configuration)\$(AssemblyName)</IntermediateOutputPath>
    ```
    
    > [!important]  
    > 여기서 잠깐!* 상대 경로 : 아래와 같이 . or .. 으로 시작하는 경로는 상대 경로라고 하며, 해당 파일이 존재하는 위치로부터 경로를 계산한다.(절대 경로 : D:\workspace\Painting C#\Lesson)* $(Platform) : 빌드되는 산출물의 플랫폼 정보이며, 보통 AnyCPU, x86, x64이 표시* $(Configuration) : 빌드되는 산출물의 구성 정보이며, Debug, Release 가 표시* $(AssemblyName) : 산출물의 이름이며, 보다 자세한 내용은 추후에 다루겠다.  
    
- 기존
    
    ![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 01. Project 생성 및 구성/attachments/Untitled 6.png|Untitled 6.png](00.%20attachments/Untitled%206.png)
    
- 신규
    
    ![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 01. Project 생성 및 구성/attachments/Untitled 7.png|Untitled 7.png](00.%20attachments/Untitled%207.png)
    
- 수정 후 Visual Stuio를 띄우면 아래오 같은 창이 뜨는데 모두 재 로드 하자

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 01. Project 생성 및 구성/attachments/Untitled 8.png|Untitled 8.png](00.%20attachments/Untitled%208.png)

- 이제 새롭게 재 빌드를 진행하면 아래 이미지와 같이 구성되며,  
    기존에 출력되던 bin, obj 폴더는 삭제하면 된다.  
    

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 01. Project 생성 및 구성/attachments/Untitled 9.png|Untitled 9.png](00.%20attachments/Untitled%209.png)