using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This following line of code adds our Scriptable Object as an option in the Asset menu.
[CreateAssetMenu(fileName="New SO",menuName="Scriptable Object")]
// [CreateAssetMenu(fileName="New SO",menuName="Scriptable Objects/Create New Object")]

public class SO : ScriptableObject // Notice how we change the inheritance from MonoBehaviour to ScriptableObject
{

    // Scriptable Objects like Mono scripts can contain variables.

    public new string name;
    public string description;

    public GameObject model;

    public Color color;

    // Scriptable Objects do not use MonoBehaviour callbacks such as Start() and Update().

    // Scriptable objects can also contain functions and conditionals.

    /* private void PrintOut(string name, string description)
    {
        Debug.Log (name + " "+ description)
        if(name == "Chuck Norris")
        {
            Debug.Log("Chuck Norris allows this program to run!");
        }
    } */
}
