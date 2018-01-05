using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelHelloWorld : MonoBehaviour {

	/*we created a new funtoin that runs when ever the
	 * objec with this scripy attached ti it collides
	 * with another 2D object
	 * this functoin recievs a variable type
	 * Collision2D named MyCollisonInfo that acts like
	 * an incident report on the collision
	 * */
	void OnCollisionEnter2D(Collision2D MyCollisionInfo){

		//We Debug.Log the name of Object that we ran into
		//that trigered the collision
		Debug.Log (MyCollisionInfo.gameObject.name);
		//if we ran into end of level object
		if (MyCollisionInfo.gameObject.name == "Key") {

			//load the next level
			SceneManager.LoadScene ("VictoryLevel");
			//this code reloads the current scene
			//SceneManager.LoadScene (SceneManager.GetActiveScene ().name);

		}

	}


}
