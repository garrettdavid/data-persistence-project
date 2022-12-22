using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField nameField;
    public GameObject nameObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew() {
        nameObj.name = nameField.text;
        DontDestroyOnLoad(nameObj);
        SceneManager.LoadScene(1);
    }

    public void SaveName() {
        //MainManager.Instance.SaveName();
    }
}
