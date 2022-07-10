using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{

    [SerializeField]
    private GameObject instructionPanel;
    [SerializeField]
    private TextMeshProUGUI instructionTitle;
    [SerializeField]
    private TextMeshProUGUI instructionText;

    [SerializeField]
    private string[] titles;
    [SerializeField]
    private string[] instructions;
    [SerializeField]
    private GameObject[] pictureInPictureCameras;

    [SerializeField]
    private Animator anim;
   
    
    public void CloseInstructionPanel()
    {
        instructionPanel.SetActive(false);
    }


    public void OnButtonClickActions(int idx)
    {
        instructionPanel.SetActive(true);

        switch(idx)
        {
            case 0:
            case 1:
            case 4:
                anim.SetBool("LeftDoor", false);
                anim.SetBool("RightDoor", false);
                instructionTitle.text = titles[idx];
                instructionText.text = instructions[idx];
                foreach (GameObject g in pictureInPictureCameras)
                    g.SetActive(false);

                pictureInPictureCameras[idx].SetActive(true);
                break;

            case 2:
                anim.SetBool("RightDoor", false);
                anim.SetBool("LeftDoor", true);
                instructionTitle.text = titles[idx];
                instructionText.text = instructions[idx];
                foreach (GameObject g in pictureInPictureCameras)
                    g.SetActive(false);

                pictureInPictureCameras[idx].SetActive(true);
                break;
            case 3:
                anim.SetBool("LeftDoor", false);
                anim.SetBool("RightDoor", true);
                instructionTitle.text = titles[idx];
                instructionText.text = instructions[idx];
                foreach (GameObject g in pictureInPictureCameras)
                    g.SetActive(false);

                pictureInPictureCameras[idx].SetActive(true);
                break;
        }
    }

    public void ApplicationClose()
    {
        Application.Quit();
    }
}
