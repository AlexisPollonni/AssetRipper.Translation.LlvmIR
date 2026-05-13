using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_5ErrnoaSEi")]
[DemangledName("__llvm_libc_20_1_2_::Errno::operator=(int)")]
[CleanName("Errno_operator_int")]
internal static partial class Errno_operator_int_dntwiy
{
	public unsafe static void Invoke(void* @this, int a)
	{
		*unchecked((int*)errno_location.Invoke()) = a;
	}
}
