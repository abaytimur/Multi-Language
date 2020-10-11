using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeLanguage : MonoBehaviour
{
    public string[] myLangs;
	int index;

	public void ChangeLanguageType(int myLanguage)
	{
		index = myLanguage;
		PlayerPrefs.SetInt ("_language_index", index);
		PlayerPrefs.SetString ("_language", myLangs[index]);
		ApplyLanguageChanges();
	}

	void ApplyLanguageChanges ()
	{
		SceneManager.LoadScene(0);
	}
}
