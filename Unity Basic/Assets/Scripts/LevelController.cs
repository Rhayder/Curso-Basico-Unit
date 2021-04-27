using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{

    public static LevelController instance;

    public int totalPickups;
    private int currentPickups;

    public string scene;

    public Text totalText;
    public Text currentText;
    public GameObject levelText;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        totalText.text = "Total: " + totalPickups;
        
    }

    // Update is called once per frame
    public void SetPickups()
    {
        currentPickups++;

        currentText.text = "Coletados: " + currentPickups;

        if (currentPickups >= totalPickups)
        {
            levelText.SetActive(true);
            Invoke("LoadScene", 2f);
        }
    }

    void LoadScene()
    {
        SceneController.instance.LoadScene(scene);    
    }
}
