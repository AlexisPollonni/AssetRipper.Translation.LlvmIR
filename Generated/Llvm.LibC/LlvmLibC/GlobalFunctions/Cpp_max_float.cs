using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_max_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp3maxIfEERKT_S4_S4_")]
	[DemangledName("float const& __llvm_libc_20_1_2_::cpp::max<float>(float const&, float const&)")]
	[return: NativeType("float const&")]
	public unsafe static void* Invoke([MangledName("a")][NativeType("float const&")] void* A, [MangledName("b")][NativeType("float const&")] void* B)
	{
		return (!unchecked(*(float*)A < *(float*)B)) ? A : B;
	}
}
