using System;
using DG.Tweening;
using UnityEngine;

namespace FoxC
{
    [RequireComponent(typeof(CanvasGroup))]
    public class WindowView : MonoBehaviour
    {
        protected CanvasGroup _canvasGroup;

        protected virtual void Awake()
        {
            _canvasGroup = GetComponent<CanvasGroup>();

        }

        public void Show()
        {
            _canvasGroup.DOFade(1f, 1f).From(0).SetEase(Ease.InOutSine);
        }

        public void Hide(Action onComplete)
        {
            _canvasGroup.DOFade(0, 1f).From(1f).SetEase(Ease.InOutSine).OnComplete(() => onComplete.Invoke());
        }
    }
}