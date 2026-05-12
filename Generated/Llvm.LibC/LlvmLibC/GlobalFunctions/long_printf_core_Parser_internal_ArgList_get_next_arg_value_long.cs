using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEE18get_next_arg_valueIlEET_v")]
[DemangledName("long __llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::get_next_arg_value<long>()")]
internal static partial class long_printf_core_Parser_internal_ArgList_get_next_arg_value_long
{
	public unsafe static long Invoke(printf_core_Parser* @this)
	{
		return long_internal_ArgList_next_var_long.Invoke(&@this->args_cur);
	}
}
