using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	//[SerializeField]
	[Range(1f,20f)]
	public float speed = 10;
	float speedBoosted = 30;
	//Rigidbody rb;


	float score = 0;
	public Text scoreText;

	public Slider boostSlider;

	void Start() {
		InitialPosition(); //handle position





		boostSlider.maxValue = 100;
		boostSlider.minValue = 0;
		boostSlider.value = 66;//testing

		//rb = GetComponent<Rigidbody>();
	}

	void InitialPosition() {
		transform.position = new Vector3(0,0,0);
		print("Centralizado");
	}



	void Update() {

		scoreText.text = score.ToString();

		if (Input.GetKey(KeyCode.Space)) {
			transform.position += new Vector3(0,.1f,0);
		}

		if (Input.GetKey(KeyCode.LeftControl) && boostSlider.value != 0) {
			transform.position += new Vector3(Input.GetAxis("Horizontal") * speedBoosted * Time.deltaTime,0,Input.GetAxis("Vertical") * speed * Time.deltaTime);
			boostSlider.value -= 25 * Time.deltaTime;
			gameObject.GetComponent<TrailRenderer>().enabled = true;
		} else {
			transform.position += new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime,0,Input.GetAxis("Vertical") * speed * Time.deltaTime);


			gameObject.GetComponent<TrailRenderer>().Clear();
			gameObject.GetComponent<TrailRenderer>().enabled = false;

		}
		//rb.AddForce(new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime,0,Input.GetAxis("Vertical") * speed * Time.deltaTime));
		//if (Input.GetKey(KeyCode.RightArrow)) {
		//	transform.position += new Vector3(1 * speed * Time.deltaTime,0,0);
		//}
		//if (Input.GetKey(KeyCode.LeftArrow)) {
		//	transform.position += new Vector3(-1 * speed * Time.deltaTime,0,0);
		//}
		//if (Input.GetKey(KeyCode.UpArrow)) {
		//	transform.position += new Vector3(0,0,1 * speed * Time.deltaTime);
		//}
		//if (Input.GetKey(KeyCode.DownArrow)) {
		//	transform.position += new Vector3(0,0,-1 * speed * Time.deltaTime);
		//}

	}

	private void OnCollisionEnter(Collision c) {
		//print("bateu " + c.gameObject.name);
		//print("bateu" + c.gameObject.tag);
		if (c.gameObject.tag == "Enemy") {
			if (c.gameObject.transform.localScale.x <= transform.localScale.x) {
				transform.localScale += c.gameObject.transform.localScale * 0.5f;
				score += c.gameObject.transform.localScale.x;
				Destroy(c.gameObject);
			} else {
				scoreText.color = Color.red;
				Destroy(gameObject);
			}
			//transform.localScale += new Vector3(.5f,.5f,.5f);

		}



	}
	private void OnCollisionStay(Collision c) {
		if (c.gameObject.tag == "Boost") {
			boostSlider.value += 25 * Time.deltaTime;
			GetComponent<Rigidbody>().WakeUp();
			print("booooost");
		}

	}


}
