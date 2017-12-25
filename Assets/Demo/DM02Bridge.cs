using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 解决问题：
/// 结构说明：
///          一个问题可以分为两个独立变化的纬度
///          Abstraction（抽象类）：我们将具有两个独立变化维度的类的一些普通业务方法和与之关系最密切的维度设计为“抽象类”层次结构（抽象部分）
///          Implementor（接口）：而将另一个维度设计为“实现类”层次结构（实现部分）
///          在抽象类中引入实现类（接口），在具体实现类里设置实现接口的类，实现功能的组合
/// </summary>
public class DM02Bridge : MonoBehaviour {

	
	void Start () {
        //RefineAbstractionA refineA = new RefineAbstractionA();
        //refineA.SetImp(new OperationA());
        //refineA.Operation();

        RefineAbstractionC refineC = new RefineAbstractionC();
        refineC.SetImp(new OperationB());
        refineC.Operation();

        
        
        
	}
	
	
}
#region “实现抽象”纬度
public abstract class Abstraction
{
    protected Implementor mImplementor;
    public void SetImp(Implementor implementor)
    {
        mImplementor = implementor;
    }
    public abstract void Operation();

}

public class RefineAbstractionA : Abstraction
{
    public override void Operation()
    {
        Debug.Log("实现抽象：RefineAbstractionA");
        mImplementor.OperationImp();
    }
}
public class RefineAbstractionB : Abstraction
{
    public override void Operation()
    {
        Debug.Log("实现抽象：RefineAbstractionB");
        mImplementor.OperationImp();
    }
}
public class RefineAbstractionC : Abstraction
{
    public override void Operation()
    {
        Debug.Log("实现抽象：RefineAbstractionC");
        mImplementor.OperationImp();
    }
}

#endregion
#region “实现接口”纬度
public interface Implementor
{
    void OperationImp();
}
public class OperationA : Implementor
{
    public void OperationImp()
    {
        Debug.Log("实现接口 ：OperationA");
    }
}
public class OperationB : Implementor
{
    public void OperationImp()
    {
        Debug.Log("实现接口 ：OperationB");
    }
}
public class OperationC : Implementor
{
    public void OperationImp()
    {
        Debug.Log("实现接口 ：OperationC");
    }
}
#endregion
