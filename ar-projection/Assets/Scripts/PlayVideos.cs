using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVideos : MonoBehaviour {
	[SerializeField] private MovieTexture[] videos;

	void Awake()
	{
		foreach (var v in videos)
			v.loop = true;
	}

	void OnEnable()
	{
		foreach (var v in videos) {
			v.Stop ();
			v.Play ();
		}
	}
}
