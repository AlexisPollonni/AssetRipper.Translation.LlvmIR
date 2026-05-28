using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Parser_internal_ArgList_get_next_arg_value_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEE18get_next_arg_valueIiEET_v")]
	[DemangledName("int __llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::get_next_arg_value<int>()")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("this")] Printf_core_Parser* This)
	{
		return ArgList_next_var_int.Invoke(&This->Args_cur);
	}
}
