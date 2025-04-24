> Object Oriented Programming  
> 객체 지향 프로그래밍  

- Index
    
    01. 객체 지향 설계란?
    
    01) 개념
    
    02) POP VS OOP
    
    02. OOP의 기본 구성 요소
    
    01) Entity
    
    02) Class
    
    03) Instance vs Object
    
    03. OOP의 특성
    
    01) Abstraction; 추상화
    
    02) Encapsulation; 캡슐화
    
    03) Generalization; 상속성
    
    04) Polymorphism; 다형성
    

---

# 01. 객체 지향 설계란?

## 01) 개념

- 현실 세계의 개체(entity)를 기계의 부품처럼 하나의 객체(Object)로 만들어, 기게적인 부품들을 조립하여 제품을 만들 듯이 S/W를 개발.
- 즉, 객체 개념을 사용하여 코드에서 데이터와 동작을 나타내는 프로그램 패러다임.
- 기존 구조적 기법(절차 지향 설계) 문제점 해결하기 위해 제안됨
    - Procedure에 근간을 두고 하나의 커다란 작업을 여러 개의 작업 작업으로 분할하고, 분할된 각각의 소작업을 수행하는 모듈을 작성하는 S/W
        - Procedure : 특정한 Logic 을 처리하기만 하고 결과 값을 반환하지 않는 서브 프로그램

## 02) POP VS OOP

> POP; Procedure Oriented Programming, 절차 지향 설계

- POP
    
    ![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 04. OOP/attachments/Untitled.png|Untitled.png](00.%20attachments/Untitled.png)
    
    - 작업을 수행하기 위해 차례로 호출되는 일련의 프로시저 또는 함수로 설계됨
    - 제어하는 데이터는 보다는 기능에 치중되어 있으며, 데이터는 전역적이며 모든 기능에서 액세스하고 수정할 수 있음
        - 이 접근 방식으로 인해 코드를 가독성 및 유지 보수성이 힘들어 진다.
- OOP
    
    ![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 04. OOP/attachments/Untitled 1.png|Untitled 1.png](00.%20attachments/Untitled%201.png)
    
    - 객체에 중점을 두며, 객체는 데이터와 기능으로 구성된다.
    - 객체간 상호 작용을 통해 기능을 처리하며, 이 접근 방식은 캡슐화 추상화, 상속 및 다형성의 뼈대가 된다.

> 즉, OOP는 프로그래밍에 대한 보다 구조화되고 모듈화된 접근 방식을 제공하며, 코드의 가독성 및 이해성, 유지보수성을 높인다.  
> 그러나, POP에 비해 더 많은 사전 계획 및 디자인과 고급 프로그래밍 기술이 필요하다.  

---

# 02. OOP의 기본 구성 요소

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 04. OOP/attachments/Untitled 2.png|Untitled 2.png](00.%20attachments/Untitled%202.png)

> 하나의 모델이 되는 청사진(blueprint)를 설계하고 → Class  
> 그 청사진을 바탕으로 한 객체(object)를 생성하는 → Instance  
> 프로그래밍  

## 01) Entity

- 현실 세계의 무엇인가, 또는 개발하고자하는 제품 또는 목적성

## 02) Class

- Entity의 모델이 되는 청사진(blueprint)
- 공통의 Attribute, 메서드(Operation), Relationship, 의미를 공유하는 객체 집합에 대한 기술
- 구성 요소
    - 속성 (Attribute)
        - 클래스의 구조적 특성에 이름을 붙인 것으로 구조적 특성에 해당하는 인스턴스가 보유할 수 있는 값의 범위를 기술
    - 함수 (Method)
        - Operation이라고도 하며, 이름, 타입, 매개변수들과 연관된 행위를 호출 할 때 제약사항이 요구되는데, 이 제약 사항을 명세하는 클래스의 행위적 특징

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 04. OOP/attachments/Untitled 3.png|Untitled 3.png](00.%20attachments/Untitled%203.png)

## 03) Instance vs Object

