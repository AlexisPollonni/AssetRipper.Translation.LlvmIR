using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Bsearch
{
	[MangledName("bsearch")]
	[DemangledName("bsearch")]
	public unsafe static void* Invoke([MangledName("key")] void* Key, [MangledName("array")] void* Array, [MangledName("array_size")] long Array_size, [MangledName("elem_size")] long Elem_size, [MangledName("compare")] void* Compare)
	{
		void* result = null;
		long num = 0L;
		void* ptr = null;
		int num2 = 0;
		void* ptr2 = Array;
		long num3 = Array_size;
		unchecked
		{
			if (Key == null || ptr2 == null || num3 == 0L || Elem_size == 0L)
			{
				result = null;
			}
			else
			{
				while (true)
				{
					if ((ulong)num3 > 0uL)
					{
						Llvm_lifetime_start_p0.Invoke(8L, &num);
						num = (long)((ulong)num3 / 2uL);
						Llvm_lifetime_start_p0.Invoke(8L, &ptr);
						ptr = (byte*)ptr2 + num * Elem_size;
						Llvm_lifetime_start_p0.Invoke(4L, &num2);
						num2 = ((delegate*<void*, void*, int>)Compare)(Key, ptr);
						int num4;
						if (num2 == 0)
						{
							result = ptr;
							num4 = 1;
						}
						else
						{
							if (num2 < 0)
							{
								num3 = num;
							}
							else
							{
								num3 -= num + 1L;
								ptr2 = (byte*)ptr + Elem_size;
							}
							num4 = 0;
						}
						Llvm_lifetime_end_p0.Invoke(4L, &num2);
						Llvm_lifetime_end_p0.Invoke(8L, &ptr);
						Llvm_lifetime_end_p0.Invoke(8L, &num);
						switch (num4)
						{
						case 0:
							continue;
						case 1:
							break;
						default:
							throw new NotImplementedException("Reached LLVM unreachable instruction.");
						}
					}
					else
					{
						result = null;
					}
					break;
				}
			}
			return result;
		}
	}
}
