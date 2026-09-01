using UnityEngine;

enum DayOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}
enum Seasons
{
    Spring,
    Summer,
    Fall,
    Winter
}

enum KeyboardCode
{
    W,
    A,
    S,
    D
}
public class EnumExamples : MonoBehaviour
{
    void Start()
    {
        DayOfWeek today = DayOfWeek.Thursday;

        if (today == DayOfWeek.Thursday)
        {
            Debug.Log("오늘은 목요일입니다");
        }

        Debug.Log(today);
        Debug.Log((int)today);

        Seasons todaySeason = Seasons.Summer;
        {
            if (todaySeason == Seasons.Summer)
            {
                Debug.Log("여름입니다");    
            }
            
        }
        KeyboardCode currentInputKeyboardCode = KeyboardCode.A;
        if (currentInputKeyboardCode == KeyboardCode.A)
        {
            Debug.Log("A키");
        }
    }
}
