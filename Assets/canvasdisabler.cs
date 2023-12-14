using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CanvasDisabler : MonoBehaviour
{
    public Canvas canvasToDisable;
    public float delay = 2f;

    // Referensi ke script HoldTeleport
    public cobaholdlogic holdTeleportScript;

    private void Start()
    {
        StartCoroutine(DisableCanvasAfterDelay());
    }

    private IEnumerator DisableCanvasAfterDelay()
    {
        yield return new WaitForSeconds(delay);

        // Mengakses variabel isHolding2 dari HoldTeleport
        if (holdTeleportScript != null)
        {
            holdTeleportScript.isHolding2 = false;
        }

        // Menonaktifkan canvas
        canvasToDisable.gameObject.SetActive(false);
    }
}
