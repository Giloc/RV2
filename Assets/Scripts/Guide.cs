using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guide : MonoBehaviour
{
    public List<Transform> rooms;

    public void GoToRoom(int room)
    {
        if(room >= rooms.Count) return;

        transform.position = rooms[room].position;
        transform.rotation = rooms[room].localRotation;
    }
}
