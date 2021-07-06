using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInputHandler))]
public class PlayerRotation : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private float smoothTime = 10.0f;

    public Vector3 LookDirection { get; private set; }
    private PlayerInputHandler input;    

    private void Awake() => input = gameObject.GetComponent<PlayerInputHandler>();    

    public void HandleRotation()
    {
        Vector2 mousePos = input.MousePosition;
        
        RaycastHit hit;
        Ray mouseRay = mainCamera.ScreenPointToRay(mousePos);

        if (Physics.Raycast(mouseRay, out hit))
        {   
            float posZ = hit.point.z;
            float posX = hit.point.x;

            LookDirection = new Vector3(posX, 0, posZ) - transform.position;

            // Creates the quaternion - angle to rotate between the look direction and player position
            Quaternion rotation = Quaternion.LookRotation(LookDirection);

            rotation.x = 0;
            rotation.z = 0;

            // Create a smooth rotation between two quaternions
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * smoothTime);

            /* Optional  - Takes away the smoothness between directions when looking at empty spaces
            transform.LookAt (lookDirection);
            */
        }
    }
}
