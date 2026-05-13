using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core6ParserINS_8internal7ArgListEE13get_arg_valueIPvEET_m")]
[DemangledName("void* __llvm_libc_20_1_2_::scanf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::get_arg_value<void*>(unsigned long)")]
internal static partial class void_scanf_core_Parser_internal_ArgList_get_arg_value_void_unsigned_long
{
	public unsafe static void* Invoke(scanf_core_Parser* @this, long index)
	{
		if (index != 0L && index != @this->args_index)
		{
			scanf_core_Parser_internal_ArgList_args_to_index_unsigned_long.Invoke(@this, index);
		}
		unchecked
		{
			@this->args_index++;
			return void_scanf_core_Parser_internal_ArgList_get_next_arg_value_void.Invoke(@this);
		}
	}
}
