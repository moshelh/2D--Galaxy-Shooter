using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
   
    private void OnTriggerEnter2D(Collider2D other) {

        if (other.tag == triggeringTag && enabled) {
            if (this.tag == "Player")
            {
                if (Life.life.numOfLife == 1)
                {
                    Life.life.decreaseLife();
                    Destroy(this.gameObject);
                    Destroy(other.gameObject);
                }
                else
                {
                    Life.life.decreaseLife();
                    Destroy(other.gameObject);
                }
            }
            else
            {
                Destroy(this.gameObject);
                Destroy(other.gameObject);
            }
           

        }
    }
}
