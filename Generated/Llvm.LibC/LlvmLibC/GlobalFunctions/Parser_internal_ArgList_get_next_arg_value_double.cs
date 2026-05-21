using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Parser_internal_ArgList_get_next_arg_value_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEE18get_next_arg_valueIdEET_v")]
	[DemangledName("double __llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::get_next_arg_value<double>()")]
	[return: NativeType("double")]
	public unsafe static double Invoke(printf_core_Parser* @this)
	{
		return ArgList_next_var_double.Invoke(&@this->args_cur);
	}
}
