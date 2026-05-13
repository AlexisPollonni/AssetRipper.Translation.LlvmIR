using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEE18get_next_arg_valueIPcEET_v")]
[DemangledName("char* __llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::get_next_arg_value<char*>()")]
internal static partial class char_printf_core_Parser_internal_ArgList_get_next_arg_value_char
{
	public unsafe static void* Invoke(printf_core_Parser* @this)
	{
		return char_internal_ArgList_next_var_char.Invoke(&@this->args_cur);
	}
}
