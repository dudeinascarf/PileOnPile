using UnityEngine;
using System.Collections;

public class PanelDestroyer : MonoBehaviour {

	public void OnCollisionEnter(Collision target){

		Destroy (target.gameObject);
	}
}
