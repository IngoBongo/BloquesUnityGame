using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barra : MonoBehaviour {

	public float velocidad = 0.4f;

	Vector3 posicionInicial;

	// Use this for initialization
	void Start () {
		posicionInicial = transform.position;
	}

	public void Reset(){
		transform.position = posicionInicial;
	}

	// Update is called once per frame
	void Update () {
		float tecladoHorizontal = Input.GetAxisRaw("Horizontal");
		float posX = transform.position.x + (tecladoHorizontal * velocidad * Time.deltaTime);
		transform.position = new Vector3(Mathf.Clamp(posX, -5.12f, 5.12f),transform.position.y,transform.position.z);
	}
}
