using System.Globalization;
using UnityEngine;

public class ForExample : MonoBehaviour
{
    void Start()
    {
        // 반복문 : 설정한 조건이 True일 동안 (거짓이 될때까지) 코드 블록 내부를 반복해서 실행한다
        
        // for 반복문
        // while 반복문
        /*
        for (int i = 0; i < 1000; i++)
        {
            Debug.Log($"안녕하세요. {i:4d}");
        }
        */
        
        int sum = 0;
        for (int i = 1; i <= 1000; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;    
            }
        }
        Debug.Log(sum);
        
        // for문 내부에서 선언된 변수는 외부에서 사용할 수 없다 , 다만 클래스에서 선언된 외부변수는 내부에서 사용가능
        //- 점프문 : 반복문 내부에서 흐름을 끊고 코드 실행위치를 원하는 곳으로 점프해준다
        //- break : 현재 실행중인 반복문이나 분기문의 실행을 중단할 때 사용 ( 종료/탈출 이라고 부르기도함)
        //- continue : 반복문 코드블록 내에서 현재 실행중인 코드 라인의 아래 코드들의 실행을 건너 뛸 때 사용

        for (int i = 2; i < 10; i++)
        {
            if (i == 5)
            {
                continue;
            }
            
            Debug.Log($"[{i}단 시작!]");
            
            for (int j = 1; j < 10; j++)
            {   
                Debug.Log($"{i} * {j} = {i * j:2d}");
            }
            
        }
    }

    
}
