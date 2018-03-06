using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidosBola : MonoBehaviour {

	public AudioSource ReboteBarra;
	public AudioSource Punto;
	public AudioSource ReboteLado;
	public AudioSource ReboteTecho;


	void OnCollisionEnter(Collision conOtro){

		if (conOtro.gameObject.CompareTag ("Bloques")) {

			Punto.Play ();

		} else if (conOtro.gameObject.CompareTag ("Postes")) {
			
			ReboteLado.Play ();

		} else if (conOtro.gameObject.CompareTag ("Techo")) {
			
			ReboteTecho.Play ();

		} else {
			
			ReboteBarra.Play ();
		}
	}
}
