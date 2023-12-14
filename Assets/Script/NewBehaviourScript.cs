using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ShoppingListButton : MonoBehaviour
{
    public Animator thisAnimator; // Animator untuk tombol ini
    public Animator otherAnimator; // Animator untuk tombol lainnya

    public void OnButtonClick()
    {
        // Memainkan trigger animasi untuk tombol ini
        thisAnimator.SetTrigger("Close");

        // Memainkan trigger animasi untuk tombol lainnya
        otherAnimator.SetTrigger("Open");
    }
}
