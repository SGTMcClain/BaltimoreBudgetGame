using UnityEngine;
using System.Collections;

public class BudgetScript : MonoBehaviour {

	public int budget = 50000;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AdjustBudget(int newBudget){

		budget = newBudget;
	}
}
