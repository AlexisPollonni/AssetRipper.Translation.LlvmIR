using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_cpp_array_char_265ul_PointerDereference
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS0_5arrayIcLm265EEEEptEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::cpp::array<char, 265ul>>::operator->()")]
	public unsafe static Cpp_array_knc3mr* Invoke([MangledName("this")] Cpp_optional_hnriuf* This)
	{
		return unchecked((Cpp_array_knc3mr*)(&This->Storage.field));
	}
}
