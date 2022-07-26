using UnityEngine;

namespace Gluon;

public class ImageEffectCtrlCronos : ImageEffectCtrl
{
	[SerializeField]
	private Color stopTimeVignetteColor;

	[SerializeField]
	private float _fadeInStopTime;

	[SerializeField]
	private AnimationCurve stopTimeFadeInCurve;

	[SerializeField]
	private AnimationCurve stopTimeAberrationSizeFadeInCurve;

	[SerializeField]
	private AnimationCurve stopTimeVignetteIntensityFadeInCurve;

	[SerializeField]
	private AnimationCurve stopTimeVignetteeDecrementFadeInCurve;

	[SerializeField]
	private float _fadeOutStopTime;

	[SerializeField]
	private AnimationCurve stopTimeFadeOutCurve;

	[SerializeField]
	private AnimationCurve stopTimeAberrationSizeFadeOutCurve;

	[SerializeField]
	private AnimationCurve stopTimeVignetteIntensityFadeOutCurve;

	[SerializeField]
	private AnimationCurve stopTimeVignetteeDecrementFadeOutCurve;

	[SerializeField]
	private Color sceneChangeColor;

	[SerializeField]
	private bool sceneChangeColorIsAdd;

	[SerializeField]
	private float _fadeInChangeSceneTime;

	[SerializeField]
	private AnimationCurve sceneChangeFilmPowerFadeInCurve;

	[SerializeField]
	private AnimationCurve sceneChangeHueFadeInCurve;

	[SerializeField]
	private AnimationCurve sceneChangeSaturationFadeInCurve;

	[SerializeField]
	private AnimationCurve sceneChangeValueFadeInCurve;

	[SerializeField]
	private float _fadeOutChangeSceneTime;

	[SerializeField]
	private AnimationCurve sceneChangeFilmPowerFadeOutCurve;

	[SerializeField]
	private AnimationCurve sceneChangeHueFadeOutCurve;

	[SerializeField]
	private AnimationCurve sceneChangeSaturationFadeOutCurve;

	[SerializeField]
	private AnimationCurve sceneChangeValueFadeOutCurve;

	private float _stopTimeFadeTime;

	private float _sceneChangeFadeTime;

	private bool _isStopTimeFadeIn;

	private bool _isSceneChangeFadeIn;

	private ExtensionImageEffectCronos _extensionImageEffectCronos;

	private ExtensionImageEffectChromaticAberration _extensionImageEffectChromaticAberration;

	private ExtensionImageEffectChangeHSV _extensionImageEffectChangeHSV;

	public float GetStopMaxFadeTime(bool isFadeIn)
	{
		return default(float);
	}

	public float GetChangeSceneMaxFadeTime(bool isFadeIn)
	{
		return default(float);
	}

	public override void Initialize(CameraGroupCtrl cameraGroupCtrl)
	{
	}

	public void FadeStopTimeEffect(float fadeTime, bool isFadeIn)
	{
	}

	public void FadeSceneChange(float fadeTime, bool isFadeIn)
	{
	}
}
