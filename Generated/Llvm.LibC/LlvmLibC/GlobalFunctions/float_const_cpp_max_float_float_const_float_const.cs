using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp3maxIfEERKT_S4_S4_")]
[DemangledName("float const& __llvm_libc_20_1_2_::cpp::max<float>(float const&, float const&)")]
internal static partial class float_const_cpp_max_float_float_const_float_const
{
	public unsafe static void* Invoke(void* a, void* b)
	{
		return (!unchecked(*(float*)a < *(float*)b)) ? a : b;
	}
}
