using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Encrypted text : " + Encryption.EncryptDecrypt("TESTING TESTING", 420));

        //The string used here is the one we get logged on the line above. - "TESTING TESTING"
        Debug.Log("Decrypted text : " + Encryption.EncryptDecrypt("ǰǡǷǰǭǪǣƄǰǡǷǰǭǪǣ", 420));
    }
}
