using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScript : MonoBehaviour {

	#region Variables
	GameObject gameController;
	VariablesScript vS;
	#endregion

	// Use this for initialization
	void Start () {
		gameController = GameObject.FindGameObjectWithTag("GameController");
		vS = gameController.GetComponent<VariablesScript>();
	}

	// Update is called once per frame
	void Update () {
		if (this.gameObject.tag == "UIDisplay")
		{
			gameObject.GetComponent<Text>().text = Mathf.Round(vS.GetPlayerMoney()).ToString();
		}
		else if (this.gameObject.tag == "MoneyPerSecDisplay")
		{
			gameObject.GetComponent<Text>().text = vS.GetPlayerMoneyPerSec().ToString();
		}
		else if (this.gameObject.tag == "+1_Text")
		{
			gameObject.GetComponent<Text>().text = "+1 Money Per Sec \n Count: " + vS.GetPlusOneCount() + "\n Cost: " + vS.GetPlusOneCostDisp().ToString();
		}
		else if (this.gameObject.tag == "+5_Text")
		{
			gameObject.GetComponent<Text>().text = "+5 Money Per Sec \n Count: " + vS.GetPlusFiveCount() + "\n Cost: " + vS.GetPlusFiveCostDisp().ToString();
		}
		else if (this.gameObject.tag == "+10_Text")
		{
			gameObject.GetComponent<Text>().text = "+10 Money Per Sec \n Count: " + vS.GetPlusTenCount() + "\n Cost: " + vS.GetPlusTenCostDisp().ToString();
		}
		else if (this.gameObject.tag == "+50_Text")
		{
			gameObject.GetComponent<Text>().text = "+50 Money Per Sec \n Count: " + vS.GetPlusFiftyCount() + "\n Cost: " + vS.GetPlusFiftyCostDisp().ToString();
		}
	}
}
