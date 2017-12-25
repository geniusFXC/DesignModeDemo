using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DM04TemplateMethod : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Concrete04A Concrete = new Concrete04A();
        Concrete.TemplateMethod();
	}
	
	
}

public abstract class AbstractClass
{
    public void TemplateMethod()
    {
        Method1();
        Method2();
        Method3();
    }
    public void Method1()
    {
        Debug.Log("Method1");
    }
    public abstract void Method2();

    public virtual void Method3()
    {
        Debug.Log("Method3");
    }
}

public class Concrete04A:AbstractClass
{
    public override void Method2()
    {
        Debug.Log("Method2");
    }

    public override void Method3()
    {
        base.Method3();
        Debug.Log("New Method3");
    }

}

