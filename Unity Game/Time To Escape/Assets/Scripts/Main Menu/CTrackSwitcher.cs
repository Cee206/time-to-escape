using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CTrackSwitcher : MonoBehaviour
{
	[SerializeField] MainMenu menu;

	[SerializeField] float cameraTrackSpeed;

	[SerializeField] CinemachineVirtualCamera vCam;
	[SerializeField] List<CameraTrack> trackList;
	int currentTrackIndex = 0;

	public void onTrackEnd(CameraTrack endedTrack)
	{
		menu.SetFaded(true);
	}

	public void onFadeEnd()
	{
		CameraTrack oldTrack = trackList[currentTrackIndex];

		currentTrackIndex++;
		if (currentTrackIndex >= trackList.Count) currentTrackIndex = 0;

		StartNewTrack(trackList[currentTrackIndex]);

		oldTrack.isActive = false;
		oldTrack.cart.m_Speed = 0;
		oldTrack.cart.m_Position = 0;

		menu.SetFaded(false);
	}

	void Awake()
	{
		currentTrackIndex = Random.Range(0, trackList.Count);

		StartNewTrack(trackList[currentTrackIndex]);
	}

	void StartNewTrack(CameraTrack track)
	{
		vCam.Follow = track.cart.transform;

		track.isActive = true;
		track.cart.m_Speed = cameraTrackSpeed;
	}
}
