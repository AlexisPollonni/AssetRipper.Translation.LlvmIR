using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEE18get_next_arg_valueIjEET_v")]
[DemangledName("unsigned int __llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::get_next_arg_value<unsigned int>()")]
internal static partial class unsigned_int_printf_core_Parser_internal_ArgList_get_next_arg_value_unsigned_int
{
	public unsafe static int Invoke(printf_core_Parser* @this)
	{
		return unsigned_int_internal_ArgList_next_var_unsigned_int.Invoke(&@this->args_cur);
	}
}
