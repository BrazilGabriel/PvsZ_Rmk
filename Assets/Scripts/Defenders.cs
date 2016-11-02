using UnityEngine;
using System.Collections;

public class Defenders : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Rigidbody2D meuRigidyBody = gameObject.AddComponent<Rigidbody2D>();
		meuRigidyBody.isKinematic = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(){
		Debug.Log (name + " colidiu");
	}
}
