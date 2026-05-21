using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Parser_internal_ArgList_Constructor_ch3m7r
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core6ParserINS_8internal7ArgListEEC2EPKcRS3_")]
	[DemangledName("__llvm_libc_20_1_2_::scanf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::Parser(char const*, __llvm_libc_20_1_2_::internal::ArgList&)")]
	[CleanName("Parser_internal_ArgList_Constructor")]
	public unsafe static void Invoke(scanf_core_Parser* @this, [NativeType("char const*")] void* new_str, [NativeType("__llvm_libc_20_1_2_::internal::ArgList&")] internal_ArgList* args)
	{
		@this->str = new_str;
		@this->cur_pos = 0L;
		ArgList_Constructor_z4jw9r.Invoke(&@this->args_cur, args);
		ArgList_Constructor_z4jw9r.Invoke(&@this->args_start, args);
		@this->args_index = 1L;
	}
}
