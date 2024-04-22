using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class InteractCube : MonoBehaviour
{
    [SerializeField] public CurrencySystem currencySystem;

    public ParticleSystem particleEffect;
    public float particleDuration = 0.2f;
    public AudioClip clickSoundEffect;
    public AudioSource source;

    public float scaleFactor = 1.2f;
    public float scaleDuration = 0.1f;

    private Vector3 originalScale;

    private bool isRunning = false;

    private void Start()
    {
        originalScale = transform.localScale;
    }

    private void OnMouseDown()
    {
        if (isRunning == false)
        {
            StartCoroutine(ScaleObject());
            source.PlayOneShot(clickSoundEffect);
        }
    }

    private IEnumerator ScaleObject()
    {
        currencySystem.AddCube();
        ParticleSystem particleEffectPlay = Instantiate(particleEffect, transform.position, Quaternion.identity);
        Destroy(particleEffectPlay.gameObject, particleDuration);
        isRunning = true;
        float timer = 0f;
        Vector3 targetScale = originalScale * scaleFactor;

        while (timer < scaleDuration)
        {
            transform.localScale = Vector3.Lerp(originalScale, targetScale, timer / scaleDuration);
            timer += Time.deltaTime;
            yield return null;
        }
        transform.localScale = targetScale;

        yield return new WaitForSeconds(0f);
        StartCoroutine(ShrinkObject());
    }

    private IEnumerator ShrinkObject()
    {
        float timer = 0f;
        Vector3 targetScale = originalScale;

        while (timer < scaleDuration)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, targetScale, timer / scaleDuration);
            timer += Time.deltaTime;
            yield return null;
        }

        transform.localScale = targetScale;
        isRunning = false;
    }
}
