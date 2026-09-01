using UnityEngine;

public class WhileExample : MonoBehaviour
{

    private void Start()
    {
        int i = 0;

        while (true)
        {
            Debug.Log("안녕하세요");

            i++;        // 증감식을 빼먹으면 반복문이 무한히 실행되는 무한루프에 빠지게됨
            if (i > 1000)
            {
                break;  // 반복문을 탈출하는 키워드
            }

        }
    }
}
