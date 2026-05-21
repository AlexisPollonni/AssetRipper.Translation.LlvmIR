using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Parser_internal_ArgList_get_next_arg_value_long_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEE18get_next_arg_valueIxEET_v")]
	[DemangledName("long long __llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::get_next_arg_value<long long>()")]
	[return: NativeType("long long")]
	public unsafe static long Invoke([MangledName("this")] Llvm_libc_20_1_2_printf_core_Parser* This)
	{
		return ArgList_next_var_long_long.Invoke(&This->Args_cur);
	}
}
