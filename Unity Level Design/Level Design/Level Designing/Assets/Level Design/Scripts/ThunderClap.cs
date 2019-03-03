using UnityEngine;
using System.Collections;

public class ThunderClap : MonoBehaviour 
{
	bool canFlicker = true;
	public AudioSource clip;
	//Light myLight;

	void Update()
	{
		StartCoroutine (Flicker ());

		//myLight = GetComponent<Light> ();

	}

	IEnumerator Flicker ()
	{
		if (canFlicker) 
		{
			canFlicker = false;

			//myLight.enabled = myLight.enabled;
			GetComponent<Light>().enabled=true;
			yield return new WaitForSeconds (Random.Range (0.1f, 0.4f));
			//myLight.enabled = !myLight.enabled;
			GetComponent<Light>().enabled=false;
			yield return new WaitForSeconds (Random.Range (0.1f, 5));

			canFlicker = true;
		}
	}

}
