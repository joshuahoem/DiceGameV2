using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clipboard : MonoBehaviour
{
    //Numbers

    //States
    bool moveUp = false;

    //Cache
    [SerializeField] GameObject clipboardGameObject, clipboardBackground;

    private void Start() {
        clipboardBackground.SetActive(false);
    }
    public void MoveClipBoard()
    {  
        moveUp = !moveUp;  
        clipboardGameObject.GetComponent<Animator>().SetBool("moveUp",moveUp);
    }

    public void ClipboardBackground()
    {
        clipboardBackground.SetActive(moveUp);
    }
}
