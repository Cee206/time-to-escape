using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayFadeTransition : MonoBehaviour
{
	[SerializeField] Animator anim;

	public void StartPlayFade()
	{
		anim.SetBool("isFaded", true);
	}

	public void onPlayFadeEnd()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
