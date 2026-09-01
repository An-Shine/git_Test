using UnityEngine;

public class Array2DExample : MonoBehaviour
{
    // 주로 타일 기반 게임에서 사용됨
    private void Start()
    {
        int[,] enemyHealth = new int [2, 3];
        enemyHealth[0, 0] = 31;
        enemyHealth[0, 1] = 28;
        enemyHealth[0, 2] = 45;
        enemyHealth[1, 0] = 31;
        enemyHealth[1, 1] = 56;
        enemyHealth[1, 2] = 68;
        
        Debug.Log(enemyHealth[1,1]);

        for (int col = 0; col < enemyHealth.Length; col++)
        {
            for (int row = 0; row < enemyHealth.Length; row++)
            {
                Debug.Log($"enemyHealth[{col}][{row}]");
            }
        }
        
    }

}
