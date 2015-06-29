using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public static float budgetTotal = 1000f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	


	}

	public void BudgetAction(float changeBudgetAmount){

		budgetTotal += changeBudgetAmount;
		Debug.Log ("Button Clicked");

	}
}
