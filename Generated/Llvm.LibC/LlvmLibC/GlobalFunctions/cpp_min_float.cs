using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_min_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp3minIfEERKT_S4_S4_")]
	[DemangledName("float const& __llvm_libc_20_1_2_::cpp::min<float>(float const&, float const&)")]
	[return: NativeType("float const&")]
	public unsafe static void* Invoke([NativeType("float const&")] void* a, [NativeType("float const&")] void* b)
	{
		return (!unchecked(*(float*)a < *(float*)b)) ? b : a;
	}
}
