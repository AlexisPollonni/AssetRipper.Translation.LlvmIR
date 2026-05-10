using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEE18get_next_arg_valueImEET_v")]
[DemangledName("unsigned long __llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::get_next_arg_value<unsigned long>()")]
internal static partial class unsigned_long_printf_core_Parser_internal_ArgList_get_next_arg_value_unsigned_long
{
	public unsafe static long Invoke(void* @this)
	{
		return unsigned_long_internal_ArgList_next_var_unsigned_long.Invoke(&unchecked((printf_core_Parser*)@this)->args_cur);
	}
}
