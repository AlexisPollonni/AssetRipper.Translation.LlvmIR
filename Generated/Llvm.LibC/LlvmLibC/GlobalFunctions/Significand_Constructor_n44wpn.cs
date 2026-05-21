using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Significand_Constructor_n44wpn
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE0EE11SignificandCI2NS4_8TypedIntItEEEt")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::Significand::Significand(unsigned short)")]
	[CleanName("Significand_Constructor")]
	public unsafe static void Invoke(void* @this, [NativeType("unsigned short")] short parameter_1)
	{
		TypedInt_unsigned_short_Constructor.Invoke(@this, parameter_1);
	}
}
