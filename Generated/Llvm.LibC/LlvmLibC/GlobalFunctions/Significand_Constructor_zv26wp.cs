using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Significand_Constructor_zv26wp
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE2EE11SignificandCI2NS4_8TypedIntImEEEm")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::Significand::Significand(unsigned long)")]
	[CleanName("Significand_Constructor")]
	public unsafe static void Invoke([MangledName("this")] void* This, [NativeType("unsigned long")] long parameter_1)
	{
		TypedInt_unsigned_long_Constructor.Invoke(This, parameter_1);
	}
}
