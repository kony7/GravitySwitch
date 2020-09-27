using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{

    private bool gOvBool;
    GameObject judgCube;
    JudgScript judgScript;

    // Start is called before the first frame update
    void Start()
    {
        gOvBool = GameObject.Find("JudgCllider");
        judgScript = judgCube.GetComponent<JudgScript>();
    }

    // Update is called once per frame
    void Update()
    {
        bool gameStatus = judgScript.gameOverBool;

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("クリックは反応している");

            if (gameStatus == true)
            {
                Debug.Log("trueだって判定されて呼ばれてはいそう");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            else
            {
                return;
            }
        }

     
    }

}
