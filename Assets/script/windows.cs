using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class windows : MonoBehaviour {

    public GameObject off1;
    public GameObject join1;

	void Start () {
		
	}

	void Update () {
		
	}

    public void off()
    {
        Application.Quit();

    }
    public void join()
    {
        SceneManager.LoadScene("bomj");
    }
}
