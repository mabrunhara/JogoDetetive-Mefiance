using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cozinheiro : MonoBehaviour {

    public Transform characterBody;
    public Transform characterHead;

    float sensitivityX = 1.0f;
    float sensitivityY = 0f;

    float rotationX = 0;
    float rotationY = 0;

    float angleYmin = 0;
    float angleYmax = 0;

    float smoothRotx = 0;
    float smoothRoty = 0;

    float smoothCoefx = 0.1f;
    float smoothCoefy = 0f;

    void Start() {

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }

    private void LateUpdate() {
        transform.position = characterHead.position;
    }

    void Update() {

     float verticalDelta = Input.GetAxisRaw("Mouse Y") * sensitivityY;
        float horizontalDelta = Input.GetAxisRaw("Mouse X") * sensitivityX;

        smoothRotx = Mathf.Lerp(smoothRotx, horizontalDelta, smoothCoefx);
        smoothRoty = Mathf.Lerp(smoothRoty, verticalDelta, smoothCoefy);

        rotationX += smoothRotx;
        rotationY += smoothRoty;

        rotationY = Mathf.Clamp(rotationY, angleYmin, angleYmax);

        characterBody.localEulerAngles = new Vector3(0, rotationX, 0);

        transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);

    }

}
