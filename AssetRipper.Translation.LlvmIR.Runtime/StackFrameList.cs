namespace AssetRipper.Translation.LlvmIR.Runtime;

public struct StackFrameList
{
	[ThreadStatic]
	public static StackFrameList Current;

	private List<StackFrame>? Frames;

	public StackFrame New<T>()
		where T : unmanaged
	{
		Frames ??= new();
		StackFrame frame = StackFrame.Create<T>(Frames.Count);
		Frames.Add(frame);
		return frame;
	}

	/// <summary>
	/// Called at the boundary where translated code returns to user code.
	/// Clears all tracked stack frames (frees native locals).
	/// Exceptions propagate through normal CLR EH regions — no sentinel polling.
	/// </summary>
	public static void ExitToUserCode()
	{
		Current.Clear();
	}

	internal readonly void Clear()
	{
		if (Frames != null)
		{
			foreach (StackFrame frame in Frames)
			{
				frame.FreeLocals();
			}
			Frames.Clear();
		}
	}

	internal readonly void Clear(int startIndex)
	{
		for (int i = Frames!.Count - 1; i >= startIndex; i--)
		{
			Frames[i].FreeLocals();
		}
		Frames.RemoveRange(startIndex, Frames.Count - startIndex);
	}

	public readonly void Clear(StackFrame startFrame) => Clear(startFrame.Index);
}
