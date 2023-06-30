using UnityEngine;

public class Simulator : MonoBehaviour
{
    public float horizontalSpeed;
    public float verticalSpeed;
    public GameObject cam;
    private float rotX;
    private float rotY;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float mouseX = Input.GetAxis("Mouse X") * horizontalSpeed;
            float mouseY = Input.GetAxis("Mouse Y") * verticalSpeed;

            rotY += mouseX;
            rotX -= mouseY;

            cam.transform.localEulerAngles = new Vector3(rotX, rotY, 0f);
        }
    }
}
