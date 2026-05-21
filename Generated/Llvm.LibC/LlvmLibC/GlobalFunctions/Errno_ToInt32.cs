using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Errno_ToInt32
{
	[MangledName("_ZN19__llvm_libc_20_1_2_5ErrnocviEv")]
	[DemangledName("__llvm_libc_20_1_2_::Errno::operator int()")]
	public unsafe static int Invoke([MangledName("this")] void* This)
	{
		return *unchecked((int*)Errno_location.Invoke());
	}
}
