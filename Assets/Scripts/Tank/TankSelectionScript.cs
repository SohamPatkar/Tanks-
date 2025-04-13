using UnityEngine;
using UnityEngine.UI;

public class TankSelectionScript : MonoBehaviour
{
    [SerializeField] private TankSpawner tankSpawner;
    [SerializeField] private GameObject mainMenu, tankSelection;

    public void BlueTank()
    {
        tankSpawner.CreateTank(TankTypes.BLUETANK);
        SoundManager.Instance.PlaySfxSound(SoundType.BUTTONCLICK);
        CloseGameObject();
    }

    public void GreenTank()
    {
        tankSpawner.CreateTank(TankTypes.GREENTANK);
        SoundManager.Instance.PlaySfxSound(SoundType.BUTTONCLICK);
        CloseGameObject();
    }

    public void RedTank()
    {
        tankSpawner.CreateTank(TankTypes.REDTANK);
        SoundManager.Instance.PlaySfxSound(SoundType.BUTTONCLICK);
        CloseGameObject();
    }

    public void StartGame()
    {
        SoundManager.Instance.PlaySfxSound(SoundType.BUTTONCLICK);
        mainMenu.SetActive(false);
        tankSelection.SetActive(true);
    }

    public void CloseGame()
    {
        SoundManager.Instance.PlaySfxSound(SoundType.BUTTONCLICK);
#if (UNITY_EDITOR)
        UnityEditor.EditorApplication.isPlaying = false;
#elif (UNITY_STANDALONE)
            Application.Quit();
#elif (UNITY_WEBGL)
            Application.OpenURL("about:blank");
#endif
    }

    public void CloseGameObject()
    {
       this.gameObject.SetActive(false);
    }
}
