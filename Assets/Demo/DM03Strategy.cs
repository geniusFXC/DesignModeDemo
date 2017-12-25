using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DM03Strategy : MonoBehaviour {

	
	void Start () {
        Context03 context = new Context03();
        context.SetStrategy(new StrategyB());
        context.Algorithm();
	}
	
	
}
public class Context03
{
    private Strategy mStrategy;
    public void SetStrategy(Strategy strategy)
    {
        mStrategy = strategy;
    }
    public void Algorithm()
    {
        mStrategy.algorithm();
    }
}
public abstract class Strategy
{
    public abstract void algorithm();
}

public class StrategyA : Strategy
{
    public override void algorithm()
    {
        Debug.Log("StrategyA");
    }
}
public class StrategyB : Strategy
{
    public override void algorithm()
    {
        Debug.Log("StrategyB");
    }
}
public class StrategyC : Strategy
{
    public override void algorithm()
    {
        Debug.Log("StrategyC");
    }
}

