using UnityEngine;
using System.Collections;

public class SoundController : MonoBehaviour {
	[SerializeField]
	private AudioClip hairballSuck = null, otherObjectSuck = null, redshirtCatSound = null, buttonSound = null; 

	private AudioSource audioSource;

	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();
	}

	public void PlayHairballSuckSound () {
		audioSource.PlayOneShot(hairballSuck);
	}

	public void PlayOtherObjectSuckSound () {
		audioSource.PlayOneShot(otherObjectSuck);
	}

	public void PlayRedShirtCatSound () {
		audioSource.PlayOneShot(redshirtCatSound);
	}

	public void PlayButtonSound () {
		audioSource.PlayOneShot(buttonSound);
	}
}

