using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	public float speed;
	float speed2 = 17;
	public Slider slider;



	void Start() {

		slider.minValue = 0;
		slider.maxValue = 100;

		slider.value = 50;
	}


	void Update() {



		if (Input.GetKey(KeyCode.LeftShift) && slider.value > 0) {

			transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * speed2,0,Input.GetAxis("Vertical") * Time.deltaTime * speed2);
			slider.value -= 10 * Time.deltaTime;
		} else {
			transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * speed,0,Input.GetAxis("Vertical") * Time.deltaTime * speed);

		}


		if (Input.GetKey(KeyCode.Space)) {

			GetComponent<Rigidbody>().AddForce(new Vector3(0,10,0));
		}


	}

	private void OnCollisionEnter(Collision c) {
		print(c.gameObject.name);

		if (c.gameObject.tag == "enemy") {//sei que eh um inimigo
			if (c.gameObject.transform.localScale.x <= transform.localScale.x) {//inimigo eh menor


				transform.localScale += new Vector3(c.gameObject.transform.localScale.x,c.gameObject.transform.localScale.y,c.gameObject.transform.localScale.z);


				Destroy(c.gameObject);




			} else {
				Destroy(this.gameObject);
			}
		}


		if (c.gameObject.tag == "boost") {

			slider.value += 10;
		}

	}


}

