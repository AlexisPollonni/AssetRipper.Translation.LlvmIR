using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEE18get_next_arg_valueIxEET_v")]
[DemangledName("long long __llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::get_next_arg_value<long long>()")]
internal static partial class long_long_printf_core_Parser_internal_ArgList_get_next_arg_value_long_long
{
	public unsafe static long Invoke(void* @this)
	{
		return long_long_internal_ArgList_next_var_long_long.Invoke(&unchecked((printf_core_Parser*)@this)->args_cur);
	}
}
