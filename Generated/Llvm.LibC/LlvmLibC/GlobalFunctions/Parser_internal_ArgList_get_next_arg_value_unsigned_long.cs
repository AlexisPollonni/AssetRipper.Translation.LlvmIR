using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Parser_internal_ArgList_get_next_arg_value_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEE18get_next_arg_valueImEET_v")]
	[DemangledName("unsigned long __llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::get_next_arg_value<unsigned long>()")]
	[return: NativeType("unsigned long")]
	public unsafe static long Invoke([MangledName("this")] Printf_core_Parser* This)
	{
		return ArgList_next_var_unsigned_long.Invoke(&This->Args_cur);
	}
}
