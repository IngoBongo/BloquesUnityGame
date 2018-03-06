using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour {

	public Rigidbody rig;  //quitar public para utilizar el metodo Awake 

	public float velocidadInicial = 600f;

	bool jugando;   //false por defecto

	Vector3 posicionInicial;

	public Transform barra; //acceso a los componentes de la Barra.

	void Awake(){
		//rig = GetComponent<Rigidbody>(); //descomentar anterior (forma alternativa para la variable reg). 

		//barra = GetComponentInParent<Transform> (); 
	}


	// Use this for initialization
	void Start () 
	{
		posicionInicial = transform.position;   // inicia la posicion de la bola.
	}

	public void Reset()
	{
		transform.position = posicionInicial;  
		transform.SetParent (barra);            // Vuelve a ser hija de la barra.
		jugando = false;
		DetenerMovimiento ();
	}

	public void DetenerMovimiento(){
		rig.isKinematic = true;
		rig.velocity = Vector3.zero;            // velocidad a cero.
	}
	
	// Update is called once per frame
	void Update () {
		if (!jugando && Input.GetButtonDown ("Fire1"))   //juego parado y pulsar Left Ctrl o Spacio 
		{
			jugando = true;                              //estado del juego >> jugando.
			transform.SetParent(null);                   // desvincula el objeto 'Bola' de su padre la 'Barra'.
			rig.isKinematic = false;					 // desactiva isKinematic del RigidBody para la 'Bola'.
			rig.AddForce(new Vector3(velocidadInicial,velocidadInicial,0)); //aplica fuerza a la 'Bola' para lanzarla.
		}
	}
}
