using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IsPuzzle : MonoBehaviour
{
    //Instructions
    public TextMeshProUGUI clockInstructions;
    public TextMeshProUGUI closePiano;

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

    void Start()
    {
        //Instructions texts
        clockInstructions.gameObject.SetActive(false);
        closePiano.gameObject.SetActive(false);

        //Piano Images
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

        //Piano Scripts
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
    }

    public void showCanvas(string puzzleType){
        if(puzzleType == "Clock"){
            clockInstructions.gameObject.SetActive(true);
        }
        else if(puzzleType == "Piano"){
            
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
        }
    }

    public void hideCanvas(string puzzleType){
        if(puzzleType == "Clock"){
            clockInstructions.gameObject.SetActive(false);
        }
        else if(puzzleType == "Piano"){
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
        }
    }
}
