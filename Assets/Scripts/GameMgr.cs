using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMgr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        GameObject btnBack = GameObject.Find("/CanvasDontDestroy");
        Debug.Log(btnBack);
        DontDestroyOnLoad(btnBack);

        Screen.orientation = ScreenOrientation.AutoRotation;
        Screen.autorotateToLandscapeLeft = true;
        Screen.autorotateToLandscapeRight = true;
        Screen.autorotateToPortrait = false;
        Screen.autorotateToPortraitUpsideDown = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnControlsClick()
    {
        SceneManager.LoadScene("Controls");
    }

    public void OnDragAndDropClick()
    {
        SceneManager.LoadScene("Drag And Drop");
    }

    public void OnDraggablePanelClick()
    {
        SceneManager.LoadScene("Draggable Panel");
    }

    public void OnLayoutGroupClick()
    {
        SceneManager.LoadScene("Layout Groups");
    }

    public void OnLightingClick()
    {
        SceneManager.LoadScene("Lighting");
    }

    public void OnMenu3DClick()
    {
        SceneManager.LoadScene("Menu 3D");
    }

    public void OnRenderTextureClick()
    {
        SceneManager.LoadScene("RenderTexture");
    }

    public void OnBackClick()
    {
        SceneManager.LoadScene("Demo");
    }
}
