using UnityEngine;
using System.Collections;

public class CustomPatternCreationButton : MonoBehaviour {
    public float theta_scale = 0.01f;        //Set lower to add more points
    public int size; //Total number of points in circle
    public float radius = 3f;
    LineRenderer lineRenderer;
    public Color c1 = Color.black;
    public Color c2 = new Color(1, 1, 1, 0);
    public GameObject canvasSheet;

    void OnMouseDown()
    {
        float sizeValue = (2.0f * Mathf.PI) / theta_scale;
        size = (int)sizeValue;
        size++;
        lineRenderer = gameObject.AddComponent<LineRenderer>();
        //lineRenderer.material = new Material(Shader.Find("Materials/Menu"));
        lineRenderer.SetWidth(0.02f, 0.02f); //thickness of line
        lineRenderer.SetVertexCount(size);
        

        Vector3 pos;
        float theta = 0f;
        for (int i = 0; i < size; i++)
        {
            theta += (2.0f * Mathf.PI * theta_scale);
            float x = radius * Mathf.Cos(theta);
            float y = radius * Mathf.Sin(theta);
            x += canvasSheet.transform.position.x;
            y += canvasSheet.transform.position.y;
            float z = canvasSheet.transform.position.z - 0.1f;
            pos = new Vector3(x, y, z);
            lineRenderer.SetColors(c1, c1);
            lineRenderer.SetPosition(i, pos);
        }
    }
}
