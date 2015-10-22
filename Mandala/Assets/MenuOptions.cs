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
    public int noPoints;
    int hit = 0;
    void Start()
    {
        UpdateSettings();
        /* patterns[0] = (Texture2D)Resources.Load("/Patterns/piece1");
           patterns[1] = (Texture2D)Resources.Load("/Patterns/piece2");
           patterns[2] = (Texture2D)Resources.Load("/Patterns/piece3");
           patterns[3] = (Texture2D)Resources.Load("/Patterns/piece4");
           patterns[4] = (Texture2D)Resources.Load("/Patterns/piece5");
           patterns[5] = (Texture2D)Resources.Load("/Patterns/piece6");
           patterns[6] = (Texture2D)Resources.Load("/Patterns/piece7");
           patterns[7] = (Texture2D)Resources.Load("/Patterns/piece8");
           patterns[8] = (Texture2D)Resources.Load("/Patterns/piece9");
           patterns[9] = (Texture2D)Resources.Load("/Patterns/piece10");
           patterns[10] = (Texture2D)Resources.Load("/Patterns/piece11");*/
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

    void OnGUI()
    {
        //float sizeValue = (2.0f * Mathf.PI) / theta_scale;
        //noPoints = (int)sizeValue;
        noPoints=21;
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
                    Rect r2 = new Rect(new Vector2(400 * Mathf.Cos(degrees * Mathf.PI / 180) + Screen.width / 2, 400 * Mathf.Sin(degrees * Mathf.PI / 180) + Screen.height / 2), new Vector2(100f, 100f));
                    GUIUtility.RotateAroundPivot(degrees+98, new Vector2(400 * Mathf.Cos(degrees * Mathf.PI / 180) + Screen.width / 2, 400 * Mathf.Sin(degrees * Mathf.PI / 180) + Screen.height / 2));
                    GUI.DrawTexture(r2, patterns[hit]);
                    GUI.matrix = matrixBackup;
                    degrees += 18;
                }
            }
        }
    }
}
