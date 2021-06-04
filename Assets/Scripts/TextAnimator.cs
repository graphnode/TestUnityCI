using UnityEngine;

namespace TestUnityCI
{
    public class TextAnimator : MonoBehaviour
    {
        private void Start()
        {
            LeanTween.rotateY(gameObject, 20f, 5f)
                .setFrom(-20f)
                .setEase(LeanTweenType.easeInOutQuad)
                .setLoopPingPong();

            LeanTween.rotateZ(gameObject, 10f, 4f)
                .setFrom(-10f)
                .setEase(LeanTweenType.easeInOutQuad)
                .setLoopPingPong();

            LeanTween.moveLocalY(gameObject, 1f, 5f)
                .setFrom(-1f)
                .setEase(LeanTweenType.easeInOutCubic)
                .setLoopPingPong();
        }
    }
}
