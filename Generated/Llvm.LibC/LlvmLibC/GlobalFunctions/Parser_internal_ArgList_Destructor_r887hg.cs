using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Parser_internal_ArgList_Destructor_r887hg
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEED2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::~Parser()")]
	[CleanName("Parser_internal_ArgList_Destructor")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_printf_core_Parser* This)
	{
		ArgList_Destructor.Invoke(&This->Args_start);
		ArgList_Destructor.Invoke(&This->Args_cur);
	}
}
