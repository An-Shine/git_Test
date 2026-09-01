using UnityEngine;

public class Operator : MonoBehaviour
{
    void Start()
    {
        // 산술 연산자 : 사칙연산을 수행하는 연산자 
        // + - * / %
        int number1 = 200;
        int number2 = 300;
        int result = number1 + number2;

        Debug.Log(result);
        Debug.Log(message: 200 + 300);      // 리터럴, 임시값, R-Value 라고도함, 200, 300은 값이지만 변수에 할당되지 않은 값임
        
        // 대입 연산자 : 값을 대입(할당) 하는 연산자 : =
        string myName = "박보검";
        
        // 증감 연산자 : 값이 1씩 증가, 또는 감소할때 쓰는 연산자
        int age = 27;
        age++;  // 후위증감연산자 //age = age +1; 과 같음 

        int age2 = 27;
        ++age;  // 전위증감연산자
        
        // 비교연산자 = 양쪽값을 비교하여 결과값을 true/false 인지 판명해주는 연산자
        // == , != , > , >= , < , <= 등등
        int student1Age = 20;
        int student2Age = 27;

        Debug.Log(message: student1Age == student2Age);
        
        // 논리 연산자 = 비교 연산자가 동시에 두개이상 사용할때 쓰는 연산자
        // 비교 연산의 결과는 true / false
        
        // (AND)    : &&    // 두 조건이 모두 참일때 만 참
        // (OR)     : ||    // 두 조건중 하나만 참이어도 참
        // (NOT)    : !     // 참은 거짓으로, 거짓은 참으로
        
        // 삼항 연산자 : 조건식을 사용해서 조건식이 참/거짓이냐에 따라 다른 값을 대입
        int health = 100;
        int damage = 50;
        
        // 변수 = 조건식 ? 참이면 대입할 값 : 거짓이면 대입할 값
        bool isDie = health - damage > 0 ? false : true;
        Debug.Log(isDie);



    }   
}
