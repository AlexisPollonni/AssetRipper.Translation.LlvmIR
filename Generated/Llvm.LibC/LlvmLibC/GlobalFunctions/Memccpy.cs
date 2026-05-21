using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memccpy
{
	[MangledName("memccpy")]
	[DemangledName("memccpy")]
	public unsafe static void* Invoke([MangledName("dest")] void* Dest, [MangledName("src")] void* Src, [MangledName("c")] int C, [MangledName("count")] long Count)
	{
		sbyte b = 0;
		void* ptr = null;
		void* ptr2 = null;
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(1L, &b);
		unchecked
		{
			b = (sbyte)C;
			Llvm_lifetime_start_p0.Invoke(8L, &ptr);
			ptr = Src;
			Llvm_lifetime_start_p0.Invoke(8L, &ptr2);
			ptr2 = Dest;
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			for (num = 0L; (ulong)num < (ulong)Count && (byte)((sbyte*)ptr)[num] != (byte)b; num++)
			{
				sbyte b2 = ((sbyte*)ptr)[num];
				((sbyte*)ptr2)[num] = b2;
			}
			void* result;
			if ((ulong)num < (ulong)Count)
			{
				sbyte b3 = ((sbyte*)ptr)[num];
				((sbyte*)ptr2)[num] = b3;
				result = (byte*)ptr2 + num + 1;
			}
			else
			{
				result = null;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(8L, &ptr2);
			Llvm_lifetime_end_p0.Invoke(8L, &ptr);
			Llvm_lifetime_end_p0.Invoke(1L, &b);
			return result;
		}
	}
}
