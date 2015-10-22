using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MenuOptions : MonoBehaviour {
    
    public GameObject canvasSheet;
    public Texture2D[] patterns;
    //ArrayList  patterns= new ArrayList();
    private bool isClicked = false;
    private int ClickCounter = 0;

    public float angle = 0;
    public Vector2 size = new Vector2(128, 128);
    public Vector2 relativePosition = new Vector2(0, 0);
    Vector2 pos = new Vector2(0, 0);
    Rect rect;
    Vector2 pivot;
    int hit = 0;

    // Added new parameters
    public float radius;
    public float patternSize;
    public int noPoints;

    void Start()
    {
        UpdateSettings();
        radius = 400f;
        patternSize = 100f;
        noPoints = 21;
    }

    void UpdateSettings()
    {
        pos = new Vector2(Screen.width/2, Screen.height/2);
        //rect = new Rect(pos.x - size.x * 0.5f, pos.y - size.y * 0.5f, size.x, size.y);
        //pivot = new Vector2(rect.xMin + rect.width * 0.5f, rect.yMin + rect.height * 0.5f);
    }

    public void drawPattern1()
    {
        isClicked = true;
        ClickCounter++;
        Debug.Log(ClickCounter);
        hit = 0;
    }
    public void drawPattern2()
    {
        isClicked = true;
        ClickCounter++;
        Debug.Log(ClickCounter);
        hit = 1;
    }
    public void drawPattern3()
    {
        isClicked = true;
        ClickCounter++;
        Debug.Log(ClickCounter);
        hit = 2;
    }
    public void drawPattern4()
    {
        isClicked = true;
        ClickCounter++;
        Debug.Log(ClickCounter);
        hit = 3;
    }
    public void drawPattern5()
    {
        isClicked = true;
        ClickCounter++;
        Debug.Log(ClickCounter);
        hit = 4;
    }
    public void drawPattern6()
    {
        isClicked = true;
        ClickCounter++;
        Debug.Log(ClickCounter);
        hit = 5;
    }
    public void drawPattern7()
    {
        isClicked = true;
        ClickCounter++;
        Debug.Log(ClickCounter);
        hit = 6;
    }
    public void drawPattern8()
    {
        isClicked = true;
        ClickCounter++;
        Debug.Log(ClickCounter);
        hit = 7;
    }
    public void drawPattern9()
    {
        isClicked = true;
        ClickCounter++;
        Debug.Log(ClickCounter);
        hit = 8;
    }
    public void drawPattern10()
    {
        isClicked = true;
        ClickCounter++;
        Debug.Log(ClickCounter);
        hit = 9;
    }
    public void drawPattern11()
    {
        isClicked = true;
        ClickCounter++;
        Debug.Log(ClickCounter);
        hit = 10;
    }

    public void adjustRadius(float newRadius)
    {
        radius = newRadius;
    }
    public void adjustPatternSize(float newPatternSize)
    {
        patternSize = newPatternSize;
    }
    public void adjustNoOfPoints(float newNoOfPoints)
    {
        noPoints =(int) newNoOfPoints;
        Debug.Log(noPoints);
    }

    void OnGUI()
    {
        //noPoints=21;
        int degrees = 45;

        if (isClicked)
        {
            if (ClickCounter >= 1)
            {
                for (int i = 0; i < noPoints; i++)
                {
                    if (Application.isEditor)
                    {
                        UpdateSettings();
                    }
                    Matrix4x4 matrixBackup = GUI.matrix;
                    Rect r2 = new Rect(new Vector2(radius * Mathf.Cos(degrees * Mathf.PI / 180) + Screen.width / 2, radius * Mathf.Sin(degrees * Mathf.PI / 180) + Screen.height / 2), new Vector2(patternSize, patternSize));
                    GUIUtility.RotateAroundPivot(degrees+98, new Vector2(radius * Mathf.Cos(degrees * Mathf.PI / 180) + Screen.width / 2, radius * Mathf.Sin(degrees * Mathf.PI / 180) + Screen.height / 2));
                    GUI.DrawTexture(r2, patterns[hit]);
                    GUI.matrix = matrixBackup;
                    degrees += 18;
                }
            }
        }
    }
}
