using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class String_view_min
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp11string_view3minEmm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::min(unsigned long, unsigned long)")]
	public static long Invoke([NativeType("unsigned long")] long A, [NativeType("unsigned long")] long B)
	{
		return unchecked((ulong)A > (ulong)B) ? B : A;
	}
}
