using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIManagerButton : MonoBehaviour
{
    private GameObject buttonPlay, buttonSettings, buttonCredits;

    private Vector3 speedButton;
    private Vector3 buttonSettingsPosition, buttonPlayPosition;

    private bool canGo;

    void Start()
    {
        this.buttonPlay = GameObject.FindGameObjectWithTag("ButtonPlay");
        this.buttonSettings = GameObject.FindGameObjectWithTag("ButtonSettings");
        this.buttonCredits = GameObject.FindGameObjectWithTag("ButtonCredits");

        this.speedButton = new Vector3 (6,0,0);
        this.canGo = true;
    }

    void FixedUpdate()
    {
        MoveButton();
    }

    public void PlayGame()
    {
        Application.LoadLevel("Game");
    }

    public void Settings()
    {
        Debug.Log("Settings");
    }

    public void Credits()
    {
        Debug.Log("Credits");
    }

    void MoveButton()
    {
        if (this.canGo)
        {
            if (this.gameObject == buttonSettings)
            {
                buttonSettings.transform.position += speedButton;

                if(buttonSettings.transform.position.x >= (Screen.width / 4))
                    this.canGo = false;
            }

            else if (this.gameObject == this.buttonPlay)
            {
                this.buttonPlay.transform.position -= this.speedButton;

                if(this.buttonPlay.transform.position.x  <= (Screen.width / 1.8f))
                    this.canGo = false;
            }

            else if (this.gameObject == this.buttonCredits)
            {
                this.buttonCredits.transform.position -= this.speedButton;

                if(this.buttonCredits.transform.position.x <= (Screen.width/1.3f))
                    this.canGo = false;
            }
                
        }
    }
}
