using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Errno_Assignment
{
	[MangledName("_ZN19__llvm_libc_20_1_2_5ErrnoaSEi")]
	[DemangledName("__llvm_libc_20_1_2_::Errno::operator=(int)")]
	public unsafe static void Invoke(void* @this, [NativeType("int")] int a)
	{
		*unchecked((int*)errno_location.Invoke()) = a;
	}
}
