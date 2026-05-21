using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_cpp_string_view_Multiply
{
	[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalINS0_11string_viewEEdeEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::cpp::string_view>::operator*() &")]
	public unsafe static void* Invoke([MangledName("this")] void* This)
	{
		return &unchecked((Llvm_libc_20_1_2_cpp_optional_bnt67x*)This)->Storage.field;
	}
}
