using System.Collections.Generic;
using Gluon.Event;

namespace Gluon;

public class MultiPlayCuttCommandCtrl
{
	private struct CommandData
	{
		public int CuttNumber;

		public int Frame;
	}

	private List<CommandData> _finishedCommands;

	private CuttCommandEvent _tmpSendEvent;

	private int _currentCuttNumber;

	private int _nextCuttNumber;

	private bool _isCuttPlaying;

	private bool _canProcessCommand;

	public void OnStartCutt()
	{
	}

	public void OnFinishCutt()
	{
	}

	public bool CanProcessCommand()
	{
		return default(bool);
	}

	public void OnStartCommand(int frame)
	{
	}

	public bool IsCommandFinished(int frame)
	{
		return default(bool);
	}

	public void OnFinalizeCommand(int frame)
	{
	}

	public void OnReceiveEvent(CuttCommandEvent recvEvent)
	{
	}

	private void SendCommandFinishEvent(int frame)
	{
	}
}
