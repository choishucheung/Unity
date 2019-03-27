using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Context
{
    private IState _state;
    public void SetState(IState state){
        _state = state;
    }
}

public interface IState
{
    void Handle(int arg);
}

/// <summary>
/// 具体的子类
/// </summary>
public class ConcreteStateA:IState
{
    public void Handle(int arg)
    {
        Debug.Log(1);
    }
}

public class ConcreteStateB : IState
{
    public void Handle(int arg)
    {
        Debug.Log(2);
    }
}
