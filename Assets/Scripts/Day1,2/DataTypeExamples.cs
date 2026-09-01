using UnityEngine;

public class DataTypeExample : MonoBehaviour
{
    void Start()
    {

        // 자료형 (변수에 직접 값이 저장되는 데이터의 종류: 데이터 타입)

        // 종류는 크게 4가지다.
        //  - 저장할 수 있는 데이터의 종류가 다르고..
        //  - 저장할 수 있는 데이터의 크기가 다르다.

        // 1. 숫자 (12가지)
        // - 정수(short, int, long)
        short jasan0 = 32767;                                                                             // 2바이트
        //int jasan1 = 12000000000;  // int가 표현할 수 있는 데이터의 범위는 -2,147,483,648 ~ 2,147,483,647                     // 4바이트
        long jasan2 = 12000000000; // long...?  -9,223,372,036,854,775,808 ~ 9,223,372,036,854,775,807    // 8바이트

        // mmorpg 게임에 데이터 종류는  50만 가지
        int id = 204023;
        long id2 = 3423894829038904830;
        //       20: 아이템의 타입이 창이다.
        //       4:  착용 가능한 직업은 전사다
        //      023: 23레벨 부터 착용 가능한 아이템


        // 실수(float, double, decimal...)
        float floaterNumber = 3.141592653589793238462643383279502884197169399f;  // float 4바이트
        double doubleNubmer = 3.141592653589793238462643383279502884197169399d;  // double 8바이트
        decimal decimalNumber = 3.141592653589793238462643383279502884197169399m;  // decimal 16qkdlxm

        Debug.Log(floaterNumber);
        Debug.Log(doubleNubmer);
        Debug.Log(decimalNumber);

        // 2. 문자(열) (2가지)
        // 문자(char), 문자열(string)
        char firstName = '안';
        string lastName = "광희";
        // 3. 논리
        // bool
        bool isdie = true;  // is, has, 3인칭 단수형 (ex : supports)
        
        // 4. Object (참조형)
        
        
        // 형변환
        // 변수에 담여깄는 데이터를 다른 데이터타입(자료형)의 변수에 옮겨담는것

        long money1 = 2345634256234;
        int money2 = (int)money1;

        int maxHealth1 = 88888;
        long maxHealth2 = 34;
        maxHealth2 = maxHealth1;  // 작은범위 > 큰범위 변환시 자동으로 자료형이 바뀜 (암시적 형변환)

        Debug.Log(money1);
        Debug.Log(money2);
        
        // 상수 : 데이터를 초기화 할때 말고는 졀대 변경할 수 없는 변수
        const int MaxHealth = 500;

        const int gameWidth = 10;
        const int gameHeight = 50;

    }
}