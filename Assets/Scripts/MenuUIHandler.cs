using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField inputText;
    public TMP_Text ScoreBest;
    // Start is called before the first frame update
    void Start()
    {
        inputText = GameObject.Find("InputField").GetComponent<TMP_InputField>();
        GameManager.Instance.LoadPlayer();
        ScoreBest.text = $"Best Score : {GameManager.Instance.playerName} : {GameManager.Instance.playerPoints}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextScene()
    {
        GameManager.Instance.playerName = inputText.text;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Debug.Log("exit called");
        #if UNITY_EDITOR
                EditorApplication.ExitPlaymode();
        #else
                        Application.Quit(); // original code to quit Unity player
        #endif
    }
}
