using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEditorInternal;

public class CameraTrack : MonoBehaviour
{
	[SerializeField] float transitionCutoff = 2;

	public CinemachineDollyCart cart;
	public CinemachineSmoothPath trackPath;

	CTrackSwitcher ctMaster;
	[HideInInspector] public bool isActive;


	void Start()
	{
		ctMaster = GameObject.FindObjectOfType<CTrackSwitcher>();
	}

	void LateUpdate()
	{
		if (!isActive) return;

		if (cart.m_Position >= (trackPath.PathLength - transitionCutoff))
		{
			ctMaster.onTrackEnd(this);
		}
	}
}
