using UnityEngine;

public class IfExample : MonoBehaviour
{
    void Start()
    {
        uint number = 7;
        if (number % 2 == 0)
        {
            Debug.Log("짝수!");
        }
        else if (number == 0)
        {
            Debug.Log("0입니다");
        }
        else
        {
            Debug.Log("홀수!");
        }

        string userInputId = "admin";
        string userInputPassword = "4321";

        const string AdminId = "admin";
        const string AdminPassword = "4321";

        if (userInputId == "admin")
        {
            if (userInputPassword == "4321")
            {
                Debug.Log("로그인 성공");
            }
            else
            {
                Debug.Log("비밀번호가 틀렸습니다");
            }    
        }
        else
        {
            Debug.Log("존재하지 않는 ID 입니다");
        }
    }

    
}
