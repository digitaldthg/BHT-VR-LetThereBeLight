using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextSceneKey : MonoBehaviour {

    public KeyCode LoadNextSceneOn = KeyCode.Space;
    public string SceneName;

    	
	// Update is called once per frame
	void Update () {
        /**
        if (Input.GetKey(LoadNextSceneOn))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        **/

        if (Input.GetKey(LoadNextSceneOn))
        {
            int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
            if (SceneManager.sceneCountInBuildSettings > nextSceneIndex)
            {
                SceneManager.LoadScene(nextSceneIndex);
            }

            else
            {
                nextSceneIndex = 0;
                SceneManager.LoadScene(nextSceneIndex);
            }
        }
    }


    public void LoadNextScene() {
        SceneManager.LoadScene(SceneName);
    }
}
