using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ItemCollector: MonoBehaviour
{
    private int kiwies = 0;

    [SerializeField] private Text KiwiesText;
    [SerializeField] private AudioSource collectingSoundEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
            if (collision.gameObject.CompareTag("kiwi"))
        {
            collectingSoundEffect.Play();
            Destroy(collision.gameObject);
            kiwies++;   
            KiwiesText.text = "kiwies:" + kiwies;    
        }
    }
}
