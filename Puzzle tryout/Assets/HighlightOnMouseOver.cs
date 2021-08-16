using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightOnMouseOver : MonoBehaviour
{
    Renderer[] renderers;
    private void Start()
    {
        renderers = GetComponentsInChildren<Renderer>();
        foreach (Renderer r in renderers)
        {
            r.material.EnableKeyword("_EMISSION");
        }
    }

    private void OnMouseEnter()
    {
        foreach (Renderer r in renderers)
        {
            r.material.SetColor("_EmissionColor", Color.gray);
        }
    }

    private void OnMouseExit()
    {
        foreach (Renderer r in renderers)
        {
            r.material.SetColor("_EmissionColor", Color.black);
        }
    }
}
