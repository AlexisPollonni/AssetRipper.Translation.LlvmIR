using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Exponent_Constructor_whhyr2
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE4EE8ExponentCI2NS4_8TypedIntIiEEEi")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)4>::Exponent::Exponent(int)")]
	[CleanName("Exponent_Constructor")]
	public unsafe static void Invoke([MangledName("this")] void* This, [NativeType("int")] int parameter_1)
	{
		TypedInt_int_Constructor_jbj43t.Invoke(This, parameter_1);
	}
}
