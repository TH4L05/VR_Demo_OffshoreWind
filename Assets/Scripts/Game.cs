using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Game : MonoBehaviour
{
    [SerializeField] private PlayableDirector director;
    [SerializeField] private float startdelay = 2.0f;
    [SerializeField] private bool allowQuitGameWithEscapeKey;
    [SerializeField] private bool showStartLogo = true;

    void Start()
    {
        if (!showStartLogo) return;
        StartCoroutine("StartDirector");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && allowQuitGameWithEscapeKey)
        {
            IngameMenu.Quit();
        }
    }

    private IEnumerator StartDirector()
    {
        yield return new WaitForSeconds(startdelay);
        if(director != null && director.playableAsset != null) director.Play();
    }
}