- 인스턴스와 객체라는 용어는 종종 같은 의미로 사용되지만, 의미가 약간 다르다.
- Object
    - 데이터(특성 또는 속성) 및 메서드(함수 또는 작업)을 포함하는 클래스의 특정 인스턴스이다.
    - 클래스는 객체를 만들기 위한 청사진 또는 템플릿과 같으며 해당 클래스의 각 객체가 가질 특성과 메서드를 정의 합니다.
- Instance
    - 런타임 시 객체의 특정 발생을 나타냅니다.
    - 프로그램이 객체를 만들 때 해당 객체의 인스턴스를 만든다.
    - 각 인스턴스에는 동일한 클래스의 다른 인스턴스와 독립적으로 접근하고 수정할 수 있는 고유한 데이터 및 메서 집합이 있다.
- 차이점
    
    ```C#
    public class Car
    {
      private string 제조사;
      private string 모델
      private string 색상
      ...
    }
    
    ------------------------------------------------------
    
    // Car Class의 Object는 아래와 같이 프로그램이 객체를 인스턴스화 할 때 생성됩니다.
    //  이 경우 "myCar"는 Car 클래스의 객체이며, 자체 데이터("audi", "A9", "White")와
    // 메서드를 포함합니다.
    //  이 객체는 런타임에 생성되었기 때문에 Car 클래스의 Instance이기도 합니다.
    Car myCar = new Car("audi", "A6", "White");
    
    ------------------------------------------------------
    
    // 프로그램이 다음과 같이 다른 Car 객체를 생성하는 경우
    //  이 경우 "myCar"와는 별개의 객체가 되며 고유한 데이터 및 메서드 집합이 있다.
    // 그러나 "myCar"와 "yourCar"는 모두 동일한 Car Class의 Instance이다.
    Car yourCar = new Car("bmw", "520D", "Black");
    ```
    

---

# 03. OOP의 특성

## 01) Abstraction; 추상화

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 04. OOP/attachments/Untitled 4.png|Untitled 4.png](00.%20attachments/Untitled%204.png)

- 어떤 영역에서 필요로 하는 속성이나 기능을 추출하는 작업
- 데이터 구조, 표현방법에 대한 추상화
- 처리 과정에 대한 추상화

## 02) Encapsulation; 캡슐화

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 04. OOP/attachments/Untitled 5.png|Untitled 5.png](00.%20attachments/Untitled%205.png)

- 데이터를 감싸서 외부에서 사용 가능한 부분만을 제공 (Infomation hiding)
- 사용하는 코드(클라이언트 코드)가 세부적인 사항을 알 필요가 없음
- 단순한 접근을 제공하여 오류가 생길 부분을 감소함

## 03) Generalization; 상속성

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 04. OOP/attachments/Untitled 6.png|Untitled 6.png](00.%20attachments/Untitled%206.png)

- 일반적인(general) 개념의 객체에서 보다 구체적인(specific) 개념의 객체의 관계를 표현
- 상속관계의 클래스는 상위 클래스의 타입을 내포함
- 상위 클래스의 속성과 기능을 하위 클래스에서 사용하거나 재정의 할 수 있음

## 04) Polymorphism; 다형성

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 04. OOP/attachments/Untitled 7.png|Untitled 7.png](00.%20attachments/Untitled%207.png)

- 같은 메세지, 같은 구현에 대해 각 객체가 다른 표현과 결과를 나타내는 것
- 클래스의 상속, 인터페이스의 구현 시에 각각의 다른 구현을 가진 클래스들이 상위 타입으로 업캐스팅이 되고  
    이 때, 각 클래스에서 오버라이딩한 메서드가 존재하는 경우 같은 상위 타입으로 선언된다 하더라도 각기 다른 인스턴스의 메서드가 호출되는것  
    C++의 경우 virtual fuction만이 재정의된 함수가 호출되지만 자바의 경우는 모든 메서드가 가상함수 기반으로 구현되므로 하위 클래스에 재정의된 메서드가 있는 경우 재정의된 메서드가 호출 됨