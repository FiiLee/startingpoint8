using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    public string itemName; // Name of the item associated with this clickable object
    public int itemValue = 1; // The amount to add when the object is clicked

    private void OnMouseDown()
    {
        // When the object is clicked, notify the ItemManager to update the item count
        ItemManager.Instance.GetItemCount(itemName, itemValue);

        // You can optionally perform other actions here when the object is clicked

        UnityEngine.Debug.Log("Item Clicked: " + itemName);
    }
}
