using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core6ParserINS_8internal7ArgListEE18get_next_arg_valueIPvEET_v")]
[DemangledName("void* __llvm_libc_20_1_2_::scanf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::get_next_arg_value<void*>()")]
internal static partial class void_scanf_core_Parser_internal_ArgList_get_next_arg_value_void
{
	public unsafe static void* Invoke(void* @this)
	{
		return void_internal_ArgList_next_var_void.Invoke(&unchecked((scanf_core_Parser*)@this)->args_cur);
	}
}
