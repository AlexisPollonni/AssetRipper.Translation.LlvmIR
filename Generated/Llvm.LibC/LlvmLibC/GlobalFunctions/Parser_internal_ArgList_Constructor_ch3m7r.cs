using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Parser_internal_ArgList_Constructor_ch3m7r
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core6ParserINS_8internal7ArgListEEC2EPKcRS3_")]
	[DemangledName("__llvm_libc_20_1_2_::scanf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::Parser(char const*, __llvm_libc_20_1_2_::internal::ArgList&)")]
	[CleanName("Parser_internal_ArgList_Constructor")]
	public unsafe static void Invoke([MangledName("this")] Scanf_core_Parser* This, [MangledName("new_str")][NativeType("char const*")] void* New_str, [MangledName("args")][NativeType("__llvm_libc_20_1_2_::internal::ArgList&")] Internal_ArgList* Args)
	{
		This->Str = New_str;
		This->Cur_pos = 0L;
		ArgList_Constructor_z4jw9r.Invoke(&This->Args_cur, Args);
		ArgList_Constructor_z4jw9r.Invoke(&This->Args_start, Args);
		This->Args_index = 1L;
	}
}
