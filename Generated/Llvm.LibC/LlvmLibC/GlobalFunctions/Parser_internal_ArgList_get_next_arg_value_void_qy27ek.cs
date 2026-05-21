using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Parser_internal_ArgList_get_next_arg_value_void_qy27ek
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core6ParserINS_8internal7ArgListEE18get_next_arg_valueIPvEET_v")]
	[DemangledName("void* __llvm_libc_20_1_2_::scanf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::get_next_arg_value<void*>()")]
	[CleanName("Parser_internal_ArgList_get_next_arg_value_void")]
	[return: NativeType("void*")]
	public unsafe static void* Invoke([MangledName("this")] Llvm_libc_20_1_2_scanf_core_Parser* This)
	{
		return ArgList_next_var_void.Invoke(&This->Args_cur);
	}
}
