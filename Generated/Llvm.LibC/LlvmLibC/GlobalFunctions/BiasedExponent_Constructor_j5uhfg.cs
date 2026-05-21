using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BiasedExponent_Constructor_j5uhfg
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE1EE14BiasedExponentCI2NS4_8TypedIntIjEEEj")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)1>::BiasedExponent::BiasedExponent(unsigned int)")]
	[CleanName("BiasedExponent_Constructor")]
	public unsafe static void Invoke([MangledName("this")] void* This, [NativeType("unsigned int")] int parameter_1)
	{
		TypedInt_unsigned_int_Constructor_znza9e.Invoke(This, parameter_1);
	}
}
