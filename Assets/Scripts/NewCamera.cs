using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;

public class NewCamera : MonoBehaviour
{
    public GameObject cameraPrefab;
    public GameObject cameraBroken;
    public GameObject blanket;
    public TextMeshProUGUI needPiecesMessage;
    public TextMeshProUGUI putCameraMessage;
    public TextMeshProUGUI takePictureMessage;
    private bool isColliding = false;
    private bool cameraPlaced = false;
    public Camera corpseCamera;
    public AudioSource cameraClick;

    void Start(){
        needPiecesMessage.gameObject.SetActive(false);
        putCameraMessage.gameObject.SetActive(false);
        takePictureMessage.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(isColliding && Gamepad.current != null && Gamepad.current.buttonWest.wasPressedThisFrame){
            Inventory inventory = Resources.Load<Inventory>("Inventory");
            Vector3 cameraPosition = new Vector3(-6.59695625f,1.722f,-16.8862514f);
            Quaternion rotation = Quaternion.Euler(0f, -80f, 0f);
            Camera activeCamera = Camera.current;

            if(cameraPlaced){
                
                StartCoroutine(TakePictureCorutine());
                
            }
           
            if(inventory.inventory.Contains("CameraPiece2") && inventory.inventory.Contains("CameraPiece1")){
                Destroy(cameraBroken);
                Destroy(blanket);
                GameObject newObject = Instantiate(cameraPrefab,cameraPosition,rotation);
                putCameraMessage.gameObject.SetActive(false);
                takePictureMessage.gameObject.SetActive(true);
                activeCamera.gameObject.SetActive(false);
                corpseCamera.gameObject.SetActive(true);
                cameraPlaced=true;
            }
            else {
                putCameraMessage.gameObject.SetActive(false);
                needPiecesMessage.gameObject.SetActive(true);
            }
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            if(cameraPlaced){
                takePictureMessage.gameObject.SetActive(true);
            }
            else{
                putCameraMessage.gameObject.SetActive(true);
            }
            isColliding = true;
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            putCameraMessage.gameObject.SetActive(false);
            needPiecesMessage.gameObject.SetActive(false);
            takePictureMessage.gameObject.SetActive(false);
            isColliding = false;
        }
    }

    IEnumerator TakePictureCorutine()
    {
        cameraClick.Play();
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("WinScene");
        // Rest of the code here
    }
}
// 