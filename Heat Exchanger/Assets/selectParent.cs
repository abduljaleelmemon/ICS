
 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEditor;
public class selectParent : MonoBehaviour
{
    // Start is called before the first frame updates
     static void SelectParentOfObject()
     {
         Selection.activeGameObject = Selection.activeGameObject.transform.parent.gameObject;
        
     }
}
