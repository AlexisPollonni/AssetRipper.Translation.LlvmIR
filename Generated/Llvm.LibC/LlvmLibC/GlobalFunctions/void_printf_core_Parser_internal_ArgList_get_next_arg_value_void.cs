using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEE18get_next_arg_valueIPvEET_v")]
[DemangledName("void* __llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::get_next_arg_value<void*>()")]
internal static partial class void_printf_core_Parser_internal_ArgList_get_next_arg_value_void
{
	public unsafe static void* Invoke(printf_core_Parser* @this)
	{
		return void_internal_ArgList_next_var_void.Invoke(&@this->args_cur);
	}
}
