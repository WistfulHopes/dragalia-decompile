using System.Collections.Generic;

namespace Gluon.Event;

public class RunActionParameterSet : RunActionParameterBase
{
	public List<RunActionParameterElement> children;

	public List<int> falseConditionParts;

	public int chargeLv;

	public static bool IsValidParameterSet(RunActionParameterBase param)
	{
		return default(bool);
	}
}
