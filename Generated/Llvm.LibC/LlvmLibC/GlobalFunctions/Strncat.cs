using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Strncat
{
	[MangledName("strncat")]
	[DemangledName("strncat")]
	public unsafe static void* Invoke([MangledName("dest")] void* Dest, [MangledName("src")] void* Src, [MangledName("count")] long Count)
	{
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = Internal_string_length_char.Invoke(Src);
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		unchecked
		{
			num2 = (((ulong)num <= (ulong)Count) ? num : Count);
			Llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = Internal_string_length_char.Invoke(Dest);
			((delegate*<sbyte*, void*, long, void*>)Strncpy.__pointer)((sbyte*)Dest + num3, Src, num2);
			((sbyte*)Dest)[num3 + num2] = 0;
			Llvm_lifetime_end_p0.Invoke(8L, &num3);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return Dest;
		}
	}
}
