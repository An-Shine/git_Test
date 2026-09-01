using UnityEngine;
using UnityEngine.Rendering;

public class AnimalWorldExample : MonoBehaviour
{   
    
    // 다형성(폴리모피즘)
    // 하나의 객체가 여러 타입(자료형)을 가질 수 있는 성질

    private void Start()
    {
        Person person1 = new Person("손정휘", 26, 179f, 50, false);
        Cat cat1 = new Cat("삠삐", 5, 30, 20);

        Person person2 = new Person("황유찬", 21, 179f, 45, false);
        Dog dog1 = new Dog("삠삐", 5, 30, 20);

        Person person3 = new Person("하지호", 28, 170f, 40, false);
        Dog dog2 = new Dog("덕자", 5, 50, 10);

        Animal person4 = new Person("민범기", 26, 178f, 64, false);
        GoldFish goldfish1 = new GoldFish("금", "빨간색");
        GoldFish goldfish2 = new GoldFish("붕", "주황색");
        
        

        person1.Introduce();
        cat1.Introduce();

        person2.Introduce();
        dog1.Introduce();

        person3.Introduce();
        dog2.Introduce();

        // 자료형[] 변수명 = new 자료형[크기] {}
        // 클래스도 자료형이고 참조 타입이며 사용자정의 자료형이라고도 한다
        Animal[] animals = new Animal[] { person1, cat1, person2, dog1, person3, dog2, person4, goldfish1, goldfish2 };

        //동물들을 반복문을 통해 순회하면서 Introduce 호출 가능
        for (int i = 0; i < animals.Length; i++)
        {
            animals[i].Introduce();
            
            // 동물이 사람타입일 경우 자기소개 후 땅바닥에 앉는다

            if (animals[i] is Person) // is 연산자는 객체가 실제로 해당 타입인지 검사 후 그 결과를 bool 로 반환
            {
                // 1. 명시적 형변환
                Person person = (Person)animals[i];
                person.SeatDown();

                // 2. as 형변환 : 형변환을 시도해서 성공하면 성공,실패하면 null 반환
                Person pperson = animals[i] as Person;
                if (pperson != null)    // null 인지 아닌지로 사람인지 아닌지로 판단 가능
                {
                   pperson.SeatDown();        
                }

            
            }
        }

}

}
