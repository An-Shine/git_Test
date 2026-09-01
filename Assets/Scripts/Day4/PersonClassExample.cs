using UnityEngine;

public class PersonClassExample : MonoBehaviour
{

    private void Start()
    {
        // 자료형 변수명 = 값
        // 클래스 클래스명 = new 클래스

        Chair chair1 = new Chair();
        // Chair chair2 = new Chair();
        chair1.Color = "푸른색";

        Person person1 = new Person("김상곤",18,182.4f, 78, false);
        
        person1.Introduce();
        person1.Run();
        person1.SeatDown(chair1);
        
        Person person2 = new Person("김예찬", 25, 178.1f, 73, true);

        person2.Introduce();
        person2.Run();
        person2.SeatDown();

        person1.Punch(person2);

        Person person3 = null;      // 메모리 주소를 가리킬 변수만 만들었지 알맹이는 존재하지 않음
        // null 이란 존재하지 않는다는 뜻
        // 객체지향 프로그램에서 제임스고슬링이 가장 후회하는 문법중 하나
        // 가장 빈번하게 오류를 일으키는 문법

        person1.Punch(person3);

    }
}
