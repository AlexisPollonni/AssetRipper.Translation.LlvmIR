using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core6ParserINS_8internal7ArgListEEC2EPKcRS3_")]
[DemangledName("__llvm_libc_20_1_2_::scanf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::Parser(char const*, __llvm_libc_20_1_2_::internal::ArgList&)")]
internal static partial class scanf_core_Parser_internal_ArgList_Parser_char_const_internal_ArgList
{
	public unsafe static void Invoke(scanf_core_Parser* @this, void* new_str, internal_ArgList* args)
	{
		@this->str = new_str;
		@this->cur_pos = 0L;
		internal_ArgList_ArgList_internal_ArgList.Invoke(&@this->args_cur, args);
		internal_ArgList_ArgList_internal_ArgList.Invoke(&@this->args_start, args);
		@this->args_index = 1L;
	}
}
