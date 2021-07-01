using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeLanguage : MonoBehaviour
{
    public string[] myLangs;
	int index;

	public void ChangeLanguageType(int myLanguage)//Change language
	{
		index = myLanguage;
		PlayerPrefs.SetInt ("_language_index", index);
		PlayerPrefs.SetString ("_language", myLangs[index]);
		Language.Instance.LoadLanguage();
		ApplyLanguageChanges();
	}

	void ApplyLanguageChanges()
	{
		foreach (Translator translator in Language.Instance.textsToTranslate)
        {
			translator.Translate();
        }
	}
}