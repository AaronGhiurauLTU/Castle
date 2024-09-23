using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example1 : MonoBehaviour
{
	public int score = 0;
	// Start is called before the first frame update
	void Start()
	{
		// declaration: creating a new variable in memory
		int bob;


		// you can declare and initialize in one line
		int jim = 7;

		// assignment: = mean take what's on the right and put it into what's on the left
		bob = 13;
		jim = 5;
	
		// LVALUE and RVALUE
		// LVALUE must be somewhere in memory and RVALUE must be anything where a value could be derived from
		// initialization: putting a value in a variable for the first time

		// casting to change datatype
		// (type) value
		bob = (int) 13.5;

		float speed = 12;
		// floating-point imprecision may yield 12.00000000000000001 or 11.999999999999

		Debug.Log(bob);
		Debug.Log(jim);
	
	}

	// Update is called once per frame
	void Update()
	{
		score++;
		

		if (score <= 100) {
			Debug.Log(score);
		} else if (score > 999) {
			Debug.Log($"NEW HIGH SCORE!! {score}"); // string interpolation
		}
	}
}
