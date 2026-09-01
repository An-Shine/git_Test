using UnityEngine;

public class StringMethodExample : MonoBehaviour
{
    void Start()
    {   
        // 길이 속성
        string name = "황금독수리 세상을 놀라게 하다";
        Debug.Log(name.Length);
        
        // 탐색 기능 : 문자열 안에서 특정 문자열이 있는지, 있다면 어디있는지 등등을 알 수 있다
        int index = name.IndexOf("놀");
        Debug.Log(index);
        bool isHwang = name.StartsWith("황");
        Debug.Log(isHwang);
        bool isContainEagle = name.Contains("독수리");
        Debug.Log(isContainEagle);
        
        // 변형 기능 : 대소문자 변환, 혹은 추가, 대체, 삭제 등등
        name = name.Insert(6, "온");
        Debug.Log(name);

        name = name.Trim();  // 공백 제거
        Debug.Log(name);

        name = name.Remove(name.IndexOf('.'));
        name = name.Replace(".", "");
        name = name.Replace("새", "세");
        
        string name2 = "Karina";
        name2 = name2.ToUpper();
        Debug.Log(name2);
        name2 = name2.ToLower();
        Debug.Log(name2);
    }
}
