using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ArgList_Destructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal7ArgListD2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ArgList::~ArgList()")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_internal_ArgList* This)
	{
		_ = &This->Vlist;
	}
}
