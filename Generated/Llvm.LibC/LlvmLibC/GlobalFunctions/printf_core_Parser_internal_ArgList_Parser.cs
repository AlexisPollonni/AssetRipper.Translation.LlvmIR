using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEED2Ev")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::~Parser()")]
internal static partial class printf_core_Parser_internal_ArgList_Parser
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			internal_ArgList_ArgList.Invoke(&((printf_core_Parser*)@this)->args_start);
			internal_ArgList_ArgList.Invoke(&((printf_core_Parser*)@this)->args_cur);
		}
	}
}
