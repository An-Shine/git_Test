using UnityEngine;
using UnityEngine.Rendering.UI;

// 상속 : 부모(상위,기반,슈퍼)클래스의 속성과 기능을 자식(하위, 파생, 서브)클래스에 물려주는것
// 장점 : 코드 재사용 (이미 만들어진 부모 클래스의 속성과 기능을 공유하므로 중복 최소화)
// 확장 : 자식 클래스만의 고유한 속성이나 기능 추가 가능
// 재정의 : 부모에게 물려받은 메서드를 상황에 맞게 재정의(오버라이딩) 가능
public class Cat : Animal
{
    public Cat(string name, int age, float height, float weight)
    {
        _name = name;
        _height = height;
        _weight = weight;
    }

    public override void Introduce()
    {
        Debug.Log($"냥냥~ 내 이름은 {_name}이다냥~");
    }
}
