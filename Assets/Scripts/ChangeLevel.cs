using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeLevel : MonoBehaviour {

    public Text txt;
    public Image img;
    public GameObject obj;
    GameObject[] gameObjects;
    bool oneTime;

    private void Awake()
    {
        oneTime = false;
    }

    public void AutoLevel()
    {
        if(SceneManager.GetActiveScene().buildIndex != 1)
        {
            if(oneTime == false)
            {
                print(oneTime);
                GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("BTConnector");
                foreach (GameObject target in gameObjects)
                {
                    DontDestroyOnLoad(target);
                }
                print("1");
                oneTime = true;
            }
            SceneManager.LoadScene("AutoMode");
        }
    }

    public void ManualMode()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            SceneManager.LoadScene("ManualMode");
        }
    }

    public void Profile()
    {
        if (SceneManager.GetActiveScene().buildIndex != 2)
        {
            print(oneTime);
            if (oneTime == false)
            {
                GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("BTConnector");
                foreach (GameObject target in gameObjects)
                {
                    DontDestroyOnLoad(target);
                }
                print("1");
                oneTime = true;
            }
            SceneManager.LoadScene("PatientProfile");
        }
    }

    public void Instructions()
    {
        if (SceneManager.GetActiveScene().buildIndex != 3)
        {
            print(oneTime);
            if (oneTime == false)
            {
                GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("BTConnector");
                foreach (GameObject target in gameObjects)
                {
                    DontDestroyOnLoad(target);
                }
                print("1");
                oneTime = true;
            }
            SceneManager.LoadScene("InstructionsScene");
        }
    }

}
