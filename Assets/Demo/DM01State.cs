using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 解决问题：
/// 结构说明：
///          环境类Context：负责维护一个抽象状态类的实例  是拥有多种状态的对象 
///          抽象状态类State：定义了一个接口 把具体状态类里相同的方法抽象出来
///          具体状态类Concrete：继承抽象状态类 实现抽象方法 实现不同状态对应的不同行为 根据传入的参数去转换不同的状态
/// </summary>
public class DM01State : MonoBehaviour {

	
	void Start () {
        Context context = Context.GetInstace();
        context.Handle(5);
        context.Handle(6);
        context.Handle(11);
    }
	
	
}
public class Context{
    private static Context mInstance = null;
    public static Context GetInstace()
    {
        if (mInstance == null)
        {
            mInstance =  new Context();
        }
        return mInstance;
    }
    
    private Context()
    {
        
        mState = new ConcreteA();
        
    }
    private State mState;
    public void SetState(State state)
    {
        mState = state;
    }
    

    public void Handle(int a)
    {
        mState.Handle(a);
    }
}
public abstract class State
{
    //protected Context mContext;

    public abstract void Handle(int a);
    
    
}

public class ConcreteA : State
{
    //public ConcreateA(Context context)
    //{
    //    mContext = context;
    //}
    public override void Handle(int a)
    {
        if (a < 10)
        {
            Debug.Log("可以转换B:" + a);
            Context.GetInstace().SetState(new ConcreteB());
        }
    }
}
public class ConcreteB : State
{
    //public ConcreateB(Context context)
    //{
    //    mContext = context;
    //}
    public override void Handle(int a)
    {
        if(a >= 10)
        {
            Debug.Log("可以转换A:" + a);
            Context.GetInstace().SetState(new ConcreteA());
        }
    }
}

