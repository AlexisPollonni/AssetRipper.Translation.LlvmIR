using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Errno_Assignment
{
	[MangledName("_ZN19__llvm_libc_20_1_2_5ErrnoaSEi")]
	[DemangledName("__llvm_libc_20_1_2_::Errno::operator=(int)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("a")][NativeType("int")] int A)
	{
		*unchecked((int*)Errno_location.Invoke()) = A;
	}
}
