using UnityEngine;

public class Person : Animal
{
    // 필드 (속성, 멤버, 변수)변수, 클래스 내부 어디서든 접근 가능
    // public : 외부에서 접근(읽기, 쓰기) 가능
    // private : 외부에서 접근이 불가능함
    // -> 접근 지정자(제한자)
    
    // 추상화 >> 은닉화 >> 캡슐화
    int _age = 0;
    public bool HasGlasses = false;
    
    // 생성자 메서드
    // 메서드 이름과 클래스 이름이 같으면 그것을 생성자 메서드 라고한다 
    public Person(string name, int age,float height, double weight, bool hasGlasses ) // ()<<< 매개변수
    {   
        _name = name;
        _height = height;
        _weight = weight;
        int myFatherAge = 34; // 지역변수
        HasGlasses = hasGlasses;
    }

    // 메서드 (기능, 함수)
    public override void Introduce()
    {
        Debug.Log($"안녕하세요. 제 이름은 {_name}이고, 나이는 {_age} 입니다. 키와 몸무게ㅐ는 ({_height}cm/{_weight}kg 입니다.");
    }
    // 메서드 오버로드 : 같은 이름의 메서드를 여러개 만드는것
    
    public void SeatDown()
    {
        Debug.Log("땅바닥에 앉는다");
    }

    public void SeatDown(Chair chair)
    {
        Debug.Log($"{chair.Color} 의자에 앉는다!");
    }

    public void Punch(Person otherPerson)
    {   
        //public 필드 변수는 : Name (파스칼)
        //private 필드 변수는 : _name(카멜)
        //        지역 변수는 : name(카멜)
        
        string Name = "아차카라쵸!";
        // 상곤이가 윤민이를 떄렸다
        Debug.Log($"{Name}이가 {otherPerson._name}이를 때렸다!");
    }
}
