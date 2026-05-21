using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Strcat
{
	[MangledName("strcat")]
	[DemangledName("strcat")]
	public unsafe static void* Invoke([MangledName("dest")] void* Dest, [MangledName("src")] void* Src)
	{
		long num = 0L;
		long num2 = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = Internal_string_length_char.Invoke(Dest);
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = Internal_string_length_char.Invoke(Src);
		unchecked
		{
			((delegate*<sbyte*, void*, void*>)Strcpy.__pointer)((sbyte*)Dest + num, Src);
			((sbyte*)Dest)[num + num2] = 0;
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return Dest;
		}
	}
}
