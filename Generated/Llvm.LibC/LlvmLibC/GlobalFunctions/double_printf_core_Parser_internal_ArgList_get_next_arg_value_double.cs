using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEE18get_next_arg_valueIdEET_v")]
[DemangledName("double __llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::get_next_arg_value<double>()")]
internal static partial class double_printf_core_Parser_internal_ArgList_get_next_arg_value_double
{
	public unsafe static double Invoke(void* @this)
	{
		return double_internal_ArgList_next_var_double.Invoke(&unchecked((printf_core_Parser*)@this)->args_cur);
	}
}
