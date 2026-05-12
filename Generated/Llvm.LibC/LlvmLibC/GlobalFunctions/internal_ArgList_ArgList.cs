using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal7ArgListD2Ev")]
[DemangledName("__llvm_libc_20_1_2_::internal::ArgList::~ArgList()")]
internal static partial class internal_ArgList_ArgList
{
	public unsafe static void Invoke(internal_ArgList* @this)
	{
		_ = &@this->vlist;
	}
}
