using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class plotter : MonoBehaviour {

    float xMin;
    float xMax;
    float yMin;
    float yMax;
    float width;
    float height;
    float xScreenSpace;
    float yScreenSpace;
    float Freq;
    float Level;
    GameObject activeChild;
    Toggle rightTog;
    Toggle leftTog;
    Toggle maskedTog;
    Camera cam;
    Vector3 mainCanvasPosition;
    Vector3 positionVector;

    // Use this for initialization
    public void Start () {
        rightTog = GameObject.FindGameObjectWithTag("RightToggle").GetComponent<Toggle>();
        leftTog = GameObject.FindGameObjectWithTag("LeftToggle").GetComponent<Toggle>();
        maskedTog = GameObject.FindGameObjectWithTag("MaskingToggle").GetComponent<Toggle>();
        cam = GameObject.Find("MainCamera").GetComponent<Camera>();
        Vector3 mainCanvasPosition = GameObject.Find("MainCanvas").transform.position;
    }

    public void Update()
    {
        xCord();
        yCord();
        if (rightTog.isOn == true) //Right Side
        {

            if (GameObject.FindGameObjectWithTag("Dropdown").GetComponent<Dropdown>().value == 0) //AC
            {

                if (maskedTog.isOn == true) //Masking on
                {
                    GameObject.Find("CommunicationText").GetComponent<Text>().text = "1,1,1," + Freq.ToString() + "," + Level.ToString();
                }

                else if (maskedTog.isOn == false) //Masking off
                {
                    GameObject.Find("CommunicationText").GetComponent<Text>().text = "1,1,0," + Freq.ToString() + "," + Level.ToString();
                }

            }

            if (GameObject.FindGameObjectWithTag("Dropdown").GetComponent<Dropdown>().value == 1) //BC
            {

                if (maskedTog.isOn == true) //Masking on
                {
                    GameObject.Find("CommunicationText").GetComponent<Text>().text = "1,0,1," + Freq.ToString() + "," + Level.ToString();
                }

                else if (maskedTog.isOn == false) //Masking off
                {
                    GameObject.Find("CommunicationText").GetComponent<Text>().text = "1,0,0," + Freq.ToString() + "," + Level.ToString();
                }
            }
        }
    }

    public void plot()
    {
        if (rightTog.isOn == true) //Right Side
        {

            if (GameObject.FindGameObjectWithTag("Dropdown").GetComponent<Dropdown>().value == 0) //AC
            {

                if (maskedTog.isOn == true) //Masking on
                {
                    GameObject rightACMasked = Instantiate(Resources.Load("RightACMaskedSymbol")) as GameObject;
                    rightACMasked.transform.SetParent(GameObject.Find("MainCanvas").transform);
                    rightACMasked.transform.localPosition = new Vector3(xCord(), yCord(), 0);
                    rightACMasked.GetComponent<Image>().color = Color.red;

                    gameObject.GetComponent<linePlotter>().addToListRightAC();
                    gameObject.GetComponent<linePlotter>().lineDraw();
                }

                else if (maskedTog.isOn == false) //Masking off
                {
                    GameObject rightACUnmasked = Instantiate(Resources.Load("RightACUnmaskedSymbol")) as GameObject;
                    rightACUnmasked.transform.SetParent(GameObject.Find("MainCanvas").transform);
                    rightACUnmasked.transform.localPosition = new Vector3(xCord(), yCord(), 0);
                    rightACUnmasked.GetComponent<Image>().color = Color.red;

                    gameObject.GetComponent<linePlotter>().addToListRightAC();
                    gameObject.GetComponent<linePlotter>().lineDraw();
                }

            }

            if (GameObject.FindGameObjectWithTag("Dropdown").GetComponent<Dropdown>().value == 1) //BC
            { 

                if (maskedTog.isOn == true) //Masking on
                {
                    GameObject rightBCMasked = Instantiate(Resources.Load("RightBCMaskedSymbol")) as GameObject;
                    rightBCMasked.transform.SetParent(GameObject.Find("MainCanvas").transform);
                    rightBCMasked.transform.localPosition = new Vector3(xCord(), yCord(), 0);
                    rightBCMasked.GetComponent<Image>().color = Color.red;

                    gameObject.GetComponent<linePlotter>().addToListRightBC();
                    gameObject.GetComponent<linePlotter>().lineDraw();
                }

                else if (maskedTog.isOn == false) //Masking off
                {

                    GameObject rightBCUnmasked = Instantiate(Resources.Load("RightBCUnmaskedSymbol")) as GameObject;
                    rightBCUnmasked.transform.SetParent(GameObject.Find("MainCanvas").transform);
                    rightBCUnmasked.transform.localPosition = new Vector3(xCord(), yCord(), 0);
                    rightBCUnmasked.GetComponent<Image>().color = Color.red;

                    gameObject.GetComponent<linePlotter>().addToListRightBC();
                    gameObject.GetComponent<linePlotter>().lineDraw();
                }
            }
        }

        if (leftTog.isOn == true) //Left Side
        {

            if (GameObject.FindGameObjectWithTag("Dropdown").GetComponent<Dropdown>().value == 0) //AC
            {
                if (maskedTog.isOn == true) //Masking on
                {
                    GameObject leftACMasked = Instantiate(Resources.Load("LeftACMaskedSymbol")) as GameObject;
                    leftACMasked.transform.SetParent(GameObject.Find("MainCanvas").transform);
                    leftACMasked.transform.localPosition = new Vector3(xCord(), yCord(), 0);
                    leftACMasked.GetComponent<Image>().color = Color.blue;

                    gameObject.GetComponent<linePlotter>().addToListLeftAC();
                    gameObject.GetComponent<linePlotter>().lineDraw();
                }

                else if (maskedTog.isOn == false) //Masking off
                {
                    GameObject leftACUnmasked = Instantiate(Resources.Load("LeftACUnmaskedSymbol")) as GameObject;
                    leftACUnmasked.transform.SetParent(GameObject.Find("MainCanvas").transform);
                    leftACUnmasked.transform.localPosition = new Vector3(xCord(), yCord(), 0);
                    leftACUnmasked.GetComponent<Image>().color = Color.blue;

                    gameObject.GetComponent<linePlotter>().addToListLeftAC();
                    gameObject.GetComponent<linePlotter>().lineDraw();
                }

            }

            if (GameObject.FindGameObjectWithTag("Dropdown").GetComponent<Dropdown>().value == 1) //BC
            {

                if (maskedTog.isOn == true) //Masking on
                {
                    GameObject leftBCMasked = Instantiate(Resources.Load("LeftBCMaskedSymbol")) as GameObject;
                    leftBCMasked.transform.SetParent(GameObject.Find("MainCanvas").transform);
                    leftBCMasked.transform.localPosition = new Vector3(xCord(), yCord(), 0);
                    leftBCMasked.GetComponent<Image>().color = Color.blue;

                    gameObject.GetComponent<linePlotter>().addToListLeftBC();
                    gameObject.GetComponent<linePlotter>().lineDraw();
                }

                else if (maskedTog.isOn == false) //Masking off
                {
                    GameObject leftBCUnmasked = Instantiate(Resources.Load("LeftBCUnmaskedSymbol")) as GameObject;
                    leftBCUnmasked.transform.SetParent(GameObject.Find("MainCanvas").transform);
                    leftBCUnmasked.transform.localPosition = new Vector3(xCord(), yCord(), 0);
                    leftBCUnmasked.GetComponent<Image>().color = Color.blue;

                    gameObject.GetComponent<linePlotter>().addToListLeftBC();
                    gameObject.GetComponent<linePlotter>().lineDraw();
                }
            }
        }
    } 
	
    public float xCord()
    {
        if(rightTog.isOn == true)
        {
            positionVector = GameObject.Find("RightGraph").transform.localPosition; //find graph position relative to parent (main canvas)
            width = GameObject.Find("RightGraph").GetComponent<RectTransform>().rect.width; //find graph dimensions
            xMin = positionVector.x - (width/2);
        }

        else if (leftTog.isOn == true)
        {
            positionVector = GameObject.Find("LeftGraph").transform.localPosition; //find graph position
            width = GameObject.Find("LeftGraph").GetComponent<RectTransform>().rect.width; //find graph dimensions
            xMin = positionVector.x - (width/2);
        }

        else
        {
            Debug.LogError("Neither left of right toggles are on.");
        }

        for (int i = 0; i < GameObject.FindGameObjectWithTag("FreqContent").transform.childCount; i++)
        {
            if (GameObject.FindGameObjectWithTag("FreqContent").transform.GetChild(i).gameObject.activeSelf == true)
            {
                Freq = float.Parse(GameObject.FindGameObjectWithTag("FreqContent").transform.GetChild(i).GetChild(0).GetComponent<Text>().text) * 1000; //convert string to int and kHz to Hz
            }
        }
      
        if(8000 % Freq == 0) //Test if freq is a multiple of 8000
        {
            xScreenSpace = xMin + (Mathf.Log(Freq / 125, 2) * ((width) / 6));
        }

        else
        {
            xScreenSpace = xMin+ ((Mathf.Log(Freq / 93.75f, 2) - 0.5f) * ((width) / 6));
        }

        print(xScreenSpace);
        return xScreenSpace;
    }

    public float yCord()
    {
        if (rightTog.isOn == true)
        {
            positionVector = GameObject.Find("RightGraph").transform.localPosition; //find graph position
            height = GameObject.Find("RightGraph").GetComponent<RectTransform>().rect.height; //find graph dimensions
            yMin = positionVector.y + (height / 2);
        }

        else if (leftTog.isOn == true)
        {
            positionVector = GameObject.Find("LeftGraph").transform.localPosition; //find graph position
            height = GameObject.Find("LeftGraph").GetComponent<RectTransform>().rect.height; //find graph dimensions
            yMin = positionVector.y + (height / 2);
        }

        else
        {
            Debug.LogError("Neither left of right toggles are on.");
        }

        for (int i = 0; i < GameObject.FindGameObjectWithTag("LevelContent").transform.childCount; i++)
        {
            if (GameObject.FindGameObjectWithTag("LevelContent").transform.GetChild(i).gameObject.activeSelf == true)
            {
                Level = int.Parse(GameObject.FindGameObjectWithTag("LevelContent").transform.GetChild(i).GetChild(0).GetComponent<Text>().text); //convert string to int
            }
        }

        return yScreenSpace = yMin + ((Level / -10) * ((height) / 14))-(height/14);
    }
}
