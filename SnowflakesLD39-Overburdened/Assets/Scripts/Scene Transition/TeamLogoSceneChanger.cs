﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeamLogoSceneChanger : MonoBehaviour {

    public string nextScene;
    private int secondTransition = 1;

    // Use this for initialization
    void Start ()
    {

        gameObject.GetComponent<Fading>().Fade(false, 3f);

        StartCoroutine(sceneChanger());

        

        

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (!gameObject.GetComponent<Fading>().isInTransition && secondTransition == 2)
        {
            SceneManager.LoadScene(nextScene);
        }
    }

    IEnumerator sceneChanger()
    {

        yield return new WaitForSeconds(6);
        gameObject.GetComponent<Fading>().Fade(true, 1f);
        secondTransition = 2;
        
       

        //yield return new WaitForSeconds(0);

    }
}
