using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultInspectorExpanding : MonoBehaviour
{
    // Apply a nice header to improve readibility
    [Header("Header")]
    public float floatA = 4.20f;
    public float floatB = 6.9f;

    [Header("Another Header")]
    // Test Range in Inspector
    [Range(0,100)]
    public float range = 50f;

    [Header("Lorem Ipsum dings")]
    
    // Apply 20px space above since why not?
    [Space(20f)]
    public string text = "Lorem Ipsum";
    
    // Let's try TextArea for larger text
    // NOTE: Can also be called like a method, with minLines and maxLines passed into it
    [TextArea(1,5)]
    public string textArea = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. \nAnd a new line";

    // Almost same as TextArea, but without word wrapping and is indented 
    [Multiline(4)]
    public string multiLine = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. \nAnd a new line";

    [HideInInspector]
    public string hidden = "Only visible in code";

    [Space]
    [Header("Color")]
    public Color color = Color.white;
    // Enable HDR
    [ColorUsage(false, true)]
    public Color colorHDR = Color.green;

#if UNITY_EDITOR
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
#endif
}
