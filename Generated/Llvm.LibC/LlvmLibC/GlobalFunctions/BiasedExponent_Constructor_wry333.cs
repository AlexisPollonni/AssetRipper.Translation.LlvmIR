using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BiasedExponent_Constructor_wry333
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE0EE14BiasedExponentCI2NS4_8TypedIntIjEEEj")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::BiasedExponent::BiasedExponent(unsigned int)")]
	[CleanName("BiasedExponent_Constructor")]
	public unsafe static void Invoke(void* @this, [NativeType("unsigned int")] int parameter_1)
	{
		TypedInt_unsigned_int_Constructor_bta9fy.Invoke(@this, parameter_1);
	}
}
