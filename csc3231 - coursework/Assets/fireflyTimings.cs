using UnityEngine;

public class fireflyBehaviour : MonoBehaviour
{
    public ParticleSystem particleSystem;
    public float onDuration = 15f;  
    public float offDuration = 15f; 

    private float timer = 8f;
    private bool isParticlesOn = false;

    void Update()
    {
        timer += Time.deltaTime;

        // Check if it's time to toggle particles
        if (timer >= (isParticlesOn ? onDuration : offDuration))
        {
            isParticlesOn = !isParticlesOn;

            timer = 0f;

            if (isParticlesOn)
            {
                particleSystem.Play();
            }
            else
            {
                particleSystem.Stop();
            }
        }
    }
}
