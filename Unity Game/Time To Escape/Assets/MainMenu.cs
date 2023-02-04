using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	[SerializeField] CTrackSwitcher ctMaster;
	[SerializeField] Animator anim;

	public void onFadeInComplete()
	{
		ctMaster.onFadeEnd();
	}


	public void SetFaded(bool state)
	{
		anim.SetBool("isFaded", state);
	}

	public void Quitgame()

	{
		Debug.Log("QUIT!");
		Application.Quit();
	}
}
