using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTutor : MonoBehaviour
{
    [SerializeField] GameObject objectToDestroy;
    
    public void Click()
    {
        Destroy(objectToDestroy);
    }
}
