using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public string sceneName;
    public int time;

    void Start()
    {
        // kick-off the one co-routine to rule them all
        StartCoroutine(LoadScenesInOrder());
    }

    private IEnumerator LoadScenesInOrder()
    {
        
        yield return new WaitForSeconds(time);
        SceneManager.LoadSceneAsync(sceneName);
    }

    
}
