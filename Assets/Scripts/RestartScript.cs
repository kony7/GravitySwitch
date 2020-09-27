using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{

    private bool gameOverBool;
    GameObject judgCube;

    // Start is called before the first frame update
    void Start()
    {
        gameOverBool = GameObject.Find("JudgCllider");
    }

    // Update is called once per frame
    void Update()
    {
        //if ()
        //{

        //}
    }

    public void NewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
