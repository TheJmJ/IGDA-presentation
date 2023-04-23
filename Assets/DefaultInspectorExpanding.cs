using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultInspectorExpanding : MonoBehaviour
{
    // Apply a nice header to improve readibility
    [Header("Header")]
    public float floatA = 0.0f;
    public float floatB = 0.0f;

    [Header("Another Header")]
    // Test Range in Inspector
    [Range(0,100)]
    public float range = 50f;

    [Header("Lorem Ipsum dings")]
    
    // Apply space since why not?
    [Space]
    public string text = "Lorem Ipsum";
    
    // Let's try TextArea for larger text
    // NOTE: Can also be called like a method, with minLines and maxLines passed into it
    [TextArea]
    public string textArea = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. ";

    // Almost same as TextArea, but without word wrapping and is indented 
    [Multiline(4)]
    public string multiLine = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. ";

    [HideInInspector]
    public string hidden = "Only visible in code";

    [Space]
    [Header("Color")]
    public Color color = Color.white;
    // Enable HDR
    [ColorUsage(false, true)]
    public Color colorHDR = Color.green;

    // Draw this method in Right-click menu
    [ContextMenu("Randomize Color!")]
    public void RandomizeColor()
    {
        GetComponentInChildren<MeshRenderer>().sharedMaterial.color = new Color(Random.value, Random.value, Random.value);
    }

    [ContextMenu("Apply Color!")]

    public void ApplyColor(bool useHDR = false)
    {
        if(!useHDR)
            GetComponentInChildren<MeshRenderer>().material.color = color;
        else
            GetComponentInChildren<MeshRenderer>().material.color = colorHDR;

    }
}
