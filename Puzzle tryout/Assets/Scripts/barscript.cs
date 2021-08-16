using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barscript : MonoBehaviour
{
    public GameObject background;
    public GameObject bar;
    public float maxScale;
    void Start()
    {
        maxScale = background.transform.localScale.y;
    }

    public void setBar(float current, float target)
    {
        float t = current / target;
        t = Mathf.Min(t, 0.995f);
        bar.transform.localScale = new Vector3(bar.transform.localScale.x, Mathf.Lerp(0, maxScale, t), bar.transform.localScale.z);
        bar.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.Lerp(Color.red, Color.green, t));
    }
}
