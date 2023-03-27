using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using TMPro;

public class EnterPuzzle : MonoBehaviour
{
    public float interactionRange = 3f;
    public string objectTag;
    public Movement playerMovement;

    //Piano text
    public TextMeshProUGUI playPianoText;
    public TextMeshProUGUI needMusicSheetText;
    public TextMeshProUGUI gotCameraPiece;

    public Camera pianoCamera;
    public Camera pianoRoomCamera;  

    //Instructions
    public TextMeshProUGUI closePiano;

    private int hasWonAux = 0;

    //Piano Images
    #region PianoImages
    public Image imgButtonA;
    public Image imgButtonB;
    public Image imgButtonX;
    public Image imgButtonY;
    public Image imgButtonDpadUp;
    public Image imgButtonDpadDown;
    public Image imgButtonDpadLeft;
    public Image imgButtonDpadRight;
    public Image imgButtonLT;
    public Image imgButtonLB;
    public Image imgButtonRT;
    #endregion 

    //Piano Scripts
    #region PianoScripts
    public Script_DO2_Note do2Script;
    public Script_DO_Note doScript;
    public Script_FA_Note faScript;
    public Script_LA_Note laScript;
    public Script_LA2_Note la2Script;
    public Script_MI_Note miScript;
    public Script_RE_Note reScript;
    public Script_RE2_Note re2Script;
    public Script_SI_Note siScript;
    public Script_SI2_Note si2Script;
    public Script_SOL_Note solScript;
    #endregion

    public bool isInPiano = false;
    private void Start(){

        //Piano text
        playPianoText.gameObject.SetActive(false);
        needMusicSheetText.gameObject.SetActive(false);
        gotCameraPiece.gameObject.SetActive(false);
    }

    private void Update()
    {
        PlayerHP playerHP = GameObject.FindWithTag("Player").GetComponent<PlayerHP>();

        if(Song.hasWon == true){
            if(hasWonAux == 0){
                pianoCamera.gameObject.SetActive(false);
                pianoRoomCamera.gameObject.SetActive(true);
                hasWonAux = 1;
                gotCameraPiece.gameObject.SetActive(true);
                playerMovement.enabled = true;
                DeactivatePiano();
            }
            return;
        }

        if((isInPiano && Gamepad.current != null && Gamepad.current.selectButton.wasPressedThisFrame) || isInPiano && playerHP.hp <= 0){
            pianoCamera.gameObject.SetActive(false);
            pianoRoomCamera.gameObject.SetActive(true);
            isInPiano = false;
            if(playerHP.hp>0){
                playerMovement.enabled = true;
            }
            DeactivatePiano();
        }

        if (Vector3.Distance(transform.position, PlayerManager.instance.player.transform.position) <= interactionRange && Gamepad.current != null && Gamepad.current.buttonWest.wasPressedThisFrame && !isInPiano)
        {
            Inventory inventory = Resources.Load<Inventory>("Inventory");
            // IsPuzzle isPuzzle = new IsPuzzle();

            playPianoText.gameObject.SetActive(false);
           
            if(inventory.inventory.Contains("MusicSheet")){
                playerMovement.enabled = false;

                //Cameras
                Camera activeCamera = Camera.current;
                activeCamera.gameObject.SetActive(false);
                pianoCamera.gameObject.SetActive(true);

                //canvas
                closePiano.gameObject.SetActive(true);

                #region PianoImages
                imgButtonA.gameObject.SetActive(true);
                imgButtonB.gameObject.SetActive(true);
                imgButtonX.gameObject.SetActive(true);
                imgButtonY.gameObject.SetActive(true);
                imgButtonDpadUp.gameObject.SetActive(true);
                imgButtonDpadDown.gameObject.SetActive(true);
                imgButtonDpadLeft.gameObject.SetActive(true);
                imgButtonDpadRight.gameObject.SetActive(true);
                imgButtonLT.gameObject.SetActive(true);
                imgButtonLB.gameObject.SetActive(true);
                imgButtonRT.gameObject.SetActive(true);
                #endregion

                #region PianoScripts
                do2Script.enabled = true;
                doScript.enabled = true;
                faScript.enabled = true;
                laScript.enabled = true;
                la2Script.enabled = true;
                miScript.enabled = true;
                reScript.enabled = true;
                re2Script.enabled = true;
                siScript.enabled = true;
                si2Script.enabled = true;
                solScript.enabled = true;
                #endregion

                needMusicSheetText.gameObject.SetActive(false);

                isInPiano = true;
            }
            else{
                needMusicSheetText.gameObject.SetActive(true);
                return;
            }
        }

        else if (Vector3.Distance(transform.position, PlayerManager.instance.player.transform.position) <= interactionRange)
        {
            if(!isInPiano){
                playPianoText.gameObject.SetActive(true);
            }
        }

        else
        {
            DeactivatePiano();
        }
    }

    void DeactivatePiano(){
            playPianoText.gameObject.SetActive(false);
            needMusicSheetText.gameObject.SetActive(false);

            closePiano.gameObject.SetActive(false);

            #region PianoImages
            imgButtonA.gameObject.SetActive(false);
            imgButtonB.gameObject.SetActive(false);
            imgButtonX.gameObject.SetActive(false);
            imgButtonY.gameObject.SetActive(false);
            imgButtonDpadUp.gameObject.SetActive(false);
            imgButtonDpadDown.gameObject.SetActive(false);
            imgButtonDpadLeft.gameObject.SetActive(false);
            imgButtonDpadRight.gameObject.SetActive(false);
            imgButtonLT.gameObject.SetActive(false);
            imgButtonLB.gameObject.SetActive(false);
            imgButtonRT.gameObject.SetActive(false);
            #endregion

            #region PianoScripts
            do2Script.enabled = false;
            doScript.enabled = false;
            faScript.enabled = false;
            laScript.enabled = false;
            la2Script.enabled = false;
            miScript.enabled = false;
            reScript.enabled = false;
            re2Script.enabled = false;
            siScript.enabled = false;
            si2Script.enabled = false;
            solScript.enabled = false;
            #endregion

            StartCoroutine(GotCameraCoroutine());
    }

    IEnumerator GotCameraCoroutine()
    {
        yield return new WaitForSeconds(2);
        gotCameraPiece.gameObject.SetActive(false);
        // Rest of the code here
    }
}
