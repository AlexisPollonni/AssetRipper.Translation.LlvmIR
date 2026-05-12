using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10CharVector5c_strEv")]
[DemangledName("__llvm_libc_20_1_2_::CharVector::c_str()")]
internal static partial class CharVector_c_str
{
	public unsafe static void* Invoke(CharVector* @this)
	{
		unchecked((sbyte*)@this->cur_str)[@this->index] = 0;
		return @this->cur_str;
	}
}
