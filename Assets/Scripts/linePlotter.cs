using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class linePlotter : MonoBehaviour {

    List<Vector3> RightAC;
    List<Vector3> LeftAC;
    List<Vector3> RightBC;
    List<Vector3> LeftBC;
    float xCord;
    float yCord;
    Toggle rightTog;
    Toggle leftTog;

    // Use this for initialization
    void Start () {
        RightAC = new List<Vector3>();
        LeftAC = new List<Vector3>();
        RightBC = new List<Vector3>();
        LeftBC = new List<Vector3>();  
    }

    public List<Vector3> addToListRightAC()
    {
        xCord = gameObject.GetComponent<plotter>().xCord();
        yCord = gameObject.GetComponent<plotter>().yCord();

        RightAC.Add(new Vector3(xCord, yCord, 1));

        return RightAC;
    }

    public List<Vector3> addToListLeftAC()
    {
        xCord = gameObject.GetComponent<plotter>().xCord();
        yCord = gameObject.GetComponent<plotter>().yCord();

        LeftAC.Add(new Vector3(xCord, yCord, 1));

        return LeftAC;
    }

    public List<Vector3> addToListRightBC()
    {
        xCord = gameObject.GetComponent<plotter>().xCord();
        yCord = gameObject.GetComponent<plotter>().yCord();

        RightBC.Add(new Vector3(xCord, yCord, 1));

        return RightBC;
    }

    public List<Vector3> addToListLeftBC()
    {
        xCord = gameObject.GetComponent<plotter>().xCord();
        yCord = gameObject.GetComponent<plotter>().yCord();

        LeftBC.Add(new Vector3(xCord, yCord, 1));

        return LeftBC;
    }

    public void lineDraw()
    {

        if (RightAC.Count != 1)
        {
            RightAC.Sort((a, b) => a.x.CompareTo(b.x)); //Sort list of vector3's by x component

            for (var i = 0; i < RightAC.Count-1; i++)
            {
                GameObject RightACLine = Instantiate(Resources.Load("Square")) as GameObject;
                RightACLine.transform.SetParent(GameObject.Find("MainCanvas").transform);
                Vector3 differenceVector = RightAC[i+1] - RightAC[i];
                RightACLine.GetComponent<RectTransform>().sizeDelta = new Vector2(differenceVector.magnitude*2.56f, 5); //Needs to be scaled by main canvas (parents) scale
                RightACLine.GetComponent<RectTransform>().pivot = new Vector2(0, 0.5f);
                RightACLine.transform.localPosition = RightAC[i];
                float angle = Mathf.Atan2(differenceVector.y, differenceVector.x) * Mathf.Rad2Deg;
                RightACLine.GetComponent<RectTransform>().rotation = Quaternion.Euler(0, 0, angle);
                RightACLine.GetComponent<Image>().color = Color.red;
            }
        }

        if (LeftAC.Count != 1)
        {
            LeftAC.Sort((a, b) => a.x.CompareTo(b.x)); //Sort list of vector3's by x component

            for (var i = 0; i < LeftAC.Count - 1; i++)
            {
                GameObject LeftACLine = Instantiate(Resources.Load("Square")) as GameObject;
                LeftACLine.transform.SetParent(GameObject.Find("MainCanvas").transform);
                Vector3 differenceVector = LeftAC[i + 1] - LeftAC[i];
                LeftACLine.GetComponent<RectTransform>().sizeDelta = new Vector2(differenceVector.magnitude * 2.56f, 5); //Needs to be scaled by main canvas (parents) scale
                LeftACLine.GetComponent<RectTransform>().pivot = new Vector2(0, 0.5f);
                LeftACLine.transform.localPosition = LeftAC[i];
                float angle = Mathf.Atan2(differenceVector.y, differenceVector.x) * Mathf.Rad2Deg;
                LeftACLine.GetComponent<RectTransform>().rotation = Quaternion.Euler(0, 0, angle);
                LeftACLine.GetComponent<Image>().color = Color.blue;
            }
        }

        if (RightBC.Count != 1)
        {
            RightBC.Sort((a, b) => a.x.CompareTo(b.x)); //Sort list of vector3's by x component

            for (var i = 0; i < RightBC.Count - 1; i++)
            {
                GameObject RightBCLine = Instantiate(Resources.Load("Dash")) as GameObject;
                RightBCLine.transform.SetParent(GameObject.Find("MainCanvas").transform);
                Vector3 differenceVector = RightBC[i + 1] - RightBC[i];
                RightBCLine.GetComponent<RectTransform>().sizeDelta = new Vector2(differenceVector.magnitude * 2.56f, 20); //Needs to be scaled by main canvas (parents) scale
                RightBCLine.GetComponent<RectTransform>().pivot = new Vector2(0, 0.5f);
                RightBCLine.transform.localPosition = RightBC[i];
                float angle = Mathf.Atan2(differenceVector.y, differenceVector.x) * Mathf.Rad2Deg;
                RightBCLine.GetComponent<RectTransform>().rotation = Quaternion.Euler(0, 0, angle);
                RightBCLine.GetComponent<Image>().color = Color.red;
            }
        }

        if (LeftBC.Count != 1)
        {
            LeftBC.Sort((a, b) => a.x.CompareTo(b.x)); //Sort list of vector3's by x component

            for (var i = 0; i < LeftBC.Count - 1; i++)
            {
                GameObject RightBCLine = Instantiate(Resources.Load("Dash")) as GameObject;
                RightBCLine.transform.SetParent(GameObject.Find("MainCanvas").transform);
                Vector3 differenceVector = LeftBC[i + 1] - LeftBC[i];
                RightBCLine.GetComponent<RectTransform>().sizeDelta = new Vector2(differenceVector.magnitude * 2.56f, 20); //Needs to be scaled by main canvas (parents) scale
                RightBCLine.GetComponent<RectTransform>().pivot = new Vector2(0, 0.5f);
                RightBCLine.transform.localPosition = LeftBC[i];
                float angle = Mathf.Atan2(differenceVector.y, differenceVector.x) * Mathf.Rad2Deg;
                RightBCLine.GetComponent<RectTransform>().rotation = Quaternion.Euler(0, 0, angle);
                RightBCLine.GetComponent<Image>().color = Color.blue;
            }
        }
    }
}
