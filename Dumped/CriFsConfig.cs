using System;

[Serializable]
public class CriFsConfig
{
	public const int defaultAndroidDeviceReadBitrate = 50000000;

	public int numberOfLoaders;

	public int numberOfBinders;

	public int numberOfInstallers;

	public int installBufferSize;

	public int maxPath;

	public string userAgentString;

	public bool minimizeFileDescriptorUsage;

	public bool enableCrcCheck;

	public int androidDeviceReadBitrate;
}
