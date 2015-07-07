using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public static float budgetTotal = 1000f;
	public static float budgetReset = 1000f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	


	}
	// function to change the value of the Budget for a given scenario
	// change the scenario value in the inspector
	// script should be located on the button and each button value should correspond with the spreadsheet
	// make sure to add aditional SetBool functions to the inspector to deactivate current question and activate the appropriate next question
	public void ScenarioValue(float changeBudgetAmount){

		budgetTotal += changeBudgetAmount;
		Debug.Log ("Button Clicked");


	}

	public void ResetBudget(){
		budgetTotal = budgetReset;
	}

}
