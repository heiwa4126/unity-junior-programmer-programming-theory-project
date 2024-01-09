using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSceneManager : MonoBehaviour
{
	[SerializeField] private TextMeshProUGUI promptText;

	// Start is called before the first frame update
	void Start()
	{
		StartCoroutine(BlinkPrompt());
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			SceneManager.LoadScene(1);
		}
	}

	IEnumerator BlinkPrompt()
	{
		while (true)
		{
			promptText.gameObject.SetActive(true);
			yield return new WaitForSeconds(1);
			promptText.gameObject.SetActive(false);
			yield return new WaitForSeconds(0.2f);
		}
	}

}
