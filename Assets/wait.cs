using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wait : MonoBehaviour

{
    public float waiting_time=7f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Waiting());

    }

    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(waiting_time);
        SceneManager.LoadScene(1);
    }
    
}
 