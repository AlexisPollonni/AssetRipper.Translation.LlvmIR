using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class String_view_length
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp11string_view6lengthEPKc")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::length(char const*)")]
	public unsafe static long Invoke([NativeType("char const*")] void* Str)
	{
		void* ptr = null;
		Llvm_lifetime_start_p0.Invoke(8L, &ptr);
		unchecked
		{
			for (ptr = Str; *(sbyte*)ptr != 0; ptr = (byte*)ptr + 1)
			{
			}
			long result = (long)ptr - (long)Str;
			Llvm_lifetime_end_p0.Invoke(8L, &ptr);
			return result;
		}
	}
}
