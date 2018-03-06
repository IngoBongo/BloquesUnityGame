using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidosFinPartida : MonoBehaviour {

	public AudioSource audioSource;
	public AudioClip completado;
	public AudioClip gameOver;
	public AudioClip looseBall;
	public AudioSource sourceMusicaJuego;

	public void GameOver(){
		
		ReproducirSonido (gameOver);
		sourceMusicaJuego.Stop ();
	}

	public void NivelCompletado(){

		ReproducirSonido (completado);
		sourceMusicaJuego.Stop ();
	}

	public void BolaPerdida(){

		ReproducirSonido (looseBall);
		sourceMusicaJuego.Stop ();
	}
		

	void ReproducirSonido(AudioClip sonido){

		audioSource.clip = sonido;
		audioSource.loop = false;
		audioSource.Play ();
	}
}
