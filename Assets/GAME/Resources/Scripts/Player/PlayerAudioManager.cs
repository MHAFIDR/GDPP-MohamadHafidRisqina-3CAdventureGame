using UnityEngine;

public class PlayerAudioManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource _footstepSfx;
    [SerializeField]
    private AudioSource _glideSfx;

    private void PlayFootstepSfx()
    {
        _footstepSfx.volume = Random.Range(0.7f, 1f);
        _footstepSfx.pitch = Random.Range(0.5f, 2.5f);
        _footstepSfx.Play();
    }

    public void PlayGlideSfx()
    {
        _glideSfx.Play();
    }
    
    public void StopGlideSfx()
    {
        _glideSfx.Stop();
    }
}