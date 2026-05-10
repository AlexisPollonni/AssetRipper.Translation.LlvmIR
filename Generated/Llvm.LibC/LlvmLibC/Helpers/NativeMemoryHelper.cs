using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LlvmLibC.Helpers;

internal static partial class NativeMemoryHelper
{
	private static readonly ConcurrentDictionary<nint, long> allocationSizes = new ConcurrentDictionary<nint, long>();

	private unsafe static void SetAllocation(void* ptr, long size)
	{
		allocationSizes[new IntPtr(ptr)] = size;
	}

	private unsafe static void RemoveAllocation(void* ptr)
	{
		allocationSizes.TryRemove(new IntPtr(ptr), out var _);
	}

	public unsafe static void* Allocate(int size)
	{
		return Allocate(unchecked((long)size));
	}

	public unsafe static void* Allocate(long size)
	{
		void* ptr = NativeMemory.AllocZeroed((nuint)size);
		SetAllocation(ptr, size);
		return ptr;
	}

	public unsafe static void Free(void* ptr)
	{
		RemoveAllocation(ptr);
		NativeMemory.Free(ptr);
	}

	public unsafe static void* Reallocate(void* ptr, int newSize)
	{
		return Reallocate(ptr, unchecked((long)newSize));
	}

	public unsafe static void* Reallocate(void* ptr, long newSize)
	{
		void* ptr2 = NativeMemory.Realloc(ptr, (nuint)newSize);
		SetAllocation(ptr2, newSize);
		if (ptr2 != ptr)
		{
			RemoveAllocation(ptr);
		}
		return ptr2;
	}

	public unsafe static long Size(void* ptr)
	{
		return allocationSizes[(nint)ptr];
	}
}
