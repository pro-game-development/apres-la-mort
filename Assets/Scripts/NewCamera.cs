using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class NewCamera : MonoBehaviour
{
    public GameObject cameraPrefab;
    public GameObject cameraBroken;
    public TextMeshProUGUI needPiecesMessage;
    public TextMeshProUGUI putCameraMessage;
    private bool isColliding = false;

    void Start(){
        needPiecesMessage.gameObject.SetActive(false);
        putCameraMessage.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(isColliding && Gamepad.current != null && Gamepad.current.buttonWest.wasPressedThisFrame){
            Inventory inventory = Resources.Load<Inventory>("Inventory");
           
            if(inventory.inventory.Contains("CameraPiece2") && inventory.inventory.Contains("CameraPiece1")){
                Destroy(cameraBroken);
            }
            else {
                putCameraMessage.gameObject.SetActive(false);
                needPiecesMessage.gameObject.SetActive(true);
            }
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            putCameraMessage.gameObject.SetActive(true);
            isColliding = true;
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            putCameraMessage.gameObject.SetActive(false);
            needPiecesMessage.gameObject.SetActive(false);
            isColliding = false;
        }
    }
}
// Vector3(-11.2880001,6.375,-3.94499993)