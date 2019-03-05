using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickerScript : MonoBehaviour {
	#region Variables
	VariablesScript vS;
	public Text uiDisplay;

	private float clickAmount = 1.0f;
	private float perSecAmount = 0.0f;

	//! Clicker game multiple value
	private float multiplier = 1.15f;

	//! Base Cost for MoneyPerSec options
	private float plusOne_baseCost = 10.0f;
	private float plusFive_baseCost = 50.0f;
	private float plusTen_baseCost = 100.0f;
	private float plusFifty_baseCost = 500.0f;

	//! Cheats
	public float cheatAmount = 50.0f;

	//! Ticks
	private float tick = 0.1f;
	private float timer = 0.0f;
	#endregion

	// Use this for initialization
	void Start () {
		vS = GetComponent<VariablesScript>();
	}
	
	// Update is called once per frame
	void Update () {
		#region GameLoop
		perSecAmount = vS.GetPlayerMoneyPerSec();
		//! Every tick loop
		if (timer > tick)
		{
			timer = 0.0f;
			vS.SetPlayerMoney(perSecAmount/10.0f);
		}
		else
		{
			timer+= Time.deltaTime;
		}

		//! The following function specifically updates cost of the MoneyPerSec seen in the buttons
		UpdateCostDisp();
		#endregion

		#region CheatKeys
		//! This section holds cheat keys to aid debugging
		//! Cheat Key: Left-Shift
		if (Input.GetKeyUp(KeyCode.LeftShift))
		{
			vS.SetPlayerMoney(cheatAmount);
		}
		#endregion
	}

	//! Adding Money By Clicking Button
	public void AddMoney()
	{
		vS.SetPlayerMoney(clickAmount);
	}
		
	#region MoneyPerSec Options
	public void AddMoneyPerSec1() //! +1 Every Second
	{
		float valHold = vS.GetPlusOneCost(plusOne_baseCost, multiplier);
		if (vS.GetPlayerMoney() - valHold >= 0.0f)
		{
			vS.SetPlayerMoney(-valHold);
			vS.SetPlayerMoneyPerSec(1.0f);
			vS.SetPlusOneCount(1);
		}
	}

	public void AddMoneyPerSec5() //! +5 Every Second
	{
		float valHold = vS.GetPlusFiveCost(plusFive_baseCost, multiplier);
		if (vS.GetPlayerMoney() - valHold >= 0.0f)
		{
			vS.SetPlayerMoney(-valHold);
			vS.SetPlayerMoneyPerSec(5.0f);
			vS.SetPlusFiveCount(1);
		}
	}

	public void AddMoneyPerSec10() //! +10 Every Second
	{
		float valHold = vS.GetPlusTenCost(plusTen_baseCost, multiplier);
		if (vS.GetPlayerMoney() - valHold >= 0.0f)
		{
			vS.SetPlayerMoney(-valHold);
			vS.SetPlayerMoneyPerSec(10.0f);
			vS.SetPlusTenCount(1);
		}
	}

	public void AddMoneyPerSec50() //! +50 Every Second
	{
		float valHold = vS.GetPlusFiftyCost(plusFifty_baseCost, multiplier);
		if (vS.GetPlayerMoney() - valHold >= 0.0f)
		{
			vS.SetPlayerMoney(-valHold);
			vS.SetPlayerMoneyPerSec(50.0f);
			vS.SetPlusFiftyCount(1);
		}
	}

	public void UpdateCostDisp()
	{
		vS.GetPlusOneCost(plusOne_baseCost, multiplier);
		vS.GetPlusFiveCost(plusFive_baseCost, multiplier);
		vS.GetPlusTenCost(plusTen_baseCost, multiplier);
		vS.GetPlusFiftyCost(plusFifty_baseCost, multiplier);
	}
	#endregion
}
