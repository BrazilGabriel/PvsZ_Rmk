using UnityEngine;
using System.Collections;

public class Attacker : MonoBehaviour {

	//Use o centro de gravidade para se basear a animacao

	[Range (-1f, 1.5f)]
	public float currentSpeed;

	// Use this for initialization
	void Start () {
		Rigidbody2D meuRigidyBody = gameObject.AddComponent<Rigidbody2D>();
		meuRigidyBody.isKinematic = true;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * currentSpeed * Time.deltaTime);
	}

	void OnTriggerEnter2D(){
		Debug.Log (name + " colidiu");
	}

	public void setSpeed(float speed){
		currentSpeed = speed;
	}

}
