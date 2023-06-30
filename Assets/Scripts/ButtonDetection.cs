using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonDetection : MonoBehaviour
{
    public int nextRoom;
    public Button button;
    public Image buttonImage;
    public ObjectSelection objectSelection;
    public Guide guide;
    
    public void OnPointEnter()
    {
        buttonImage.color = Color.green;
        objectSelection.StartObjectSelection();
        objectSelection.OnObjectSelection += OnPointClick;
    }
    
    public void OnPointExit()
    {
        buttonImage.color = Color.white;
        objectSelection.OnObjectSelection -= OnPointClick;
    }
    
    public void OnPointClick()
    {
        button.onClick.AddListener(delegate { guide.GoToRoom(nextRoom); });
        button.onClick.Invoke();
    }
}
