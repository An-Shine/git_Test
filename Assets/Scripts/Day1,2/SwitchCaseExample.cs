using UnityEditor.Rendering;
using UnityEngine;

public class SwitchCaseExample : MonoBehaviour
{
    void Start()
    {
        string today = "목요일";
        switch (today)
        {
            case "월요일":
            {
                Debug.Log("오늘은 월요일입니다");
                break;
            }
            case "화요일":
            {
                Debug.Log("오늘은 화요일입니다");
                break;
            }
            case "수요일":
            {
                Debug.Log("오늘은 수요일입니다");
                break;
            }
            case "목요일":
            {
                Debug.Log("오늘은 목요일입니다");
                break;
            }
            case "금요일":
            {
                Debug.Log("오늘은 금요일입니다");
                break;
            }
            case "토요일":
            {
                Debug.Log("오늘은 토요일입니다");
                break;
            }
            case "일요일":
            {
                Debug.Log("오늘은 일요일입니다");
                break;
            }

        }

        int score = 98;
        switch (score / 10)
        {
            case 100:
            {
                Debug.Log("A+");
                break;
            }
            case 9:
            {
                Debug.Log("A");
                break;
            }
            case 8:
            {
                Debug.Log("B+");
                break;
            }
                default:
            {
                Debug.Log("C");
                break;
            }
        }




    }
}
