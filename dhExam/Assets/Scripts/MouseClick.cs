using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    public GameObject bird;

    private void OnMouseDown()
    {
        Destroy(bird);
  
    }
}