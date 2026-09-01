using UnityEngine;

public abstract class Animal    // 추상 클래스  : new  연산자를 이용해서 객체를 못만듦
{   
    // protected : 외부에서는 접근이 불가능하지만 내부 혹은 자식클래스에서는 접근 가능
    protected string _name = string.Empty;
    protected float _height = 0f;
    protected double _weight = 0f;
    
    //virtual : 상속받고있는 하위 클래스에서 override 할수 있게끔 해주는 키워드
    public abstract void Introduce();    // 추상 메서드 - 구현이 없는 메서드 이므로 자식 클래스에서 무조건 구현해야하는 클래스

    public void Run()
    {
        Debug.Log($"[{_name} 뛰는중!] 속도: {100 - (_height/_weight)}");
    }
}
