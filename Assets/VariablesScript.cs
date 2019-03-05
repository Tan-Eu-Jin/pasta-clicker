using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesScript : MonoBehaviour {

	#region Variables
	private float playerMoney = 0.0f;
	private float playerMoneyPerSec = 0.0f;

	//! Buy Counters
	private int plusOne_Count = 0;
	private int plusFive_Count = 0;
	private int plusTen_Count = 0;
	private int plusFifty_Count = 0;

	//! Current Cost
	private float plusOne_Cost = 10.0f;
	private float plusFive_Cost = 50.0f;
	private float plusTen_Cost = 100.0f;
	private float plusFifty_Cost = 500.0f;
	#endregion

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	#region Money
	public float GetPlayerMoney(){
		return playerMoney;
	}

	public void SetPlayerMoney(float amount){
		playerMoney += amount;
	}
	#endregion

	#region MoneyPerSec
	public float GetPlayerMoneyPerSec(){
		return playerMoneyPerSec;
	}

	public void SetPlayerMoneyPerSec(float amount){
		playerMoneyPerSec += amount;
	}
	#endregion

	#region PlusOptions

	#region Plus One
	//! Gets current count, gets current cost & calculates current cost
	public int GetPlusOneCount()
	{
		return plusOne_Count;
	}

	public float GetPlusOneCost(float baseCost, float mulValue)
	{
		plusOne_Cost = baseCost * (Mathf.Pow(mulValue, plusOne_Count));
		return plusOne_Cost;
	}

	public float GetPlusOneCostDisp()
	{
		return plusOne_Cost;
	}

	public void SetPlusOneCount(int amount)
	{
		plusOne_Count += amount;
	}
	#endregion

	#region Plus Five
	//! Gets current count, gets current cost & calculates current cost
	public int GetPlusFiveCount()
	{
		return plusFive_Count;
	}

	public float GetPlusFiveCost(float baseCost, float mulValue)
	{
		plusFive_Cost = baseCost * (Mathf.Pow(mulValue, plusFive_Count));
		return plusFive_Cost;
	}

	public float GetPlusFiveCostDisp()
	{
		return plusFive_Cost;
	}

	public void SetPlusFiveCount(int amount)
	{
		plusFive_Count += amount;
	}
	#endregion

	#region Plus Ten
	//! Gets current count, gets current cost & calculates current cost
	public int GetPlusTenCount()
	{
		return plusTen_Count;
	}

	public float GetPlusTenCost(float baseCost, float mulValue)
	{
		plusTen_Cost = baseCost * (Mathf.Pow(mulValue, plusTen_Count));
		return plusTen_Cost;
	}

	public float GetPlusTenCostDisp()
	{
		return plusTen_Cost;
	}

	public void SetPlusTenCount(int amount)
	{
		plusTen_Count += amount;
	}
	#endregion

	#region Plus Fifty
	//! Gets current count, gets current cost & calculates current cost
	public int GetPlusFiftyCount()
	{
		return plusFifty_Count;
	}

	public float GetPlusFiftyCost(float baseCost, float mulValue)
	{
		plusFifty_Cost = baseCost * (Mathf.Pow(mulValue, plusFifty_Count));
		return plusFifty_Cost;
	}

	public float GetPlusFiftyCostDisp()
	{
		return plusFifty_Cost;
	}

	public void SetPlusFiftyCount(int amount)
	{
		plusFifty_Count += amount;
	}
	#endregion

	#endregion
}
