---
소유자: ContBigExcel
태그:
  - DE
최종 편집 일시: Invalid date
---

[..](../MySql.md)

- Index
    
    01. Install
    
    01) MySQL Community Server
    
    (01) Downlaod
    
    (02) Install
    
    (03) Verification
    
    02. MySQL Workbench 사용법
    

---

# 01. Install

> [!info] MySQL :: MySQL Community Downloads  
>  
> [https://dev.mysql.com/downloads/](https://dev.mysql.com/downloads/)  

## 01) MySQL Community Server

### (01) Downlaod

> [!info]  
>  
> [https://dev.mysql.com/downloads/mysql/](https://dev.mysql.com/downloads/mysql/)  

- Step 01. Download Spec
    - Select Version : 8.0.35
    - Select Operating System : Windows
- Step 02. Go to Download Page 이동
    
    ![Untitled.png](attachments/Untitled.png)
    
- Step 03. Version & System 확인 후 MSI Installer Download
    
    - 자연스럽게 mysql-installer-community-8.0.35.0.msi download
        
        (위에 항목은 On-line Installer 같다…)
        
    
    ![Untitled 1.png](attachments/Untitled%201.png)
    
    - ==Download 클릭 시 로그인 필요 화면이 뜨지만 아래 텍스트 버튼으로 PASS!==
        
        ![Untitled 2.png](attachments/Untitled%202.png)
        

### (02) Install

- Install Img
    
    ![Untitled 3.png](attachments/Untitled%203.png)
    
    ![Untitled 4.png](attachments/Untitled%204.png)
    
    ![Untitled 5.png](attachments/Untitled%205.png)
    
    ![Untitled 6.png](attachments/Untitled%206.png)
    
    ![Untitled 7.png](attachments/Untitled%207.png)
    
    ![Untitled 8.png](attachments/Untitled%208.png)
    
    ![Untitled 9.png](attachments/Untitled%209.png)
    
    ![Untitled 10.png](attachments/Untitled%2010.png)
    
    ![Untitled 11.png](attachments/Untitled%2011.png)
    
    ![Untitled 12.png](attachments/Untitled%2012.png)
    
    ![Untitled 13.png](attachments/Untitled%2013.png)
    
    ![Untitled 14.png](attachments/Untitled%2014.png)
    
    ![Untitled 15.png](attachments/Untitled%2015.png)
    
    ![Untitled 16.png](attachments/Untitled%2016.png)
    
    ![Untitled 17.png](attachments/Untitled%2017.png)
    
    ![Untitled 18.png](attachments/Untitled%2018.png)
    
    ![Untitled 19.png](attachments/Untitled%2019.png)
    
    ![Untitled 20.png](attachments/Untitled%2020.png)
    
    ![Untitled 21.png](attachments/Untitled%2021.png)
    
    ![Untitled 22.png](attachments/Untitled%2022.png)
    
    ![Untitled 23.png](attachments/Untitled%2023.png)
    
    ![Untitled 24.png](attachments/Untitled%2024.png)
    
    ![Untitled 25.png](attachments/Untitled%2025.png)
    

### (03) Verification

![Untitled 26.png](attachments/Untitled%2026.png)

![Untitled 27.png](attachments/Untitled%2027.png)

![Untitled 28.png](attachments/Untitled%2028.png)

---

# 02. MySQL Workbench 사용법

- Execution Button
    
    ![Untitled 29.png](attachments/Untitled%2029.png)
    
    전체 실행 or 블록 처리된 라인 실행
    
    ![Untitled 30.png](attachments/Untitled%2030.png)
    
    현재 커서 라인 실행
    
    ```SQL
    -- 주석 1 : 해당 라인 주석
    
    # 주석 1 : 해당 키워드 이후 주석
    
    /*
    주석 3 : 다중 라인 주석
    */
    ```
    
- 모든 데이터베이스 목록 보기
    
    ```SQL
    -- 모든 데이터베이스 목록 보기
    show databases;
    ```
    
    ![Untitled 31.png](attachments/Untitled%2031.png)
    
- 데이터베이스 생성 및 확인
    
    ```SQL
    -- 데이터베이스 생성 및 지정
    create database NBE_DB; #생성
    show databases;
    # 삭제 drop database NBE_DB;
    ```
    
    ![Untitled 32.png](attachments/Untitled%2032.png)
    
- 데이터베이스 지정 및 테이블 생성 & 데이터 삽입
    
    ```SQL
    -- 데이터 베이스 지정 및 테이블 생성 및 데이터 삽입
    #지정
    use NBE_DB;
    # 테이블 생성
    create table NBE_Table (
    			col1 INT,
    			col2 CHAR(2)
    );
    # 데이터 삽입
    insert into NBE_Table (col1, col2)
    value (1, 'a'), (2, 'b'), (3, 'c'), (4, 'd'), (5, 'e');
    # 확인
    select * from NBE_Table;
    ```
    
    ![Untitled 33.png](attachments/Untitled%2033.png)