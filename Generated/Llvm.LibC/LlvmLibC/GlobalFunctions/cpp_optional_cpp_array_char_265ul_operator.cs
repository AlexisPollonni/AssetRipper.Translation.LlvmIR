using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS0_5arrayIcLm265EEEEptEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::cpp::array<char, 265ul>>::operator->()")]
internal static partial class cpp_optional_cpp_array_char_265ul_operator
{
	public unsafe static cpp_array_55kc72* Invoke(cpp_optional_pjf72b* @this)
	{
		return unchecked((cpp_array_55kc72*)(&@this->storage.field));
	}
}
