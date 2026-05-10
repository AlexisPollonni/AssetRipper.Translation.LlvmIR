using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core6ParserINS_8internal7ArgListEED2Ev")]
[DemangledName("__llvm_libc_20_1_2_::scanf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::~Parser()")]
internal static partial class scanf_core_Parser_internal_ArgList_Parser
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			internal_ArgList_ArgList.Invoke(&((scanf_core_Parser*)@this)->args_start);
			internal_ArgList_ArgList.Invoke(&((scanf_core_Parser*)@this)->args_cur);
		}
	}
}
