using System.Runtime.CompilerServices;

namespace AssetRipper.Translation.LlvmIR.Runtime;

[Obsolete("Windows targets are getting dropped in favor of POSIX linux-x64")]
public static unsafe class PointerIndices
{
	private static readonly Dictionary<int, IntPtr> IndexToPointer = new();
	private static readonly Dictionary<IntPtr, int> PointerToIndex = new();
	private static readonly object SyncRoot = new();
	private static int NextIndex = 1;

	public static void* Register(void* ptr)
	{
		ThrowIfNull(ptr);

		IntPtr address = (IntPtr)ptr;
		lock (SyncRoot)
		{
			if (PointerToIndex.ContainsKey(address))
			{
				return ptr;
			}

			int index = NextIndex++;
			IndexToPointer[index] = address;
			PointerToIndex[address] = index;
		}

		return ptr;

		static void ThrowIfNull(
			void* value,
			[CallerArgumentExpression(nameof(value))] string? paramName = null
		)
		{
			if (value is null)
			{
				throw new ArgumentNullException(paramName);
			}
		}
	}

	public static int GetIndex(void* ptr)
	{
		if (ptr is null)
		{
			return 0;
		}

		lock (SyncRoot)
		{
			return PointerToIndex.TryGetValue((IntPtr)ptr, out int index) ? index : 0;
		}
	}

	public static void* GetPointer(int index)
	{
		if (index == 0)
		{
			return null;
		}

		lock (SyncRoot)
		{
			return IndexToPointer.TryGetValue(index, out IntPtr ptr) ? (void*)ptr : null;
		}
	}
}
