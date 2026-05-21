using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Significand_Constructor_vz3zem
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE1EE11SignificandCI2NS4_8TypedIntIjEEEj")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)1>::Significand::Significand(unsigned int)")]
	[CleanName("Significand_Constructor")]
	public unsafe static void Invoke(void* @this, [NativeType("unsigned int")] int parameter_1)
	{
		TypedInt_unsigned_int_Constructor_znza9e.Invoke(@this, parameter_1);
	}
}
