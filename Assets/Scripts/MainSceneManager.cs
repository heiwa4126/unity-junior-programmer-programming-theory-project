using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MainSceneManager : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Keyboard.current.escapeKey.wasPressedThisFrame)
		{
			SceneManager.LoadScene(0);
		}
	}
}
