using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ArgList_Constructor_7zbjxz
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal7ArgListC2EP13__va_list_tag")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ArgList::ArgList(__va_list_tag*)")]
	[CleanName("ArgList_Constructor")]
	public unsafe static void Invoke(internal_ArgList* @this, [NativeType("__va_list_tag*")] va_list_tag* vlist)
	{
		_ = &@this->vlist;
		llvm_va_copy_p0.Invoke(&@this->vlist, vlist);
	}
}
